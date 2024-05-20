using Microsoft.Win32;

namespace Frigg.Python
{
    public static class PythonHelpers
    {
        public static string? FindPythonDllPath()
        {
            try
            {
                // Look in registry first
                string registryKey = @"SOFTWARE\Python\PythonCore\3.8\InstallPath";
                using RegistryKey? key = Registry.CurrentUser.OpenSubKey(registryKey) ?? Registry.LocalMachine.OpenSubKey(registryKey);
                if (key != null)
                {
                    string? installPath = key.GetValue(null) as string;
                    if (!string.IsNullOrEmpty(installPath))
                    {
                        string pythonDllPath = Path.Combine(installPath, "python38.dll");
                        if (File.Exists(pythonDllPath))
                        {
                            return pythonDllPath;
                        }
                    }
                }
            }
            catch (Exception)
            {
            }

            // If not found try the PATH
            string? pathVariable = Environment.GetEnvironmentVariable("PATH");
            foreach (string path in pathVariable?.Split(Path.PathSeparator) ?? [])
            {
                string pythonDllPath = Path.Combine(path, "python38.dll");
                if (File.Exists(pythonDllPath))
                {
                    return pythonDllPath;
                }
            }

            return null;
        }

        public static string? FindPythonExePath()
        {
            try
            {
                // Look in registry first
                string registryKey = @"SOFTWARE\Python\PythonCore\3.8\InstallPath";
                using RegistryKey? key = Registry.CurrentUser.OpenSubKey(registryKey) ?? Registry.LocalMachine.OpenSubKey(registryKey);
                if (key != null)
                {
                    string? installPath = key.GetValue(null) as string;
                    if (!string.IsNullOrEmpty(installPath))
                    {
                        string pythonDllPath = Path.Combine(installPath, "python.exe");
                        if (File.Exists(pythonDllPath))
                        {
                            return pythonDllPath;
                        }
                    }
                }
            }
            catch (Exception)
            {
            }

            // If not found try the PATH
            string? pathVariable = Environment.GetEnvironmentVariable("PATH");
            foreach (string path in pathVariable?.Split(Path.PathSeparator) ?? [])
            {
                string pythonDllPath = Path.Combine(path, "python.exe");
                if (File.Exists(pythonDllPath))
                {
                    return pythonDllPath;
                }
            }

            return null;
        }
    }
}