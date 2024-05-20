namespace Frigg.Devices.WiFi
{
    public interface IWiFiDeviceManager
    {
        IList<IWiFiDevice> GetWiFiDevices();
    }
}