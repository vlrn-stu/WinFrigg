namespace Frigg.Model
{
    [Serializable]
    public class StepParameterDictionary : Dictionary<string, StepParameterValue>
    {
    }

    public class StepParameterValue
    {
        public StepParameterValueInputType InputType { get; set; }

        public object Value { get; set; } = default!;
    }

    public enum StepParameterValueInputType
    {
        String,
        Int,
        Double,
        PathDialog,
        Enum,
        Checkbox
    }

    public enum PathDialogType
    {
        File,
        Directory
    }

    public class PathDialogInputValue
    {
        public PathDialogType Type { get; set; }
        public string InitialDirectory { get; set; } = default!;
        public string Path { get; set; } = default!;
        public string? Extensions { get; set; }
    }

    public class EnumInputValue

    {
        public Type EnumType { get; set; } = default!;
        public string Value { get; set; } = default!;
    }
}