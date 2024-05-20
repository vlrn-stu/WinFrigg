using Frigg.Common;
using Frigg.Model.Encoding;
using Frigg.Model.Signalling;

namespace Frigg.Model
{
    public interface ICTCStep
    {
        public string StepName { get; }
        public int[] StepOrder { get; }
        public abstract bool DoDrawSprectrogram { get; set; }
        public bool CheckpointStep { get; set; }
        public bool CheckpointCheck { get; set; }
        public byte[] InputData { get; set; }
        public byte[] OutputData { get; set; }
        public string? SpectrogramImagePath { get; set; }
        public string OutputMessage { get; set; }
        public StepParameterDictionary Parameters { get; set; }
        public double[]? Amplitudes { get; set; }
    }

    [Serializable]
    public abstract class CTCStep : ICTCStep
    {
        public abstract string StepName { get; }
        public abstract int[] StepOrder { get; }
        public abstract bool DoDrawSprectrogram { get; set; }
        public bool CheckpointStep { get; set; } = false;
        public bool CheckpointCheck { get; set; } = false;
        public byte[] InputData { get; set; } = [];

        public byte[] OutputData { get; set; } = [];

        public string? SpectrogramImagePath { get; set; }

        public string OutputMessage { get; set; } = "";

        public abstract StepParameterDictionary Parameters { get; set; }

        public double[]? Amplitudes { get; set; }

        public async Task<bool> PerformStep(CTCStep? previousStep)
        {
            if (previousStep is not null)
            {
                InputData = previousStep.OutputData;
                SpectrogramImagePath = previousStep.SpectrogramImagePath;
                Amplitudes = previousStep.Amplitudes;
            }
            await DoStep();
            if (DoDrawSprectrogram)
            {
                await DrawSpectrogram();
            }
            return true;
        }

        public virtual async Task DrawSpectrogram()
        {
            SpectrogramImagePath = Path.Combine(Config.Folders.SpectrogramFolder, $"{Guid.NewGuid()}.png");
            _ = Directory.CreateDirectory(Config.Folders.SpectrogramFolder);
            await Plotter.CreateSpectrogramAsync(OutputData, SpectrogramImagePath);
        }

        #region Proteted Fields

        protected abstract Task DoStep();

        public static void GetCTCParameters(StepParameterDictionary parameters, out ICTCEncoding encoding, out ICTCSignalling signalling)
        {
            encoding = new BinaryCTCEncoding();
            switch ((CTCEncoding)parameters["Encoding"].Value)
            {
                case CTCEncoding.Binary:
                    break;

                case CTCEncoding.Morse:
                    encoding = new MorseCTCEncoding();
                    break;

                case CTCEncoding.SimpleMorse:
                    encoding = new SimpleMorseCTCEncoding();
                    break;

                case CTCEncoding.ECC:
                    encoding = new ECCBinaryCTCEncoding();
                    break;

                default:
                    break;
            }
            signalling = new TimeBasedCTCSignalling();
            switch ((CTCSignalling)parameters["Signalling"].Value)
            {
                case CTCSignalling.TimeBased:
                    break;

                case CTCSignalling.UDPFragmentation:
                    signalling = new UDPFragmentationCTCSignalling();
                    break;

                default:
                    break;
            }
        }

        #endregion Proteted Fields
    }
}