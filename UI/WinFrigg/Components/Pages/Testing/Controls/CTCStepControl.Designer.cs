namespace WinFrigg.Components
{
    partial class CTCStepControl
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
            comboOperation = new ReaLTaiizor.Controls.ForeverComboBox();
            pnlTop = new Panel();
            lblStepId = new ReaLTaiizor.Controls.ForeverLabel();
            pnlClose = new Panel();
            picClose = new PictureBox();
            tabControlStep = new ReaLTaiizor.Controls.HopeTabPage();
            tabStepSpectogram = new TabPage();
            pnlSpectrogramImage = new Panel();
            pnlDecodedMessage = new FlowLayoutPanel();
            charCodeTooltipLabel = new Common.CharCodeTooltipLabel();
            lblDecodedMessage = new ReaLTaiizor.Controls.ForeverLabel();
            tabStepParameters = new TabPage();
            pnlParameters = new Panel();
            btnParametersSave = new ReaLTaiizor.Controls.ForeverButton();
            pnlTop.SuspendLayout();
            pnlClose.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picClose).BeginInit();
            tabControlStep.SuspendLayout();
            tabStepSpectogram.SuspendLayout();
            pnlDecodedMessage.SuspendLayout();
            tabStepParameters.SuspendLayout();
            pnlParameters.SuspendLayout();
            SuspendLayout();
            // 
            // comboOperation
            // 
            comboOperation.BaseColor = Color.FromArgb(25, 27, 29);
            comboOperation.BGColor = Color.FromArgb(45, 47, 49);
            comboOperation.Dock = DockStyle.Top;
            comboOperation.DrawMode = DrawMode.OwnerDrawFixed;
            comboOperation.DropDownStyle = ComboBoxStyle.DropDownList;
            comboOperation.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboOperation.ForeColor = Color.White;
            comboOperation.FormattingEnabled = true;
            comboOperation.HoverColor = Color.FromArgb(74, 110, 174);
            comboOperation.HoverFontColor = Color.White;
            comboOperation.ItemHeight = 23;
            comboOperation.Items.AddRange(new object[] { "Stream data from SDR", "Stream data from File", "Apply normalisation", "Apply contrast filter", "UDP Fragmentation Hi/Lo", "Time based Hi/Lo", "Decode bytes", "Decode morse", "Decode morse + ECC" });
            comboOperation.Location = new Point(0, 22);
            comboOperation.Margin = new Padding(18, 15, 18, 15);
            comboOperation.MaxDropDownItems = 12;
            comboOperation.Name = "comboOperation";
            comboOperation.Size = new Size(304, 29);
            comboOperation.TabIndex = 1;
            comboOperation.SelectedIndexChanged += ComboOperation_SelectedIndexChanged;
            // 
            // pnlTop
            // 
            pnlTop.Controls.Add(lblStepId);
            pnlTop.Controls.Add(pnlClose);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Margin = new Padding(3, 2, 3, 2);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(304, 22);
            pnlTop.TabIndex = 0;
            // 
            // lblStepId
            // 
            lblStepId.AutoSize = true;
            lblStepId.BackColor = Color.Transparent;
            lblStepId.Font = new Font("Segoe UI", 8F);
            lblStepId.ForeColor = Color.LightGray;
            lblStepId.Location = new Point(3, 4);
            lblStepId.Name = "lblStepId";
            lblStepId.Size = new Size(59, 13);
            lblStepId.TabIndex = 6;
            lblStepId.Text = "Step Id: -1";
            // 
            // pnlClose
            // 
            pnlClose.Controls.Add(picClose);
            pnlClose.Dock = DockStyle.Right;
            pnlClose.Location = new Point(278, 0);
            pnlClose.Margin = new Padding(3, 2, 3, 2);
            pnlClose.Name = "pnlClose";
            pnlClose.Size = new Size(26, 22);
            pnlClose.TabIndex = 5;
            // 
            // picClose
            // 
            picClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picClose.Image = Properties.Resources.close;
            picClose.Location = new Point(5, 4);
            picClose.Margin = new Padding(3, 2, 3, 2);
            picClose.Name = "picClose";
            picClose.Size = new Size(16, 14);
            picClose.SizeMode = PictureBoxSizeMode.Zoom;
            picClose.TabIndex = 1;
            picClose.TabStop = false;
            picClose.Click += PicClose_Click;
            picClose.MouseLeave += PicClose_MouseLeave;
            picClose.MouseHover += PicClose_MouseHover;
            // 
            // tabControlStep
            // 
            tabControlStep.BaseColor = Color.FromArgb(69, 69, 69);
            tabControlStep.Controls.Add(tabStepSpectogram);
            tabControlStep.Controls.Add(tabStepParameters);
            tabControlStep.Dock = DockStyle.Fill;
            tabControlStep.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabControlStep.ForeColorA = Color.Silver;
            tabControlStep.ForeColorB = Color.Gray;
            tabControlStep.ForeColorC = Color.FromArgb(150, 255, 255, 255);
            tabControlStep.ItemSize = new Size(120, 40);
            tabControlStep.Location = new Point(0, 51);
            tabControlStep.Margin = new Padding(3, 2, 3, 2);
            tabControlStep.Name = "tabControlStep";
            tabControlStep.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            tabControlStep.SelectedIndex = 0;
            tabControlStep.Size = new Size(304, 435);
            tabControlStep.SizeMode = TabSizeMode.Fixed;
            tabControlStep.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            tabControlStep.TabIndex = 3;
            tabControlStep.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            tabControlStep.ThemeColorA = Color.FromArgb(74, 110, 174);
            tabControlStep.ThemeColorB = Color.FromArgb(74, 110, 174);
            tabControlStep.TitleTextState = ReaLTaiizor.Controls.HopeTabPage.TextState.Normal;
            // 
            // tabStepSpectogram
            // 
            tabStepSpectogram.BackColor = Color.FromArgb(45, 47, 49);
            tabStepSpectogram.Controls.Add(pnlSpectrogramImage);
            tabStepSpectogram.Controls.Add(pnlDecodedMessage);
            tabStepSpectogram.Controls.Add(lblDecodedMessage);
            tabStepSpectogram.Location = new Point(0, 40);
            tabStepSpectogram.Margin = new Padding(3, 2, 3, 2);
            tabStepSpectogram.Name = "tabStepSpectogram";
            tabStepSpectogram.Padding = new Padding(3, 2, 3, 2);
            tabStepSpectogram.Size = new Size(304, 395);
            tabStepSpectogram.TabIndex = 0;
            tabStepSpectogram.Text = "Spectrogram";
            // 
            // pnlSpectrogramImage
            // 
            pnlSpectrogramImage.Dock = DockStyle.Fill;
            pnlSpectrogramImage.Location = new Point(3, 61);
            pnlSpectrogramImage.Name = "pnlSpectrogramImage";
            pnlSpectrogramImage.Size = new Size(298, 332);
            pnlSpectrogramImage.TabIndex = 1;
            // 
            // pnlDecodedMessage
            // 
            pnlDecodedMessage.AutoScroll = true;
            pnlDecodedMessage.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pnlDecodedMessage.Controls.Add(charCodeTooltipLabel);
            pnlDecodedMessage.Dock = DockStyle.Top;
            pnlDecodedMessage.Location = new Point(3, 22);
            pnlDecodedMessage.Name = "pnlDecodedMessage";
            pnlDecodedMessage.Size = new Size(298, 39);
            pnlDecodedMessage.TabIndex = 3;
            pnlDecodedMessage.Visible = false;
            pnlDecodedMessage.WrapContents = false;
            // 
            // charCodeTooltipLabel
            // 
            charCodeTooltipLabel.ForeColor = Color.LightGray;
            charCodeTooltipLabel.Location = new Point(3, 0);
            charCodeTooltipLabel.Name = "charCodeTooltipLabel";
            charCodeTooltipLabel.Size = new Size(299, 39);
            charCodeTooltipLabel.TabIndex = 2;
            charCodeTooltipLabel.Text = "Default Message";
            charCodeTooltipLabel.Visible = false;
            // 
            // lblDecodedMessage
            // 
            lblDecodedMessage.BackColor = Color.Transparent;
            lblDecodedMessage.Dock = DockStyle.Top;
            lblDecodedMessage.Font = new Font("Segoe UI", 8F);
            lblDecodedMessage.ForeColor = Color.LightGray;
            lblDecodedMessage.Location = new Point(3, 2);
            lblDecodedMessage.Name = "lblDecodedMessage";
            lblDecodedMessage.Size = new Size(298, 20);
            lblDecodedMessage.TabIndex = 0;
            lblDecodedMessage.Text = "Decoded Message:";
            lblDecodedMessage.TextAlign = ContentAlignment.TopCenter;
            lblDecodedMessage.Visible = false;
            // 
            // tabStepParameters
            // 
            tabStepParameters.BackColor = Color.FromArgb(45, 47, 49);
            tabStepParameters.Controls.Add(pnlParameters);
            tabStepParameters.Location = new Point(0, 40);
            tabStepParameters.Margin = new Padding(3, 2, 3, 2);
            tabStepParameters.Name = "tabStepParameters";
            tabStepParameters.Padding = new Padding(3, 2, 3, 2);
            tabStepParameters.Size = new Size(304, 395);
            tabStepParameters.TabIndex = 1;
            tabStepParameters.Text = "Parameters";
            // 
            // pnlParameters
            // 
            pnlParameters.Controls.Add(btnParametersSave);
            pnlParameters.Dock = DockStyle.Fill;
            pnlParameters.Location = new Point(3, 2);
            pnlParameters.Name = "pnlParameters";
            pnlParameters.Size = new Size(298, 391);
            pnlParameters.TabIndex = 0;
            // 
            // btnParametersSave
            // 
            btnParametersSave.BackColor = Color.Transparent;
            btnParametersSave.BaseColor = Color.FromArgb(74, 110, 174);
            btnParametersSave.Dock = DockStyle.Top;
            btnParametersSave.Font = new Font("Segoe UI", 12F);
            btnParametersSave.Location = new Point(0, 0);
            btnParametersSave.Name = "btnParametersSave";
            btnParametersSave.Rounded = false;
            btnParametersSave.Size = new Size(298, 40);
            btnParametersSave.TabIndex = 0;
            btnParametersSave.Text = "Save Parameters";
            btnParametersSave.TextColor = Color.FromArgb(243, 243, 243);
            btnParametersSave.Click += BtnParametersSave_Click;
            // 
            // CTCStepControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(tabControlStep);
            Controls.Add(comboOperation);
            Controls.Add(pnlTop);
            Margin = new Padding(3, 2, 3, 2);
            Name = "CTCStepControl";
            Size = new Size(304, 486);
            Load += CTCStepControl_Load;
            Paint += CTCStepControl_Paint;
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            pnlClose.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picClose).EndInit();
            tabControlStep.ResumeLayout(false);
            tabStepSpectogram.ResumeLayout(false);
            pnlDecodedMessage.ResumeLayout(false);
            tabStepParameters.ResumeLayout(false);
            pnlParameters.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.ForeverComboBox comboOperation;
        private Panel pnlTop;
        private Panel pnlClose;
        private PictureBox picClose;
        private ReaLTaiizor.Controls.HopeTabPage tabControlStep;
        private TabPage tabStepSpectogram;
        private TabPage tabStepParameters;
        private ReaLTaiizor.Controls.ForeverLabel lblStepId;
        private Panel pnlParameters;
        private ReaLTaiizor.Controls.ForeverButton btnParametersSave;
        private ReaLTaiizor.Controls.ForeverLabel lblDecodedMessage;
        private Panel pnlSpectrogramImage;
        private Common.CharCodeTooltipLabel charCodeTooltipLabel;
        private FlowLayoutPanel pnlDecodedMessage;
    }
}
