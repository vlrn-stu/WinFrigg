using Frigg.Devices.SDR;
using nethackrf;

namespace Frigg.Devices.HackRF
{
    public sealed unsafe class HackRFDevice(string name, NetHackrf netHackrf) : ISDRDevice
    {
        private double filterBandwith = 2.0;
        private long frequency = 2437;
        private long lNAGain = 30;
        private bool open = true;
        private long sampleRate = 1;
        private long tXVGAGain = 30;
        private long vGAGain = 30;

        public event EventHandler<OpenChangedEventArgs>? OpenChanged;

        public double FilterBandwith
        {
            get => filterBandwith;
            set
            {
                if (Open)
                {
                    try
                    {
                        NetHackRf.FilterBandwidthMHz = value;
                        filterBandwith = value;
                    }
                    catch (Exception)
                    {
                        Open = false;
                    }
                }
            }
        }

        public long Frequency
        {
            get => frequency;
            set
            {
                if (Open)
                {
                    try
                    {
                        NetHackRf.CarrierFrequencyMHz = value;
                        frequency = value;
                    }
                    catch (Exception)
                    {
                        Open = false;
                    }
                }
            }
        }

        public long LNAGain
        {
            get => lNAGain;
            set
            {
                if (Open)
                {
                    try
                    {
                        NetHackRf.LNAGainDb = value;
                        lNAGain = value;
                    }
                    catch (Exception)
                    {
                        Open = false;
                    }
                }
            }
        }

        public string Name { get; set; } = name;

        public NetHackrf NetHackRf { get; private set; } = netHackrf;

        public bool Open
        {
            get => open;
            set
            {
                open = value;
                _ = (OpenChanged?.DynamicInvoke());
            }
        }

        public long SampleRate
        {
            get => sampleRate;
            set
            {
                if (Open)
                {
                    try
                    {
                        NetHackRf.SampleFrequencyMHz = value;
                        sampleRate = value;
                    }
                    catch (Exception)
                    {
                        Open = false;
                    }
                }
            }
        }

        public long TXVGAGain
        {
            get => tXVGAGain;
            set
            {
                if (Open)
                {
                    try
                    {
                        NetHackRf.TXVGAGainDb = value;
                        tXVGAGain = value;
                    }
                    catch (Exception)
                    {
                        Open = false;
                    }
                }
            }
        }

        public long VGAGain
        {
            get => vGAGain;
            set
            {
                if (Open)
                {
                    try
                    {
                        NetHackRf.VGAGainDb = value;
                        vGAGain = value;
                    }
                    catch (Exception)
                    {
                        Open = false;
                    }
                }
            }
        }

        public unsafe void Close()
        {
            if (Open)
            {
                try
                {
                    NetHackRf.Reset();
                    NetHackRf.Dispose();
                }
                catch (Exception)
                {
                    Open = false;
                }
            }
        }

        public Stream Receive()
        {
            return NetHackRf.StartRX();
        }

        public Stream Send()
        {
            return NetHackRf.StartTX();
        }
    }
}