using System;
using Xunit;
using Tedd;

namespace Tedd.Tests
{
    public class SpanMoveWriteTests
    {
        [Theory]
        [InlineData(0ul, 1, new byte[] { 0x80 })]
        [InlineData(126ul, 1, new byte[] { 0xFE })]
        [InlineData(127ul, 2, new byte[] { 0x40, 0x7F })]
        [InlineData(16382ul, 2, new byte[] { 0x7F, 0xFE })]
        [InlineData(16383ul, 3, new byte[] { 0x20, 0x3F, 0xFF })]
        [InlineData(2097150ul, 3, new byte[] { 0x3F, 0xFF, 0xFE })]
        [InlineData(2097151ul, 4, new byte[] { 0x10, 0x1F, 0xFF, 0xFF })]
        [InlineData(268435454ul, 4, new byte[] { 0x1F, 0xFF, 0xFF, 0xFE })]
        [InlineData(268435455ul, 5, new byte[] { 0x08, 0x0F, 0xFF, 0xFF, 0xFF })]
        [InlineData(34359738366ul, 5, new byte[] { 0x0F, 0xFF, 0xFF, 0xFF, 0xFE })]
        [InlineData(34359738367ul, 6, new byte[] { 0x04, 0x07, 0xFF, 0xFF, 0xFF, 0xFF })]
        [InlineData(4398046511102ul, 6, new byte[] { 0x07, 0xFF, 0xFF, 0xFF, 0xFF, 0xFE })]
        [InlineData(4398046511103ul, 7, new byte[] { 0x02, 0x03, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF })]
        [InlineData(562949953421310ul, 7, new byte[] { 0x03, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFE })]
        [InlineData(562949953421311ul, 8, new byte[] { 0x01, 0x01, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF })]
        [InlineData(72057594037927934ul, 8, new byte[] { 0x01, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFE })]
        // 72057594037927935 (max 56-bit payload) is the reserved all-ones value and throws ArgumentOutOfRangeException.
        public void MoveWriteVInt_ValidInput_WritesExpectedBytesAndMoves(ulong value, int expectedLength, byte[] expectedBytes)
        {
            byte[] buffer = new byte[10];
            Span<byte> span = buffer;
            Span<byte> originalSpan = span;

            int bytesWritten = span.MoveWriteVInt(value);

            Assert.Equal(expectedLength, bytesWritten);
            Assert.Equal(originalSpan.Length - expectedLength, span.Length);

            for (int i = 0; i < expectedBytes.Length; i++)
            {
                Assert.Equal(expectedBytes[i], buffer[i]);
            }
        }

        [Theory]
        [InlineData(0ul, 1, new byte[] { 0x80 })]
        [InlineData(126ul, 1, new byte[] { 0xFE })]
        [InlineData(127ul, 2, new byte[] { 0x40, 0x7F })]
        [InlineData(16382ul, 2, new byte[] { 0x7F, 0xFE })]
        [InlineData(72057594037927934ul, 8, new byte[] { 0x01, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFE })]
        public void TryMoveWriteVInt_ValidInput_ReturnsTrueWritesExpectedBytesAndMoves(ulong value, int expectedLength, byte[] expectedBytes)
        {
            byte[] buffer = new byte[10];
            Span<byte> span = buffer;
            Span<byte> originalSpan = span;

            bool success = span.TryMoveWriteVInt(value, out int bytesWritten);

            Assert.True(success);
            Assert.Equal(expectedLength, bytesWritten);
            Assert.Equal(originalSpan.Length - expectedLength, span.Length);

            for (int i = 0; i < expectedBytes.Length; i++)
            {
                Assert.Equal(expectedBytes[i], buffer[i]);
            }
        }

        [Theory]
        [InlineData(0ul, 0)]
        [InlineData(127ul, 1)]
        [InlineData(16383ul, 2)]
        [InlineData(2097151ul, 3)]
        [InlineData(72057594037927934ul, 7)]
        public void TryMoveWriteVInt_BufferTooSmall_ReturnsFalseAndDoesNotMove(ulong value, int bufferSize)
        {
            byte[] buffer = new byte[bufferSize];
            Span<byte> span = buffer;
            Span<byte> originalSpan = span;

            bool success = span.TryMoveWriteVInt(value, out int bytesWritten);

            Assert.False(success);
            Assert.Equal(0, bytesWritten);
            Assert.Equal(originalSpan.Length, span.Length);
        }
    }
}
