namespace Frigg.Devices.SDR
{
    public interface ISDRDeviceManager
    {
        public Task<List<ISDRDevice>> GetDevices();
    }
}