using Frigg.CTC.Decoding;
using Frigg.CTC.Signalling;
using Frigg.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using WinFrigg.Components;

public static class AppHelper
{
    public class CTCStepConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return typeof(CTCStep).IsAssignableFrom(objectType);
        }

        public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
        {
            if (value is not CTCStep step)
            {
                return;
            }
            JObject jObject = new()
        {
            { "StepName", step.StepName },
            { "InputData", JToken.FromObject(step.InputData) },
            { "OutputData", JToken.FromObject(step.OutputData) },
            { "Type", step.GetType().AssemblyQualifiedName }
        };
            jObject.WriteTo(writer);
        }

        public override object? ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer)
        {
            // This is a workaround to deserialize
            JObject jObject = JObject.Load(reader);
            string? typeName = jObject["Type"]?.Value<string>();
            if (typeName is null)
            {
                return null;
            }
            Type? type = Type.GetType(typeName);
            if (type is null)
            {
                return null;
            }
            CTCStep? step = (CTCStep?)Activator.CreateInstance(type);
            if (step is null)
            {
                return null;
            }
            serializer.Populate(jObject.CreateReader(), step);
            return step;
        }
    }

    public static void SaveSteps(string filePath, List<CTCStepControl> steps)
    {
        List<StepInfo> stepsToSerialize = steps.Select(stepControl =>
        {
            if (stepControl?.Step != null)
            {
                // Remove output and input data
                stepControl.Step.InputData = [];
                stepControl.Step.OutputData = [];
            }
            return new StepInfo
            {
                StepName = stepControl?.Step?.StepName ?? "Empty Step",
                Step = stepControl?.Step ?? new EmptyCTCStep()
            };
        }).ToList();

        string json = JsonConvert.SerializeObject(stepsToSerialize, new JsonSerializerSettings
        {
            TypeNameHandling = TypeNameHandling.None,
            Converters = [new CTCStepConverter()]
        });

        File.WriteAllText(filePath, json);
    }

    public static List<CTCStepControl> LoadSteps(string filePath)
    {
        if (!File.Exists(filePath))
        {
            return
            [
                new() { Step = new SignalGenerationStep() },
                new() { Step = new SignalDecodingStep() }
            ];
        }

        string json = File.ReadAllText(filePath);
        List<StepInfo>? stepsToDeserialize = JsonConvert.DeserializeObject<List<StepInfo>>(json, new JsonSerializerSettings
        {
            TypeNameHandling = TypeNameHandling.None,
            Converters = [new CTCStepConverter()]
        });

        return stepsToDeserialize?.Select(info => new CTCStepControl
        {
            Step = info.Step
        }).ToList() ??
        [
            new() { Step = new SignalGenerationStep() },
            new() { Step = new SignalDecodingStep() }
        ];
    }

    public class StepInfo
    {
        public string? StepName { get; set; }
        public CTCStep? Step { get; set; }
    }
}