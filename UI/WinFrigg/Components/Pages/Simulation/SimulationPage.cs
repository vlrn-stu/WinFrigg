using Frigg.Common;
using Frigg.CTC.Decoding;
using Frigg.CTC.Signalling;
using Frigg.Model;
using Frigg.Model.Encoding;
using Frigg.Model.Signalling;
using System.Data;
using System.Text;
using System.Text.RegularExpressions;

namespace WinFrigg.Components.Pages.Simulation
{
    public partial class SimulationPage : UserControl
    {
        private CancellationTokenSource _cancellationTokenSource = new();
        private string _filePath = Path.Combine(Config.Folders.SimulationsFolder, "tests.csv");
        private DateTime? simulationStart = null;
        private DateTime? simulationEnd = null;

        public SimulationPage()
        {
            InitializeComponent();
            comboNoiseType.SelectedIndex = 0;
            comboSignalingType.SelectedIndex = 0;
            pagedDataControl.CsvFilePath = _filePath;
            openFileDialog.InitialDirectory = Config.Folders.SimulationsFolder;
            saveFileDialog.InitialDirectory = Config.Folders.SimulationsFolder;
        }

        private static void EnqueueParameters(Queue<StepParameterDictionary> parameters, string message, object signalling, object encoding, int signalTime, int noisePercent, object noiseType)
        {
            parameters.Enqueue(new StepParameterDictionary
            {
                { "Message", new StepParameterValue { InputType = StepParameterValueInputType.String, Value = message } },
                { "Signalling", new StepParameterValue { InputType = StepParameterValueInputType.Enum, Value = signalling } },
                { "Encoding", new StepParameterValue { InputType = StepParameterValueInputType.Enum, Value = encoding } },
                { "Sample Rate", new StepParameterValue { InputType = StepParameterValueInputType.Int, Value = 1 } },
                { "Signal Time", new StepParameterValue { InputType = StepParameterValueInputType.Int, Value = signalTime } },
                { "Noise", new StepParameterValue { InputType = StepParameterValueInputType.Int, Value = noisePercent } },
                { "NoiseType", new StepParameterValue { InputType = StepParameterValueInputType.Enum, Value = noiseType } }
            });
        }

        private async void BtnRun_Click(object sender, EventArgs e)
        {
            simulationStart = DateTime.Now;
            simulationEnd = null;
            btnRun.Enabled = false;
            btnCancel.Visible = true;
            _cancellationTokenSource = new CancellationTokenSource();
            Queue<StepParameterDictionary> parameters = [];
            List<string> messages = [];
            Random random = new();
            string alphabet = txtAlphabet.Text.Trim().Replace(Environment.NewLine, "").Replace("`", "");
            int totalCharacters = int.TryParse(txtTestCount.Text, out int testCount) ? testCount : 0;

            for (int i = 0; i < totalCharacters; i++)
            {
                StringBuilder sb = new();
                for (int j = 0; j < (int)numMessageSize.Value; j++)
                {
                    double z = Math.Pow(random.NextDouble(), -1.07);
                    int index = Math.Min((int)(z * alphabet.Length) % alphabet.Length, alphabet.Length - 1);
                    _ = sb.Append(alphabet[index]);
                }
                messages.Add(sb.ToString());
            }

            CTCSignalling signalling = CTCSignalling.TimeBased;
            switch (comboSignalingType.SelectedItem)
            {
                case "Time Based":
                    break;

                case "UDP Fragmentation":
                    signalling = CTCSignalling.UDPFragmentation;
                    break;

                default:
                    break;
            }

            List<CTCEncoding> encodings = [];
            if (checkBinary.Checked)
            {
                encodings.Add(CTCEncoding.Binary);
            }
            if (checkECC.Checked)
            {
                encodings.Add(CTCEncoding.ECC);
            }
            if (checkSimpleMorse.Checked)
            {
                encodings.Add(CTCEncoding.SimpleMorse);
            }
            if (checkAdvancedMorse.Checked)
            {
                encodings.Add(CTCEncoding.Morse);
            }
            if (encodings.Count == 0)
            {
                encodings.Add(CTCEncoding.Binary);
                checkBinary.Checked = true;
            }

            NoiseType noiseType = NoiseType.Random;
            switch (comboNoiseType.SelectedItem)
            {
                case "Random":
                    break;

                case "Bit Sized Packets":
                    noiseType = NoiseType.ConstantSizePackets;
                    break;

                case "Random Sized Packets":
                    noiseType = NoiseType.RandomSizePackets;
                    break;

                default:
                    break;
            }

            foreach (string message in messages)
            {
                for (int signalTime = (int)numTimeStart.Value; signalTime <= numTimeEnd.Value; signalTime += (int)numTimeStep.Value)
                {
                    for (int noisePercent = 0; (int)numNoiseStep.Value == 0 ? noisePercent == 0 : noisePercent <= 100; noisePercent += (int)numNoiseStep.Value)
                    {
                        Array signallingTypes = checkSignallingAll.Checked ? Enum.GetValues(typeof(CTCSignalling)) : new[] { signalling };
                        Array noiseTypes = checkNoiseAll.Checked ? Enum.GetValues(typeof(NoiseType)) : new[] { noiseType };

                        foreach (CTCEncoding encType in encodings)
                        {
                            foreach (object? sigType in signallingTypes)
                            {
                                foreach (object? noiType in noiseTypes)
                                {
                                    EnqueueParameters(parameters, message, sigType, encType, signalTime, noisePercent, noiType);
                                }
                            }
                        }

                        if ((int)numNoiseStep.Value == 0)
                        {
                            noisePercent++;
                        }
                    }
                }
            }

            pagedDataControl.timerRefresh.Enabled = true;
            while (parameters.Count > 0)
            {
                List<StepParameterDictionary> parametersBatch = [];
                for (int i = 0; i < numThreads.Value; i++)
                {
                    if (parameters.TryDequeue(out StepParameterDictionary? parameter))
                    {
                        parametersBatch.Add(parameter);
                    }
                }

                List<string> lines = [];
                lblElapsed.Text = $"Elapsed: {(simulationEnd ?? DateTime.Now) - simulationStart:hh\\:mm\\:ss\\.fff}";

                try
                {
                    // Running tests in parallel
                    await Parallel.ForEachAsync(parametersBatch, _cancellationTokenSource.Token, async (parameter, cancellationToken) =>
                    {
                        (string DecodedMessage, double Throughput, double ErrorPercent) = await RunSingleStep(parameter);
                        lines.Add($"{CSVSafe().Replace(parameter["Message"]?.Value?.ToString() ?? "", "")}`{CSVSafe().Replace(DecodedMessage, "")}`{parameter["Signalling"].Value}`{parameter["Encoding"].Value}`{parameter["Sample Rate"].Value}`{parameter["Signal Time"].Value}`{parameter["Noise"].Value}`{parameter["NoiseType"].Value}`{Throughput}`{ErrorPercent}");
                    });
                }
                catch (TaskCanceledException)
                {
                    btnRun.Enabled = true;
                    btnCancel.Visible = false;
                    pagedDataControl.timerRefresh.Enabled = false;
                    simulationEnd = DateTime.Now;
                    return;
                }
                _ = Directory.CreateDirectory(Path.GetDirectoryName(_filePath) ?? "");
                using (StreamWriter writer = new(new FileStream(_filePath, FileMode.Append, FileAccess.Write)))
                {
                    if (new FileInfo(_filePath).Length == 0)
                    {
                        writer.WriteLine("Message`Decoded Message`Signalling`Encoding`Sample Rate (MHz)`Signal Time (ms)`Noise (%)`NoiseType`Throughput (char/s)`ErrorPercent (%)");
                    }
                    foreach (string line in lines)
                    {
                        writer.WriteLine(line);
                    }
                }

                GC.Collect();
            }
            btnRun.Enabled = true;
            btnCancel.Visible = false;
            pagedDataControl.timerRefresh.Enabled = false;
            simulationEnd = DateTime.Now;
            lblElapsed.Text = $"Elapsed: {(simulationEnd ?? DateTime.Now) - simulationStart:hh\\:mm\\:ss\\.fff}";
        }

        private static async Task<(string DecodedMessage, double Throughput, double ErrorPercent)> RunSingleStep(StepParameterDictionary parameters)
        {
            CTCStep encodingStep = new SignalGenerationStep() { DoDrawSprectrogram = false };
            CTCStep decodingStep = new SignalDecodingStep() { DoDrawSprectrogram = false };
            double errorPercent;

            encodingStep.Parameters = parameters;
            encodingStep.OutputData = [];
            decodingStep.Parameters = parameters;

            _ = await encodingStep.PerformStep(null);
            _ = await decodingStep.PerformStep(encodingStep);

            int correctCharacters = 0;
            string message = parameters["Message"]?.Value?.ToString() ?? "";

            // Calculate throughput using the formula in thesis
            double throughput = message.Length / (double)((double)encodingStep.OutputData.Length / ((int)parameters["Sample Rate"].Value * 1_000_000));

            // Calculate our error percentage metric
            for (int i = 0; i < Math.Min(message.Length, decodingStep?.OutputMessage?.Length ?? 0); i++)
            {
                if (message[i] == decodingStep?.OutputMessage?[i])
                {
                    correctCharacters++;
                }
            }

            errorPercent = (1.0 - (correctCharacters / (double)message.Length)) * 100;

            return (decodingStep?.OutputMessage.Replace("`", "#").Trim().Replace(Environment.NewLine, "") ?? string.Empty, throughput, errorPercent);
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                _filePath = openFileDialog.FileName;
                pagedDataControl.CsvFilePath = _filePath;
            }
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            saveFileDialog.FileName = Path.GetFileNameWithoutExtension(_filePath) + "_export.csv";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.Copy(_filePath, saveFileDialog.FileName, true);
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(_filePath))
                {
                    File.Delete(_filePath);
                }
            }
            catch (IOException)
            {
                _ = MessageBox.Show("The file is currently in use. Please close any applications using the file and try again.");
            }
            pagedDataControl.CsvFilePath = _filePath;
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            _filePath = Path.Combine(Config.Folders.SimulationsFolder, Guid.NewGuid().ToString().Replace("-", "") + ".csv");
            pagedDataControl.CsvFilePath = _filePath;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            _cancellationTokenSource.Cancel();
        }

        private void CheckNoiseAll_CheckedChanged(object sender, EventArgs e)
        {
            comboNoiseType.Enabled = !checkNoiseAll.Checked;
        }

        private void CheckSignallingAll_CheckedChanged(object sender, EventArgs e)
        {
            comboSignalingType.Enabled = !checkSignallingAll.Checked;
        }

        private void CheckAlphabet_CheckedChanged(object sender, EventArgs e)
        {
            txtAlphabet.Text = StringFilter.FilterAlphabet(checkLower.Checked, checkEnglish.Checked, checkHungarian.Checked, checkSlovak.Checked, checkSpecial.Checked);
        }

        [GeneratedRegex(@"[^\p{L}\p{N}~!@#$%^&*()_+\-=\[\]\{\}\\|;':"",./<>?]", RegexOptions.Compiled)]
        private static partial Regex CSVSafe();
    }

    public class StringFilter
    {
        // Order using the retrospective ditribution of each character in the 3 languages, merged using Zipf's law
        public const string FullAlphabet = "eatonsirldhmkvápcgéubzyjEfAwTONúSIRíLýDHMKVőčöžÁóPCüšGÉUBZYťJľFWôÚxÍÝűqŐČÖŽÓÜŠďňŤĽÔXäŰQĎŕŇÄŔ!@#$%^&*()-=_+[]\\{}|;':\",./<>?~";

        public static string FilterAlphabet(bool convertToLowercase, bool includeEnglishAlphabetNumeric, bool includeHungarianAlphabetNumeric, bool includeSlovakAlphabetNumeric, bool includeSpecialSymbols)
        {
            string englishAlphabet = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string hungarianAlphabet = "aábcdeéfghiíjklmnoóöőpqrstuúüűvwxyzAÁBCDEÉFGHIÍJKLMNOÓÖŐPQRSTUÚÜŰVWXYZ";
            string slovakAlphabet = "aáäbcčdďeéfghiíjklĺľmnňoóôpqrŕsštťuúvwxyýzžAÁÄBCČDĎEÉFGHIÍJKLĹĽMNOÓÔPQRŔSŠTŤUÚVWXYÝZŽ";

            StringBuilder builder = new();
            foreach (char ch in FullAlphabet)
            {
                if (convertToLowercase && char.IsUpper(ch))
                {
                    continue;  // Skip uppercase characters if convertToLowercase is true
                }

                char processedChar = convertToLowercase ? char.ToLower(ch) : ch;

                if (includeEnglishAlphabetNumeric && englishAlphabet.Contains(processedChar))
                {
                    _ = builder.Append(processedChar);
                    continue;
                }

                if (includeHungarianAlphabetNumeric && hungarianAlphabet.Contains(processedChar))
                {
                    _ = builder.Append(processedChar);
                    continue;
                }

                if (includeSlovakAlphabetNumeric && slovakAlphabet.Contains(processedChar))
                {
                    _ = builder.Append(processedChar);
                    continue;
                }

                if (includeSpecialSymbols && !char.IsLetterOrDigit(ch))
                {
                    _ = builder.Append(ch);
                }
            }

            return builder.ToString();
        }
    }
}