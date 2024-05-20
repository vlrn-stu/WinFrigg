using Frigg.Common;
using Frigg.CTC.Logic;
using Frigg.Devices.SDR;
using Frigg.Devices.WiFi.Windows;
using Frigg.Model;
using Frigg.Model.Encoding;
using Frigg.Model.Signalling;
using System.Diagnostics;
using System.Net;
using System.Net.NetworkInformation;
using WinFrigg.Components.Common;

namespace WinFrigg
{
    public partial class App : Form
    {
        private readonly CancellationTokenSource _cts = new();
        private readonly IEnumerable<ISDRDeviceManager> _sDRDeviceManagers;
        private readonly List<ISDRDevice> _sDRDevices = [];
        private bool _isRecording = false;
        private DateTimeOffset? captureStart = null;
        private ISDRDevice? selectedSDRDevice;

        public App(IEnumerable<ISDRDeviceManager> sdrDeviceManagers)
        {
            InitializeComponent();
            SetStyle(ControlStyles.ResizeRedraw, true);
            Hide();
            SetDataBindings();
            _sDRDeviceManagers = sdrDeviceManagers;
            LoadSDRDevices(true);
            LoadWiFiDevices();
            LoadFrequencies();
            comboSDRSamplingRate.SelectedIndex = 0;
            WindowState = FormWindowState.Normal;
            Location = Screen.PrimaryScreen?.WorkingArea.Location ?? Location;
            Size = Screen.PrimaryScreen?.WorkingArea.Size ?? Size;
            DoubleBuffered = true;
            spectrogramFileListControl1.FileSelected += SpectrogramFileListControl_FileSelected;
        }

        private static void OpenExplorerAtPath(string? path)
        {
            if (!string.IsNullOrEmpty(path))
            {
                if (Directory.Exists(path))
                {
                    _ = Process.Start("explorer.exe", path);
                }
                else if (File.Exists(path))
                {
                    _ = Process.Start("explorer.exe", $"/select, \"{path}\"");
                }
                else
                {
                    _ = MessageBox.Show("Path not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                _ = MessageBox.Show("Invalid path. The directory doesn't exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void App_FormClosing(object sender, FormClosingEventArgs e)
        {
            stepsPanelControl.SaveSteps("steps.wfs");
        }

        private void App_SizeChanged(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                CenterToScreen();
            }
        }

        private void BtnCaptureSave_Click(object sender, EventArgs e)
        {
            string? path = IQDataRecorder.CopyRecordingsToNewDirectory();
            OpenExplorerAtPath(path);
        }

        private void BtnInfo_Click(object sender, EventArgs e)
        {
            _ = new Info().ShowDialog();
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            using FolderBrowserDialog fbd = new();
            fbd.Description = "Select a recordings folder";
            fbd.SelectedPath = Config.Folders.RecordingsFolder + "\\";

            if (fbd.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
            {
                IQDataRecorder.CleanTempFolder();
                IQDataRecorder.CopyFilesToTemp(fbd.SelectedPath);
            }
        }

        private void BtnLoadState_Click(object sender, EventArgs e)
        {
            stepsPanelControl.LoadSteps("steps.wfs");
        }

        private void BtnLoadStateFromFile_Click(object sender, EventArgs e)
        {
            using OpenFileDialog openFileDialog = new();
            _ = Directory.CreateDirectory(Config.Folders.SaveStatesFolder);
            openFileDialog.InitialDirectory = Config.Folders.SaveStatesFolder;
            openFileDialog.Filter = "Save State files (*.wfs)|*.wfs|All files (*.*)|*.*";
            openFileDialog.CheckFileExists = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                stepsPanelControl.LoadSteps(openFileDialog.FileName);
            }
        }

        private void BtnSaveState_Click(object sender, EventArgs e)
        {
            stepsPanelControl.SaveSteps("steps.wfs");
        }

        private void BtnSaveStateAs_Click(object sender, EventArgs e)
        {
            using SaveFileDialog saveFileDialog = new();
            _ = Directory.CreateDirectory(Config.Folders.SaveStatesFolder);
            saveFileDialog.InitialDirectory = Config.Folders.SaveStatesFolder;
            saveFileDialog.FileName = $"save-{DateTimeOffset.UtcNow:yyyy-MM-dd-HH-mm-ss.fff}.wfs";
            saveFileDialog.Filter = "Save State files (*.wfs)|*.wfs|All files (*.*)|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                stepsPanelControl.SaveSteps(saveFileDialog.FileName);
            }
        }

        private void BtnSDRRefresh_Click(object sender, EventArgs e)
        {
            LoadSDRDevices();
        }

        private void BtnTransmit_Click(object sender, EventArgs e)
        {
            btnTransmitUDP.Enabled = false;
            try
            {
                CTCTransmission transmission = new(comboWiFiDevices.SelectedItem?.ToString() ?? throw new Exception("No WiFi interface selected."));
                string message = string.IsNullOrWhiteSpace(txtTransmitUDPMessage.Text) ? throw new Exception("Message is empty or null") : txtTransmitUDPMessage.Text;
                ICTCEncoding encoding = (comboTransmitUDPEncoding.SelectedItem?.ToString()) switch
                {
                    "Binary" => new BinaryCTCEncoding(),
                    "ECC" => new ECCBinaryCTCEncoding(),
                    "Simple Morse" => new SimpleMorseCTCEncoding(),
                    "Advanced Morse" => new MorseCTCEncoding(),
                    _ => new BinaryCTCEncoding(),
                };
                transmission.Transmit(message, encoding, checkTransmitRecord.Checked, selectedSDRDevice);
            }
            catch (Exception ex)
            {
                _ = MessageBox.Show(ex.Message, "Transmission Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            btnTransmitUDP.Enabled = true;
        }

        private void BtnTransmitSDR_Click(object sender, EventArgs e)
        {
            string message = string.IsNullOrWhiteSpace(txtTransmitSDRMessage.Text) ? throw new Exception("Message is empty or null") : txtTransmitSDRMessage.Text;
            ICTCEncoding encoding = (comboTransmitSDREncoding.SelectedItem?.ToString()) switch
            {
                "Binary" => new BinaryCTCEncoding(),
                "ECC" => new ECCBinaryCTCEncoding(),
                "Simple Morse" => new SimpleMorseCTCEncoding(),
                "Advanced Morse" => new MorseCTCEncoding(),
                _ => new BinaryCTCEncoding(),
            };

            StepParameterDictionary parameters = new()
            {
                { "Message", new StepParameterValue { InputType = StepParameterValueInputType.String, Value = message } },
                { "Signalling", new StepParameterValue { InputType = StepParameterValueInputType.Enum, Value = CTCSignalling.TimeBased } },
                { "Encoding", new StepParameterValue { InputType = StepParameterValueInputType.Enum, Value = encoding } },
                { "Sample Rate", new StepParameterValue { InputType = StepParameterValueInputType.Int, Value = 1 } },
                { "Signal Time", new StepParameterValue { InputType = StepParameterValueInputType.Int, Value = sliderTransmitSDRSignalTime.Percentage <= 0 ? 1 :  sliderTransmitSDRSignalTime.Percentage} },
            };
            try
            {
                CTCTransmission.Transmit(parameters, selectedSDRDevice ?? throw new Exception("No SDR device found."));
            }
            catch (Exception ex)
            {
                _ = MessageBox.Show(ex.Message, "Transmission Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnTransmitSDRFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new()
            {
                DefaultExt = "bin",
                Filter = "Binary files (*.bin)|*.bin|All files (*.*)|*.*",
                InitialDirectory = Config.Folders.TempIQFolder
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName;
                CTCTransmission.Transmit(File.ReadAllBytes(selectedFilePath), selectedSDRDevice ?? _sDRDeviceManagers.FirstOrDefault()?.GetDevices().Result.FirstOrDefault() ?? throw new Exception("No SDR device found."));
            }
        }

        private async void CheckBoxCaptureDisplaySpectrogram_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCaptureDisplaySpectrogram.Checked)
            {
                captureStart = DateTimeOffset.UtcNow;
                pnlCaptureSpectrogram.Controls.Clear();
                if (!Directory.Exists(Config.Folders.TempIQFolder))
                {
                    checkBoxCaptureDisplaySpectrogram.Checked = false;
                    return;
                }
                pnlCaptureSpectrogram.Controls.Add(new SpectrogramDisplayControl(await Plotter.CreateSpectrogramAsync(Config.Folders.TempIQFolder))
                {
                    Visible = true,
                    Dock = DockStyle.Fill,
                });
                pnlCaptureSpectrogram.Visible = true;
            }
            else
            {
                pnlCaptureSpectrogram.Visible = false;
            }
        }

        private void ComboChannelPresets_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboChannelPresets.SelectedItem is string selectedKey &&
                ZigBeeWiFiOverlapFrequencyDictionary.KeyValuePairs.TryGetValue(selectedKey, out (int ZigBeeChannel, double ZigBeeFrequency, int WiFiChannel, double WiFiFrequency) frequencies))
            {
                numSDRFrequency.Value = (decimal)frequencies.ZigBeeFrequency;
                NumSDRFrequency_ValueChanged(numSDRFrequency, EventArgs.Empty);
            }
        }

        private void ComboSDRSamplingRate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selectedSDRDevice is not null && comboSDRSamplingRate.SelectedItem is not null)
            {
                if (long.TryParse(comboSDRSamplingRate.SelectedItem.ToString(), out long sampleRate))
                {
                    selectedSDRDevice.SampleRate = sampleRate;
                }
                else
                {
                    _ = MessageBox.Show("Invalid sample rate selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadFrequencies()
        {
            comboChannelPresets.Items.Clear();
            foreach (KeyValuePair<string, (int ZigBeeChannel, double ZigBeeFrequency, int WiFiChannel, double WiFiFrequency)> keyValuePair in ZigBeeWiFiOverlapFrequencyDictionary.KeyValuePairs)
            {
                _ = comboChannelPresets.Items.Add(keyValuePair.Key);
            }
            comboChannelPresets.SelectedIndex = 4;
        }

        private async void LoadSDRDevices(bool first = false)
        {
            comboSDRDevices.Items.Clear();
            _sDRDevices.Clear();

            foreach (ISDRDeviceManager manager in _sDRDeviceManagers)
            {
                List<ISDRDevice> devices = await manager.GetDevices();
                _sDRDevices.AddRange(devices);
            }

            foreach (ISDRDevice device in _sDRDevices)
            {
                _ = comboSDRDevices.Items.Add((device,
                $"{device.Name}"));
            }

            if (first && _sDRDevices.Count > 0)
            {
                SelectSDRDevice(0);
            }
        }

        private void LoadWiFiDevices()
        {
            comboWiFiDevices.Items.Clear();
            int selectedIndex = -1;

            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (nic.NetworkInterfaceType == NetworkInterfaceType.Wireless80211)
                {
                    _ = comboWiFiDevices.Items.Add(nic.Name);

                    if (nic.OperationalStatus == OperationalStatus.Up)
                    {
                        IPInterfaceProperties ipProps = nic.GetIPProperties();
                        if (ipProps.UnicastAddresses.Any(ua => ua.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork &&
                                                               !IPAddress.IsLoopback(ua.Address) &&
                                                               !ua.Address.ToString().StartsWith("169.254")))
                        {
                            selectedIndex = comboWiFiDevices.Items.Count - 1;
                        }
                    }
                }
            }

            comboWiFiDevices.SelectedIndex = selectedIndex >= 0 ? selectedIndex : (comboWiFiDevices.Items.Count > 0 ? 0 : -1);
        }

        private void NumSDRFilterBandwith_ValueChanged(object sender, EventArgs e)
        {
            if (selectedSDRDevice is not null)
            {
                selectedSDRDevice.FilterBandwith = (long)numSDRFilterBandwith.Value;
            }
        }

        private void NumSDRFrequency_ValueChanged(object sender, EventArgs e)
        {
            if (selectedSDRDevice is not null)
            {
                selectedSDRDevice.Frequency = (long)numSDRFrequency.Value;
            }
        }

        private void NumSDRLNAGain_ValueChanged(object sender, EventArgs e)
        {
            if (selectedSDRDevice is not null)
            {
                selectedSDRDevice.LNAGain = (long)numSDRLNAGain.Value;
            }
        }

        private void NumSDRVGAGain_ValueChanged(object sender, EventArgs e)
        {
            if (selectedSDRDevice is not null)
            {
                selectedSDRDevice.VGAGain = (long)numSDRVGAGain.Value;
            }
        }

        private void SelectSDRDevice(int index)
        {
            comboSDRDevices.SelectedIndex = index;
            selectedSDRDevice = _sDRDevices[index];
            toggleSDRConnection.Checked = true;
        }

        private void SetDataBindings()
        {
            if (selectedSDRDevice is not null)
            {
                selectedSDRDevice.OpenChanged += (s, e) =>
                {
                    numSDRFrequency.Enabled = e.IsInitialized;
                };
            }
        }

        private void SpectrogramFileListControl_FileSelected(object? sender, string e)
        {
            pnlCaptureSpectrogram.Controls.Clear();
            pnlCaptureSpectrogram.Controls.Add(new SpectrogramDisplayControl(Image.FromFile(e))
            {
                Visible = true,
                Dock = DockStyle.Fill,
            });
            pnlCaptureSpectrogram.Visible = true;
        }

        private void TimerCaptureStatus_Tick(object sender, EventArgs e)
        {
            if (_isRecording)
            {
                string statusFormat = "Time: {0}\r\nSize: {1}\r\n";
                TimeSpan? elapsed = DateTimeOffset.UtcNow - captureStart;
                string dataLength = IQDataRecorder.GetReadableFileSize(IQDataRecorder.BytesRead);
                lblCaptureProgress.Visible = true;
                lblCaptureProgress.Text = string.Format(statusFormat, elapsed, dataLength);
            }
        }

        private void ToggleCapture_CheckedChanged(object sender)
        {
            if (toggleCapture.Checked)
            {
                if (selectedSDRDevice is not null)
                {
                    _isRecording = true;
                    captureStart = DateTimeOffset.UtcNow;
                    timerCaptureStatus.Enabled = true;
                    _ = Task.Factory.StartNew(() =>
                    {
                        try
                        {
                            IQDataRecorder.WriteStreamToFile(selectedSDRDevice, _cts.Token);
                        }
                        catch (OperationCanceledException)
                        {
                            Console.WriteLine("Operation was cancelled.");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"An error occurred: {ex.Message}");
                        }
                    },
                    _cts.Token,
                    TaskCreationOptions.LongRunning,
                    TaskScheduler.Default);
                }
                else
                {
                    toggleCapture.Checked = false;
                }
            }
            else
            {
                _cts.Cancel();
                _isRecording = false;
                timerCaptureStatus.Enabled = false;
            }
        }

        private void ToggleSDRConnection_CheckedChanged(object sender)
        {
            if (toggleSDRConnection.Checked && selectedSDRDevice is not null)
            {
                SetDataBindings();
                if (selectedSDRDevice.Open == false)
                {
                    toggleSDRConnection.Checked = false;
                    LoadSDRDevices(true);
                }
            }
            else
            {
                toggleSDRConnection.Checked = false;
                selectedSDRDevice?.Close();
            }
        }

        private void App_Load(object sender, EventArgs e)
        {
            stepsPanelControl.LoadSteps("steps.wfs");
            comboTransmitSDREncoding.SelectedIndex = 0;
            comboTransmitUDPEncoding.SelectedIndex = 0;
        }
    }
}