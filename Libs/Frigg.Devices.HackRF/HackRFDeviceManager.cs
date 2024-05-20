using Frigg.Devices.SDR;
using nethackrf;

namespace Frigg.Devices.HackRF
{
    public class HackRFDeviceManager : ISDRDeviceManager
    {
        public async Task<List<ISDRDevice>> GetDevices()
        {
            return await Task.Run(() =>
            {
                NetHackrf.hackrf_device_info[] devices = [];
                List<ISDRDevice> sDRDevices = [];
                try
                {
                    devices = NetHackrf.HackrfDeviceList();
                    if (devices.Length > 0)
                    {
                        // Default values for Channel 6 CTC
                        NetHackrf device = devices[0].OpenDevice();
                        device.CarrierFrequencyMHz = 2440;
                        device.SampleFrequencyMHz = 2;
                        device.FilterBandwidthMHz = 2;
                        device.LNAGainDb = 0;
                        device.VGAGainDb = 0;
                        device.SampleFrequencyMHz = 1;
                        return [new HackRFDevice(devices[0].serial_number, device)];
                    }
                }
                catch (Exception)
                {
                    return [];
                }

                return sDRDevices;
            });
        }
    }
}