using System;
using Xunit;
using Tedd;

namespace Tedd.SpanUtilsTests
{
    public class SpanMoveWriteTests
    {
        [Theory]
        [InlineData(0UL, 1, new byte[] { 0x80 })]
        [InlineData(126UL, 1, new byte[] { 0xFE })]
        [InlineData(127UL, 2, new byte[] { 0x40, 0x7F })]
        [InlineData(16382UL, 2, new byte[] { 0x7F, 0xFE })]
        [InlineData(16383UL, 3, new byte[] { 0x20, 0x3F, 0xFF })]
        [InlineData(16384UL, 3, new byte[] { 0x20, 0x40, 0x00 })]
        public void MoveWriteVInt_ValidInput_MovesSpan(ulong value, int expectedLength, byte[] expectedBytes)
        {
            var buffer = new byte[10];
            var span = buffer.AsSpan();
            var originalLength = span.Length;

            var result = span.MoveWriteVInt(value);

            Assert.Equal(expectedLength, result);
            Assert.Equal(originalLength - expectedLength, span.Length);
            Assert.True(buffer.AsSpan(0, expectedLength).SequenceEqual(expectedBytes));
        }

        [Theory]
        [InlineData(0UL, 1, new byte[] { 0x80 })]
        [InlineData(126UL, 1, new byte[] { 0xFE })]
        [InlineData(127UL, 2, new byte[] { 0x40, 0x7F })]
        [InlineData(16382UL, 2, new byte[] { 0x7F, 0xFE })]
        [InlineData(16383UL, 3, new byte[] { 0x20, 0x3F, 0xFF })]
        [InlineData(16384UL, 3, new byte[] { 0x20, 0x40, 0x00 })]
        public void TryMoveWriteVInt_ValidInput_MovesSpan(ulong value, int expectedLength, byte[] expectedBytes)
        {
            var buffer = new byte[10];
            var span = buffer.AsSpan();
            var originalLength = span.Length;

            var success = span.TryMoveWriteVInt(value, out var resultLength);

            Assert.True(success);
            Assert.Equal(expectedLength, resultLength);
            Assert.Equal(originalLength - expectedLength, span.Length);
            Assert.True(buffer.AsSpan(0, expectedLength).SequenceEqual(expectedBytes));
        }

        [Theory]
        [InlineData(127UL, 1)]
        [InlineData(16384UL, 2)]
        [InlineData(ulong.MaxValue, 8)]
        public void TryMoveWriteVInt_BufferTooSmall_ReturnsFalseAndDoesNotMoveSpan(ulong value, int bufferSize)
        {
            var buffer = new byte[bufferSize];
            var span = buffer.AsSpan();
            var originalLength = span.Length;

            var success = span.TryMoveWriteVInt(value, out var resultLength);

            Assert.False(success);
            Assert.Equal(0, resultLength);
            Assert.Equal(originalLength, span.Length);
        }
    }
}
