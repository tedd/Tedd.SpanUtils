using System;
using Xunit;
using Tedd;

namespace Tedd.Tests
{
    public class SpanMoveWriteTests
    {
        [Theory]
        [InlineData(0ul, 1)]
        [InlineData(126ul, 1)]
        [InlineData(127ul, 2)]
        [InlineData(0x00FFFFFFFFFFFFFEUL, 8)]
        public void MoveWriteVInt_ValidValues_WritesAndSlices(ulong value, int expectedLength)
        {
            var buffer = new byte[10];
            var span = buffer.AsSpan();
            var originalLength = span.Length;

            var length = span.MoveWriteVInt(value);

            Assert.Equal(expectedLength, length);
            Assert.Equal(originalLength - expectedLength, span.Length);
        }

        [Theory]
        [InlineData(0ul, 1, true)]
        [InlineData(126ul, 1, true)]
        [InlineData(127ul, 2, true)]
        [InlineData(0x00FFFFFFFFFFFFFEUL, 8, true)]
        [InlineData(0ul, 0, false)] // buffer too small
        [InlineData(127ul, 1, false)] // buffer too small
        [InlineData(0x00FFFFFFFFFFFFFEUL, 7, false)] // buffer too small
        public void TryMoveWriteVInt_VariousValues_SlicesIfSuccessful(ulong value, int bufferSize, bool expectedSuccess)
        {
            var buffer = new byte[bufferSize];
            var span = buffer.AsSpan();
            var originalLength = span.Length;

            var success = span.TryMoveWriteVInt(value, out int length);

            Assert.Equal(expectedSuccess, success);
            if (success)
            {
                Assert.True(length > 0);
                Assert.Equal(originalLength - length, span.Length);
            }
            else
            {
                Assert.Equal(0, length);
                Assert.Equal(originalLength, span.Length);
            }
        }
    }
}
