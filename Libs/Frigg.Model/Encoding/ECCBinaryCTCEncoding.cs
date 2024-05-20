using STH1123.ReedSolomon;
using System.Collections;

namespace Frigg.Model.Encoding
{
    public class ECCBinaryCTCEncoding : ICTCEncoding
    {
        private readonly ReedSolomonEncoder encoder;
        private readonly ReedSolomonDecoder decoder;

        public ECCBinaryCTCEncoding()
        {
            GenericGF field = new(285, 256, 0);
            encoder = new ReedSolomonEncoder(field);
            decoder = new ReedSolomonDecoder(field);
        }

        public BitArray GetBits(string text)
        {
            byte[] bytes = System.Text.Encoding.UTF8.GetBytes(text);
            int eccLength = Math.Max(9, bytes.Length / 10);
            int[] data = new int[bytes.Length + eccLength];
            Array.Copy(bytes, data, bytes.Length);
            encoder.Encode(data, eccLength);
            return new BitArray(data.Select(i => (byte)i).ToArray());
        }

        public string GetString(BitArray bits)
        {
            try
            {
                byte[] encodedBytes = new byte[bits.Length / 8];
                bits.CopyTo(encodedBytes, 0);
                int totalBytes = bits.Length / 8;
                int eccLength = Math.Max(9, totalBytes / 11);

                int[] data = new int[encodedBytes.Length];
                for (int i = 0; i < encodedBytes.Length; i++)
                {
                    data[i] = encodedBytes[i];
                }

                _ = decoder.Decode(data, eccLength);

                byte[] decodedBytes = data.Take(data.Length - eccLength).Select(i => (byte)i).ToArray();

                return System.Text.Encoding.UTF8.GetString(decodedBytes);
            }
            catch (Exception)
            {
                return "Failed ECC";
            }
        }
    }
}