using System.Collections;

namespace Frigg.Model.Signalling
{
    public interface ICTCSignalling
    {
        public byte[] GetIQValues(BitArray bits, CTCSignallingParameters parameters);

        public BitArray GetBits(byte[] iQValues, CTCSignallingParameters parameters);
    }

    public class CTCSignallingParameters
    {
        public long SampleFrequency { get; set; }
        public double SignalTimeMs { get; set; }
        public int BeaconIntervalMs { get; set; } = 100;
    }

    public enum CTCSignalling
    {
        TimeBased,
        UDPFragmentation
    }
}