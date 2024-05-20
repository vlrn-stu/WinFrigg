using Frigg.Model;
using Frigg.Model.Encoding;
using Frigg.Model.Signalling;
using MathNet.Numerics.Random;
using System.Collections;

namespace Frigg.CTC.Signalling
{
    public enum NoiseType
    {
        Random,
        ConstantSizePackets,
        RandomSizePackets
    }

    public class SignalGenerationStep : CTCStep
    {
        public override string StepName => "Signal Generation";

        public override int[] StepOrder => [0];
        public override bool DoDrawSprectrogram { get; set; } = true;

        public override StepParameterDictionary Parameters { get; set; } = new()
        {
            { "Message", new StepParameterValue { InputType = StepParameterValueInputType.String, Value = "Default Message" } },
            { "Signalling", new StepParameterValue { InputType = StepParameterValueInputType.Enum, Value = CTCSignalling.TimeBased } },
            { "Encoding", new StepParameterValue { InputType = StepParameterValueInputType.Enum, Value = CTCEncoding.Binary } },
            { "Sample Rate", new StepParameterValue { InputType = StepParameterValueInputType.Int, Value = 1 } },
            { "Signal Time", new StepParameterValue { InputType = StepParameterValueInputType.Double, Value = 50 } },
            { "Noise", new StepParameterValue {InputType = StepParameterValueInputType.Int, Value = 0} },
            { "NoiseType", new StepParameterValue {InputType = StepParameterValueInputType.Enum, Value = NoiseType.Random } }
        };

        protected override Task DoStep()
        {
            GetCTCParameters(Parameters, out ICTCEncoding? encoding, out ICTCSignalling? signalling);
            string message = Parameters["Message"].Value.ToString() ?? "Default Message";
            int sampleMHz = Convert.ToInt32(Parameters["Sample Rate"].Value);
            double signalTimeMs = Convert.ToDouble(Parameters["Signal Time"].Value);

            OutputData = AddNoise(
                signalling.GetIQValues(EncodeMessage(message, encoding), new()
                {
                    SampleFrequency = sampleMHz * 1_000_000,
                    SignalTimeMs = signalTimeMs
                }),
                (int)Parameters["Noise"].Value,
                (NoiseType)Parameters["NoiseType"].Value,
                sampleMHz,
                signalTimeMs);
            return Task.CompletedTask;
        }

        private static BitArray EncodeMessage(string message, ICTCEncoding encoding)
        {
            return encoding.GetBits(message);
        }

        private static byte[] AddNoise(byte[] data, int noisePercent, NoiseType noiseType, int sampleMHz, double signalTimeMs)
        {
            if (noisePercent == 0)
            {
                return data;
            }
            Random rnd = new();
            int samplesPerBit = (int)(sampleMHz * 1000000 * signalTimeMs / 1000);

            switch (noiseType)
            {
                case NoiseType.Random:
                    for (int i = 0; i < data.Length; i += 2)
                    {
                        if (rnd.Next(100) < noisePercent)
                        {
                            data[i] = (byte)rnd.Next(256);
                            data[i + 1] = (byte)rnd.Next(256);
                        }
                    }
                    break;

                case NoiseType.ConstantSizePackets:
                    int totalPackets = data.Length / samplesPerBit;
                    int noisyPackets = (int)(totalPackets * ((double)noisePercent / 100));

                    // Split the data into chunks to overwrite based on percentage
                    List<int> noisyIndices = Enumerable.Range(0, totalPackets).OrderBy(x => rnd.Next()).Take(noisyPackets).ToList();

                    for (int k = 0; k < noisyIndices.Count; k++)
                    {
                        int packetStart = noisyIndices[k] * samplesPerBit;
                        for (int j = 0; j < samplesPerBit && packetStart + j < data.Length; j += 2)
                        {
                            // Either lose or simulate interfering signal
                            data[packetStart + j] = (byte)(rnd.NextBoolean() ? 255 : 0);
                            data[packetStart + j + 1] = (byte)(rnd.NextBoolean() ? 255 : 0);
                        }
                    }
                    break;

                case NoiseType.RandomSizePackets:
                    // Randomly replace a percentage of data with highs
                    for (int i = 0; i < data.Length; i += rnd.Next(samplesPerBit / 2, samplesPerBit * 2))
                    {
                        if (rnd.Next(100) < noisePercent)
                        {
                            data[i] = 255;
                            if (i + 1 < data.Length)
                            {
                                data[i + 1] = 255;
                            }
                        }
                    }
                    break;
            }

            return data;
        }
    }
}