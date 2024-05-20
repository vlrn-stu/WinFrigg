using System.Collections;
using System.Text;

namespace Frigg.Model.Encoding
{
    public class SimpleMorseCTCEncoding : ICTCEncoding
    {
        public static readonly BitArray Dot = new(new[] { true }); //.
        public static readonly BitArray Dash = new(new[] { false, false }); //-
        public static readonly BitArray CharSpace = new(new[] { false, true });//
        public static readonly BitArray Space = new(new[] { false, true, false, true });//

        public static readonly Dictionary<string, char> MorseDictionaryString = new()
        {
            { ".-", 'a' },
            { "-...", 'b' },
            { "-.-.", 'c' },
            { "-..", 'd' },
            { ".", 'e' },
            { "..-.", 'f' },
            { "--.", 'g' },
            { "....", 'h' },
            { "..", 'i' },
            { ".---", 'j' },
            { "-.-", 'k' },
            { ".-..", 'l' },
            { "--", 'm' },
            { "-.", 'n' },
            { "---", 'o' },
            { ".--.", 'p' },
            { "--.-", 'q' },
            { ".-.", 'r' },
            { "...", 's' },
            { "-", 't' },
            { "..-", 'u' },
            { "...-", 'v' },
            { ".--", 'w' },
            { "-..-", 'x' },
            { "-.--", 'y' },
            { "--..", 'z' },

            { "-----", '0' },{ ".----", '1' },{ "..---", '2' },{ "...--", '3' },{ "....-", '4' },{ ".....", '5' },{ "-....", '6' },{ "--...", '7' },{ "---..", '8' },{ "----.", '9' },
        };

        private static readonly string[] separator = ["  "];

        public string GetString(BitArray bits)
        {
            StringBuilder decodedString = new();
            StringBuilder morseString = new();
            Queue<bool> bitQueue = new(bits.Cast<bool>());

            while (bitQueue.Count > 0)
            {
                _ = bitQueue.Count > 0 && bitQueue.Dequeue()
                    ? morseString.Append('.')
                    : bitQueue.Count > 0 && bitQueue.Dequeue() ? morseString.Append(' ') : morseString.Append('-');
            }

            string[] morseWords = morseString.ToString().Split(separator, StringSplitOptions.RemoveEmptyEntries);
            foreach (string morseWord in morseWords)
            {
                foreach (string morseChar in morseWord.Split(' '))
                {
                    if (MorseDictionaryString.TryGetValue(morseChar, out char letter))
                    {
                        _ = decodedString.Append(letter);
                    }
                }
                _ = decodedString.Append(' ');
            }

            return decodedString.ToString().TrimEnd();
        }

        public BitArray GetBits(string text)
        {
            List<bool> bitList = [];
            foreach (char c in text)
            {
                char character = c;
                if (char.IsUpper(c))
                {
                    character = c.ToString().ToLower()[0];
                }
                string morseCode = MorseDictionaryString.FirstOrDefault(x => x.Value == character).Key;
                if (morseCode != null)
                {
                    foreach (char code in morseCode)
                    {
                        if (code == '.')
                        {
                            bitList.AddRange(Dot.Cast<bool>());
                        }
                        else if (code == '-')
                        {
                            bitList.AddRange(Dash.Cast<bool>());
                        }
                    }
                    bitList.AddRange(CharSpace.Cast<bool>());
                }
                else if (c == ' ')
                {
                    bitList.AddRange(Space.Cast<bool>());
                }
            }

            if (bitList.Count > CharSpace.Length)
            {
                bitList.RemoveRange(bitList.Count - CharSpace.Length, CharSpace.Length);
            }

            return new BitArray(bitList.ToArray());
        }
    }
}