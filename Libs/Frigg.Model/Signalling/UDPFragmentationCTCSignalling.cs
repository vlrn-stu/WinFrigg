using System.Collections;

namespace Frigg.Model.Signalling
{
    public class UDPFragmentationCTCSignalling : ICTCSignalling
    {
        public BitArray GetBits(byte[] iQValues, CTCSignallingParameters parameters)
        {
            List<bool> bits = [];
            double frameLength = parameters.SampleFrequency * parameters.SignalTimeMs / 1000.0;
            int beaconPartLength = (int)(frameLength * 0.3);

            for (int i = 0; i < iQValues.Length; i += (int)frameLength)
            {
                if (i + (int)frameLength > iQValues.Length)
                {
                    break;
                }

                // Determine if the frames beginning 30% is above the average amplitude
                double[] frame = iQValues.Skip(i).Take((int)frameLength).Select(x => (double)x).ToArray();
                double[] beaconPart = frame.Take(beaconPartLength).ToArray();

                double beaconPartAverage = beaconPart.Average();

                if (beaconPartAverage > 128)
                {
                    bits.Add(true);
                }
                else
                {
                    bits.Add(false);
                }
            }

            return ConvertBits(new BitArray(bits.ToArray()));
        }

        public static BitArray ConvertBits(BitArray bits)
        {
            List<bool> convertedBits = [];

            // Prefixed code for 1 and 0
            for (int i = 0; i < bits.Length - 1; i++)
            {
                bool currentBit = bits[i];
                bool nextBit = bits[i + 1];

                if (!currentBit && nextBit)
                {
                    convertedBits.Add(false);
                    i++;
                }
                else if (currentBit && nextBit)
                {
                    convertedBits.Add(true);
                    i++;
                }
            }

            //Handle last bit
            if (!bits[^1] && !convertedBits.LastOrDefault())
            {
                convertedBits.Add(false);
            }

            return new BitArray(convertedBits.ToArray());
        }

        public byte[] GetIQValues(BitArray bits, CTCSignallingParameters parameters)
        {
            List<byte> iqData = [];
            double frameLength = parameters.SampleFrequency * parameters.SignalTimeMs / 1000.0;
            double beaconLength = frameLength * 0.32;

            foreach (bool bit in bits)
            {
                if (!bit)
                {
                    iqData.AddRange(Enumerable.Repeat<byte>(0, (int)frameLength));
                }
                for (int i = 0; i < (bit ? 2 : 1); i++)
                {
                    iqData.AddRange(Enumerable.Repeat<byte>(255, (int)beaconLength));
                    iqData.AddRange(Enumerable.Repeat<byte>(0, (int)(frameLength - beaconLength)));
                }
            }

            return [.. iqData];
        }
    }
}