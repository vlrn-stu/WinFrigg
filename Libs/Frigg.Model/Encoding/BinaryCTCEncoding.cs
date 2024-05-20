using System.Collections;

namespace Frigg.Model.Encoding
{
    public class BinaryCTCEncoding : ICTCEncoding
    {
        public BitArray GetBits(string text)
        {
            return new BitArray(System.Text.Encoding.UTF8.GetBytes(text));
        }

        public string GetString(BitArray bits)
        {
            byte[] ret = new byte[((bits.Length - 1) / 8) + 1];
            bits.CopyTo(ret, 0);
            return System.Text.Encoding.UTF8.GetString(ret);
        }
    }
}