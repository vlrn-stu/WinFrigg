using Frigg.Common;
using Frigg.Devices.SDR;

namespace Frigg.Model
{
    public static class IQDataRecorder
    {
        public static long BytesRead { get; set; } = 0;

        public static void InitializeRecordingSession()
        {
            CleanTempFolder();
            _ = Directory.CreateDirectory(Config.Folders.TempIQFolder);
        }

        public static void WriteStreamToFile(ISDRDevice hackRFDevice, CancellationToken cancellationToken)
        {
            InitializeRecordingSession();
            int fileIndex = 0;
            FileStream fileStream = CreateNewFile(ref fileIndex);
            try
            {
                byte[] buffer = new byte[Config.General.BufferSize];
                Stream sdrStream = hackRFDevice.Receive();
                while (!cancellationToken.IsCancellationRequested)
                {
                    BytesRead += sdrStream.Read(buffer, 0, buffer.Length);
                    fileStream.Write(buffer);
                }
                cancellationToken.ThrowIfCancellationRequested();
            }
            catch (OperationCanceledException)
            {
                Console.WriteLine("Operation was cancelled.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            finally
            {
                fileStream.Flush();
                fileStream.Close();
            }
        }

        public static byte[] GenerateIQData(int samplingRateMHz, double signalTime, bool[] boolArray)
        {
            int samplingRate = samplingRateMHz * 1000000;
            int samplesPerBool = (int)(samplingRate * signalTime);
            List<byte> iqData = [];

            byte highAmplitudeI = 255;
            byte lowAmplitudeI = 0;
            byte amplitudeQ = 128;

            foreach (bool signalHigh in boolArray)
            {
                byte amplitudeI = signalHigh ? highAmplitudeI : lowAmplitudeI;

                for (int i = 0; i < samplesPerBool; i++)
                {
                    iqData.Add(amplitudeI);
                    iqData.Add(amplitudeQ);
                }
            }

            return [.. iqData];
        }

        public static string? CopyRecordingsToNewDirectory()
        {
            if (!Directory.Exists(Config.Folders.RecordingsFolder))
            {
                _ = Directory.CreateDirectory(Config.Folders.RecordingsFolder);
            }
            long totalSize = Directory.GetFiles(Config.Folders.TempIQFolder, "*.*", SearchOption.AllDirectories)
                                 .Sum(file => new FileInfo(file).Length);
            string readableSize = SizeSuffix(totalSize).Replace(".", "_");
            string newDirectoryName = $"IQRecordings_{DateTime.Now:yyyy-MM-dd_HH-mm-ss-fff}-Size-{readableSize}";
            string newDirectoryPath = Path.Combine(Config.Folders.RecordingsFolder, newDirectoryName);

            if (!Directory.Exists(newDirectoryPath))
            {
                _ = Directory.CreateDirectory(newDirectoryPath);
            }

            if (!Directory.Exists(Config.Folders.TempIQFolder))
            {
                return null;
            }

            foreach (string dirPath in Directory.GetDirectories(Config.Folders.TempIQFolder, "*", SearchOption.AllDirectories))
            {
                _ = Directory.CreateDirectory(dirPath.Replace(Config.Folders.TempIQFolder, newDirectoryPath));
            }

            foreach (string filePath in Directory.GetFiles(Config.Folders.TempIQFolder, "*.*", SearchOption.AllDirectories))
            {
                string newFilePath = filePath.Replace(Config.Folders.TempIQFolder, newDirectoryPath);
                File.Copy(filePath, newFilePath, true);
            }
            CleanTempFolder();

            return newDirectoryPath;
        }

        public static string GetReadableFileSize(long bytes)
        {
            string[] sizes = ["B", "KB", "MB", "GB",];
            double len = bytes;
            int order = 0;

            while (len >= 1024 && order < sizes.Length - 1)
            {
                order++;
                len /= 1024;
            }

            return string.Format("{0:0.##} {1}", len, sizes[order]);
        }

        private static string SizeSuffix(long value, int decimalPlaces = 1)
        {
            string[] SizeSuffixes = ["bytes", "KB", "MB", "GB"];
            if (value < 0) { return "-" + SizeSuffix(-value); }
            int i = 0;
            decimal dValue = value;
            while (Math.Round(dValue, decimalPlaces) >= 1000)
            {
                dValue /= 1024;
                i++;
            }
            return string.Format("{0:n" + decimalPlaces + "} {1}", dValue, SizeSuffixes[i]);
        }

        public static void CopyFilesToTemp(string selectedFolderPath)
        {
            if (!Directory.Exists(Config.Folders.TempIQFolder))
            {
                _ = Directory.CreateDirectory(Config.Folders.TempIQFolder);
            }

            foreach (string filePath in Directory.GetFiles(selectedFolderPath, "*.*", SearchOption.AllDirectories))
            {
                string destinationFilePath = filePath.Replace(selectedFolderPath, Config.Folders.TempIQFolder);

                string destinationDir = Path.GetDirectoryName(destinationFilePath) ?? throw new Exception("Destination path not found in save.");
                if (destinationDir != null && !Directory.Exists(destinationDir))
                {
                    _ = Directory.CreateDirectory(destinationDir);
                }

                File.Copy(filePath, destinationFilePath, true);
            }
        }

        public static void CleanTempFolder()
        {
            _ = Directory.CreateDirectory(Config.Folders.TempIQFolder);
            foreach (string file in Directory.GetFiles(Config.Folders.TempIQFolder))
            {
                File.Delete(file);
            }
            if (Directory.Exists(Config.Folders.TempIQFolder))
            {
                Directory.Delete(Config.Folders.TempIQFolder, true);
            }
        }

        private static FileStream CreateNewFile(ref int fileIndex)
        {
            fileIndex++;
            if (!Directory.Exists(Config.Folders.TempIQFolder))
            {
                _ = Directory.CreateDirectory(Config.Folders.TempIQFolder);
            }
            string filePath = Path.Combine(Config.Folders.TempIQFolder, $"IQData_{fileIndex}.bin");
            Console.WriteLine($"Creating file: {filePath}");
            return new FileStream(filePath, FileMode.Create);
        }
    }
}