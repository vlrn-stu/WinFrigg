using Frigg.Model;

namespace WinFrigg.Components
{
    public partial class StepsPanelControl : UserControl
    {
        private int lastStepControl = 0;

        private int currentStep = 0;

        private DateTimeOffset? StepsStarted = null;

        public StepsPanelControl()
        {
            InitializeComponent();
        }

        public List<CTCStepControl> Steps => GetSteps();

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            lastStepControl++;
            RefreshSteps();
        }

        private async void BtnRunAll_Click(object sender, EventArgs e)
        {
            StepsStarted = DateTimeOffset.UtcNow;
            if (Steps.Count != 0)
            {
                for (int i = 0; i <= lastStepControl; i++)
                {
                    currentStep = i + 1;
                    if (i == 0)
                    {
                        await Steps[0].RunStep(null);
                    }
                    else
                    {
                        await Steps[i].RunStep(Steps[i - 1].Step);
                    }
                    UpdateStatus();
                }
                currentStep = 0;
            }
        }

        private List<CTCStepControl> GetSteps()
        {
            List<CTCStepControl> result = [];
            foreach (object? control in pnlSteps.Controls)
            {
                if (control is CTCStepControl stepControl && stepControl is not null && stepControl.Step is not null)
                {
                    result.Add(stepControl);
                }
            }
            return result;
        }

        private void StepControl_CloseButtonClicked(object? sender, EventArgs e)
        {
            if (sender is CTCStepControl closingStepControl)
            {
                RemoveStep(closingStepControl);
            }
        }

        private void RefreshSteps()
        {
            for (int i = 0; i < pnlSteps.Controls.Count; i++)
            {
                if (pnlSteps.Controls[i] is CTCStepControl stepControl)
                {
                    if (i <= lastStepControl)
                    {
                        stepControl.Visible = true;
                        stepControl.InitializeGetIndexInParent();
                        stepControl.InitializeStep();
                    }
                    else
                    {
                        if (stepControl is null)
                        {
                            return;
                        }
                        stepControl.Visible = false;
                    }
                }
            }
        }

        public void RemoveStep(CTCStepControl stepControl)
        {
            int index = pnlSteps.Controls.IndexOf(stepControl);
            if (index != -1)
            {
                pnlSteps.Controls.RemoveAt(index);

                List<CTCStepControl> emptySteps = pnlSteps.Controls.OfType<CTCStepControl>()
                                     .Where(control => control.Step is EmptyCTCStep)
                                     .ToList();
                foreach (CTCStepControl? emptyStep in emptySteps)
                {
                    pnlSteps.Controls.Remove(emptyStep);
                }

                lastStepControl--;

                while (pnlSteps.Controls.Count < 10)
                {
                    CTCStepControl emptyStep = new(new EmptyCTCStep()) { Visible = false };
                    pnlSteps.Controls.Add(emptyStep);
                    emptyStep.CloseButtonClicked += StepControl_CloseButtonClicked;
                }

                RefreshSteps();
            }
        }

        public void SaveSteps(string filePath)
        {
            AppHelper.SaveSteps(filePath, Steps);
        }

        public void LoadSteps(string filePath)
        {
            List<CTCStep?> loadedSteps = AppHelper.LoadSteps(filePath).Select(s => s.Step).ToList();
            for (int i = loadedSteps.Count; i < 10; i++)
            {
                loadedSteps.Add(new EmptyCTCStep());
            }
            loadedSteps.RemoveAll(s => s is null);
            ReconstructSteps(loadedSteps as List<CTCStep>);
        }

        private void ReconstructSteps(List<CTCStep> loadedSteps)
        {
            pnlSteps.Controls.Clear();
            int lastIndex = -1;
            pnlSteps.Visible = false;
            for (int i = 0; i < loadedSteps.Count; i++)
            {
                CTCStep step = loadedSteps[i];
                CTCStepControl stepControl = new(step);
                stepControl.CloseButtonClicked += StepControl_CloseButtonClicked;
                pnlSteps.Controls.Add(stepControl);

                // We find the last non empty step
                if (step.StepName != new EmptyCTCStep().StepName)
                {
                    lastIndex = i;
                }
            }

            lastStepControl = lastIndex;
            RefreshSteps();
            pnlSteps.Visible = true;
        }

        private void UpdateStatus()
        {
            TimeSpan elapsedTime = DateTimeOffset.UtcNow - (StepsStarted ?? DateTimeOffset.MinValue);
            lblCurrentStep.Text = $"Step:\n{currentStep}/{lastStepControl + 1}";
            lblElapsedTime.Text = $"Elapsed Time:\n{elapsedTime:hh\\:mm\\:ss\\.fff}";
        }

        private async void BtnRunStep_Click(object sender, EventArgs e)
        {
            // Run step, include previous when not first
            await Steps[currentStep].RunStep(currentStep == 0 ? null : Steps[currentStep - 1].Step);
            currentStep++;
            UpdateStatus();
            if (currentStep >= lastStepControl)
            {
                currentStep = 0;
            }
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            UpdateStatus();
            ReconstructSteps(Steps.Select(s => s.Step ?? new EmptyCTCStep()).ToList());
        }
    }
}