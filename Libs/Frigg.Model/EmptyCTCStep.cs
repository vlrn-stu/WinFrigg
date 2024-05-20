namespace Frigg.Model
{
    public class EmptyCTCStep() : CTCStep()
    {
        public override string StepName => "Empty Step";

        public override int[] StepOrder => [-1];
        public override bool DoDrawSprectrogram { get; set; } = false;

        public override StepParameterDictionary Parameters { get => []; set => _ = value; }

        protected override Task DoStep()
        {
            OutputData = InputData;
            return Task.CompletedTask;
        }
    }
}