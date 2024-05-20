using Frigg.Common;
using Python.Runtime;
using System.Diagnostics;

namespace Frigg.Python
{
    public static class PythonInterop
    {
        public static void InstallRequirements()
        {
            string requirementsPath = Path.Combine(Config.Folders.PythonFolder, "requirements.txt");
            string? pythonExePath = PythonHelpers.FindPythonExePath();
            if (string.IsNullOrEmpty(pythonExePath))
            {
                throw new Exception("Failed to find python");
            }
            else
            {
                // Run a regular command process with pip
                ProcessStartInfo startInfo = new(pythonExePath, $"-m pip install -r {requirementsPath}")
                {
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                using Process? process = Process.Start(startInfo);
                process?.WaitForExit();
                if ((process?.ExitCode ?? -1) != 0)
                {
                    throw new Exception("Failed to install dependencies");
                }
            }
        }

        public static void RunSpectrogramGenerationFromBuffer(byte[] iqDataBuffer, string outputPath)
        {
            string scriptPath = Path.Combine(Config.Folders.PythonFolder, "iq_spectrogram.py");
            string moduleName = Path.GetFileNameWithoutExtension(scriptPath);

            using (Py.GIL())
            {
                dynamic np = Py.Import("numpy");
                PyObject pyIqDataBuffer = np.array(iqDataBuffer, dtype: np.int8);

                dynamic sys = Py.Import("sys");
                dynamic os = Py.Import("os");
                string directoryPath = os.path.dirname(scriptPath);
                sys.path.append(directoryPath);
                dynamic script = Py.Import(moduleName);

                script.create_spectrogram_from_buffer(pyIqDataBuffer, outputPath);

                // Make sure the file is available before returning
                while (!File.Exists(outputPath))
                {
                    Thread.Sleep(250);
                }
            }
        }

        public static void StitchImages(string imageDirectoryPath, string outputPath)
        {
            string scriptPath = Path.Combine(Config.Folders.PythonFolder, "image_tools.py");
            string moduleName = Path.GetFileNameWithoutExtension(scriptPath);

            using (Py.GIL())
            {
                dynamic sys = Py.Import("sys");
                dynamic os = Py.Import("os");
                string directoryPath = os.path.dirname(scriptPath);
                sys.path.append(directoryPath);
                dynamic script = Py.Import(moduleName);

                script.stitch_images(imageDirectoryPath, outputPath);

                // Make sure the file is available before returning
                while (!File.Exists(outputPath))
                {
                    Thread.Sleep(250);
                }
            }
        }
    }
}