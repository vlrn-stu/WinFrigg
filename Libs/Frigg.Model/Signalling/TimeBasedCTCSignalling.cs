using System.Collections;

namespace Frigg.Model.Signalling
{
    internal class TimeBasedCTCSignalling : ICTCSignalling
    {
        public BitArray GetBits(byte[] iQValues, CTCSignallingParameters parameters)
        {
            int samplesPerBit = (int)(parameters.SampleFrequency * parameters.SignalTimeMs / 1000);
            List<bool> bits = [];

            double sumValues = iQValues.Select(b => (double)b).Sum();
            double meanThreshold = sumValues / iQValues.Length;

            // Take average of samples per bit count and use mean threshold
            for (int i = 0; i < iQValues.Length; i += 2 * samplesPerBit)
            {
                double sumAmplitude = 0;
                int count = 0;
                for (int j = i; j < i + (2 * samplesPerBit) && j < iQValues.Length; j += 2)
                {
                    double iValue = iQValues[j];
                    double qValue = iQValues[j + 1];
                    sumAmplitude += Math.Sqrt((iValue * iValue) + (qValue * qValue));
                    count++;
                }

                double averageAmplitude = sumAmplitude / count;
                bits.Add(averageAmplitude >= meanThreshold);
            }

            return new BitArray(bits.ToArray());
        }

        public byte[] GetIQValues(BitArray bits, CTCSignallingParameters parameters)
        {
            int samplesPerBit = (int)(parameters.SampleFrequency * parameters.SignalTimeMs / 1000);

            List<byte> iqData = [];

            foreach (bool bit in bits)
            {
                for (int sample = 0; sample < samplesPerBit; sample++)
                {
                    byte iValue = bit ? (byte)255 : (byte)0;
                    byte qValue = iValue;

                    iqData.Add(iValue);
                    iqData.Add(qValue);
                }
            }

            return [.. iqData];
        }
    }
}