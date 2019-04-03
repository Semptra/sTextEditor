using System;
using System.Collections;
using System.Linq;
using NUnit.Framework;
using sTextEditor.Services;

namespace sTextEditor.Tests.Services
{
    [TestFixture]
    public class CompressionServiceTest
    {
        [Test]
        [TestCaseSource(typeof(CompressionServiceDataFactory), "SampleSmallRandomData")]
        public void CompressAndDecompressToSameResultTest(byte[] data)
        {
            var compressionService = new CompressionService();
            var compressedData = compressionService.Compress(data);
            var decompressedData = compressionService.Decompress(compressedData);

            Assert.True(data.SequenceEqual(decompressedData));
        }

        [Test]
        [TestCaseSource(typeof(CompressionServiceDataFactory), "SampleLargeRandomData")]
        public void CompressedDataSmallerThenOriginalTest(byte[] data)
        {
            var compressionService = new CompressionService();
            var compressedData = compressionService.Compress(data);

            var originalDataSize = data.Length * sizeof(byte);
            var compressedDataSize = compressedData.Length * sizeof(byte);

            Assert.LessOrEqual(compressedDataSize, compressedDataSize,
                "Compressed data size ({0}) is greater then original ({1}).",
                compressedDataSize, originalDataSize);
        }
    }

    public class CompressionServiceDataFactory
    {
        private static Random random = new Random();

        public static IEnumerable SampleSmallRandomData
        {
            get
            {
                for(int i = 0; i < 10; i++)
                {
                    yield return GenerateRandomBytes(100);
                }
            }
        }

        public static IEnumerable SampleLargeRandomData
        {
            get
            {
                for (int i = 0; i < 10; i++)
                {
                    yield return GenerateRandomBytes(10000);
                }
            }
        }

        private static byte[] GenerateRandomBytes(int size)
        {
            var data = new byte[size];
            random.NextBytes(data);
            return data;
        }
    }
}
