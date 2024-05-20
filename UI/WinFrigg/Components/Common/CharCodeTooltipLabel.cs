namespace WinFrigg.Components.Common
{
    public class CharCodeTooltipLabel : Label
    {
        private readonly ToolTip _tooltip = new();
        private const string Placeholder = "#";

        public CharCodeTooltipLabel()
        {
            AutoSize = false;
            MouseMove += (sender, e) =>
            {
                if (sender is CharCodeTooltipLabel label && !string.IsNullOrEmpty(label.Text))
                {
                    int charIndex = GetCharacterIndexAtPoint(label, e.Location);
                    if (charIndex != -1 && charIndex < label.Text.Length)
                    {
                        char character = originalText[charIndex];
                        Point toolTipPosition = CalculateToolTipPosition(label, e.Location, charIndex);
                        _tooltip.Show($"Char Code: {(int)character} ({character})", label, toolTipPosition);
                    }
                    else
                    {
                        _tooltip.Hide(label);
                    }
                }
            };
        }

        private static Point CalculateToolTipPosition(Label label, Point mousePosition, int charIndex)
        {
            Graphics graphics = label.CreateGraphics();
            using Graphics g = graphics;
            string textUpToChar = label.Text[..charIndex];
            SizeF size = g.MeasureString(textUpToChar, label.Font);
            int xPosition = (int)size.Width;

            string charString = label.Text.Length > charIndex ? label.Text[charIndex].ToString() : "";
            SizeF charSize = g.MeasureString(charString, label.Font);
            xPosition += (int)(charSize.Width / 2) + 10;

            return new Point(xPosition, mousePosition.Y);
        }

        private string? originalText = string.Empty;

        public override string Text
        {
            get => base.Text;
#pragma warning disable CS8765 // Nullability of type of parameter doesn't match overridden member (possibly because of nullability attributes).
            set
#pragma warning restore CS8765 // Nullability of type of parameter doesn't match overridden member (possibly because of nullability attributes).
            {
                originalText = value;
                base.Text = ReplaceNonPrintable(value ?? string.Empty, Placeholder);
                AdjustSize();
            }
        }

        private static string ReplaceNonPrintable(string input, string placeholder)
        {
            char[] chars = input.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                if (!IsPrintable(chars[i]))
                {
                    chars[i] = placeholder[0];
                }
            }
            return new string(chars);
        }

        private static int GetCharacterIndexAtPoint(Label label, Point point)
        {
            using Graphics g = label.CreateGraphics();
            int startIndex = 0;
            string[] lines = label.Text.Split('\n');
            float height = 0;
            for (int lineIndex = 0; lineIndex < lines.Length; lineIndex++)
            {
                string line = lines[lineIndex];
                SizeF size = g.MeasureString(line, label.Font);
                if (point.Y <= height + size.Height)
                {
                    for (int charIndex = 0; charIndex < line.Length; charIndex++)
                    {
                        size = g.MeasureString(line.AsSpan(0, charIndex + 1), label.Font);
                        if (point.X <= size.Width)
                        {
                            return startIndex + charIndex;
                        }
                    }
                    return startIndex + line.Length;
                }
                startIndex += line.Length + 1;
                height += size.Height;
            }
            return -1;
        }

        private static bool IsPrintable(char c)
        {
            return (!char.IsControl(c) && !char.IsWhiteSpace(c)) || c == ' ';
        }

        private void AdjustSize()
        {
            using Graphics g = CreateGraphics();
            SizeF size = g.MeasureString(Text, Font);
            Height = (int)Math.Ceiling(size.Height);
            Width = (int)Math.Ceiling(size.Width) + 50;
        }
    }
}