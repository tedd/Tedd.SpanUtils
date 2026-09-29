using System;
using System.IO;
using Xunit;
using Tedd;

namespace Tedd.SpanUtilsTests
{
    public class SpanReadTests
    {
        [Theory]
        [InlineData(new byte[] { 0x80 }, 1, 0UL)]
        [InlineData(new byte[] { 0xFE }, 1, 126UL)]
        [InlineData(new byte[] { 0x40, 0x7F }, 2, 127UL)]
        [InlineData(new byte[] { 0x7F, 0xFE }, 2, 16382UL)]
        [InlineData(new byte[] { 0x20, 0x3F, 0xFF }, 3, 16383UL)]
        public void ReadVInt_ValidInput_Span(byte[] input, int expectedLength, ulong expectedPayload)
        {
            Span<byte> span = input.AsSpan();
            var result = span.ReadVInt();
            Assert.Equal(expectedLength, result.Length);
            Assert.Equal(expectedPayload, result.Value);
        }

        [Theory]
        [InlineData(new byte[] { 0x80 }, 1, 0UL)]
        [InlineData(new byte[] { 0xFE }, 1, 126UL)]
        [InlineData(new byte[] { 0x40, 0x7F }, 2, 127UL)]
        [InlineData(new byte[] { 0x7F, 0xFE }, 2, 16382UL)]
        [InlineData(new byte[] { 0x20, 0x3F, 0xFF }, 3, 16383UL)]
        public void ReadVInt_ValidInput_ReadOnlySpan(byte[] input, int expectedLength, ulong expectedPayload)
        {
            ReadOnlySpan<byte> span = input.AsSpan();
            var result = span.ReadVInt();
            Assert.Equal(expectedLength, result.Length);
            Assert.Equal(expectedPayload, result.Value);
        }

        [Theory]
        [InlineData(new byte[] { 0x80 }, 1, 0UL)]
        [InlineData(new byte[] { 0xFE }, 1, 126UL)]
        [InlineData(new byte[] { 0x40, 0x7F }, 2, 127UL)]
        [InlineData(new byte[] { 0x7F, 0xFE }, 2, 16382UL)]
        [InlineData(new byte[] { 0x20, 0x3F, 0xFF }, 3, 16383UL)]
        public void TryReadVInt_ValidInput_Span(byte[] input, int expectedLength, ulong expectedPayload)
        {
            Span<byte> span = input.AsSpan();
            var success = span.TryReadVInt(out var result);
            Assert.True(success);
            Assert.Equal(expectedLength, result.Length);
            Assert.Equal(expectedPayload, result.Value);
        }

        [Theory]
        [InlineData(new byte[] { 0x80 }, 1, 0UL)]
        [InlineData(new byte[] { 0xFE }, 1, 126UL)]
        [InlineData(new byte[] { 0x40, 0x7F }, 2, 127UL)]
        [InlineData(new byte[] { 0x7F, 0xFE }, 2, 16382UL)]
        [InlineData(new byte[] { 0x20, 0x3F, 0xFF }, 3, 16383UL)]
        public void TryReadVInt_ValidInput_ReadOnlySpan(byte[] input, int expectedLength, ulong expectedPayload)
        {
            ReadOnlySpan<byte> span = input.AsSpan();
            var success = span.TryReadVInt(out var result);
            Assert.True(success);
            Assert.Equal(expectedLength, result.Length);
            Assert.Equal(expectedPayload, result.Value);
        }

        [Fact]
        public void ReadVInt_InvalidInput_ThrowsInvalidDataException()
        {
            Span<byte> span = new byte[] { 0x00, 0x01 }.AsSpan();
            try { span.ReadVInt(); Assert.Fail("Expected InvalidDataException"); }
            catch (InvalidDataException) {}

            ReadOnlySpan<byte> roSpan = new byte[] { 0x00, 0x01 }.AsSpan();
            try { roSpan.ReadVInt(); Assert.Fail("Expected InvalidDataException"); }
            catch (InvalidDataException) {}
        }

        [Fact]
        public void TryReadVInt_InvalidInput_ReturnsFalse()
        {
            Span<byte> span = new byte[] { 0x00, 0x01 }.AsSpan();
            Assert.False(span.TryReadVInt(out _));

            ReadOnlySpan<byte> roSpan = new byte[] { 0x00, 0x01 }.AsSpan();
            Assert.False(roSpan.TryReadVInt(out _));
        }

        [Theory]
        [InlineData(new byte[] { 0x80 }, 1, 0UL)]
        [InlineData(new byte[] { 0xFE }, 1, 126UL)]
        [InlineData(new byte[] { 0x40, 0x7F }, 2, 127UL)]
        [InlineData(new byte[] { 0x7F, 0xFE }, 2, 16382UL)]
        [InlineData(new byte[] { 0x20, 0x3F, 0xFF }, 3, 16383UL)]
        public void MoveReadVInt_ValidInput_Span(byte[] input, int expectedLength, ulong expectedPayload)
        {
            Span<byte> span = input.AsSpan();
            var originalLength = span.Length;
            var result = span.MoveReadVInt();
            Assert.Equal(expectedLength, result.Length);
            Assert.Equal(expectedPayload, result.Value);
            Assert.Equal(originalLength - expectedLength, span.Length);
        }

        [Theory]
        [InlineData(new byte[] { 0x80 }, 1, 0UL)]
        [InlineData(new byte[] { 0xFE }, 1, 126UL)]
        [InlineData(new byte[] { 0x40, 0x7F }, 2, 127UL)]
        [InlineData(new byte[] { 0x7F, 0xFE }, 2, 16382UL)]
        [InlineData(new byte[] { 0x20, 0x3F, 0xFF }, 3, 16383UL)]
        public void MoveReadVInt_ValidInput_ReadOnlySpan(byte[] input, int expectedLength, ulong expectedPayload)
        {
            ReadOnlySpan<byte> span = input.AsSpan();
            var originalLength = span.Length;
            var result = span.MoveReadVInt();
            Assert.Equal(expectedLength, result.Length);
            Assert.Equal(expectedPayload, result.Value);
            Assert.Equal(originalLength - expectedLength, span.Length);
        }

        [Theory]
        [InlineData(new byte[] { 0x80 }, 1, 0UL)]
        [InlineData(new byte[] { 0xFE }, 1, 126UL)]
        [InlineData(new byte[] { 0x40, 0x7F }, 2, 127UL)]
        [InlineData(new byte[] { 0x7F, 0xFE }, 2, 16382UL)]
        [InlineData(new byte[] { 0x20, 0x3F, 0xFF }, 3, 16383UL)]
        public void TryMoveReadVInt_ValidInput_Span(byte[] input, int expectedLength, ulong expectedPayload)
        {
            Span<byte> span = input.AsSpan();
            var originalLength = span.Length;
            var success = span.TryMoveReadVInt(out var result);
            Assert.True(success);
            Assert.Equal(expectedLength, result.Length);
            Assert.Equal(expectedPayload, result.Value);
            Assert.Equal(originalLength - expectedLength, span.Length);
        }

        [Theory]
        [InlineData(new byte[] { 0x80 }, 1, 0UL)]
        [InlineData(new byte[] { 0xFE }, 1, 126UL)]
        [InlineData(new byte[] { 0x40, 0x7F }, 2, 127UL)]
        [InlineData(new byte[] { 0x7F, 0xFE }, 2, 16382UL)]
        [InlineData(new byte[] { 0x20, 0x3F, 0xFF }, 3, 16383UL)]
        public void TryMoveReadVInt_ValidInput_ReadOnlySpan(byte[] input, int expectedLength, ulong expectedPayload)
        {
            ReadOnlySpan<byte> span = input.AsSpan();
            var originalLength = span.Length;
            var success = span.TryMoveReadVInt(out var result);
            Assert.True(success);
            Assert.Equal(expectedLength, result.Length);
            Assert.Equal(expectedPayload, result.Value);
            Assert.Equal(originalLength - expectedLength, span.Length);
        }

        [Fact]
        public void MoveReadVInt_InvalidInput_ThrowsInvalidDataException_Span()
        {
            Span<byte> span = new byte[] { 0x00, 0x01 }.AsSpan();
            try { span.MoveReadVInt(); Assert.Fail("Expected InvalidDataException"); }
            catch (InvalidDataException) {}
        }

        [Fact]
        public void MoveReadVInt_InvalidInput_ThrowsInvalidDataException_ReadOnlySpan()
        {
            ReadOnlySpan<byte> span = new byte[] { 0x00, 0x01 }.AsSpan();
            try { span.MoveReadVInt(); Assert.Fail("Expected InvalidDataException"); }
            catch (InvalidDataException) {}
        }

        [Fact]
        public void TryMoveReadVInt_InvalidInput_ReturnsFalse_Span()
        {
            Span<byte> span = new byte[] { 0x00, 0x01 }.AsSpan();
            var originalLength = span.Length;
            Assert.False(span.TryMoveReadVInt(out _));
            Assert.Equal(originalLength, span.Length);
        }

        [Fact]
        public void TryMoveReadVInt_InvalidInput_ReturnsFalse_ReadOnlySpan()
        {
            ReadOnlySpan<byte> span = new byte[] { 0x00, 0x01 }.AsSpan();
            var originalLength = span.Length;
            Assert.False(span.TryMoveReadVInt(out _));
            Assert.Equal(originalLength, span.Length);
        }

        [Theory]
        [InlineData(new byte[] { 0x40, 0x7F }, 1)]
        [InlineData(new byte[] { 0x7F, 0xFE }, 1)]
        public void ReadVInt_ExceedsMaxLength_ThrowsInvalidDataException(byte[] input, int maxLength)
        {
            Span<byte> span = input.AsSpan();
            try { span.ReadVInt(maxLength); Assert.Fail("Expected InvalidDataException"); }
            catch (InvalidDataException) {}
        }

        [Theory]
        [InlineData(new byte[] { 0x40, 0x7F }, 1)]
        [InlineData(new byte[] { 0x7F, 0xFE }, 1)]
        public void TryReadVInt_ExceedsMaxLength_ReturnsFalse(byte[] input, int maxLength)
        {
            Span<byte> span = input.AsSpan();
            Assert.False(span.TryReadVInt(out _, maxLength));
        }
    }
}
