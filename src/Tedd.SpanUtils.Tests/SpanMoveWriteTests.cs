using System;
using Xunit;
using Tedd;

namespace Tedd.Tests
{
    public class SpanMoveWriteTests
    {
        [Theory]
        [InlineData(0, 1)]
        [InlineData(126, 1)]
        [InlineData(127, 2)]
        [InlineData(16382, 2)]
        [InlineData(16383, 3)]
        public void MoveWriteVInt_ValidInput_Success(ulong value, int expectedLength)
        {
            var buffer = new byte[8];
            var span = buffer.AsSpan();
            var result = span.MoveWriteVInt(value);

            Assert.Equal(expectedLength, result);
            Assert.Equal(8 - expectedLength, span.Length);
        }

        [Theory]
        [InlineData(0, 1, true)]
        [InlineData(126, 1, true)]
        [InlineData(127, 2, true)]
        [InlineData(16383, 3, true)]
        public void TryMoveWriteVInt_ValidInput_Success(ulong value, int expectedLength, bool expectedResult)
        {
            var buffer = new byte[8];
            var span = buffer.AsSpan();
            var result = span.TryMoveWriteVInt(value, out var length);

            Assert.Equal(expectedResult, result);
            Assert.Equal(expectedLength, length);
            Assert.Equal(8 - expectedLength, span.Length);
        }

        [Fact]
        public void TryMoveWriteVInt_BufferTooSmall_ReturnsFalse()
        {
            var buffer = new byte[1];
            var span = buffer.AsSpan();

            // Value 127 requires 2 bytes
            var result = span.TryMoveWriteVInt(127, out var length);

            Assert.False(result);
            Assert.Equal(0, length);
            Assert.Equal(1, span.Length); // Span should not move
        }
    }
}
