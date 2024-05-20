namespace Frigg.Devices.SDR
{
    public interface ISDRDevice
    {
        public string Name { get; set; }
        public long Frequency { get; set; }
        public double FilterBandwith { get; set; }
        public long LNAGain { get; set; }
        public long VGAGain { get; set; }
        public long TXVGAGain { get; set; }
        public long SampleRate { get; set; }
        public bool Open { get; set; }

        public void Close();

        public event EventHandler<OpenChangedEventArgs> OpenChanged;

        public Stream Receive();

        public Stream Send();
    }

    public class OpenChangedEventArgs(bool isInitialized) : EventArgs
    {
        public bool IsInitialized { get; } = isInitialized;
    }
}