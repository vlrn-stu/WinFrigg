using System.Collections;
using System.Text;

namespace Frigg.Model.Encoding
{
    public class MorseCTCEncoding : ICTCEncoding
    {
        public static readonly BitArray Dot = new(new[] { false, false }); //.
        public static readonly BitArray Dash = new(new[] { true, true }); //-
        public static readonly BitArray Space = new(new[] { true, false, false });//
        public static readonly BitArray CharSpace = new(new[] { true, false, true });//_
        public static readonly BitArray Upper = new(new[] { false, true, false, false });//|
        public static readonly BitArray Acute = new(new[] { false, true, false, true });//`
        public static readonly BitArray Diacritic = new(new[] { false, true, true, false });//~
        public static readonly BitArray Special = new(new[] { false, true, true, true });//*

        public static readonly Dictionary<string, char> MorseDictionaryString = new()
        {
            { ".-", 'a' }, { "`.-", 'á'}, { "~.-", 'ä'},
            { "-...", 'b' },
            { "-.-.", 'c' }, { "`-.-.", 'č' },
            { "-..", 'd' }, { "`-..", 'ď' },
            { ".", 'e' }, { "`.", 'é' },
            { "..-.", 'f' },
            { "--.", 'g' },
            { "....", 'h' },
            { "..", 'i' },{ "`..", 'í' },
            { ".---", 'j' },
            { "-.-", 'k' },
            { ".-..", 'l' }, { "`.-..", 'ľ' },
            { "--", 'm' },
            { "-.", 'n' }, { "`-.", 'ň' },
            { "---", 'o' }, { "`---", 'ó' },{ "~---", 'ö' },{ "`~---", 'ő' }, {"*---", 'ô'},
            { ".--.", 'p' },
            { "--.-", 'q' },
            { ".-.", 'r' }, { "`.-.-", 'ŕ'},
            { "...", 's' }, { "`...", 'š' },
            { "-", 't' }, { "`-", 'ť' },
            { "..-", 'u' }, { "`..-", 'ú' }, { "~..-", 'ü' }, { "`~..-", 'ű' },
            { "...-", 'v' },
            { ".--", 'w' },
            { "-..-", 'x' },
            { "-.--", 'y' }, { "`-.--", 'ý' },
            { "--..", 'z' }, { "`--..", 'ž' },

            { "-----", '0' },{ ".----", '1' },{ "..---", '2' },{ "...--", '3' },{ "....-", '4' },{ ".....", '5' },{ "-....", '6' },{ "--...", '7' },{ "---..", '8' },{ "----.", '9' },

            { "*.-", '!' },
            { "*-...", '@' },
            { "*-.-.", '#' },
            { "*-..", '$' },
            { "*.", '%' },
            { "*..-.", '^' },
            { "*--.", '&' },
            { "*....", '*' },
            { "*..", '(' },
            { "*.---", ')' },
            { "*-.-", '-' },
            { "*.-..", '=' },
            { "*--", '_' },
            { "*-.", '+' },
            { "*----", '[' },
            { "*.--.", ']' },
            { "*--.-", '\\' },
            { "*....-", '{' },
            { "*..-", '}' },
            { "*.----", '|' },
            { "*-.-.-", ';' },
            { "*-..-.", '\'' },
            { "*-.-.--", ':' },
            { "*-...-", '"' },
            { "*.-.-.-", ',' },
            { "*-....-", '.' },
            { "*..--..", '/' },
            { "*.-..-.", '<' },
            { "*--..--", '>' },
            { "*-..-.-", '?' },
            { "*....--", '~' }
        };

        public string GetString(BitArray bits)
        {
            StringBuilder decodedString = new();
            StringBuilder morseString = new();
            Queue<bool> bitQueue = new(bits.Cast<bool>());

            while (bitQueue.Count > 0)
            {
                if (bitQueue.Count > 0 && bitQueue.Dequeue()) //1
                {
                    if (bitQueue.Count > 0 && bitQueue.Dequeue()) //11
                    {
                        _ = morseString.Append('-');
                    }
                    else //10
                    {
                        if (bitQueue.Count > 0 && !bitQueue.Dequeue()) //100
                        {
                            _ = morseString.Append(' '); // Space
                        }
                        else //101
                        {
                            _ = morseString.Append('_'); // CharSpace
                        }
                    }
                }
                else //0
                {
                    if (bitQueue.Count > 0 && !bitQueue.Dequeue()) //00
                    {
                        _ = morseString.Append('.');
                    }
                    else //01
                    {
                        if (bitQueue.Count > 0 && bitQueue.Dequeue())//011
                        {
                            if (bitQueue.Count > 0 && bitQueue.Dequeue())//0111
                            {
                                _ = morseString.Append('*'); // Special
                            }
                            else//0110
                            {
                                _ = morseString.Append('~'); // Diacritic
                            }
                        }
                        else //010
                        {
                            if (bitQueue.Count > 0 && bitQueue.Dequeue()) //0101
                            {
                                _ = morseString.Append('`'); // Acute
                            }
                            else //0100
                            {
                                _ = morseString.Append('|'); // Upper
                            }
                        }
                    }
                }
            }

            foreach (string morseChar in morseString.ToString().Split('_'))
            {
                string mChar = morseChar.Trim();
                if (morseChar.StartsWith(' '))
                {
                    _ = decodedString.Append(' ');
                }

                if (mChar.Contains('|'))
                {
                    string morseCharWithoutCase = mChar.Replace("|", "");
                    if (MorseDictionaryString.TryGetValue(morseCharWithoutCase, out char character))
                    {
                        _ = decodedString.Append(char.ToUpper(character));
                    }
                }
                else if (MorseDictionaryString.TryGetValue(mChar, out char character))
                {
                    _ = decodedString.Append(character);
                }
            }

            return decodedString.ToString();
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
                    if (char.IsUpper(c))
                    {
                        bitList.AddRange(Upper.Cast<bool>());
                    }
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
                        else if (code == '|')
                        {
                            bitList.AddRange(Upper.Cast<bool>());
                        }
                        else if (code == '`')
                        {
                            bitList.AddRange(Acute.Cast<bool>());
                        }
                        else if (code == '~')
                        {
                            bitList.AddRange(Diacritic.Cast<bool>());
                        }
                        else if (code == '*')
                        {
                            bitList.AddRange(Special.Cast<bool>());
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