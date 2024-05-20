using System.Text.Json;

namespace Frigg.Common
{
    public static class Config
    {
        public static FolderSettings Folders { get; set; } = new FolderSettings();
        public static GeneralSettings General { get; set; } = new GeneralSettings();
        private static readonly JsonSerializerOptions jsonSerializerOptions = new() { WriteIndented = true };

        public static void SaveConfiguration()
        {
            var configObject = new
            {
                Folders,
                General
            };

            string json = JsonSerializer.Serialize(configObject, jsonSerializerOptions);
            File.WriteAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config.json"), json);
        }

        public static void LoadConfiguration()
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config.json");
            if (!File.Exists(path))
            {
                return;
            }

            string json = File.ReadAllText(path);
            ConfigObject? configObject = JsonSerializer.Deserialize<ConfigObject>(json);

            if (configObject != null)
            {
                Folders = configObject.Folders;
                General = configObject.Network;
            }
        }

        private class ConfigObject
        {
            public FolderSettings Folders { get; set; } = default!;
            public GeneralSettings Network { get; set; } = default!;
        }

        public class FolderSettings
        {
            public string TempIQFolder { get; set; } = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "tempIQ");
            public string GeneratedIQFolder { get; set; } = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "genIQ");
            public string RecordingsFolder { get; set; } = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "recordings");
            public string TempSpectrogramFolder { get; set; } = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "tempSpectrograms");
            public string SpectrogramFolder { get; set; } = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "spectrograms");
            public string SimulationsFolder { get; set; } = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "simulations");
            public string PythonFolder { get; set; } = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Python");
            public string PlotsFolder { get; set; } = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "plots");
            public string? PythonRuntimeFolder { get; set; } = null;
            public string SaveStatesFolder { get; set; } = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "saveStates");
        }

        public class GeneralSettings
        {
            public int BufferSize { get; set; } = 1_000_000;
            public int ChunkSize { get; set; } = 1_000_000;
            public int MTU { get; set; } = 1500;
        }
    }
}