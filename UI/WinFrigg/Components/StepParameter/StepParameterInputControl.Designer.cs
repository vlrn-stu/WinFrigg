namespace WinFrigg.Components
{
    partial class StepParameterInputControl
    {
        /// <summary> 
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
            txtboxStepParameterValue = new ReaLTaiizor.Controls.ForeverTextBox();
            lblStepParameterKey = new ReaLTaiizor.Controls.ForeverLabel();
            btnParameterValuePathDialog = new ReaLTaiizor.Controls.ForeverButton();
            openFileDialog = new OpenFileDialog();
            folderBrowserDialog = new FolderBrowserDialog();
            comboParameterValueEnum = new ReaLTaiizor.Controls.ForeverComboBox();
            chckboxParameterValue = new ReaLTaiizor.Controls.ForeverCheckBox();
            SuspendLayout();
            // 
            // txtboxStepParameterValue
            // 
            txtboxStepParameterValue.BackColor = Color.Transparent;
            txtboxStepParameterValue.BaseColor = Color.FromArgb(45, 47, 49);
            txtboxStepParameterValue.BorderColor = Color.FromArgb(74, 110, 174);
            txtboxStepParameterValue.Dock = DockStyle.Bottom;
            txtboxStepParameterValue.FocusOnHover = false;
            txtboxStepParameterValue.ForeColor = Color.FromArgb(192, 192, 192);
            txtboxStepParameterValue.Location = new Point(0, 33);
            txtboxStepParameterValue.MaxLength = 32767;
            txtboxStepParameterValue.Multiline = false;
            txtboxStepParameterValue.Name = "txtboxStepParameterValue";
            txtboxStepParameterValue.ReadOnly = false;
            txtboxStepParameterValue.Size = new Size(250, 29);
            txtboxStepParameterValue.TabIndex = 0;
            txtboxStepParameterValue.Text = "ParameterValue";
            txtboxStepParameterValue.TextAlign = HorizontalAlignment.Left;
            txtboxStepParameterValue.UseSystemPasswordChar = false;
            txtboxStepParameterValue.Visible = false;
            // 
            // lblStepParameterKey
            // 
            lblStepParameterKey.BackColor = Color.Transparent;
            lblStepParameterKey.Dock = DockStyle.Bottom;
            lblStepParameterKey.Font = new Font("Segoe UI", 8F);
            lblStepParameterKey.ForeColor = Color.LightGray;
            lblStepParameterKey.Location = new Point(0, -60);
            lblStepParameterKey.Name = "lblStepParameterKey";
            lblStepParameterKey.Size = new Size(250, 18);
            lblStepParameterKey.TabIndex = 1;
            lblStepParameterKey.Text = "ParameterKey";
            lblStepParameterKey.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnParameterValuePathDialog
            // 
            btnParameterValuePathDialog.BackColor = Color.Transparent;
            btnParameterValuePathDialog.BaseColor = Color.FromArgb(74, 110, 174);
            btnParameterValuePathDialog.Dock = DockStyle.Bottom;
            btnParameterValuePathDialog.Font = new Font("Segoe UI", 12F);
            btnParameterValuePathDialog.Location = new Point(0, 4);
            btnParameterValuePathDialog.Name = "btnParameterValuePathDialog";
            btnParameterValuePathDialog.Rounded = false;
            btnParameterValuePathDialog.Size = new Size(250, 29);
            btnParameterValuePathDialog.TabIndex = 2;
            btnParameterValuePathDialog.Text = "Choose file/directory";
            btnParameterValuePathDialog.TextColor = Color.FromArgb(243, 243, 243);
            btnParameterValuePathDialog.Visible = false;
            // 
            // comboParameterValueEnum
            // 
            comboParameterValueEnum.BaseColor = Color.FromArgb(25, 27, 29);
            comboParameterValueEnum.BGColor = Color.FromArgb(45, 47, 49);
            comboParameterValueEnum.Dock = DockStyle.Bottom;
            comboParameterValueEnum.DrawMode = DrawMode.OwnerDrawFixed;
            comboParameterValueEnum.DropDownStyle = ComboBoxStyle.DropDownList;
            comboParameterValueEnum.Font = new Font("Segoe UI", 8F);
            comboParameterValueEnum.ForeColor = Color.White;
            comboParameterValueEnum.FormattingEnabled = true;
            comboParameterValueEnum.HoverColor = Color.FromArgb(35, 168, 109);
            comboParameterValueEnum.HoverFontColor = Color.White;
            comboParameterValueEnum.ItemHeight = 18;
            comboParameterValueEnum.Location = new Point(0, -20);
            comboParameterValueEnum.Name = "comboParameterValueEnum";
            comboParameterValueEnum.Size = new Size(250, 24);
            comboParameterValueEnum.TabIndex = 3;
            comboParameterValueEnum.Visible = false;
            // 
            // chckboxParameterValue
            // 
            chckboxParameterValue.BackColor = Color.FromArgb(69, 69, 69);
            chckboxParameterValue.BaseColor = Color.FromArgb(45, 47, 49);
            chckboxParameterValue.BorderColor = Color.FromArgb(35, 168, 109);
            chckboxParameterValue.Checked = false;
            chckboxParameterValue.Dock = DockStyle.Bottom;
            chckboxParameterValue.Font = new Font("Segoe UI", 10F);
            chckboxParameterValue.ForeColor = Color.FromArgb(243, 243, 243);
            chckboxParameterValue.Location = new Point(0, -42);
            chckboxParameterValue.Name = "chckboxParameterValue";
            chckboxParameterValue.Options = ReaLTaiizor.Controls.ForeverCheckBox._Options.Style1;
            chckboxParameterValue.Size = new Size(250, 22);
            chckboxParameterValue.TabIndex = 4;
            chckboxParameterValue.Text = "foreverCheckBox1";
            chckboxParameterValue.Visible = false;
            // 
            // StepParameterInputControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(lblStepParameterKey);
            Controls.Add(chckboxParameterValue);
            Controls.Add(comboParameterValueEnum);
            Controls.Add(btnParameterValuePathDialog);
            Controls.Add(txtboxStepParameterValue);
            Name = "StepParameterInputControl";
            Size = new Size(250, 62);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.ForeverTextBox txtboxStepParameterValue;
        private ReaLTaiizor.Controls.ForeverLabel lblStepParameterKey;
        private ReaLTaiizor.Controls.ForeverButton btnParameterValuePathDialog;
        private OpenFileDialog openFileDialog;
        private FolderBrowserDialog folderBrowserDialog;
        private ReaLTaiizor.Controls.ForeverComboBox comboParameterValueEnum;
        private ReaLTaiizor.Controls.ForeverCheckBox chckboxParameterValue;
    }
}
