namespace WinFrigg.Components.Pages.Simulation
{
    partial class SimulationPage
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
            pnlSidebar = new Panel();
            checkSpecial = new ReaLTaiizor.Controls.CrownCheckBox();
            checkHungarian = new ReaLTaiizor.Controls.CrownCheckBox();
            checkSlovak = new ReaLTaiizor.Controls.CrownCheckBox();
            checkEnglish = new ReaLTaiizor.Controls.CrownCheckBox();
            checkLower = new ReaLTaiizor.Controls.CrownCheckBox();
            checkAdvancedMorse = new ReaLTaiizor.Controls.CrownCheckBox();
            checkSimpleMorse = new ReaLTaiizor.Controls.CrownCheckBox();
            checkECC = new ReaLTaiizor.Controls.CrownCheckBox();
            checkBinary = new ReaLTaiizor.Controls.CrownCheckBox();
            lblThreads = new ReaLTaiizor.Controls.CrownLabel();
            numThreads = new ReaLTaiizor.Controls.CrownNumeric();
            checkSignallingAll = new ReaLTaiizor.Controls.CrownCheckBox();
            checkNoiseAll = new ReaLTaiizor.Controls.CrownCheckBox();
            lblAlphabet = new ReaLTaiizor.Controls.CrownLabel();
            lblElapsed = new ReaLTaiizor.Controls.CrownLabel();
            btnCancel = new ReaLTaiizor.Controls.ForeverButton();
            btnNew = new ReaLTaiizor.Controls.ForeverButton();
            btnClear = new ReaLTaiizor.Controls.ForeverButton();
            numTimeStep = new ReaLTaiizor.Controls.CrownNumeric();
            comboNoiseType = new ReaLTaiizor.Controls.CrownComboBox();
            lblNoiseType = new ReaLTaiizor.Controls.CrownLabel();
            lblTimeStart = new ReaLTaiizor.Controls.CrownLabel();
            lblTimeEnd = new ReaLTaiizor.Controls.CrownLabel();
            btnExport = new ReaLTaiizor.Controls.ForeverButton();
            btnLoad = new ReaLTaiizor.Controls.ForeverButton();
            txtAlphabet = new ReaLTaiizor.Controls.CrownTextBox();
            lblTimeStep = new ReaLTaiizor.Controls.CrownLabel();
            numTimeEnd = new ReaLTaiizor.Controls.CrownNumeric();
            numTimeStart = new ReaLTaiizor.Controls.CrownNumeric();
            btnRun = new ReaLTaiizor.Controls.ForeverButton();
            lblSimSignalTime = new ReaLTaiizor.Controls.CrownLabel();
            txtTestCount = new ReaLTaiizor.Controls.CrownTextBox();
            lblEncoding = new ReaLTaiizor.Controls.CrownLabel();
            lblTestCount = new ReaLTaiizor.Controls.CrownLabel();
            lblMessageSize = new ReaLTaiizor.Controls.CrownLabel();
            lblSignalingType = new ReaLTaiizor.Controls.CrownLabel();
            numNoiseStep = new ReaLTaiizor.Controls.CrownNumeric();
            lblNoisePercent = new ReaLTaiizor.Controls.CrownLabel();
            comboSignalingType = new ReaLTaiizor.Controls.CrownComboBox();
            numMessageSize = new ReaLTaiizor.Controls.CrownNumeric();
            pagedDataControl = new Common.PagedDataControl();
            openFileDialog = new OpenFileDialog();
            saveFileDialog = new SaveFileDialog();
            pnlSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numThreads).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numTimeStep).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numTimeEnd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numTimeStart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numNoiseStep).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numMessageSize).BeginInit();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.Controls.Add(checkSpecial);
            pnlSidebar.Controls.Add(checkHungarian);
            pnlSidebar.Controls.Add(checkSlovak);
            pnlSidebar.Controls.Add(checkEnglish);
            pnlSidebar.Controls.Add(checkLower);
            pnlSidebar.Controls.Add(checkAdvancedMorse);
            pnlSidebar.Controls.Add(checkSimpleMorse);
            pnlSidebar.Controls.Add(checkECC);
            pnlSidebar.Controls.Add(checkBinary);
            pnlSidebar.Controls.Add(lblThreads);
            pnlSidebar.Controls.Add(numThreads);
            pnlSidebar.Controls.Add(checkSignallingAll);
            pnlSidebar.Controls.Add(checkNoiseAll);
            pnlSidebar.Controls.Add(lblAlphabet);
            pnlSidebar.Controls.Add(lblElapsed);
            pnlSidebar.Controls.Add(btnCancel);
            pnlSidebar.Controls.Add(btnNew);
            pnlSidebar.Controls.Add(btnClear);
            pnlSidebar.Controls.Add(numTimeStep);
            pnlSidebar.Controls.Add(comboNoiseType);
            pnlSidebar.Controls.Add(lblNoiseType);
            pnlSidebar.Controls.Add(lblTimeStart);
            pnlSidebar.Controls.Add(lblTimeEnd);
            pnlSidebar.Controls.Add(btnExport);
            pnlSidebar.Controls.Add(btnLoad);
            pnlSidebar.Controls.Add(txtAlphabet);
            pnlSidebar.Controls.Add(lblTimeStep);
            pnlSidebar.Controls.Add(numTimeEnd);
            pnlSidebar.Controls.Add(numTimeStart);
            pnlSidebar.Controls.Add(btnRun);
            pnlSidebar.Controls.Add(lblSimSignalTime);
            pnlSidebar.Controls.Add(txtTestCount);
            pnlSidebar.Controls.Add(lblEncoding);
            pnlSidebar.Controls.Add(lblTestCount);
            pnlSidebar.Controls.Add(lblMessageSize);
            pnlSidebar.Controls.Add(lblSignalingType);
            pnlSidebar.Controls.Add(numNoiseStep);
            pnlSidebar.Controls.Add(lblNoisePercent);
            pnlSidebar.Controls.Add(comboSignalingType);
            pnlSidebar.Controls.Add(numMessageSize);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(280, 831);
            pnlSidebar.TabIndex = 15;
            // 
            // checkSpecial
            // 
            checkSpecial.AutoSize = true;
            checkSpecial.Location = new Point(118, 259);
            checkSpecial.Name = "checkSpecial";
            checkSpecial.Size = new Size(63, 19);
            checkSpecial.TabIndex = 46;
            checkSpecial.Text = "Special";
            checkSpecial.CheckedChanged += CheckAlphabet_CheckedChanged;
            // 
            // checkHungarian
            // 
            checkHungarian.AutoSize = true;
            checkHungarian.Location = new Point(30, 259);
            checkHungarian.Name = "checkHungarian";
            checkHungarian.Size = new Size(82, 19);
            checkHungarian.TabIndex = 45;
            checkHungarian.Text = "Hungarian";
            checkHungarian.CheckedChanged += CheckAlphabet_CheckedChanged;
            // 
            // checkSlovak
            // 
            checkSlovak.AutoSize = true;
            checkSlovak.Location = new Point(164, 234);
            checkSlovak.Name = "checkSlovak";
            checkSlovak.Size = new Size(60, 19);
            checkSlovak.TabIndex = 44;
            checkSlovak.Text = "Slovak";
            checkSlovak.CheckedChanged += CheckAlphabet_CheckedChanged;
            // 
            // checkEnglish
            // 
            checkEnglish.AutoSize = true;
            checkEnglish.Location = new Point(94, 234);
            checkEnglish.Name = "checkEnglish";
            checkEnglish.Size = new Size(64, 19);
            checkEnglish.TabIndex = 43;
            checkEnglish.Text = "English";
            checkEnglish.CheckedChanged += CheckAlphabet_CheckedChanged;
            // 
            // checkLower
            // 
            checkLower.AutoSize = true;
            checkLower.Location = new Point(30, 234);
            checkLower.Name = "checkLower";
            checkLower.Size = new Size(58, 19);
            checkLower.TabIndex = 42;
            checkLower.Text = "Lower";
            checkLower.CheckedChanged += CheckAlphabet_CheckedChanged;
            // 
            // checkAdvancedMorse
            // 
            checkAdvancedMorse.AutoSize = true;
            checkAdvancedMorse.Location = new Point(30, 131);
            checkAdvancedMorse.Name = "checkAdvancedMorse";
            checkAdvancedMorse.Size = new Size(115, 19);
            checkAdvancedMorse.TabIndex = 41;
            checkAdvancedMorse.Text = "Advanced Morse";
            // 
            // checkSimpleMorse
            // 
            checkSimpleMorse.AutoSize = true;
            checkSimpleMorse.Location = new Point(150, 106);
            checkSimpleMorse.Name = "checkSimpleMorse";
            checkSimpleMorse.Size = new Size(98, 19);
            checkSimpleMorse.TabIndex = 40;
            checkSimpleMorse.Text = "Simple Morse";
            // 
            // checkECC
            // 
            checkECC.AutoSize = true;
            checkECC.Location = new Point(96, 106);
            checkECC.Name = "checkECC";
            checkECC.RightToLeft = RightToLeft.Yes;
            checkECC.Size = new Size(48, 19);
            checkECC.TabIndex = 39;
            checkECC.Text = "ECC";
            // 
            // checkBinary
            // 
            checkBinary.AutoSize = true;
            checkBinary.Checked = true;
            checkBinary.CheckState = CheckState.Checked;
            checkBinary.Location = new Point(31, 106);
            checkBinary.Name = "checkBinary";
            checkBinary.Size = new Size(59, 19);
            checkBinary.TabIndex = 38;
            checkBinary.Text = "Binary";
            // 
            // lblThreads
            // 
            lblThreads.AutoSize = true;
            lblThreads.ForeColor = Color.FromArgb(220, 220, 220);
            lblThreads.Location = new Point(30, 367);
            lblThreads.Name = "lblThreads";
            lblThreads.Size = new Size(51, 15);
            lblThreads.TabIndex = 37;
            lblThreads.Text = "Threads:";
            // 
            // numThreads
            // 
            numThreads.Location = new Point(30, 385);
            numThreads.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numThreads.Name = "numThreads";
            numThreads.Size = new Size(61, 23);
            numThreads.TabIndex = 36;
            numThreads.Value = new decimal(new int[] { 8, 0, 0, 0 });
            // 
            // checkSignallingAll
            // 
            checkSignallingAll.Location = new Point(210, 468);
            checkSignallingAll.Name = "checkSignallingAll";
            checkSignallingAll.Size = new Size(40, 20);
            checkSignallingAll.TabIndex = 35;
            checkSignallingAll.Text = "All";
            checkSignallingAll.CheckedChanged += CheckSignallingAll_CheckedChanged;
            // 
            // checkNoiseAll
            // 
            checkNoiseAll.BackColor = Color.FromArgb(42, 42, 42);
            checkNoiseAll.Location = new Point(211, 414);
            checkNoiseAll.Name = "checkNoiseAll";
            checkNoiseAll.Size = new Size(40, 20);
            checkNoiseAll.TabIndex = 34;
            checkNoiseAll.Text = "All";
            checkNoiseAll.CheckedChanged += CheckNoiseAll_CheckedChanged;
            // 
            // lblAlphabet
            // 
            lblAlphabet.AutoSize = true;
            lblAlphabet.ForeColor = Color.FromArgb(220, 220, 220);
            lblAlphabet.Location = new Point(30, 212);
            lblAlphabet.Name = "lblAlphabet";
            lblAlphabet.Size = new Size(58, 15);
            lblAlphabet.TabIndex = 32;
            lblAlphabet.Text = "Alphabet:";
            // 
            // lblElapsed
            // 
            lblElapsed.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblElapsed.AutoSize = true;
            lblElapsed.ForeColor = Color.FromArgb(220, 220, 220);
            lblElapsed.Location = new Point(33, 611);
            lblElapsed.Name = "lblElapsed";
            lblElapsed.Size = new Size(116, 15);
            lblElapsed.TabIndex = 31;
            lblElapsed.Text = "Elapsed: 00:00:00.000";
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCancel.BackColor = Color.Transparent;
            btnCancel.BaseColor = Color.DarkRed;
            btnCancel.Font = new Font("Segoe UI", 12F);
            btnCancel.Location = new Point(31, 568);
            btnCancel.Name = "btnCancel";
            btnCancel.Rounded = false;
            btnCancel.Size = new Size(220, 40);
            btnCancel.TabIndex = 30;
            btnCancel.Text = "Cancel";
            btnCancel.TextColor = Color.FromArgb(243, 243, 243);
            btnCancel.Visible = false;
            btnCancel.Click += BtnCancel_Click;
            // 
            // btnNew
            // 
            btnNew.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnNew.BackColor = Color.Transparent;
            btnNew.BaseColor = Color.FromArgb(35, 168, 109);
            btnNew.Font = new Font("Segoe UI", 12F);
            btnNew.Location = new Point(144, 711);
            btnNew.Name = "btnNew";
            btnNew.Rounded = false;
            btnNew.Size = new Size(107, 54);
            btnNew.TabIndex = 29;
            btnNew.Text = "New CSV";
            btnNew.TextColor = Color.FromArgb(243, 243, 243);
            btnNew.Click += BtnNew_Click;
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnClear.BackColor = Color.Transparent;
            btnClear.BaseColor = Color.Maroon;
            btnClear.Font = new Font("Segoe UI", 12F);
            btnClear.Location = new Point(144, 771);
            btnClear.Name = "btnClear";
            btnClear.Rounded = false;
            btnClear.Size = new Size(107, 54);
            btnClear.TabIndex = 28;
            btnClear.Text = "Clear";
            btnClear.TextColor = Color.FromArgb(243, 243, 243);
            btnClear.Click += BtnClear_Click;
            // 
            // numTimeStep
            // 
            numTimeStep.DecimalPlaces = 3;
            numTimeStep.Location = new Point(190, 55);
            numTimeStep.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numTimeStep.Minimum = new decimal(new int[] { 1, 0, 0, 196608 });
            numTimeStep.Name = "numTimeStep";
            numTimeStep.Size = new Size(60, 23);
            numTimeStep.TabIndex = 27;
            numTimeStep.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // comboNoiseType
            // 
            comboNoiseType.DrawMode = DrawMode.OwnerDrawVariable;
            comboNoiseType.FormattingEnabled = true;
            comboNoiseType.Items.AddRange(new object[] { "Random", "Bit Sized Packets", "Random Sized Packets" });
            comboNoiseType.Location = new Point(30, 439);
            comboNoiseType.Name = "comboNoiseType";
            comboNoiseType.Size = new Size(220, 24);
            comboNoiseType.TabIndex = 26;
            // 
            // lblNoiseType
            // 
            lblNoiseType.AutoSize = true;
            lblNoiseType.ForeColor = Color.FromArgb(220, 220, 220);
            lblNoiseType.Location = new Point(31, 416);
            lblNoiseType.Name = "lblNoiseType";
            lblNoiseType.Size = new Size(67, 15);
            lblNoiseType.TabIndex = 25;
            lblNoiseType.Text = "Noise Type:";
            // 
            // lblTimeStart
            // 
            lblTimeStart.AutoSize = true;
            lblTimeStart.ForeColor = Color.FromArgb(220, 220, 220);
            lblTimeStart.Location = new Point(30, 37);
            lblTimeStart.Name = "lblTimeStart";
            lblTimeStart.Size = new Size(34, 15);
            lblTimeStart.TabIndex = 23;
            lblTimeStart.Text = "Start:";
            // 
            // lblTimeEnd
            // 
            lblTimeEnd.AutoSize = true;
            lblTimeEnd.ForeColor = Color.FromArgb(220, 220, 220);
            lblTimeEnd.Location = new Point(116, 37);
            lblTimeEnd.Name = "lblTimeEnd";
            lblTimeEnd.Size = new Size(30, 15);
            lblTimeEnd.TabIndex = 22;
            lblTimeEnd.Text = "End:";
            // 
            // btnExport
            // 
            btnExport.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnExport.BackColor = Color.Transparent;
            btnExport.BaseColor = Color.FromArgb(74, 110, 174);
            btnExport.Font = new Font("Segoe UI", 12F);
            btnExport.Location = new Point(30, 771);
            btnExport.Name = "btnExport";
            btnExport.Rounded = false;
            btnExport.Size = new Size(107, 54);
            btnExport.TabIndex = 21;
            btnExport.Text = "Export CSV";
            btnExport.TextColor = Color.FromArgb(243, 243, 243);
            btnExport.Click += BtnExport_Click;
            // 
            // btnLoad
            // 
            btnLoad.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnLoad.BackColor = Color.Transparent;
            btnLoad.BaseColor = Color.FromArgb(35, 168, 109);
            btnLoad.Font = new Font("Segoe UI", 12F);
            btnLoad.Location = new Point(31, 711);
            btnLoad.Name = "btnLoad";
            btnLoad.Rounded = false;
            btnLoad.Size = new Size(107, 54);
            btnLoad.TabIndex = 20;
            btnLoad.Text = "Load CSV";
            btnLoad.TextColor = Color.FromArgb(243, 243, 243);
            btnLoad.Click += BtnLoad_Click;
            // 
            // txtAlphabet
            // 
            txtAlphabet.BackColor = Color.FromArgb(69, 73, 74);
            txtAlphabet.BorderStyle = BorderStyle.FixedSingle;
            txtAlphabet.ForeColor = Color.FromArgb(220, 220, 220);
            txtAlphabet.Location = new Point(30, 289);
            txtAlphabet.Multiline = true;
            txtAlphabet.Name = "txtAlphabet";
            txtAlphabet.Size = new Size(220, 71);
            txtAlphabet.TabIndex = 19;
            txtAlphabet.Text = "eatonsirldhmkvápcgéubzyjEfAwTONúSIRíLýDHMKVőčöžÁóPCüšGÉUBZYťJľFWôÚxÍÝűqŐČÖŽÓÜŠďňŤĽÔXäŰQĎŕŇÄŔ!@#$%^&*()-=_+[]\\{}|;':\",./<>?~";
            // 
            // lblTimeStep
            // 
            lblTimeStep.AutoSize = true;
            lblTimeStep.ForeColor = Color.FromArgb(220, 220, 220);
            lblTimeStep.Location = new Point(190, 37);
            lblTimeStep.Name = "lblTimeStep";
            lblTimeStep.Size = new Size(33, 15);
            lblTimeStep.TabIndex = 17;
            lblTimeStep.Text = "Step:";
            // 
            // numTimeEnd
            // 
            numTimeEnd.Location = new Point(116, 55);
            numTimeEnd.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            numTimeEnd.Name = "numTimeEnd";
            numTimeEnd.Size = new Size(68, 23);
            numTimeEnd.TabIndex = 16;
            numTimeEnd.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // numTimeStart
            // 
            numTimeStart.Location = new Point(30, 55);
            numTimeStart.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numTimeStart.Name = "numTimeStart";
            numTimeStart.Size = new Size(80, 23);
            numTimeStart.TabIndex = 15;
            numTimeStart.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnRun
            // 
            btnRun.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnRun.BackColor = Color.Transparent;
            btnRun.BaseColor = Color.FromArgb(42, 42, 42);
            btnRun.Font = new Font("Segoe UI", 12F);
            btnRun.Location = new Point(31, 630);
            btnRun.Name = "btnRun";
            btnRun.Rounded = false;
            btnRun.Size = new Size(220, 75);
            btnRun.TabIndex = 14;
            btnRun.Text = "Run";
            btnRun.TextColor = Color.FromArgb(243, 243, 243);
            btnRun.Click += BtnRun_Click;
            // 
            // lblSimSignalTime
            // 
            lblSimSignalTime.AutoSize = true;
            lblSimSignalTime.ForeColor = Color.FromArgb(220, 220, 220);
            lblSimSignalTime.Location = new Point(30, 12);
            lblSimSignalTime.Name = "lblSimSignalTime";
            lblSimSignalTime.Size = new Size(98, 15);
            lblSimSignalTime.TabIndex = 0;
            lblSimSignalTime.Text = "Signal Time (ms):";
            // 
            // txtTestCount
            // 
            txtTestCount.BackColor = Color.FromArgb(69, 73, 74);
            txtTestCount.BorderStyle = BorderStyle.FixedSingle;
            txtTestCount.ForeColor = Color.FromArgb(220, 220, 220);
            txtTestCount.Location = new Point(97, 385);
            txtTestCount.Name = "txtTestCount";
            txtTestCount.Size = new Size(77, 23);
            txtTestCount.TabIndex = 13;
            txtTestCount.Text = "10";
            // 
            // lblEncoding
            // 
            lblEncoding.AutoSize = true;
            lblEncoding.ForeColor = Color.FromArgb(220, 220, 220);
            lblEncoding.Location = new Point(30, 88);
            lblEncoding.Name = "lblEncoding";
            lblEncoding.Size = new Size(60, 15);
            lblEncoding.TabIndex = 1;
            lblEncoding.Text = "Encoding:";
            // 
            // lblTestCount
            // 
            lblTestCount.AutoSize = true;
            lblTestCount.ForeColor = Color.FromArgb(220, 220, 220);
            lblTestCount.Location = new Point(97, 366);
            lblTestCount.Name = "lblTestCount";
            lblTestCount.Size = new Size(66, 15);
            lblTestCount.TabIndex = 12;
            lblTestCount.Text = "Test Count:";
            // 
            // lblMessageSize
            // 
            lblMessageSize.AutoSize = true;
            lblMessageSize.ForeColor = Color.FromArgb(220, 220, 220);
            lblMessageSize.Location = new Point(30, 157);
            lblMessageSize.Name = "lblMessageSize";
            lblMessageSize.Size = new Size(144, 15);
            lblMessageSize.TabIndex = 2;
            lblMessageSize.Text = "Message Size (characters):";
            // 
            // lblSignalingType
            // 
            lblSignalingType.AutoSize = true;
            lblSignalingType.ForeColor = Color.FromArgb(220, 220, 220);
            lblSignalingType.Location = new Point(30, 470);
            lblSignalingType.Name = "lblSignalingType";
            lblSignalingType.Size = new Size(86, 15);
            lblSignalingType.TabIndex = 3;
            lblSignalingType.Text = "Signaling Type:";
            // 
            // numNoiseStep
            // 
            numNoiseStep.Location = new Point(179, 385);
            numNoiseStep.Name = "numNoiseStep";
            numNoiseStep.Size = new Size(72, 23);
            numNoiseStep.TabIndex = 10;
            numNoiseStep.Value = new decimal(new int[] { 50, 0, 0, 0 });
            // 
            // lblNoisePercent
            // 
            lblNoisePercent.AutoSize = true;
            lblNoisePercent.ForeColor = Color.FromArgb(220, 220, 220);
            lblNoisePercent.Location = new Point(179, 366);
            lblNoisePercent.Name = "lblNoisePercent";
            lblNoisePercent.Size = new Size(66, 15);
            lblNoisePercent.TabIndex = 4;
            lblNoisePercent.Text = "Noise Step:";
            // 
            // comboSignalingType
            // 
            comboSignalingType.DrawMode = DrawMode.OwnerDrawVariable;
            comboSignalingType.FormattingEnabled = true;
            comboSignalingType.Items.AddRange(new object[] { "Time Based", "UDP Fragmentation" });
            comboSignalingType.Location = new Point(30, 493);
            comboSignalingType.Name = "comboSignalingType";
            comboSignalingType.Size = new Size(220, 24);
            comboSignalingType.TabIndex = 9;
            // 
            // numMessageSize
            // 
            numMessageSize.Location = new Point(30, 182);
            numMessageSize.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numMessageSize.Name = "numMessageSize";
            numMessageSize.Size = new Size(220, 23);
            numMessageSize.TabIndex = 8;
            numMessageSize.ThousandsSeparator = true;
            numMessageSize.Value = new decimal(new int[] { 20, 0, 0, 0 });
            // 
            // pagedDataControl
            // 
            pagedDataControl.BackColor = Color.Transparent;
            pagedDataControl.CsvFilePath = null;
            pagedDataControl.Dock = DockStyle.Fill;
            pagedDataControl.Location = new Point(280, 0);
            pagedDataControl.Name = "pagedDataControl";
            pagedDataControl.PageSize = 30;
            pagedDataControl.Size = new Size(779, 831);
            pagedDataControl.TabIndex = 16;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog";
            // 
            // SimulationPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 47, 49);
            Controls.Add(pagedDataControl);
            Controls.Add(pnlSidebar);
            Name = "SimulationPage";
            Size = new Size(1059, 831);
            pnlSidebar.ResumeLayout(false);
            pnlSidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numThreads).EndInit();
            ((System.ComponentModel.ISupportInitialize)numTimeStep).EndInit();
            ((System.ComponentModel.ISupportInitialize)numTimeEnd).EndInit();
            ((System.ComponentModel.ISupportInitialize)numTimeStart).EndInit();
            ((System.ComponentModel.ISupportInitialize)numNoiseStep).EndInit();
            ((System.ComponentModel.ISupportInitialize)numMessageSize).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSidebar;
        private ReaLTaiizor.Controls.ForeverButton btnRun;
        private ReaLTaiizor.Controls.CrownLabel lblSimSignalTime;
        private ReaLTaiizor.Controls.CrownTextBox txtTestCount;
        private ReaLTaiizor.Controls.CrownLabel lblEncoding;
        private ReaLTaiizor.Controls.CrownLabel lblTestCount;
        private ReaLTaiizor.Controls.CrownLabel lblMessageSize;
        private ReaLTaiizor.Controls.CrownLabel lblSignalingType;
        private ReaLTaiizor.Controls.CrownNumeric numNoiseStep;
        private ReaLTaiizor.Controls.CrownLabel lblNoisePercent;
        private ReaLTaiizor.Controls.CrownComboBox comboSignalingType;
        private ReaLTaiizor.Controls.CrownNumeric numMessageSize;
        private ReaLTaiizor.Controls.ForeverButton btnExport;
        private ReaLTaiizor.Controls.ForeverButton btnLoad;
        private ReaLTaiizor.Controls.CrownTextBox txtAlphabet;
        private ReaLTaiizor.Controls.CrownLabel lblTimeStep;
        private ReaLTaiizor.Controls.CrownNumeric numTimeEnd;
        private ReaLTaiizor.Controls.CrownNumeric numTimeStart;
        private ReaLTaiizor.Controls.CrownLabel lblTimeStart;
        private ReaLTaiizor.Controls.CrownLabel lblTimeEnd;
        private ReaLTaiizor.Controls.CrownComboBox comboNoiseType;
        private ReaLTaiizor.Controls.CrownLabel lblNoiseType;
        private ReaLTaiizor.Controls.CrownNumeric numTimeStep;
        private Common.PagedDataControl pagedDataControl;
        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
        private ReaLTaiizor.Controls.ForeverButton btnClear;
        private ReaLTaiizor.Controls.ForeverButton btnNew;
        private ReaLTaiizor.Controls.ForeverButton btnCancel;
        private ReaLTaiizor.Controls.CrownLabel lblElapsed;
        private ReaLTaiizor.Controls.CrownLabel lblAlphabet;
        private ReaLTaiizor.Controls.CrownCheckBox checkSignallingAll;
        private ReaLTaiizor.Controls.CrownCheckBox checkNoiseAll;
        private ReaLTaiizor.Controls.CrownLabel lblThreads;
        private ReaLTaiizor.Controls.CrownNumeric numThreads;
        private ReaLTaiizor.Controls.CrownCheckBox checkAdvancedMorse;
        private ReaLTaiizor.Controls.CrownCheckBox checkSimpleMorse;
        private ReaLTaiizor.Controls.CrownCheckBox checkECC;
        private ReaLTaiizor.Controls.CrownCheckBox checkBinary;
        private ReaLTaiizor.Controls.CrownCheckBox checkSpecial;
        private ReaLTaiizor.Controls.CrownCheckBox checkHungarian;
        private ReaLTaiizor.Controls.CrownCheckBox checkSlovak;
        private ReaLTaiizor.Controls.CrownCheckBox checkEnglish;
        private ReaLTaiizor.Controls.CrownCheckBox checkLower;
    }
}
