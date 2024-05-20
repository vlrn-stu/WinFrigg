using Frigg.Model;
using System.Text.RegularExpressions;

namespace WinFrigg.Components
{
    public partial class StepParameterInputControl : UserControl
    {
        public (string Key, StepParameterValue Value) StepParameterKeyValuePair()
        {
            StepParameterValue stepParameterValue = new()
            {
                InputType = _stepParameterValue.InputType
            };
            switch (stepParameterValue.InputType)
            {
                case StepParameterValueInputType.String:
                    if (!string.IsNullOrWhiteSpace(txtboxStepParameterValue.Text))
                    {
                        stepParameterValue.Value = txtboxStepParameterValue.Text;
                        return (_stepParameterKey, stepParameterValue);
                    }
                    return (_stepParameterKey, _stepParameterValue);

                case StepParameterValueInputType.Int:
                    if (int.TryParse(txtboxStepParameterValue.Text, out int intValue))
                    {
                        stepParameterValue.Value = intValue;
                        return (_stepParameterKey, stepParameterValue);
                    }
                    return (_stepParameterKey, _stepParameterValue);

                case StepParameterValueInputType.Double:
                    if (double.TryParse(txtboxStepParameterValue.Text, out double doubleValue))
                    {
                        stepParameterValue.Value = doubleValue;
                        return (_stepParameterKey, stepParameterValue);
                    }
                    return (_stepParameterKey, _stepParameterValue);

                case StepParameterValueInputType.PathDialog:
                    PathDialogInputValue? pathDialogInputValue = _stepParameterValue.Value as PathDialogInputValue;
                    switch (pathDialogInputValue?.Type)
                    {
                        case PathDialogType.File:
                            if (openFileDialog.CheckFileExists)
                            {
                                pathDialogInputValue.Path = openFileDialog.FileName;
                                stepParameterValue.Value = pathDialogInputValue;
                                return (_stepParameterKey, stepParameterValue);
                            }
                            break;

                        case PathDialogType.Directory:
                            pathDialogInputValue.Path = folderBrowserDialog.SelectedPath;
                            stepParameterValue.Value = pathDialogInputValue;
                            return (_stepParameterKey, stepParameterValue);

                        default:
                            break;
                    }
                    return (_stepParameterKey, _stepParameterValue);

                case StepParameterValueInputType.Enum:
                    EnumInputValue enumInputValue = new()
                    {
                        EnumType = _stepParameterValue.Value.GetType(),
                        Value = _stepParameterValue?.Value?.ToString() ?? string.Empty,
                    };

                    if (Enum.TryParse(enumInputValue.EnumType, comboParameterValueEnum?.SelectedItem?.ToString() ?? string.Empty, out object? enumValue) && enumValue is not null)
                    {
                        stepParameterValue.Value = enumValue;
                        return (_stepParameterKey, stepParameterValue);
                    }
                    return (_stepParameterKey, _stepParameterValue ?? throw new NullReferenceException("Step paramater value was null"));

                case StepParameterValueInputType.Checkbox:
                    stepParameterValue.Value = chckboxParameterValue.Checked;
                    return (_stepParameterKey, stepParameterValue);

                default:
                    break;
            }
            return (_stepParameterKey, _stepParameterValue);
        }

        private readonly string _stepParameterKey;
        private readonly StepParameterValue _stepParameterValue;

        public StepParameterInputControl(string stepParameterKey, StepParameterValue stepParameterValue)
        {
            _stepParameterKey = stepParameterKey;
            _stepParameterValue = stepParameterValue;
            InitializeComponent();
            lblStepParameterKey.Text = stepParameterKey;
            switch (stepParameterValue.InputType)
            {
                case StepParameterValueInputType.String:
                    txtboxStepParameterValue.Text = stepParameterValue.Value.ToString();
                    txtboxStepParameterValue.Visible = true;
                    break;

                case StepParameterValueInputType.Int:
                    lblStepParameterKey.Text = stepParameterKey + " (int)";
                    txtboxStepParameterValue.Text = stepParameterValue.Value.ToString();
                    txtboxStepParameterValue.Visible = true;
                    break;

                case StepParameterValueInputType.Double:
                    lblStepParameterKey.Text = stepParameterKey + " (double)";
                    txtboxStepParameterValue.Text = stepParameterValue.Value.ToString();
                    txtboxStepParameterValue.Visible = true;
                    break;

                case StepParameterValueInputType.PathDialog:
                    btnParameterValuePathDialog.Visible = true;
                    break;

                case StepParameterValueInputType.Enum:
                    Type enumType = _stepParameterValue.Value.GetType();
                    comboParameterValueEnum.Items.Clear();
                    foreach (object enumValue in Enum.GetValues(enumType))
                    {
                        _ = comboParameterValueEnum.Items.Add(enumValue.ToString() ?? "");
                    }
                    comboParameterValueEnum.SelectedItem = _stepParameterValue.Value.ToString();
                    comboParameterValueEnum.Visible = true;
                    break;

                case StepParameterValueInputType.Checkbox:
                    chckboxParameterValue.Text = EnumWordSpaces().Replace(_stepParameterKey, " $1");
                    chckboxParameterValue.Visible = true;
                    break;

                default:
                    break;
            }
        }

        [GeneratedRegex("(\\B[A-Z])")]
        private static partial Regex EnumWordSpaces();
    }
}