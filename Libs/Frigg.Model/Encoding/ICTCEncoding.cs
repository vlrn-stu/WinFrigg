using System.Collections;

namespace Frigg.Model.Encoding
{
    public enum CTCEncoding
    {
        Binary,
        Morse,
        SimpleMorse,
        ECC,
    }
    public interface ICTCEncoding
    {
        public string GetString(BitArray bits);

        public BitArray GetBits(string text);
    }
}