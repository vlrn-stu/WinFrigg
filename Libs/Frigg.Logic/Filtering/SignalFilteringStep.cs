using Frigg.Model;

namespace Frigg.CTC.Filtering
{
    public class SignalFilteringStep : CTCStep
    {
        public bool[]? Signals { get; private set; }

        public override string StepName => "Signal Filtering";
        public override int[] StepOrder => [1, 2, 3, 4, 5, 6, 7, 8, 9];
        public override bool DoDrawSprectrogram { get; set; } = true;

        public override StepParameterDictionary Parameters { get; set; } = new()
        {
            { "SampleMHz", new StepParameterValue { InputType = StepParameterValueInputType.Int, Value = 1 } },
            { "SignalTimeMs", new StepParameterValue { InputType = StepParameterValueInputType.Int, Value = 50 } }
        };

        protected override Task DoStep()
        {
            int sampleMHz = Convert.ToInt32(Parameters["SampleMHz"].Value);
            int signalTimeMs = Convert.ToInt32(Parameters["SignalTimeMs"].Value);
            int sampleRate = sampleMHz * 1000000;
            int samplesPerBit = sampleRate * signalTimeMs / 1000;

            double[] normalizedAmplitudes = NormalizeAmplitudes(InputData);

            Signals = new bool[InputData.Length / (2 * samplesPerBit)];

            for (int i = 0, signalIndex = 0; i < normalizedAmplitudes.Length; i += samplesPerBit, signalIndex++)
            {
                Signals[signalIndex] = IsSignalHigh(normalizedAmplitudes, i, samplesPerBit);
            }

            OutputData = GenerateOutputData(Signals, samplesPerBit);
            return Task.CompletedTask;
        }

        // Basic normalization of the data to have higher margin of error
        private static double[] NormalizeAmplitudes(byte[] data)
        {
            double[] magnitudes = new double[data.Length / 2];
            double min = double.MaxValue;
            double max = double.MinValue;

            for (int i = 0; i < data.Length; i += 2)
            {
                double magnitude = Math.Sqrt((data[i] * data[i]) + (data[i + 1] * data[i + 1]));
                magnitudes[i / 2] = magnitude;
                if (magnitude < min)
                {
                    min = magnitude;
                }

                if (magnitude > max)
                {
                    max = magnitude;
                }
            }

            for (int i = 0; i < magnitudes.Length; i++)
            {
                magnitudes[i] = (magnitudes[i] - min) / (max - min);
            }

            return magnitudes;
        }

        private static bool IsSignalHigh(double[] amplitudes, int start, int samplesPerBit)
        {
            double sum = 0;
            for (int i = start; i < start + samplesPerBit && i < amplitudes.Length; i++)
            {
                sum += amplitudes[i];
            }
            double avg = sum / samplesPerBit;
            return avg > 0.5;
        }

        // Create clean I/Q values from signals
        private static byte[] GenerateOutputData(bool[] signals, int samplesPerBit)
        {
            List<byte> outputData = [];
            foreach (bool signal in signals)
            {
                byte value = signal ? (byte)255 : (byte)0;
                for (int sample = 0; sample < samplesPerBit; sample++)
                {
                    outputData.Add(value);
                    outputData.Add(value);
                }
            }
            return [.. outputData];
        }
    }
}