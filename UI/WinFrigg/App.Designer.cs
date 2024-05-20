using WinFrigg.Components;

namespace WinFrigg
{
    partial class App
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(App));
            pnlSideBar = new FlowLayoutPanel();
            pnlSDRDevice = new ReaLTaiizor.Controls.CrownSectionPanel();
            comboSDRDevices = new ReaLTaiizor.Controls.CrownComboBox();
            btnSDRRefresh = new ReaLTaiizor.Controls.LostButton();
            lblSDRDevices = new ReaLTaiizor.Controls.ForeverLabel();
            pnlWiFiDevice = new ReaLTaiizor.Controls.CrownSectionPanel();
            comboWiFiDevices = new ReaLTaiizor.Controls.CrownComboBox();
            lblWiFiDevices = new ReaLTaiizor.Controls.ForeverLabel();
            pnlChannelPreset = new ReaLTaiizor.Controls.CrownSectionPanel();
            comboChannelPresets = new ReaLTaiizor.Controls.CrownComboBox();
            pnlSDRSettings = new ReaLTaiizor.Controls.CrownSectionPanel();
            lblSDRSamplingRate = new ReaLTaiizor.Controls.ForeverLabel();
            comboSDRSamplingRate = new ReaLTaiizor.Controls.CrownComboBox();
            numSDRVGAGain = new ReaLTaiizor.Controls.CrownNumeric();
            lblSDRVGAGain = new ReaLTaiizor.Controls.ForeverLabel();
            numSDRLNAGain = new ReaLTaiizor.Controls.CrownNumeric();
            lblSDRLNAGain = new ReaLTaiizor.Controls.ForeverLabel();
            numSDRFilterBandwith = new ReaLTaiizor.Controls.CrownNumeric();
            lblSDRFilterBandwith = new ReaLTaiizor.Controls.ForeverLabel();
            lblSDRConnection = new ReaLTaiizor.Controls.ForeverLabel();
            toggleSDRConnection = new ReaLTaiizor.Controls.ForeverToggle();
            numSDRFrequency = new ReaLTaiizor.Controls.CrownNumeric();
            lblSDRFrequency = new ReaLTaiizor.Controls.ForeverLabel();
            pnlToolBar = new Panel();
            btnLoadStateFromFile = new ReaLTaiizor.Controls.ForeverButton();
            btnSaveStateAs = new ReaLTaiizor.Controls.ForeverButton();
            btnInfo = new ReaLTaiizor.Controls.ForeverButton();
            btnLoadState = new ReaLTaiizor.Controls.ForeverButton();
            btnSaveState = new ReaLTaiizor.Controls.ForeverButton();
            customWindowHeaderControl = new CustomWindowHeaderControl();
            timerCaptureStatus = new System.Windows.Forms.Timer(components);
            tabCapture = new TabPage();
            spectrogramFileListControl1 = new Components.Common.SpectrogramFileListControl();
            pnlCaptureToggle = new Panel();
            toggleCapture = new ReaLTaiizor.Controls.ForeverToggle();
            lblCaptureProgress = new ReaLTaiizor.Controls.ForeverLabel();
            lblCapture = new ReaLTaiizor.Controls.ForeverLabel();
            pnlCaptureSpectrogram = new Panel();
            checkBoxCaptureDisplaySpectrogram = new ReaLTaiizor.Controls.CrownCheckBox();
            btnLoad = new ReaLTaiizor.Controls.ForeverButton();
            btnCaptureSave = new ReaLTaiizor.Controls.ForeverButton();
            tabPageTransmit = new TabPage();
            tabControlTransmit = new ReaLTaiizor.Controls.HopeTabPage();
            tabPageTransmitUDP = new TabPage();
            txtTransmitUDPMessage = new ReaLTaiizor.Controls.CrownTextBox();
            lblTransmitUDPMessage = new ReaLTaiizor.Controls.CrownLabel();
            comboTransmitUDPEncoding = new ReaLTaiizor.Controls.CrownComboBox();
            btnTransmitUDP = new ReaLTaiizor.Controls.ForeverButton();
            lblTransmitUDPEncoding = new ReaLTaiizor.Controls.CrownLabel();
            checkTransmitRecord = new ReaLTaiizor.Controls.CrownCheckBox();
            tabPageTransmitSDR = new TabPage();
            lblTransmitSDRSignalTime = new ReaLTaiizor.Controls.CrownLabel();
            sliderTransmitSDRSignalTime = new ReaLTaiizor.Controls.ParrotSlider();
            txtTransmitSDRMessage = new ReaLTaiizor.Controls.CrownTextBox();
            lblTransmitSDRMessage = new ReaLTaiizor.Controls.CrownLabel();
            comboTransmitSDREncoding = new ReaLTaiizor.Controls.CrownComboBox();
            lblTransmitSDREncoding = new ReaLTaiizor.Controls.CrownLabel();
            btnTransmitSDRFile = new ReaLTaiizor.Controls.ForeverButton();
            btnTransmitSDR = new ReaLTaiizor.Controls.ForeverButton();
            tabPageSimulation = new TabPage();
            simulationPage = new Components.Pages.Simulation.SimulationPage();
            tabPageTesting = new TabPage();
            stepsPanelControl = new StepsPanelControl();
            tabControlApp = new ReaLTaiizor.Controls.HopeTabPage();
            pnlSideBar.SuspendLayout();
            pnlSDRDevice.SuspendLayout();
            pnlWiFiDevice.SuspendLayout();
            pnlChannelPreset.SuspendLayout();
            pnlSDRSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numSDRVGAGain).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSDRLNAGain).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSDRFilterBandwith).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSDRFrequency).BeginInit();
            pnlToolBar.SuspendLayout();
            tabCapture.SuspendLayout();
            pnlCaptureToggle.SuspendLayout();
            tabPageTransmit.SuspendLayout();
            tabControlTransmit.SuspendLayout();
            tabPageTransmitUDP.SuspendLayout();
            tabPageTransmitSDR.SuspendLayout();
            tabPageSimulation.SuspendLayout();
            tabPageTesting.SuspendLayout();
            tabControlApp.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSideBar
            // 
            pnlSideBar.BackColor = Color.FromArgb(69, 69, 69);
            pnlSideBar.Controls.Add(pnlSDRDevice);
            pnlSideBar.Controls.Add(pnlWiFiDevice);
            pnlSideBar.Controls.Add(pnlChannelPreset);
            pnlSideBar.Controls.Add(pnlSDRSettings);
            pnlSideBar.Dock = DockStyle.Left;
            pnlSideBar.FlowDirection = FlowDirection.TopDown;
            pnlSideBar.Location = new Point(0, 117);
            pnlSideBar.Name = "pnlSideBar";
            pnlSideBar.Size = new Size(350, 728);
            pnlSideBar.TabIndex = 3;
            // 
            // pnlSDRDevice
            // 
            pnlSDRDevice.BackColor = Color.FromArgb(69, 69, 69);
            pnlSDRDevice.Controls.Add(comboSDRDevices);
            pnlSDRDevice.Controls.Add(btnSDRRefresh);
            pnlSDRDevice.Controls.Add(lblSDRDevices);
            pnlSDRDevice.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            pnlSDRDevice.Location = new Point(3, 3);
            pnlSDRDevice.Name = "pnlSDRDevice";
            pnlSDRDevice.SectionHeader = "SDR Device";
            pnlSDRDevice.Size = new Size(341, 100);
            pnlSDRDevice.TabIndex = 0;
            // 
            // comboSDRDevices
            // 
            comboSDRDevices.DrawMode = DrawMode.OwnerDrawVariable;
            comboSDRDevices.FormattingEnabled = true;
            comboSDRDevices.Location = new Point(10, 57);
            comboSDRDevices.Name = "comboSDRDevices";
            comboSDRDevices.Size = new Size(322, 28);
            comboSDRDevices.TabIndex = 3;
            // 
            // btnSDRRefresh
            // 
            btnSDRRefresh.BackColor = Color.FromArgb(45, 45, 48);
            btnSDRRefresh.Font = new Font("Segoe UI", 7.8F);
            btnSDRRefresh.ForeColor = Color.White;
            btnSDRRefresh.HoverColor = Color.DodgerBlue;
            btnSDRRefresh.Image = null;
            btnSDRRefresh.Location = new Point(268, 31);
            btnSDRRefresh.Name = "btnSDRRefresh";
            btnSDRRefresh.Size = new Size(64, 23);
            btnSDRRefresh.TabIndex = 2;
            btnSDRRefresh.Text = "Refresh";
            btnSDRRefresh.Click += BtnSDRRefresh_Click;
            // 
            // lblSDRDevices
            // 
            lblSDRDevices.AutoSize = true;
            lblSDRDevices.BackColor = Color.Transparent;
            lblSDRDevices.Font = new Font("Segoe UI", 8F);
            lblSDRDevices.ForeColor = Color.LightGray;
            lblSDRDevices.Location = new Point(8, 35);
            lblSDRDevices.Name = "lblSDRDevices";
            lblSDRDevices.Size = new Size(97, 13);
            lblSDRDevices.TabIndex = 1;
            lblSDRDevices.Text = "Available Devices:";
            // 
            // pnlWiFiDevice
            // 
            pnlWiFiDevice.Controls.Add(comboWiFiDevices);
            pnlWiFiDevice.Controls.Add(lblWiFiDevices);
            pnlWiFiDevice.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            pnlWiFiDevice.Location = new Point(3, 109);
            pnlWiFiDevice.Name = "pnlWiFiDevice";
            pnlWiFiDevice.SectionHeader = "WiFi Interface";
            pnlWiFiDevice.Size = new Size(341, 100);
            pnlWiFiDevice.TabIndex = 1;
            // 
            // comboWiFiDevices
            // 
            comboWiFiDevices.DrawMode = DrawMode.OwnerDrawVariable;
            comboWiFiDevices.FormattingEnabled = true;
            comboWiFiDevices.Location = new Point(9, 57);
            comboWiFiDevices.Name = "comboWiFiDevices";
            comboWiFiDevices.Size = new Size(323, 28);
            comboWiFiDevices.TabIndex = 4;
            // 
            // lblWiFiDevices
            // 
            lblWiFiDevices.AutoSize = true;
            lblWiFiDevices.BackColor = Color.Transparent;
            lblWiFiDevices.Font = new Font("Segoe UI", 8F);
            lblWiFiDevices.ForeColor = Color.LightGray;
            lblWiFiDevices.Location = new Point(7, 35);
            lblWiFiDevices.Name = "lblWiFiDevices";
            lblWiFiDevices.Size = new Size(97, 13);
            lblWiFiDevices.TabIndex = 3;
            lblWiFiDevices.Text = "Available Devices:";
            // 
            // pnlChannelPreset
            // 
            pnlChannelPreset.Controls.Add(comboChannelPresets);
            pnlChannelPreset.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            pnlChannelPreset.Location = new Point(3, 215);
            pnlChannelPreset.Name = "pnlChannelPreset";
            pnlChannelPreset.SectionHeader = "Channel Preset";
            pnlChannelPreset.Size = new Size(341, 81);
            pnlChannelPreset.TabIndex = 4;
            // 
            // comboChannelPresets
            // 
            comboChannelPresets.DrawMode = DrawMode.OwnerDrawVariable;
            comboChannelPresets.FormattingEnabled = true;
            comboChannelPresets.Location = new Point(10, 36);
            comboChannelPresets.Name = "comboChannelPresets";
            comboChannelPresets.Size = new Size(322, 28);
            comboChannelPresets.TabIndex = 5;
            comboChannelPresets.SelectedIndexChanged += ComboChannelPresets_SelectedIndexChanged;
            // 
            // pnlSDRSettings
            // 
            pnlSDRSettings.Controls.Add(lblSDRSamplingRate);
            pnlSDRSettings.Controls.Add(comboSDRSamplingRate);
            pnlSDRSettings.Controls.Add(numSDRVGAGain);
            pnlSDRSettings.Controls.Add(lblSDRVGAGain);
            pnlSDRSettings.Controls.Add(numSDRLNAGain);
            pnlSDRSettings.Controls.Add(lblSDRLNAGain);
            pnlSDRSettings.Controls.Add(numSDRFilterBandwith);
            pnlSDRSettings.Controls.Add(lblSDRFilterBandwith);
            pnlSDRSettings.Controls.Add(lblSDRConnection);
            pnlSDRSettings.Controls.Add(toggleSDRConnection);
            pnlSDRSettings.Controls.Add(numSDRFrequency);
            pnlSDRSettings.Controls.Add(lblSDRFrequency);
            pnlSDRSettings.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            pnlSDRSettings.Location = new Point(3, 302);
            pnlSDRSettings.Name = "pnlSDRSettings";
            pnlSDRSettings.SectionHeader = "SDR Settings";
            pnlSDRSettings.Size = new Size(341, 281);
            pnlSDRSettings.TabIndex = 2;
            // 
            // lblSDRSamplingRate
            // 
            lblSDRSamplingRate.AutoSize = true;
            lblSDRSamplingRate.BackColor = Color.Transparent;
            lblSDRSamplingRate.Font = new Font("Segoe UI", 8F);
            lblSDRSamplingRate.ForeColor = Color.LightGray;
            lblSDRSamplingRate.Location = new Point(10, 233);
            lblSDRSamplingRate.Name = "lblSDRSamplingRate";
            lblSDRSamplingRate.Size = new Size(113, 13);
            lblSDRSamplingRate.TabIndex = 13;
            lblSDRSamplingRate.Text = "Sampling Rate (MHz)";
            // 
            // comboSDRSamplingRate
            // 
            comboSDRSamplingRate.DrawMode = DrawMode.OwnerDrawVariable;
            comboSDRSamplingRate.FormattingEnabled = true;
            comboSDRSamplingRate.Items.AddRange(new object[] { "1", "2", "4", "8", "16", "22", "0.25", "0.5" });
            comboSDRSamplingRate.Location = new Point(182, 226);
            comboSDRSamplingRate.Name = "comboSDRSamplingRate";
            comboSDRSamplingRate.Size = new Size(150, 28);
            comboSDRSamplingRate.TabIndex = 12;
            comboSDRSamplingRate.SelectedIndexChanged += ComboSDRSamplingRate_SelectedIndexChanged;
            // 
            // numSDRVGAGain
            // 
            numSDRVGAGain.BorderStyle = BorderStyle.FixedSingle;
            numSDRVGAGain.Increment = new decimal(new int[] { 2, 0, 0, 0 });
            numSDRVGAGain.Location = new Point(182, 193);
            numSDRVGAGain.Maximum = new decimal(new int[] { 60, 0, 0, 0 });
            numSDRVGAGain.Name = "numSDRVGAGain";
            numSDRVGAGain.ReadOnly = true;
            numSDRVGAGain.Size = new Size(150, 27);
            numSDRVGAGain.TabIndex = 11;
            numSDRVGAGain.ThousandsSeparator = true;
            numSDRVGAGain.ValueChanged += NumSDRVGAGain_ValueChanged;
            // 
            // lblSDRVGAGain
            // 
            lblSDRVGAGain.AutoSize = true;
            lblSDRVGAGain.BackColor = Color.Transparent;
            lblSDRVGAGain.Font = new Font("Segoe UI", 8F);
            lblSDRVGAGain.ForeColor = Color.LightGray;
            lblSDRVGAGain.Location = new Point(10, 199);
            lblSDRVGAGain.Name = "lblSDRVGAGain";
            lblSDRVGAGain.Size = new Size(95, 13);
            lblSDRVGAGain.TabIndex = 10;
            lblSDRVGAGain.Text = "RX VGA Gain (db)";
            // 
            // numSDRLNAGain
            // 
            numSDRLNAGain.BorderStyle = BorderStyle.FixedSingle;
            numSDRLNAGain.Increment = new decimal(new int[] { 8, 0, 0, 0 });
            numSDRLNAGain.Location = new Point(182, 160);
            numSDRLNAGain.Maximum = new decimal(new int[] { 40, 0, 0, 0 });
            numSDRLNAGain.Name = "numSDRLNAGain";
            numSDRLNAGain.ReadOnly = true;
            numSDRLNAGain.Size = new Size(150, 27);
            numSDRLNAGain.TabIndex = 9;
            numSDRLNAGain.ThousandsSeparator = true;
            numSDRLNAGain.ValueChanged += NumSDRLNAGain_ValueChanged;
            // 
            // lblSDRLNAGain
            // 
            lblSDRLNAGain.AutoSize = true;
            lblSDRLNAGain.BackColor = Color.Transparent;
            lblSDRLNAGain.Font = new Font("Segoe UI", 8F);
            lblSDRLNAGain.ForeColor = Color.LightGray;
            lblSDRLNAGain.Location = new Point(10, 166);
            lblSDRLNAGain.Name = "lblSDRLNAGain";
            lblSDRLNAGain.Size = new Size(93, 13);
            lblSDRLNAGain.TabIndex = 8;
            lblSDRLNAGain.Text = "RX LNA Gain (db)";
            // 
            // numSDRFilterBandwith
            // 
            numSDRFilterBandwith.BorderStyle = BorderStyle.FixedSingle;
            numSDRFilterBandwith.DecimalPlaces = 1;
            numSDRFilterBandwith.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            numSDRFilterBandwith.Location = new Point(182, 127);
            numSDRFilterBandwith.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            numSDRFilterBandwith.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numSDRFilterBandwith.Name = "numSDRFilterBandwith";
            numSDRFilterBandwith.Size = new Size(150, 27);
            numSDRFilterBandwith.TabIndex = 7;
            numSDRFilterBandwith.ThousandsSeparator = true;
            numSDRFilterBandwith.Value = new decimal(new int[] { 2, 0, 0, 0 });
            numSDRFilterBandwith.ValueChanged += NumSDRFilterBandwith_ValueChanged;
            // 
            // lblSDRFilterBandwith
            // 
            lblSDRFilterBandwith.AutoSize = true;
            lblSDRFilterBandwith.BackColor = Color.Transparent;
            lblSDRFilterBandwith.Font = new Font("Segoe UI", 8F);
            lblSDRFilterBandwith.ForeColor = Color.LightGray;
            lblSDRFilterBandwith.Location = new Point(10, 133);
            lblSDRFilterBandwith.Name = "lblSDRFilterBandwith";
            lblSDRFilterBandwith.Size = new Size(117, 13);
            lblSDRFilterBandwith.TabIndex = 6;
            lblSDRFilterBandwith.Text = "Filter Bandwith(MHz):";
            // 
            // lblSDRConnection
            // 
            lblSDRConnection.AutoSize = true;
            lblSDRConnection.BackColor = Color.Transparent;
            lblSDRConnection.Font = new Font("Segoe UI", 8F);
            lblSDRConnection.ForeColor = Color.LightGray;
            lblSDRConnection.Location = new Point(10, 54);
            lblSDRConnection.Name = "lblSDRConnection";
            lblSDRConnection.Size = new Size(70, 13);
            lblSDRConnection.TabIndex = 5;
            lblSDRConnection.Text = "Connection:";
            // 
            // toggleSDRConnection
            // 
            toggleSDRConnection.BackColor = Color.Transparent;
            toggleSDRConnection.BaseColor = Color.FromArgb(35, 168, 109);
            toggleSDRConnection.BaseColorRed = Color.FromArgb(220, 85, 96);
            toggleSDRConnection.BGColor = Color.FromArgb(84, 85, 86);
            toggleSDRConnection.Checked = false;
            toggleSDRConnection.Font = new Font("Segoe UI", 10F);
            toggleSDRConnection.Location = new Point(182, 49);
            toggleSDRConnection.Name = "toggleSDRConnection";
            toggleSDRConnection.Options = ReaLTaiizor.Controls.ForeverToggle._Options.Style3;
            toggleSDRConnection.Size = new Size(76, 33);
            toggleSDRConnection.TabIndex = 4;
            toggleSDRConnection.TextColor = Color.FromArgb(243, 243, 243);
            toggleSDRConnection.ToggleColor = Color.FromArgb(42, 42, 42);
            toggleSDRConnection.CheckedChanged += ToggleSDRConnection_CheckedChanged;
            // 
            // numSDRFrequency
            // 
            numSDRFrequency.BorderStyle = BorderStyle.FixedSingle;
            numSDRFrequency.DecimalPlaces = 1;
            numSDRFrequency.Location = new Point(182, 94);
            numSDRFrequency.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            numSDRFrequency.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
            numSDRFrequency.Name = "numSDRFrequency";
            numSDRFrequency.Size = new Size(150, 27);
            numSDRFrequency.TabIndex = 3;
            numSDRFrequency.ThousandsSeparator = true;
            numSDRFrequency.Value = new decimal(new int[] { 2440, 0, 0, 0 });
            numSDRFrequency.ValueChanged += NumSDRFrequency_ValueChanged;
            // 
            // lblSDRFrequency
            // 
            lblSDRFrequency.AutoSize = true;
            lblSDRFrequency.BackColor = Color.Transparent;
            lblSDRFrequency.Font = new Font("Segoe UI", 8F);
            lblSDRFrequency.ForeColor = Color.LightGray;
            lblSDRFrequency.Location = new Point(10, 100);
            lblSDRFrequency.Name = "lblSDRFrequency";
            lblSDRFrequency.Size = new Size(92, 13);
            lblSDRFrequency.TabIndex = 2;
            lblSDRFrequency.Text = "Frequency(MHz):";
            // 
            // pnlToolBar
            // 
            pnlToolBar.BackColor = Color.FromArgb(45, 47, 49);
            pnlToolBar.Controls.Add(btnLoadStateFromFile);
            pnlToolBar.Controls.Add(btnSaveStateAs);
            pnlToolBar.Controls.Add(btnInfo);
            pnlToolBar.Controls.Add(btnLoadState);
            pnlToolBar.Controls.Add(btnSaveState);
            pnlToolBar.Dock = DockStyle.Top;
            pnlToolBar.Location = new Point(0, 30);
            pnlToolBar.Name = "pnlToolBar";
            pnlToolBar.Size = new Size(1450, 87);
            pnlToolBar.TabIndex = 4;
            // 
            // btnLoadStateFromFile
            // 
            btnLoadStateFromFile.BackColor = Color.Transparent;
            btnLoadStateFromFile.BaseColor = Color.FromArgb(69, 69, 69);
            btnLoadStateFromFile.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLoadStateFromFile.Location = new Point(233, 9);
            btnLoadStateFromFile.Name = "btnLoadStateFromFile";
            btnLoadStateFromFile.Rounded = false;
            btnLoadStateFromFile.Size = new Size(69, 69);
            btnLoadStateFromFile.TabIndex = 7;
            btnLoadStateFromFile.Text = "Load State From File";
            btnLoadStateFromFile.TextColor = Color.FromArgb(243, 243, 243);
            btnLoadStateFromFile.Click += BtnLoadStateFromFile_Click;
            // 
            // btnSaveStateAs
            // 
            btnSaveStateAs.BackColor = Color.Transparent;
            btnSaveStateAs.BaseColor = Color.FromArgb(69, 69, 69);
            btnSaveStateAs.Font = new Font("Segoe UI", 12F);
            btnSaveStateAs.Location = new Point(82, 9);
            btnSaveStateAs.Name = "btnSaveStateAs";
            btnSaveStateAs.Rounded = false;
            btnSaveStateAs.Size = new Size(69, 69);
            btnSaveStateAs.TabIndex = 6;
            btnSaveStateAs.Text = "Save State As";
            btnSaveStateAs.TextColor = Color.FromArgb(243, 243, 243);
            btnSaveStateAs.Click += BtnSaveStateAs_Click;
            // 
            // btnInfo
            // 
            btnInfo.BackColor = Color.Transparent;
            btnInfo.BaseColor = Color.FromArgb(69, 69, 69);
            btnInfo.Font = new Font("Segoe UI", 12F);
            btnInfo.Location = new Point(308, 9);
            btnInfo.Name = "btnInfo";
            btnInfo.Rounded = false;
            btnInfo.Size = new Size(69, 69);
            btnInfo.TabIndex = 4;
            btnInfo.Text = "Info";
            btnInfo.TextColor = Color.FromArgb(243, 243, 243);
            btnInfo.Click += BtnInfo_Click;
            // 
            // btnLoadState
            // 
            btnLoadState.BackColor = Color.Transparent;
            btnLoadState.BaseColor = Color.FromArgb(69, 69, 69);
            btnLoadState.Font = new Font("Segoe UI", 12F);
            btnLoadState.Location = new Point(158, 9);
            btnLoadState.Name = "btnLoadState";
            btnLoadState.Rounded = false;
            btnLoadState.Size = new Size(69, 69);
            btnLoadState.TabIndex = 3;
            btnLoadState.Text = "Load State";
            btnLoadState.TextColor = Color.FromArgb(243, 243, 243);
            btnLoadState.Click += BtnLoadState_Click;
            // 
            // btnSaveState
            // 
            btnSaveState.BackColor = Color.Transparent;
            btnSaveState.BaseColor = Color.FromArgb(69, 69, 69);
            btnSaveState.Font = new Font("Segoe UI", 12F);
            btnSaveState.Location = new Point(7, 9);
            btnSaveState.Name = "btnSaveState";
            btnSaveState.Rounded = false;
            btnSaveState.Size = new Size(69, 69);
            btnSaveState.TabIndex = 2;
            btnSaveState.Text = "Save State";
            btnSaveState.TextColor = Color.FromArgb(243, 243, 243);
            btnSaveState.Click += BtnSaveState_Click;
            // 
            // customWindowHeaderControl
            // 
            customWindowHeaderControl.Dock = DockStyle.Top;
            customWindowHeaderControl.Location = new Point(0, 0);
            customWindowHeaderControl.Margin = new Padding(3, 2, 3, 2);
            customWindowHeaderControl.Name = "customWindowHeaderControl";
            customWindowHeaderControl.Size = new Size(1450, 30);
            customWindowHeaderControl.TabIndex = 0;
            // 
            // timerCaptureStatus
            // 
            timerCaptureStatus.Tick += TimerCaptureStatus_Tick;
            // 
            // tabCapture
            // 
            tabCapture.BackColor = Color.FromArgb(45, 47, 49);
            tabCapture.Controls.Add(spectrogramFileListControl1);
            tabCapture.Controls.Add(pnlCaptureToggle);
            tabCapture.Controls.Add(pnlCaptureSpectrogram);
            tabCapture.Controls.Add(checkBoxCaptureDisplaySpectrogram);
            tabCapture.Controls.Add(btnLoad);
            tabCapture.Controls.Add(btnCaptureSave);
            tabCapture.Location = new Point(0, 40);
            tabCapture.Margin = new Padding(0);
            tabCapture.Name = "tabCapture";
            tabCapture.Size = new Size(1100, 688);
            tabCapture.TabIndex = 5;
            tabCapture.Text = "Capture";
            // 
            // spectrogramFileListControl1
            // 
            spectrogramFileListControl1.BackColor = Color.Transparent;
            spectrogramFileListControl1.Dock = DockStyle.Right;
            spectrogramFileListControl1.Location = new Point(626, 0);
            spectrogramFileListControl1.Margin = new Padding(3, 4, 3, 4);
            spectrogramFileListControl1.Name = "spectrogramFileListControl1";
            spectrogramFileListControl1.Size = new Size(474, 0);
            spectrogramFileListControl1.TabIndex = 14;
            // 
            // pnlCaptureToggle
            // 
            pnlCaptureToggle.Controls.Add(toggleCapture);
            pnlCaptureToggle.Controls.Add(lblCaptureProgress);
            pnlCaptureToggle.Controls.Add(lblCapture);
            pnlCaptureToggle.Location = new Point(20, 20);
            pnlCaptureToggle.Name = "pnlCaptureToggle";
            pnlCaptureToggle.Size = new Size(125, 125);
            pnlCaptureToggle.TabIndex = 13;
            // 
            // toggleCapture
            // 
            toggleCapture.BackColor = Color.Transparent;
            toggleCapture.BaseColor = Color.FromArgb(35, 168, 109);
            toggleCapture.BaseColorRed = Color.FromArgb(220, 85, 96);
            toggleCapture.BGColor = Color.FromArgb(84, 85, 86);
            toggleCapture.Checked = false;
            toggleCapture.Font = new Font("Segoe UI", 10F);
            toggleCapture.Location = new Point(24, 43);
            toggleCapture.Name = "toggleCapture";
            toggleCapture.Options = ReaLTaiizor.Controls.ForeverToggle._Options.Style1;
            toggleCapture.Size = new Size(76, 33);
            toggleCapture.TabIndex = 4;
            toggleCapture.Text = "foreverToggle1";
            toggleCapture.TextColor = Color.FromArgb(243, 243, 243);
            toggleCapture.ToggleColor = Color.FromArgb(45, 47, 49);
            toggleCapture.CheckedChanged += ToggleCapture_CheckedChanged;
            // 
            // lblCaptureProgress
            // 
            lblCaptureProgress.BackColor = Color.Transparent;
            lblCaptureProgress.Font = new Font("Segoe UI", 8F);
            lblCaptureProgress.ForeColor = Color.LightGray;
            lblCaptureProgress.Location = new Point(0, 92);
            lblCaptureProgress.Name = "lblCaptureProgress";
            lblCaptureProgress.Size = new Size(125, 33);
            lblCaptureProgress.TabIndex = 12;
            lblCaptureProgress.Text = "Time: 00:00:00.000\r\nSize: 0B\r\n";
            lblCaptureProgress.TextAlign = ContentAlignment.MiddleCenter;
            lblCaptureProgress.Visible = false;
            // 
            // lblCapture
            // 
            lblCapture.BackColor = Color.Transparent;
            lblCapture.Font = new Font("Segoe UI", 8F);
            lblCapture.ForeColor = Color.LightGray;
            lblCapture.Location = new Point(24, 10);
            lblCapture.Name = "lblCapture";
            lblCapture.Size = new Size(76, 22);
            lblCapture.TabIndex = 5;
            lblCapture.Text = "Capture";
            lblCapture.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlCaptureSpectrogram
            // 
            pnlCaptureSpectrogram.Dock = DockStyle.Bottom;
            pnlCaptureSpectrogram.Location = new Point(0, -1);
            pnlCaptureSpectrogram.Name = "pnlCaptureSpectrogram";
            pnlCaptureSpectrogram.Size = new Size(1100, 689);
            pnlCaptureSpectrogram.TabIndex = 11;
            pnlCaptureSpectrogram.Visible = false;
            // 
            // checkBoxCaptureDisplaySpectrogram
            // 
            checkBoxCaptureDisplaySpectrogram.AutoSize = true;
            checkBoxCaptureDisplaySpectrogram.Location = new Point(482, 20);
            checkBoxCaptureDisplaySpectrogram.Name = "checkBoxCaptureDisplaySpectrogram";
            checkBoxCaptureDisplaySpectrogram.Size = new Size(188, 25);
            checkBoxCaptureDisplaySpectrogram.TabIndex = 7;
            checkBoxCaptureDisplaySpectrogram.Text = "Display Spectrogram";
            checkBoxCaptureDisplaySpectrogram.CheckedChanged += CheckBoxCaptureDisplaySpectrogram_CheckedChanged;
            // 
            // btnLoad
            // 
            btnLoad.BackColor = Color.Transparent;
            btnLoad.BaseColor = Color.FromArgb(69, 69, 69);
            btnLoad.Font = new Font("Segoe UI", 12F);
            btnLoad.Location = new Point(329, 20);
            btnLoad.Name = "btnLoad";
            btnLoad.Rounded = false;
            btnLoad.Size = new Size(125, 125);
            btnLoad.TabIndex = 3;
            btnLoad.Text = "Load";
            btnLoad.TextColor = Color.FromArgb(243, 243, 243);
            btnLoad.Click += BtnLoad_Click;
            // 
            // btnCaptureSave
            // 
            btnCaptureSave.BackColor = Color.Transparent;
            btnCaptureSave.BaseColor = Color.FromArgb(69, 69, 69);
            btnCaptureSave.Font = new Font("Segoe UI", 12F);
            btnCaptureSave.Location = new Point(175, 20);
            btnCaptureSave.Name = "btnCaptureSave";
            btnCaptureSave.Rounded = false;
            btnCaptureSave.Size = new Size(125, 125);
            btnCaptureSave.TabIndex = 2;
            btnCaptureSave.Text = "Save";
            btnCaptureSave.TextColor = Color.FromArgb(243, 243, 243);
            btnCaptureSave.Click += BtnCaptureSave_Click;
            // 
            // tabPageTransmit
            // 
            tabPageTransmit.BackColor = Color.FromArgb(45, 47, 49);
            tabPageTransmit.Controls.Add(tabControlTransmit);
            tabPageTransmit.Location = new Point(0, 40);
            tabPageTransmit.Name = "tabPageTransmit";
            tabPageTransmit.Size = new Size(1100, 688);
            tabPageTransmit.TabIndex = 1;
            tabPageTransmit.Text = "Transmit";
            // 
            // tabControlTransmit
            // 
            tabControlTransmit.BaseColor = Color.FromArgb(69, 69, 69);
            tabControlTransmit.Controls.Add(tabPageTransmitUDP);
            tabControlTransmit.Controls.Add(tabPageTransmitSDR);
            tabControlTransmit.Dock = DockStyle.Top;
            tabControlTransmit.Font = new Font("Segoe UI", 12F);
            tabControlTransmit.ForeColorA = Color.Silver;
            tabControlTransmit.ForeColorB = Color.Gray;
            tabControlTransmit.ForeColorC = Color.FromArgb(150, 255, 255, 255);
            tabControlTransmit.ItemSize = new Size(120, 40);
            tabControlTransmit.Location = new Point(0, 0);
            tabControlTransmit.Margin = new Padding(0);
            tabControlTransmit.Name = "tabControlTransmit";
            tabControlTransmit.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            tabControlTransmit.SelectedIndex = 0;
            tabControlTransmit.Size = new Size(1100, 256);
            tabControlTransmit.SizeMode = TabSizeMode.Fixed;
            tabControlTransmit.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            tabControlTransmit.TabIndex = 43;
            tabControlTransmit.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            tabControlTransmit.ThemeColorA = Color.FromArgb(74, 110, 174);
            tabControlTransmit.ThemeColorB = Color.FromArgb(69, 69, 69);
            tabControlTransmit.TitleTextState = ReaLTaiizor.Controls.HopeTabPage.TextState.Normal;
            // 
            // tabPageTransmitUDP
            // 
            tabPageTransmitUDP.BackColor = Color.FromArgb(45, 47, 49);
            tabPageTransmitUDP.Controls.Add(txtTransmitUDPMessage);
            tabPageTransmitUDP.Controls.Add(lblTransmitUDPMessage);
            tabPageTransmitUDP.Controls.Add(comboTransmitUDPEncoding);
            tabPageTransmitUDP.Controls.Add(btnTransmitUDP);
            tabPageTransmitUDP.Controls.Add(lblTransmitUDPEncoding);
            tabPageTransmitUDP.Controls.Add(checkTransmitRecord);
            tabPageTransmitUDP.ForeColor = Color.White;
            tabPageTransmitUDP.Location = new Point(0, 40);
            tabPageTransmitUDP.Name = "tabPageTransmitUDP";
            tabPageTransmitUDP.Padding = new Padding(3);
            tabPageTransmitUDP.Size = new Size(1100, 216);
            tabPageTransmitUDP.TabIndex = 0;
            tabPageTransmitUDP.Text = "UDP";
            // 
            // txtTransmitUDPMessage
            // 
            txtTransmitUDPMessage.BackColor = Color.FromArgb(69, 73, 74);
            txtTransmitUDPMessage.BorderStyle = BorderStyle.FixedSingle;
            txtTransmitUDPMessage.ForeColor = Color.FromArgb(220, 220, 220);
            txtTransmitUDPMessage.Location = new Point(262, 41);
            txtTransmitUDPMessage.Multiline = true;
            txtTransmitUDPMessage.Name = "txtTransmitUDPMessage";
            txtTransmitUDPMessage.Size = new Size(793, 161);
            txtTransmitUDPMessage.TabIndex = 41;
            txtTransmitUDPMessage.Text = "example";
            // 
            // lblTransmitUDPMessage
            // 
            lblTransmitUDPMessage.AutoSize = true;
            lblTransmitUDPMessage.ForeColor = Color.FromArgb(220, 220, 220);
            lblTransmitUDPMessage.Location = new Point(262, 17);
            lblTransmitUDPMessage.Name = "lblTransmitUDPMessage";
            lblTransmitUDPMessage.Size = new Size(74, 21);
            lblTransmitUDPMessage.TabIndex = 42;
            lblTransmitUDPMessage.Text = "Message:";
            // 
            // comboTransmitUDPEncoding
            // 
            comboTransmitUDPEncoding.DrawMode = DrawMode.OwnerDrawVariable;
            comboTransmitUDPEncoding.FormattingEnabled = true;
            comboTransmitUDPEncoding.Items.AddRange(new object[] { "Binary", "ECC", "Simple Morse", "Advanced Morse" });
            comboTransmitUDPEncoding.Location = new Point(11, 40);
            comboTransmitUDPEncoding.Name = "comboTransmitUDPEncoding";
            comboTransmitUDPEncoding.Size = new Size(220, 30);
            comboTransmitUDPEncoding.TabIndex = 27;
            // 
            // btnTransmitUDP
            // 
            btnTransmitUDP.BackColor = Color.Transparent;
            btnTransmitUDP.BaseColor = Color.FromArgb(74, 110, 174);
            btnTransmitUDP.Font = new Font("Segoe UI", 12F);
            btnTransmitUDP.Location = new Point(10, 135);
            btnTransmitUDP.Margin = new Padding(3, 2, 3, 2);
            btnTransmitUDP.Name = "btnTransmitUDP";
            btnTransmitUDP.Rounded = false;
            btnTransmitUDP.Size = new Size(220, 67);
            btnTransmitUDP.TabIndex = 28;
            btnTransmitUDP.Text = "Transmit";
            btnTransmitUDP.TextColor = Color.FromArgb(243, 243, 243);
            btnTransmitUDP.Click += BtnTransmit_Click;
            // 
            // lblTransmitUDPEncoding
            // 
            lblTransmitUDPEncoding.AutoSize = true;
            lblTransmitUDPEncoding.ForeColor = Color.FromArgb(220, 220, 220);
            lblTransmitUDPEncoding.Location = new Point(7, 16);
            lblTransmitUDPEncoding.Name = "lblTransmitUDPEncoding";
            lblTransmitUDPEncoding.Size = new Size(77, 21);
            lblTransmitUDPEncoding.TabIndex = 40;
            lblTransmitUDPEncoding.Text = "Encoding:";
            // 
            // checkTransmitRecord
            // 
            checkTransmitRecord.AutoSize = true;
            checkTransmitRecord.Location = new Point(11, 89);
            checkTransmitRecord.Name = "checkTransmitRecord";
            checkTransmitRecord.Size = new Size(146, 25);
            checkTransmitRecord.TabIndex = 39;
            checkTransmitRecord.Text = "Record with SDR";
            // 
            // tabPageTransmitSDR
            // 
            tabPageTransmitSDR.BackColor = Color.FromArgb(45, 47, 49);
            tabPageTransmitSDR.Controls.Add(lblTransmitSDRSignalTime);
            tabPageTransmitSDR.Controls.Add(sliderTransmitSDRSignalTime);
            tabPageTransmitSDR.Controls.Add(txtTransmitSDRMessage);
            tabPageTransmitSDR.Controls.Add(lblTransmitSDRMessage);
            tabPageTransmitSDR.Controls.Add(comboTransmitSDREncoding);
            tabPageTransmitSDR.Controls.Add(lblTransmitSDREncoding);
            tabPageTransmitSDR.Controls.Add(btnTransmitSDRFile);
            tabPageTransmitSDR.Controls.Add(btnTransmitSDR);
            tabPageTransmitSDR.Location = new Point(0, 40);
            tabPageTransmitSDR.Name = "tabPageTransmitSDR";
            tabPageTransmitSDR.Padding = new Padding(3);
            tabPageTransmitSDR.Size = new Size(1100, 216);
            tabPageTransmitSDR.TabIndex = 1;
            tabPageTransmitSDR.Text = "SDR";
            // 
            // lblTransmitSDRSignalTime
            // 
            lblTransmitSDRSignalTime.AutoSize = true;
            lblTransmitSDRSignalTime.ForeColor = Color.FromArgb(220, 220, 220);
            lblTransmitSDRSignalTime.Location = new Point(262, 170);
            lblTransmitSDRSignalTime.Name = "lblTransmitSDRSignalTime";
            lblTransmitSDRSignalTime.Size = new Size(129, 21);
            lblTransmitSDRSignalTime.TabIndex = 49;
            lblTransmitSDRSignalTime.Text = "Signal Time (ms):";
            // 
            // sliderTransmitSDRSignalTime
            // 
            sliderTransmitSDRSignalTime.BarThickness = 4;
            sliderTransmitSDRSignalTime.BigStepIncrement = 10;
            sliderTransmitSDRSignalTime.Colors = (List<Color>)resources.GetObject("sliderTransmitSDRSignalTime.Colors");
            sliderTransmitSDRSignalTime.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            sliderTransmitSDRSignalTime.FilledColor = Color.FromArgb(74, 110, 174);
            sliderTransmitSDRSignalTime.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            sliderTransmitSDRSignalTime.KnobColor = Color.Gray;
            sliderTransmitSDRSignalTime.KnobImage = null;
            sliderTransmitSDRSignalTime.Location = new Point(397, 171);
            sliderTransmitSDRSignalTime.Max = 100;
            sliderTransmitSDRSignalTime.Name = "sliderTransmitSDRSignalTime";
            sliderTransmitSDRSignalTime.Percentage = 50;
            sliderTransmitSDRSignalTime.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            sliderTransmitSDRSignalTime.Positions = (List<float>)resources.GetObject("sliderTransmitSDRSignalTime.Positions");
            sliderTransmitSDRSignalTime.QuickHopping = false;
            sliderTransmitSDRSignalTime.Size = new Size(250, 20);
            sliderTransmitSDRSignalTime.SliderStyle = ReaLTaiizor.Controls.ParrotSlider.Style.Windows10;
            sliderTransmitSDRSignalTime.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            sliderTransmitSDRSignalTime.TabIndex = 48;
            sliderTransmitSDRSignalTime.Text = "Signal Time (ms)";
            sliderTransmitSDRSignalTime.UnfilledColor = Color.FromArgb(74, 110, 174);
            // 
            // txtTransmitSDRMessage
            // 
            txtTransmitSDRMessage.BackColor = Color.FromArgb(69, 73, 74);
            txtTransmitSDRMessage.BorderStyle = BorderStyle.FixedSingle;
            txtTransmitSDRMessage.ForeColor = Color.FromArgb(220, 220, 220);
            txtTransmitSDRMessage.Location = new Point(262, 41);
            txtTransmitSDRMessage.Multiline = true;
            txtTransmitSDRMessage.Name = "txtTransmitSDRMessage";
            txtTransmitSDRMessage.Size = new Size(793, 115);
            txtTransmitSDRMessage.TabIndex = 45;
            txtTransmitSDRMessage.Text = "example";
            // 
            // lblTransmitSDRMessage
            // 
            lblTransmitSDRMessage.AutoSize = true;
            lblTransmitSDRMessage.ForeColor = Color.FromArgb(220, 220, 220);
            lblTransmitSDRMessage.Location = new Point(262, 17);
            lblTransmitSDRMessage.Name = "lblTransmitSDRMessage";
            lblTransmitSDRMessage.Size = new Size(74, 21);
            lblTransmitSDRMessage.TabIndex = 46;
            lblTransmitSDRMessage.Text = "Message:";
            // 
            // comboTransmitSDREncoding
            // 
            comboTransmitSDREncoding.DrawMode = DrawMode.OwnerDrawVariable;
            comboTransmitSDREncoding.FormattingEnabled = true;
            comboTransmitSDREncoding.Items.AddRange(new object[] { "Binary", "ECC", "Simple Morse", "Advanced Morse" });
            comboTransmitSDREncoding.Location = new Point(11, 40);
            comboTransmitSDREncoding.Name = "comboTransmitSDREncoding";
            comboTransmitSDREncoding.Size = new Size(220, 30);
            comboTransmitSDREncoding.TabIndex = 43;
            // 
            // lblTransmitSDREncoding
            // 
            lblTransmitSDREncoding.AutoSize = true;
            lblTransmitSDREncoding.ForeColor = Color.FromArgb(220, 220, 220);
            lblTransmitSDREncoding.Location = new Point(7, 16);
            lblTransmitSDREncoding.Name = "lblTransmitSDREncoding";
            lblTransmitSDREncoding.Size = new Size(77, 21);
            lblTransmitSDREncoding.TabIndex = 44;
            lblTransmitSDREncoding.Text = "Encoding:";
            // 
            // btnTransmitSDRFile
            // 
            btnTransmitSDRFile.BackColor = Color.Transparent;
            btnTransmitSDRFile.BaseColor = Color.FromArgb(69, 69, 69);
            btnTransmitSDRFile.Font = new Font("Segoe UI", 12F);
            btnTransmitSDRFile.Location = new Point(10, 86);
            btnTransmitSDRFile.Name = "btnTransmitSDRFile";
            btnTransmitSDRFile.Rounded = false;
            btnTransmitSDRFile.Size = new Size(220, 43);
            btnTransmitSDRFile.TabIndex = 30;
            btnTransmitSDRFile.Text = "Transmit File";
            btnTransmitSDRFile.TextColor = Color.FromArgb(243, 243, 243);
            btnTransmitSDRFile.Click += BtnTransmitSDRFile_Click;
            // 
            // btnTransmitSDR
            // 
            btnTransmitSDR.BackColor = Color.Transparent;
            btnTransmitSDR.BaseColor = Color.FromArgb(74, 110, 174);
            btnTransmitSDR.Font = new Font("Segoe UI", 12F);
            btnTransmitSDR.Location = new Point(10, 135);
            btnTransmitSDR.Margin = new Padding(3, 2, 3, 2);
            btnTransmitSDR.Name = "btnTransmitSDR";
            btnTransmitSDR.Rounded = false;
            btnTransmitSDR.Size = new Size(220, 67);
            btnTransmitSDR.TabIndex = 29;
            btnTransmitSDR.Text = "Transmit";
            btnTransmitSDR.TextColor = Color.FromArgb(243, 243, 243);
            btnTransmitSDR.Click += BtnTransmitSDR_Click;
            // 
            // tabPageSimulation
            // 
            tabPageSimulation.BackColor = Color.FromArgb(45, 47, 49);
            tabPageSimulation.Controls.Add(simulationPage);
            tabPageSimulation.ForeColor = Color.White;
            tabPageSimulation.Location = new Point(0, 40);
            tabPageSimulation.Margin = new Padding(0);
            tabPageSimulation.Name = "tabPageSimulation";
            tabPageSimulation.Size = new Size(1100, 688);
            tabPageSimulation.TabIndex = 6;
            tabPageSimulation.Text = "Simulation";
            // 
            // simulationPage
            // 
            simulationPage.BackColor = Color.FromArgb(45, 47, 49);
            simulationPage.Dock = DockStyle.Fill;
            simulationPage.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            simulationPage.Location = new Point(0, 0);
            simulationPage.Margin = new Padding(2);
            simulationPage.Name = "simulationPage";
            simulationPage.Size = new Size(1100, 688);
            simulationPage.TabIndex = 0;
            // 
            // tabPageTesting
            // 
            tabPageTesting.BackColor = Color.FromArgb(45, 47, 49);
            tabPageTesting.Controls.Add(stepsPanelControl);
            tabPageTesting.Location = new Point(0, 40);
            tabPageTesting.Name = "tabPageTesting";
            tabPageTesting.Padding = new Padding(3);
            tabPageTesting.Size = new Size(1100, 688);
            tabPageTesting.TabIndex = 4;
            tabPageTesting.Text = "Testing";
            // 
            // stepsPanelControl
            // 
            stepsPanelControl.BackColor = Color.Transparent;
            stepsPanelControl.Dock = DockStyle.Fill;
            stepsPanelControl.Location = new Point(3, 3);
            stepsPanelControl.Margin = new Padding(3, 1, 3, 1);
            stepsPanelControl.Name = "stepsPanelControl";
            stepsPanelControl.Size = new Size(1094, 682);
            stepsPanelControl.TabIndex = 0;
            // 
            // tabControlApp
            // 
            tabControlApp.BaseColor = Color.FromArgb(69, 69, 69);
            tabControlApp.Controls.Add(tabPageTesting);
            tabControlApp.Controls.Add(tabPageSimulation);
            tabControlApp.Controls.Add(tabPageTransmit);
            tabControlApp.Controls.Add(tabCapture);
            tabControlApp.Dock = DockStyle.Fill;
            tabControlApp.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            tabControlApp.ForeColorA = Color.Silver;
            tabControlApp.ForeColorB = Color.Gray;
            tabControlApp.ForeColorC = Color.FromArgb(150, 255, 255, 255);
            tabControlApp.ItemSize = new Size(120, 40);
            tabControlApp.Location = new Point(350, 117);
            tabControlApp.Name = "tabControlApp";
            tabControlApp.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            tabControlApp.SelectedIndex = 0;
            tabControlApp.Size = new Size(1100, 728);
            tabControlApp.SizeMode = TabSizeMode.Fixed;
            tabControlApp.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            tabControlApp.TabIndex = 3;
            tabControlApp.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            tabControlApp.ThemeColorA = Color.FromArgb(74, 110, 174);
            tabControlApp.ThemeColorB = Color.FromArgb(69, 69, 69);
            tabControlApp.TitleTextState = ReaLTaiizor.Controls.HopeTabPage.TextState.Normal;
            // 
            // App
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(42, 42, 42);
            ClientSize = new Size(1450, 845);
            Controls.Add(tabControlApp);
            Controls.Add(pnlSideBar);
            Controls.Add(pnlToolBar);
            Controls.Add(customWindowHeaderControl);
            Font = new Font("Segoe UI", 10.8F);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "App";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "App";
            WindowState = FormWindowState.Maximized;
            FormClosing += App_FormClosing;
            Load += App_Load;
            SizeChanged += App_SizeChanged;
            pnlSideBar.ResumeLayout(false);
            pnlSDRDevice.ResumeLayout(false);
            pnlSDRDevice.PerformLayout();
            pnlWiFiDevice.ResumeLayout(false);
            pnlWiFiDevice.PerformLayout();
            pnlChannelPreset.ResumeLayout(false);
            pnlSDRSettings.ResumeLayout(false);
            pnlSDRSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numSDRVGAGain).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSDRLNAGain).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSDRFilterBandwith).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSDRFrequency).EndInit();
            pnlToolBar.ResumeLayout(false);
            tabCapture.ResumeLayout(false);
            tabCapture.PerformLayout();
            pnlCaptureToggle.ResumeLayout(false);
            tabPageTransmit.ResumeLayout(false);
            tabControlTransmit.ResumeLayout(false);
            tabPageTransmitUDP.ResumeLayout(false);
            tabPageTransmitUDP.PerformLayout();
            tabPageTransmitSDR.ResumeLayout(false);
            tabPageTransmitSDR.PerformLayout();
            tabPageSimulation.ResumeLayout(false);
            tabPageTesting.ResumeLayout(false);
            tabControlApp.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Components.CustomWindowHeaderControl customWindowHeaderControl;
        private FlowLayoutPanel pnlSideBar;
        private Panel pnlToolBar;
        private ReaLTaiizor.Controls.CrownSectionPanel pnlSDRDevice;
        private ReaLTaiizor.Controls.ForeverLabel lblSDRDevices;
        private ReaLTaiizor.Controls.CrownSectionPanel pnlWiFiDevice;
        private ReaLTaiizor.Controls.ForeverLabel lblWiFiDevices;
        private ReaLTaiizor.Controls.LostButton btnSDRRefresh;
        private ReaLTaiizor.Controls.CrownSectionPanel pnlSDRSettings;
        private ReaLTaiizor.Controls.CrownNumeric numSDRFrequency;
        private ReaLTaiizor.Controls.ForeverLabel lblSDRFrequency;
        private ReaLTaiizor.Controls.CrownSectionPanel pnlChannelPreset;
        private ReaLTaiizor.Controls.ForeverLabel lblSDRConnection;
        private ReaLTaiizor.Controls.ForeverToggle toggleSDRConnection;
        private ReaLTaiizor.Controls.CrownNumeric numSDRFilterBandwith;
        private ReaLTaiizor.Controls.ForeverLabel lblSDRFilterBandwith;
        private System.Windows.Forms.Timer timerCaptureStatus;
        private ReaLTaiizor.Controls.CrownNumeric numSDRLNAGain;
        private ReaLTaiizor.Controls.ForeverLabel lblSDRLNAGain;
        private ReaLTaiizor.Controls.CrownNumeric numSDRVGAGain;
        private ReaLTaiizor.Controls.ForeverLabel lblSDRVGAGain;
        private ReaLTaiizor.Controls.ForeverButton btnInfo;
        private ReaLTaiizor.Controls.ForeverButton btnLoadState;
        private ReaLTaiizor.Controls.ForeverButton btnSaveState;
        private ReaLTaiizor.Controls.ForeverLabel lblSDRSamplingRate;
        private ReaLTaiizor.Controls.CrownComboBox comboSDRSamplingRate;
        private ReaLTaiizor.Controls.CrownComboBox comboWiFiDevices;
        private ReaLTaiizor.Controls.CrownComboBox comboChannelPresets;
        private ReaLTaiizor.Controls.CrownComboBox comboSDRDevices;
        private ReaLTaiizor.Controls.ForeverButton btnSaveStateAs;
        private ReaLTaiizor.Controls.ForeverButton btnLoadStateFromFile;
        private TabPage tabCapture;
        private Components.Common.SpectrogramFileListControl spectrogramFileListControl1;
        private Panel pnlCaptureToggle;
        private ReaLTaiizor.Controls.ForeverToggle toggleCapture;
        private ReaLTaiizor.Controls.ForeverLabel lblCaptureProgress;
        private ReaLTaiizor.Controls.ForeverLabel lblCapture;
        private Panel pnlCaptureSpectrogram;
        private ReaLTaiizor.Controls.CrownCheckBox checkBoxCaptureDisplaySpectrogram;
        private ReaLTaiizor.Controls.ForeverButton btnLoad;
        private ReaLTaiizor.Controls.ForeverButton btnCaptureSave;
        private TabPage tabPageTransmit;
        private ReaLTaiizor.Controls.HopeTabPage tabControlTransmit;
        private TabPage tabPageTransmitUDP;
        private ReaLTaiizor.Controls.CrownTextBox txtTransmitUDPMessage;
        private ReaLTaiizor.Controls.CrownLabel lblTransmitUDPMessage;
        private ReaLTaiizor.Controls.CrownComboBox comboTransmitUDPEncoding;
        private ReaLTaiizor.Controls.ForeverButton btnTransmitUDP;
        private ReaLTaiizor.Controls.CrownLabel lblTransmitUDPEncoding;
        private ReaLTaiizor.Controls.CrownCheckBox checkTransmitRecord;
        private TabPage tabPageTransmitSDR;
        private ReaLTaiizor.Controls.CrownTextBox txtTransmitSDRMessage;
        private ReaLTaiizor.Controls.CrownLabel lblTransmitSDRMessage;
        private ReaLTaiizor.Controls.CrownComboBox comboTransmitSDREncoding;
        private ReaLTaiizor.Controls.CrownLabel lblTransmitSDREncoding;
        private ReaLTaiizor.Controls.ForeverButton btnTransmitSDRFile;
        private ReaLTaiizor.Controls.ForeverButton btnTransmitSDR;
        private TabPage tabPageSimulation;
        private Components.Pages.Simulation.SimulationPage simulationPage;
        private TabPage tabPageTesting;
        private StepsPanelControl stepsPanelControl;
        private ReaLTaiizor.Controls.HopeTabPage tabControlApp;
        private ReaLTaiizor.Controls.CrownLabel lblTransmitSDRSignalTime;
        private ReaLTaiizor.Controls.ParrotSlider sliderTransmitSDRSignalTime;
    }
}