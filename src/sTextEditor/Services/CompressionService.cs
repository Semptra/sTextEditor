using System;
using System.IO;
using System.IO.Compression;

namespace sTextEditor.Services
{
    public sealed class CompressionService
    {
        public byte[] Compress(byte[] data)
        {
            using (var result = new MemoryStream())
            {
                var lengthBytes = BitConverter.GetBytes(data.Length);
                result.Write(lengthBytes, 0, 4);

                using (var compressionStream = new GZipStream(result, CompressionMode.Compress))
                {
                    compressionStream.Write(data, 0, data.Length);
                    compressionStream.Flush();
                }

                return result.ToArray();
            }
        }

        public byte[] Decompress(byte[] data)
        {
            using (var source = new MemoryStream(data))
            {
                byte[] lengthBytes = new byte[4];
                source.Read(lengthBytes, 0, 4);

                var length = BitConverter.ToInt32(lengthBytes, 0);

                using (var decompressionStream = new GZipStream(source, CompressionMode.Decompress))
                {
                    var result = new byte[length];
                    decompressionStream.Read(result, 0, length);
                    return result;
                }
            }
        }
    }
}
