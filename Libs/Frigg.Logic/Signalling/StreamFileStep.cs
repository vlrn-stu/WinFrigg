using Frigg.Common;
using Frigg.Model;

namespace Frigg.CTC.Signalling
{
    public class StreamFileStep : CTCStep
    {
        public override int[] StepOrder => [0];
        public override string StepName => "Stream I/Q values from file";
        public override bool DoDrawSprectrogram { get; set; } = true;

        public override StepParameterDictionary Parameters
        { get; set; }
        = new()
        {
            { "File Path", new StepParameterValue()
                {
                    InputType = StepParameterValueInputType.PathDialog,
                    Value = Path.Combine(Config.Folders.TempIQFolder, "IQData_1.bin")
                }
            }
        };

        protected override async Task DoStep()
        {
            OutputData = await File.ReadAllBytesAsync(Parameters["File Path"]?.Value.ToString() ?? Path.Combine(Config.Folders.TempIQFolder, "IQData_1.bin"));
        }
    }
}