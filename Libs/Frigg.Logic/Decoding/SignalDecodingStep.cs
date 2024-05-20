using Frigg.Common;
using Frigg.Model;
using Frigg.Model.Encoding;
using Frigg.Model.Signalling;
using System.Drawing;
using System.Drawing.Imaging;

namespace Frigg.CTC.Decoding
{
    public class SignalDecodingStep : CTCStep
    {
        private int _sampleMHz;
        private double _signalTimeMs;

        public override string StepName => "Signal Decoding";

        public override int[] StepOrder => [1, 2, 3, 4, 5, 6, 7, 8, 9];
        public override bool DoDrawSprectrogram { get; set; } = true;

        public override StepParameterDictionary Parameters { get; set; } = new()
        {
            { "Signalling", new StepParameterValue { InputType = StepParameterValueInputType.Enum, Value = CTCSignalling.TimeBased } },
            { "Encoding", new StepParameterValue { InputType = StepParameterValueInputType.Enum, Value = CTCEncoding.Binary} },
            { "Sample Rate", new StepParameterValue { InputType = StepParameterValueInputType.Int, Value = 1 } },
            { "Signal Time", new StepParameterValue { InputType = StepParameterValueInputType.Double, Value = 50 } }
        };

        protected override Task DoStep()
        {
            GetCTCParameters(Parameters, out ICTCEncoding? encoding, out ICTCSignalling? signalling);
            _sampleMHz = Convert.ToInt32(Parameters["Sample Rate"].Value);
            _signalTimeMs = Convert.ToDouble(Parameters["Signal Time"].Value);

            int samplesPerBit = (int)Math.Floor(_sampleMHz * 1000000 * (_signalTimeMs / 1000));
            int bytesPerBit = 2 * samplesPerBit;
            int trimmedLength = InputData.Length / bytesPerBit * bytesPerBit;
            byte[] trimmedData = new byte[trimmedLength];
            Array.Copy(InputData, trimmedData, trimmedLength);

            OutputData = trimmedData;
            OutputMessage = DecodeMessageFromIQData(trimmedData, _sampleMHz, _signalTimeMs, signalling, encoding);
            return Task.CompletedTask;
        }

        private static string DecodeMessageFromIQData(byte[] iQValues, int sampleMHz, double signalTimeMs, ICTCSignalling signalling, ICTCEncoding encoding)
        {
            // Use the encoding scheme to get back bits from the I/Q values
            System.Collections.BitArray bits = signalling.GetBits(iQValues, new()
            {
                SampleFrequency = sampleMHz * 1000000,
                SignalTimeMs = signalTimeMs,
            });
            return encoding.GetString(bits);
        }

        public override Task DrawSpectrogram()
        {
            string overlayedImagePath = Path.Combine(Config.Folders.SpectrogramFolder, $"{Guid.NewGuid()}.png");
            using (Bitmap? originalImage = Image.FromFile(SpectrogramImagePath ?? "") as Bitmap)
            using (Bitmap resizedImage = new(originalImage
                                             ?? throw new ArgumentNullException(nameof(originalImage)),
                new Size(originalImage.Width, OutputMessage?.Length > 0 ? OutputMessage.Length * 200 : originalImage.Height)))
            using (Graphics graphics = Graphics.FromImage(resizedImage))
            {
                float charHeight = 200;
                float charWidth = 200;
                float bitLineHeight = charHeight / 8;
                Pen whiteDashedPen = new(Color.White) { DashPattern = [4, 4] };
                Pen redDashedPen = new(Color.Red) { DashPattern = [4, 4] };

                // Draw each character and bit line
                for (int i = 0; i < OutputMessage?.Length; i++)
                {
                    string character = OutputMessage[i].ToString();
                    using Font font = new("Arial", charHeight * 0.8f, FontStyle.Regular, GraphicsUnit.Pixel);
                    SizeF textSize = graphics.MeasureString(character, font);

                    float rectX = originalImage.Width - charWidth;
                    RectangleF rect = new(rectX, charHeight * i, charWidth, charHeight);

                    if ((CTCEncoding)Parameters["Encoding"].Value == CTCEncoding.Binary)
                    {
                        for (int bit = 0; bit < 8; bit++)
                        {
                            float bitLineY = rect.Top + (bit * bitLineHeight);
                            if (bit == 0)
                            {
                                graphics.DrawLine(redDashedPen, 0, bitLineY, originalImage.Width - charWidth, bitLineY);
                            }
                            else
                            {
                                graphics.DrawLine(whiteDashedPen, 0, bitLineY, originalImage.Width - charWidth, bitLineY);
                            }
                        }
                    }

                    graphics.FillRectangle(Brushes.White, rect);

                    PointF location = new(rect.Left + ((rect.Width - textSize.Width) / 2), rect.Top + ((rect.Height - textSize.Height) / 2));
                    graphics.DrawString(character, font, Brushes.Black, location);
                }

                resizedImage.Save(overlayedImagePath, ImageFormat.Png);
            }
            SpectrogramImagePath = overlayedImagePath;
            return Task.CompletedTask;
        }
    }
}