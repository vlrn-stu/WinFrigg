using STH1123.ReedSolomon;
using System;
using System.Linq;
using System.Text;

namespace Frigg.ECC
{
    public static class ECCHelper
    {
        private const int DataShards = 10;  // Number of data shards
        private const int ParityShards = 2;  // Number of parity shards for error correction
        private const int TotalShards = DataShards + ParityShards;

        public static string Encode(string input)
        {
            byte[] inputData = Encoding.UTF8.GetBytes(input);

            var encoder = new ReedSolomonEncoder(GenericGF.QR_CODE_FIELD_256);
            var shards = input.Select(c => int.Parse(c + "")).ToArray();
            encoder.Encode(shards, ParityShards);

            // Combine shards into a single byte array
            return shards.Select(i => (char)i)?.ToString();
        }

        public static string Decode(string encodedInput)
        {
            return "";
            /*byte[] encodedData = Convert.FromBase64String(encodedInput);
            var shards = new byte[TotalShards][];
            int shardLength = encodedData.Length / TotalShards;

            for (int i = 0; i < TotalShards; i++)
            {
                shards[i] = new byte[shardLength];
                Array.Copy(encodedData, i * shardLength, shards[i], 0, shardLength);
            }

            var decoder = new ReedSolomonDecoder(GenericGF.QR_CODE_FIELD_256);
            decoder.Decode(shards, ParityShards);

            // Combine the data shards into a single byte array
            byte[] decodedData = shards.Take(DataShards).SelectMany(s => s).ToArray();
            // Assuming the original data fills the entire shard length without padding
            int originalLength = shardLength * DataShards;
            return Encoding.UTF8.GetString(decodedData, 0, originalLength);*/
        }
    }
}
