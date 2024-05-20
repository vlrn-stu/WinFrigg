namespace WinFrigg
{
    partial class Info
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Info));
            customWindowHeaderControl = new Components.CustomWindowHeaderControl();
            tabGeneral = new TabPage();
            richTextBoxGeneral = new RichTextBox();
            tabControlInfo = new ReaLTaiizor.Controls.HopeTabPage();
            tabLicenses = new TabPage();
            hopeTabPage1 = new ReaLTaiizor.Controls.HopeTabPage();
            tabNethackrfLicense = new TabPage();
            richTextBox2 = new RichTextBox();
            tabGeneral.SuspendLayout();
            tabControlInfo.SuspendLayout();
            tabLicenses.SuspendLayout();
            hopeTabPage1.SuspendLayout();
            tabNethackrfLicense.SuspendLayout();
            SuspendLayout();
            // 
            // customWindowHeaderControl
            // 
            customWindowHeaderControl.BorderStyle = BorderStyle.FixedSingle;
            customWindowHeaderControl.Dock = DockStyle.Top;
            customWindowHeaderControl.Location = new Point(0, 0);
            customWindowHeaderControl.Margin = new Padding(3, 2, 3, 2);
            customWindowHeaderControl.Name = "customWindowHeaderControl";
            customWindowHeaderControl.Size = new Size(690, 22);
            customWindowHeaderControl.TabIndex = 0;
            // 
            // tabGeneral
            // 
            tabGeneral.BackColor = Color.FromArgb(42, 42, 42);
            tabGeneral.Controls.Add(richTextBoxGeneral);
            tabGeneral.Location = new Point(0, 40);
            tabGeneral.Name = "tabGeneral";
            tabGeneral.Padding = new Padding(3);
            tabGeneral.Size = new Size(690, 628);
            tabGeneral.TabIndex = 4;
            tabGeneral.Text = "General";
            // 
            // richTextBoxGeneral
            // 
            richTextBoxGeneral.BackColor = Color.FromArgb(45, 47, 49);
            richTextBoxGeneral.BorderStyle = BorderStyle.None;
            richTextBoxGeneral.Dock = DockStyle.Fill;
            richTextBoxGeneral.ForeColor = Color.White;
            richTextBoxGeneral.Location = new Point(3, 3);
            richTextBoxGeneral.Name = "richTextBoxGeneral";
            richTextBoxGeneral.ReadOnly = true;
            richTextBoxGeneral.Size = new Size(684, 622);
            richTextBoxGeneral.TabIndex = 0;
            richTextBoxGeneral.Text = resources.GetString("richTextBoxGeneral.Text");
            // 
            // tabControlInfo
            // 
            tabControlInfo.BaseColor = Color.FromArgb(69, 69, 69);
            tabControlInfo.Controls.Add(tabGeneral);
            tabControlInfo.Controls.Add(tabLicenses);
            tabControlInfo.Dock = DockStyle.Fill;
            tabControlInfo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            tabControlInfo.ForeColorA = Color.Silver;
            tabControlInfo.ForeColorB = Color.Gray;
            tabControlInfo.ForeColorC = Color.FromArgb(150, 255, 255, 255);
            tabControlInfo.ItemSize = new Size(120, 40);
            tabControlInfo.Location = new Point(0, 22);
            tabControlInfo.Margin = new Padding(0);
            tabControlInfo.Name = "tabControlInfo";
            tabControlInfo.Padding = new Point(0, 0);
            tabControlInfo.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            tabControlInfo.SelectedIndex = 0;
            tabControlInfo.Size = new Size(690, 668);
            tabControlInfo.SizeMode = TabSizeMode.Fixed;
            tabControlInfo.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            tabControlInfo.TabIndex = 4;
            tabControlInfo.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            tabControlInfo.ThemeColorA = Color.FromArgb(74, 110, 174);
            tabControlInfo.ThemeColorB = Color.FromArgb(69, 69, 69);
            tabControlInfo.TitleTextState = ReaLTaiizor.Controls.HopeTabPage.TextState.Normal;
            // 
            // tabLicenses
            // 
            tabLicenses.BackColor = Color.FromArgb(42, 42, 42);
            tabLicenses.Controls.Add(hopeTabPage1);
            tabLicenses.Location = new Point(0, 40);
            tabLicenses.Name = "tabLicenses";
            tabLicenses.Size = new Size(690, 628);
            tabLicenses.TabIndex = 5;
            tabLicenses.Text = "Licenses";
            // 
            // hopeTabPage1
            // 
            hopeTabPage1.BaseColor = Color.FromArgb(69, 69, 69);
            hopeTabPage1.Controls.Add(tabNethackrfLicense);
            hopeTabPage1.Dock = DockStyle.Fill;
            hopeTabPage1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            hopeTabPage1.ForeColorA = Color.Silver;
            hopeTabPage1.ForeColorB = Color.Gray;
            hopeTabPage1.ForeColorC = Color.FromArgb(150, 255, 255, 255);
            hopeTabPage1.ItemSize = new Size(120, 40);
            hopeTabPage1.Location = new Point(0, 0);
            hopeTabPage1.Name = "hopeTabPage1";
            hopeTabPage1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            hopeTabPage1.SelectedIndex = 0;
            hopeTabPage1.Size = new Size(690, 628);
            hopeTabPage1.SizeMode = TabSizeMode.Fixed;
            hopeTabPage1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            hopeTabPage1.TabIndex = 5;
            hopeTabPage1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            hopeTabPage1.ThemeColorA = Color.FromArgb(74, 110, 174);
            hopeTabPage1.ThemeColorB = Color.FromArgb(69, 69, 69);
            hopeTabPage1.TitleTextState = ReaLTaiizor.Controls.HopeTabPage.TextState.Normal;
            // 
            // tabNethackrfLicense
            // 
            tabNethackrfLicense.BackColor = Color.FromArgb(42, 42, 42);
            tabNethackrfLicense.Controls.Add(richTextBox2);
            tabNethackrfLicense.Location = new Point(0, 40);
            tabNethackrfLicense.Name = "tabNethackrfLicense";
            tabNethackrfLicense.Padding = new Padding(3);
            tabNethackrfLicense.Size = new Size(690, 588);
            tabNethackrfLicense.TabIndex = 4;
            tabNethackrfLicense.Text = "HackRF";
            // 
            // richTextBox2
            // 
            richTextBox2.BackColor = Color.FromArgb(45, 47, 49);
            richTextBox2.BorderStyle = BorderStyle.None;
            richTextBox2.Dock = DockStyle.Fill;
            richTextBox2.ForeColor = Color.White;
            richTextBox2.Location = new Point(3, 3);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.ReadOnly = true;
            richTextBox2.Size = new Size(684, 582);
            richTextBox2.TabIndex = 0;
            richTextBox2.Text = resources.GetString("richTextBox2.Text");
            // 
            // Info
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(42, 42, 42);
            ClientSize = new Size(690, 690);
            Controls.Add(tabControlInfo);
            Controls.Add(customWindowHeaderControl);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Info";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Info";
            Load += Info_Load;
            tabGeneral.ResumeLayout(false);
            tabControlInfo.ResumeLayout(false);
            tabLicenses.ResumeLayout(false);
            hopeTabPage1.ResumeLayout(false);
            tabNethackrfLicense.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Components.CustomWindowHeaderControl customWindowHeaderControl;
        private TabPage tabGeneral;
        private ReaLTaiizor.Controls.HopeTabPage tabControlInfo;
        private TabPage tabLicenses;
        private RichTextBox richTextBoxGeneral;
        private ReaLTaiizor.Controls.HopeTabPage hopeTabPage1;
        private TabPage tabNethackrfLicense;
        private RichTextBox richTextBox2;
    }
}