using Frigg.Model;

namespace Frigg.CTC.Logic
{
    public class CTCStepFactoryDictionary : Dictionary<string, (Func<CTCStep> Constructor, int[] StepOrder)>
    {
        public CTCStep CreateInstance(string Name)
        {
            return TryGetValue(Name, out (Func<CTCStep> Constructor, int[] StepOrder) value)
                ? value.Constructor.Invoke()
                : throw new KeyNotFoundException($"No step constructor found for step name: {Name}.");
        }
    }
}