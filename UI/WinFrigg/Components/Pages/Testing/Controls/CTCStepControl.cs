using Frigg.Common;
using Frigg.CTC.Logic;
using Frigg.Model;
using WinFrigg.Components.Common;

namespace WinFrigg.Components
{
    public partial class CTCStepControl : UserControl
    {
        public CTCStepControl()
        {
            InitializeComponent();
            if (!DesignMode)
            {
                InitializeGetIndexInParent();
            }
        }

        public CTCStepControl(CTCStep step)
        {
            InitializeComponent();
            if (!DesignMode)
            {
                Step = step;
                if (Step is null) { throw new Exception("Step in StepControl was null."); }
            }
        }

        public Func<CTCStepControl, int>? GetIndexInParent { get; private set; }

        public event EventHandler? CloseButtonClicked;

        public CTCStep? Step { get; set; }

        public async Task RunStep(CTCStep? previousStep)
        {
            if (Step is null) { return; }
            _ = await Step.PerformStep(previousStep);
            RefreshControl();
        }

        public void InitializeGetIndexInParent()
        {
            GetIndexInParent = (ctcStepControl) =>
            {
                return ctcStepControl.Parent is Panel parentPanel ? parentPanel.Controls.GetChildIndex(ctcStepControl) : -1;
            };
        }

        private void BtnParametersSave_Click(object sender, EventArgs e)
        {
            if (Step is null)
            {
                return;
            }
            StepParameterDictionary stepParameterDictionary = [];
            foreach (object? parameter in pnlParameters.Controls)
            {
                if (parameter is StepParameterInputControl StepParameter)
                {
                    (string Key, StepParameterValue Value) = StepParameter.StepParameterKeyValuePair();
                    stepParameterDictionary[Key] = Value;
                }
            }
            Step.Parameters = stepParameterDictionary;
        }

        private void ComboOperation_SelectedIndexChanged(object sender, EventArgs e)
        {
            string? selectedStepName = comboOperation.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(selectedStepName))
            {
                // Get the class type using the factory and instantiate it in StepControl
                CTCStepFactoryDictionary? stepFactoryDictionary = ServiceActivator.GetService<CTCStepFactoryDictionary>();
                if (stepFactoryDictionary != null && stepFactoryDictionary.TryGetValue(selectedStepName, out (Func<CTCStep> Constructor, int[] StepOrder) createStepFunc))
                {
                    if (Step is null)
                    {
                        return;
                    }
                    PopulateParameters();
                    Step = createStepFunc.Constructor?.Invoke();
                    PopulateParameters();
                }
            }
        }

        private void RefreshControl()
        {
            if (Step?.SpectrogramImagePath is not null)
            {
                if (!string.IsNullOrEmpty(Step.OutputMessage))
                {
                    lblDecodedMessage.Visible = true;
                    charCodeTooltipLabel.Text = Step.OutputMessage;
                    charCodeTooltipLabel.Visible = true;
                    pnlDecodedMessage.Visible = true;
                }
                else
                {
                    lblDecodedMessage.Visible = false;
                    pnlDecodedMessage.Visible = false;
                }
                pnlSpectrogramImage.Controls.Clear();
                pnlSpectrogramImage.Controls.Add(new SpectrogramDisplayControl(Step.SpectrogramImagePath, tabStepSpectogram.ClientRectangle.Width - 50)
                {
                    Visible = true,
                    Width = Width,
                    Height = Height - 50,
                    Dock = DockStyle.Top
                });
                tabControlStep.SelectedIndex = 0;
            }
            else
            {
                tabControlStep.SelectedIndex = 1;
            }
        }

        private void CTCStepControl_Load(object sender, EventArgs e)
        {
            RefreshControl();
        }

        public void InitializeStep()
        {
            lblStepId.Text = $"Step Id: {GetIndexInParent?.Invoke(this)}";
            PopulateOperationComboBox();
            PopulateParameters();
        }

        private void PicClose_Click(object sender, EventArgs e)
        {
            CloseButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        private void PicClose_MouseHover(object sender, EventArgs e)
        {
            pnlClose.BackColor = Color.FromArgb(100, 210, 150, 150);
        }

        private void PicClose_MouseLeave(object sender, EventArgs e)
        {
            pnlClose.BackColor = Color.Transparent;
        }

        private void PopulateOperationComboBox()
        {
            if (Step is null)
            {
                return;
            }
            comboOperation.Items.Clear();
            CTCStepFactoryDictionary? stepFactoryDictionary = ServiceActivator.GetService<CTCStepFactoryDictionary>();
            if (stepFactoryDictionary != null)
            {
                foreach (KeyValuePair<string, (Func<CTCStep> Constructor, int[] StepOrder)> keyValuePairs in stepFactoryDictionary.OrderBy(kvp => kvp.Value.StepOrder.Min()))
                {
                    if (keyValuePairs.Value.StepOrder.ToArray().Contains(GetIndexInParent?.Invoke(this) ?? -1))
                    {
                        _ = comboOperation.Items.Add(keyValuePairs.Key);
                    }
                }
                comboOperation.SelectedItem = Step?.StepName;
            }
        }

        private void PopulateParameters()
        {
            if (Step is null)
            {
                return;
            }
            pnlParameters.Controls.Clear();
            foreach (KeyValuePair<string, StepParameterValue> parameterKeyPair in Step.Parameters)
            {
                pnlParameters.Controls.Add(new StepParameterInputControl(parameterKeyPair.Key, parameterKeyPair.Value)
                {
                    Dock = DockStyle.Top
                });
            }
            pnlParameters.Controls.Add(btnParametersSave);
        }

        private void CTCStepControl_Paint(object sender, PaintEventArgs e)
        {
            Height = Parent?.ClientRectangle.Height - 100 ?? Height;
        }
    }
}