using System;
using System.IO;
using Xunit;
using Tedd;

namespace Tedd.SpanUtilsTests.Span
{
    public class SpanVIntTests
    {
        [Theory]
        [InlineData(new byte[] { 0x80 }, 1, 0x80ul, 0)]
        [InlineData(new byte[] { 0x81 }, 1, 0x81ul, 1)]
        [InlineData(new byte[] { 0xfe }, 1, 0xfeul, 126)]
        [InlineData(new byte[] { 0x40, 0x7f }, 2, 0x407ful, 127)]
        [InlineData(new byte[] { 0x40, 0x80 }, 2, 0x4080ul, 128)]
        [InlineData(new byte[] { 0x10, 0xDE, 0xFF, 0xAD }, 4, 0x10deffad, 0xdeffad)]
        public void MoveReadVInt_Span(byte[] bytes, int expectedLength, ulong expectedEncodedValue, ulong expectedValue)
        {
            var span = bytes.AsSpan();
            var origLength = span.Length;
            var result = span.MoveReadVInt(4);
            Assert.Equal(expectedLength, result.Length);
            Assert.Equal(expectedEncodedValue, result.EncodedValue);
            Assert.Equal(expectedValue, result.Value);
            Assert.Equal(origLength - expectedLength, span.Length);
        }

        [Theory]
        [InlineData(new byte[] { 0x80 }, 1, 0x80ul, 0)]
        [InlineData(new byte[] { 0x81 }, 1, 0x81ul, 1)]
        [InlineData(new byte[] { 0xfe }, 1, 0xfeul, 126)]
        [InlineData(new byte[] { 0x40, 0x7f }, 2, 0x407ful, 127)]
        [InlineData(new byte[] { 0x40, 0x80 }, 2, 0x4080ul, 128)]
        [InlineData(new byte[] { 0x10, 0xDE, 0xFF, 0xAD }, 4, 0x10deffad, 0xdeffad)]
        public void MoveReadVInt_ReadOnlySpan(byte[] bytes, int expectedLength, ulong expectedEncodedValue, ulong expectedValue)
        {
            ReadOnlySpan<byte> span = bytes.AsSpan();
            var origLength = span.Length;
            var result = span.MoveReadVInt(4);
            Assert.Equal(expectedLength, result.Length);
            Assert.Equal(expectedEncodedValue, result.EncodedValue);
            Assert.Equal(expectedValue, result.Value);
            Assert.Equal(origLength - expectedLength, span.Length);
        }

        [Theory]
        [InlineData(new byte[] { 0x80 }, 1, 0x80ul, 0)]
        [InlineData(new byte[] { 0x81 }, 1, 0x81ul, 1)]
        [InlineData(new byte[] { 0xfe }, 1, 0xfeul, 126)]
        [InlineData(new byte[] { 0x40, 0x7f }, 2, 0x407ful, 127)]
        [InlineData(new byte[] { 0x40, 0x80 }, 2, 0x4080ul, 128)]
        [InlineData(new byte[] { 0x10, 0xDE, 0xFF, 0xAD }, 4, 0x10deffad, 0xdeffad)]
        public void TryMoveReadVInt_Span(byte[] bytes, int expectedLength, ulong expectedEncodedValue, ulong expectedValue)
        {
            var span = bytes.AsSpan();
            var origLength = span.Length;
            var success = span.TryMoveReadVInt(out var result, 4);
            Assert.True(success);
            Assert.Equal(expectedLength, result.Length);
            Assert.Equal(expectedEncodedValue, result.EncodedValue);
            Assert.Equal(expectedValue, result.Value);
            Assert.Equal(origLength - expectedLength, span.Length);
        }

        [Theory]
        [InlineData(new byte[] { 0x80 }, 1, 0x80ul, 0)]
        [InlineData(new byte[] { 0x81 }, 1, 0x81ul, 1)]
        [InlineData(new byte[] { 0xfe }, 1, 0xfeul, 126)]
        [InlineData(new byte[] { 0x40, 0x7f }, 2, 0x407ful, 127)]
        [InlineData(new byte[] { 0x40, 0x80 }, 2, 0x4080ul, 128)]
        [InlineData(new byte[] { 0x10, 0xDE, 0xFF, 0xAD }, 4, 0x10deffad, 0xdeffad)]
        public void TryMoveReadVInt_ReadOnlySpan(byte[] bytes, int expectedLength, ulong expectedEncodedValue, ulong expectedValue)
        {
            ReadOnlySpan<byte> span = bytes.AsSpan();
            var origLength = span.Length;
            var success = span.TryMoveReadVInt(out var result, 4);
            Assert.True(success);
            Assert.Equal(expectedLength, result.Length);
            Assert.Equal(expectedEncodedValue, result.EncodedValue);
            Assert.Equal(expectedValue, result.Value);
            Assert.Equal(origLength - expectedLength, span.Length);
        }

        [Theory]
        [InlineData(0, 1)]
        [InlineData(1, 1)]
        [InlineData(126, 1)]
        [InlineData(127, 2)]
        [InlineData(128, 2)]
        [InlineData(0xdeffad, 4)]
        public void MoveWriteVInt_Span(ulong value, int expectedLength)
        {
            var bytes = new byte[8];
            var span = bytes.AsSpan();
            var origLength = span.Length;
            var length = span.MoveWriteVInt(value);
            Assert.Equal(expectedLength, length);
            Assert.Equal(origLength - expectedLength, span.Length);

            var readSpan = bytes.AsSpan();
            var readResult = readSpan.ReadVInt(8);
            Assert.Equal(value, readResult.Value);
        }

        [Theory]
        [InlineData(0, 1)]
        [InlineData(1, 1)]
        [InlineData(126, 1)]
        [InlineData(127, 2)]
        [InlineData(128, 2)]
        [InlineData(0xdeffad, 4)]
        public void TryMoveWriteVInt_Span(ulong value, int expectedLength)
        {
            var bytes = new byte[8];
            var span = bytes.AsSpan();
            var origLength = span.Length;
            var success = span.TryMoveWriteVInt(value, out var length);
            Assert.True(success);
            Assert.Equal(expectedLength, length);
            Assert.Equal(origLength - expectedLength, span.Length);

            var readSpan = bytes.AsSpan();
            var readResult = readSpan.ReadVInt(8);
            Assert.Equal(value, readResult.Value);
        }

        [Theory]
        [InlineData(0, 0)]
        [InlineData(127, 1)]
        [InlineData(0xdeffad, 3)]
        public void TryMoveWriteVInt_Span_InsufficientSpace(ulong value, int bufferSize)
        {
            var bytes = new byte[bufferSize];
            var span = bytes.AsSpan();
            var origLength = span.Length;
            var success = span.TryMoveWriteVInt(value, out var length);
            Assert.False(success);
            Assert.Equal(0, length);
            Assert.Equal(origLength, span.Length);
        }

        [Theory]
        [InlineData(new byte[] { 0x40 }, 4)]
        [InlineData(new byte[] { 0x01 }, 8)]
        public void TryMoveReadVInt_Span_InsufficientData(byte[] bytes, int maxLength)
        {
            var span = bytes.AsSpan();
            var origLength = span.Length;
            var success = span.TryMoveReadVInt(out var result, maxLength);
            Assert.False(success);
            Assert.Equal(0, result.Length);
            Assert.Equal(origLength, span.Length);
        }

        [Theory]
        [InlineData(new byte[] { 0x40 }, 4)]
        [InlineData(new byte[] { 0x01 }, 8)]
        public void TryMoveReadVInt_ReadOnlySpan_InsufficientData(byte[] bytes, int maxLength)
        {
            ReadOnlySpan<byte> span = bytes.AsSpan();
            var origLength = span.Length;
            var success = span.TryMoveReadVInt(out var result, maxLength);
            Assert.False(success);
            Assert.Equal(0, result.Length);
            Assert.Equal(origLength, span.Length);
        }

        [Fact]
        public void TryMoveReadVInt_Span_Empty()
        {
            var bytes = new byte[0];
            var span = bytes.AsSpan();
            var success = span.TryMoveReadVInt(out var result);
            Assert.False(success);
        }

        [Fact]
        public void TryMoveReadVInt_ReadOnlySpan_Empty()
        {
            var bytes = new byte[0];
            ReadOnlySpan<byte> span = bytes.AsSpan();
            var success = span.TryMoveReadVInt(out var result);
            Assert.False(success);
        }

        [Fact]
        public void TryMoveReadVInt_Span_ZeroByte()
        {
            var bytes = new byte[] { 0x00, 0x00 };
            var span = bytes.AsSpan();
            var success = span.TryMoveReadVInt(out var result);
            Assert.False(success);
        }

        [Fact]
        public void TryMoveReadVInt_ReadOnlySpan_ZeroByte()
        {
            var bytes = new byte[] { 0x00, 0x00 };
            ReadOnlySpan<byte> span = bytes.AsSpan();
            var success = span.TryMoveReadVInt(out var result);
            Assert.False(success);
        }

        [Fact]
        public void MoveReadVInt_Span_Throws()
        {
            var bytes = new byte[] { 0x40 };
            bool threw = false;
            try
            {
                var span = bytes.AsSpan();
                span.MoveReadVInt();
            }
            catch (InvalidDataException)
            {
                threw = true;
            }
            Assert.True(threw);
        }

        [Fact]
        public void MoveReadVInt_ReadOnlySpan_Throws()
        {
            var bytes = new byte[] { 0x40 };
            bool threw = false;
            try
            {
                ReadOnlySpan<byte> span = bytes.AsSpan();
                span.MoveReadVInt();
            }
            catch (InvalidDataException)
            {
                threw = true;
            }
            Assert.True(threw);
        }
    }
}
