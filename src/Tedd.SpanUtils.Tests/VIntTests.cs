using System;
using System.IO;
using Tedd;
using Xunit;

namespace Tedd.Tests
{
    public class VIntTests
    {
        [Theory]
        [InlineData(0)]
        [InlineData(4)]
        public void ReadVInt_EmptySpan_ThrowsInvalidDataException(int maxLength)
        {
            var span = Span<byte>.Empty;
            bool threw = false;
            try
            {
                span.ReadVInt(maxLength);
            }
            catch (InvalidDataException)
            {
                threw = true;
            }
            Assert.True(threw);
        }

        [Theory]
        [InlineData(new byte[] { 0x00, 0x00, 0x00, 0x00 }, 4)]
        [InlineData(new byte[] { 0x08, 0x00 }, 2)]
        public void ReadVInt_InvalidVInt_ThrowsInvalidDataException(byte[] bytes, int maxLength)
        {
            var span = bytes.AsSpan();
            bool threw = false;
            try
            {
                span.ReadVInt(maxLength);
            }
            catch (InvalidDataException)
            {
                threw = true;
            }
            Assert.True(threw);
        }

        [Theory]
        [InlineData(1, 0x81ul, 1ul, "VInt, value = 1, length = 1, encoded = 81")]
        [InlineData(4, 0x10DEFFADul, 0xDEFFADul, "VInt, value = 14614445, length = 4, encoded = 10DEFFAD")]
        [InlineData(2, 0x407ful, 127ul, "VInt, value = 127, length = 2, encoded = 407F")]
        public void VInt_ToString_ReturnsExpectedFormat(int length, ulong encoded, ulong value, string expected)
        {
            var vint = new VInt(length, encoded, value);
            Assert.Equal(expected, vint.ToString());
        }
    }
}
