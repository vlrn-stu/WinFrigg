using Frigg.CTC;
using Frigg.Model;

namespace WinFrigg.Components
{
    partial class StepsPanelControl
    {
        /// <summary> s
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlSteps = new FlowLayoutPanel();
            pnlSideBar = new Panel();
            btnRefresh = new ReaLTaiizor.Controls.ForeverButton();
            btnRunStep = new ReaLTaiizor.Controls.ForeverButton();
            lblElapsedTime = new ReaLTaiizor.Controls.ForeverLabel();
            lblCurrentStep = new ReaLTaiizor.Controls.ForeverLabel();
            btnRunAll = new ReaLTaiizor.Controls.ForeverButton();
            btnAdd = new ReaLTaiizor.Controls.ForeverButton();
            pnlSideBar.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSteps
            // 
            pnlSteps.AutoScroll = true;
            pnlSteps.Dock = DockStyle.Top;
            pnlSteps.Location = new Point(150, 0);
            pnlSteps.Margin = new Padding(0);
            pnlSteps.Name = "pnlSteps";
            pnlSteps.Size = new Size(1350, 1000);
            pnlSteps.TabIndex = 0;
            pnlSteps.WrapContents = false;
            // 
            // pnlSideBar
            // 
            pnlSideBar.Controls.Add(btnRefresh);
            pnlSideBar.Controls.Add(btnRunStep);
            pnlSideBar.Controls.Add(lblElapsedTime);
            pnlSideBar.Controls.Add(lblCurrentStep);
            pnlSideBar.Controls.Add(btnRunAll);
            pnlSideBar.Controls.Add(btnAdd);
            pnlSideBar.Dock = DockStyle.Left;
            pnlSideBar.Location = new Point(0, 0);
            pnlSideBar.Name = "pnlSideBar";
            pnlSideBar.Size = new Size(150, 750);
            pnlSideBar.TabIndex = 2;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.Transparent;
            btnRefresh.BaseColor = Color.FromArgb(69, 69, 69);
            btnRefresh.Dock = DockStyle.Top;
            btnRefresh.Font = new Font("Segoe UI", 12F);
            btnRefresh.Location = new Point(0, 486);
            btnRefresh.Margin = new Padding(3, 2, 3, 2);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Rounded = false;
            btnRefresh.Size = new Size(150, 112);
            btnRefresh.TabIndex = 7;
            btnRefresh.Text = "Refresh";
            btnRefresh.TextColor = Color.FromArgb(243, 243, 243);
            btnRefresh.Click += BtnRefresh_Click;
            // 
            // btnRunStep
            // 
            btnRunStep.BackColor = Color.Transparent;
            btnRunStep.BaseColor = Color.FromArgb(69, 69, 69);
            btnRunStep.Dock = DockStyle.Top;
            btnRunStep.Font = new Font("Segoe UI", 12F);
            btnRunStep.Location = new Point(0, 374);
            btnRunStep.Margin = new Padding(3, 2, 3, 2);
            btnRunStep.Name = "btnRunStep";
            btnRunStep.Rounded = false;
            btnRunStep.Size = new Size(150, 112);
            btnRunStep.TabIndex = 6;
            btnRunStep.Text = "Run Step";
            btnRunStep.TextColor = Color.FromArgb(243, 243, 243);
            btnRunStep.Click += BtnRunStep_Click;
            // 
            // lblElapsedTime
            // 
            lblElapsedTime.BackColor = Color.Transparent;
            lblElapsedTime.Dock = DockStyle.Top;
            lblElapsedTime.Font = new Font("Segoe UI", 8F);
            lblElapsedTime.ForeColor = Color.LightGray;
            lblElapsedTime.Location = new Point(0, 299);
            lblElapsedTime.Name = "lblElapsedTime";
            lblElapsedTime.Size = new Size(150, 75);
            lblElapsedTime.TabIndex = 5;
            lblElapsedTime.Text = "Elapsed Time:\r\n00:00:00.000";
            lblElapsedTime.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCurrentStep
            // 
            lblCurrentStep.BackColor = Color.Transparent;
            lblCurrentStep.Dock = DockStyle.Top;
            lblCurrentStep.Font = new Font("Segoe UI", 8F);
            lblCurrentStep.ForeColor = Color.LightGray;
            lblCurrentStep.Location = new Point(0, 224);
            lblCurrentStep.Name = "lblCurrentStep";
            lblCurrentStep.Size = new Size(150, 75);
            lblCurrentStep.TabIndex = 4;
            lblCurrentStep.Text = "Step: \r\n0/0";
            lblCurrentStep.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnRunAll
            // 
            btnRunAll.BackColor = Color.Transparent;
            btnRunAll.BaseColor = Color.FromArgb(74, 110, 174);
            btnRunAll.Dock = DockStyle.Top;
            btnRunAll.Font = new Font("Segoe UI", 12F);
            btnRunAll.Location = new Point(0, 112);
            btnRunAll.Margin = new Padding(3, 2, 3, 2);
            btnRunAll.Name = "btnRunAll";
            btnRunAll.Rounded = false;
            btnRunAll.Size = new Size(150, 112);
            btnRunAll.TabIndex = 3;
            btnRunAll.Text = "Run All";
            btnRunAll.TextColor = Color.FromArgb(243, 243, 243);
            btnRunAll.Click += BtnRunAll_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Transparent;
            btnAdd.BaseColor = Color.FromArgb(74, 110, 174);
            btnAdd.Dock = DockStyle.Top;
            btnAdd.Font = new Font("Segoe UI", 12F);
            btnAdd.Location = new Point(0, 0);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Rounded = false;
            btnAdd.Size = new Size(150, 112);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add Step";
            btnAdd.TextColor = Color.FromArgb(243, 243, 243);
            btnAdd.Click += BtnAdd_Click;
            // 
            // StepsPanelControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(pnlSteps);
            Controls.Add(pnlSideBar);
            Margin = new Padding(3, 2, 3, 2);
            Name = "StepsPanelControl";
            Size = new Size(1500, 750);
            pnlSideBar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel pnlSteps;
        private Panel pnlSideBar;
        private ReaLTaiizor.Controls.ForeverButton btnRunStep;
        private ReaLTaiizor.Controls.ForeverLabel lblElapsedTime;
        private ReaLTaiizor.Controls.ForeverLabel lblCurrentStep;
        private ReaLTaiizor.Controls.ForeverButton btnRunAll;
        private ReaLTaiizor.Controls.ForeverButton btnAdd;
        private ReaLTaiizor.Controls.ForeverButton btnRefresh;
    }
}
