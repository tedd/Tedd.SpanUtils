using Xunit;
using Tedd;
using System;

namespace Tedd.Tests
{
    public class VIntTests
    {
        [Theory]
        [InlineData(1, 0x80ul, 0ul, 1)]
        [InlineData(1, 0x81ul, 1ul, 1)]
        [InlineData(1, 0xfeul, 126ul, 1)]
        [InlineData(2, 0x407ful, 127, 2)]
        [InlineData(2, 0x4080ul, 128, 2)]
        [InlineData(4, 0x10deffad, 0xdeffad, 4)]
        public void Constructor_And_Properties(int length, ulong encoded, ulong value, int expectedSize)
        {
            var vint = new VInt(length, encoded, value);
            Assert.Equal(length, vint.Length);
            Assert.Equal(encoded, vint.EncodedValue);
            Assert.Equal(value, vint.Value);
            Assert.Equal(expectedSize, vint.Size);
        }

        [Theory]
        [InlineData(0ul, 1)]
        [InlineData(126ul, 1)]
        [InlineData(127ul, 2)]
        [InlineData(128ul, 2)]
        [InlineData(16383ul, 3)]
        [InlineData(0xdeffadul, 4)]
        // [InlineData(ulong.MaxValue, 1)]
        public void GetSize_ReturnsExpected(ulong value, int expectedSize)
        {
            Assert.Equal(expectedSize, VInt.GetSize(value));
        }

        [Fact]
        public void ToString_ReturnsExpected()
        {
            var vint = new VInt(1, 0x81ul, 1);
            Assert.Equal("VInt, value = 1, length = 1, encoded = 81", vint.ToString());
        }
    }
}
