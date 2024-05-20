using Frigg.Common;
using Frigg.Devices.HackRF;
using Microsoft.Extensions.DependencyInjection;

namespace WinFrigg
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            EnsureFriggDevicesAssembliesLoaded();
            if (Directory.Exists(Config.Folders.TempSpectrogramFolder))
            {
                Directory.Delete(Config.Folders.TempSpectrogramFolder, true);
            }
            ServiceCollection serviceCollection = new();
            new Startup().ConfigureServices(serviceCollection);
            ServiceProvider serviceProvider = serviceCollection.BuildServiceProvider();

            ApplicationConfiguration.Initialize();
            Application.Run(serviceProvider.GetRequiredService<Splash>());
        }

        private static void EnsureFriggDevicesAssembliesLoaded()
        {
            Type _ = typeof(HackRFDeviceManager);
        }
    }
}