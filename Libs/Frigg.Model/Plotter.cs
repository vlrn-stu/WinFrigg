using Frigg.Common;
using Frigg.Python;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;

namespace Frigg.Model
{
    public static class Plotter
    {
        public static async Task<System.Drawing.Image?> CreateSpectrogramAsync(string directoryPath)
        {
            if (!Directory.Exists(directoryPath))
            {
                _ = Directory.CreateDirectory(directoryPath);
            }
            string finalImagePath = Path.Combine(Config.Folders.SpectrogramFolder, "final_spectrogram.png");
            List<byte> allBytes = [];
            foreach (string filePath in Directory.GetFiles(directoryPath, "*.bin"))
            {
                byte[] fileBytes = await File.ReadAllBytesAsync(filePath);
                allBytes.AddRange(fileBytes);
            }
            await CreateSpectrogramAsync([.. allBytes], finalImagePath);

            return System.Drawing.Image.FromFile(finalImagePath);
        }

        public static async Task CreateSpectrogramAsync(byte[] data, string output)
        {
            List<string> imagePaths = [];
            string guid = Guid.NewGuid().ToString();
            string outputFolderPath = Path.Combine(Config.Folders.TempSpectrogramFolder, guid);
            _ = Directory.CreateDirectory(outputFolderPath);
            using MemoryStream ms = new(data);
            int bytesRead;
            byte[] buffer = new byte[Config.General.ChunkSize];
            int chunkIndex = 0;

            // Create the spectrogram in chunks, uses .NET 8 new Memory method
            while ((bytesRead = await ms.ReadAsync(buffer.AsMemory(0, Config.General.ChunkSize))) > 0)
            {
                byte[] actualBuffer = bytesRead < Config.General.ChunkSize ? buffer[..bytesRead] : buffer;

                string outputPath = Path.Combine(outputFolderPath, $"chunk_{chunkIndex}.png");
                PythonInterop.RunSpectrogramGenerationFromBuffer(actualBuffer, outputPath);

                imagePaths.Add(outputPath);
                chunkIndex++;
            }

            bool wait = true;
            while (wait)
            {
                foreach (string path in imagePaths)
                {
                    if (!File.Exists(path))
                    {
                        break;
                    }
                    wait = false;
                }
                await Task.Delay(100);
            }

            Image? finalImage;
            if (imagePaths.Count == 1)
            {
                finalImage = Image.Load(imagePaths[0]);
            }
            else
            {
                PythonInterop.StitchImages(outputFolderPath, output);
                finalImage = Image.Load(output);
            }

            foreach (string path in imagePaths)
            {
                File.Delete(path);
            }
            Directory.Delete(outputFolderPath, true);
            finalImage?.Save(output);
        }

        public static async Task CreateRSSIWaterfallAsync(string output, double[] amplitudes, int width = 420)
        {
            (await CreateRSSIWaterfall(amplitudes, width)).Save(output);
        }

        public static Task<Image<Rgb24>> CreateRSSIWaterfall(double[] amplitudes, int width = 420)
        {
            int height = amplitudes.Length;
            Image<Rgb24> image = new(width, height);

            double minAmplitude = amplitudes.Min();
            double maxAmplitude = amplitudes.Max();
            double amplitudeRange = maxAmplitude - minAmplitude;

            for (int y = 0; y < height; y++)
            {
                double normalizedAmplitude = (amplitudes[y] - minAmplitude) / amplitudeRange;
                byte colorValue = (byte)(normalizedAmplitude * 255);
                Rgb24 color = new(colorValue, colorValue, colorValue);

                for (int x = 0; x < width; x++)
                {
                    image[x, y] = color;
                }
            }

            return Task.FromResult(image);
        }

        public static System.Drawing.Image? ConvertImageSharpImageToSystemDrawingImage(Image<Rgb24>? imageSharpImage)
        {
            if (imageSharpImage is null)
            {
                return null;
            }
            using MemoryStream memoryStream = new();
            imageSharpImage.SaveAsBmp(memoryStream);
            _ = memoryStream.Seek(0, SeekOrigin.Begin);

            return System.Drawing.Image.FromStream(memoryStream);
        }
    }
}