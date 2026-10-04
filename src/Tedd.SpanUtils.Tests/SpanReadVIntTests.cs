using System;
using System.IO;
using Xunit;
using Tedd;

namespace Tedd.Tests
{
    public class SpanReadVIntTests
    {
        public static TheoryData<byte[], int, ulong, ulong> ReadVIntSuccessData => new()
        {
            { new byte[] { 0x80 }, 1, 0x80, 0 },
            { new byte[] { 0xFF }, 1, 0xFF, 127 },
            { new byte[] { 0x40, 0x00 }, 2, 0x4000, 0 },
            { new byte[] { 0x7F, 0xFF }, 2, 0x7FFF, 16383 },
            { new byte[] { 0x20, 0x00, 0x00 }, 3, 0x200000, 0 },
            { new byte[] { 0x3F, 0xFF, 0xFF }, 3, 0x3FFFFF, 2097151 },
            { new byte[] { 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 }, 8, 0x0100000000000000, 0 },
            { new byte[] { 0x01, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF }, 8, 0x01FFFFFFFFFFFFFF, 72057594037927935 }
        };

        [Theory]
        [MemberData(nameof(ReadVIntSuccessData))]
        public void ReadVInt_ValidInput_Success(byte[] input, int expectedLength, ulong expectedEncodedValue, ulong expectedPayload)
        {
            var span = input.AsSpan();
            var result = span.ReadVInt();

            Assert.Equal(expectedLength, result.Length);
            Assert.Equal(expectedEncodedValue, result.EncodedValue);
            Assert.Equal(expectedPayload, result.Value);
        }

        [Fact]
        public void ReadVInt_EmptySpan_ThrowsInvalidDataException()
        {
            try
            {
                var span = Span<byte>.Empty;
                span.ReadVInt();
                Assert.Fail("Expected InvalidDataException");
            }
            catch (InvalidDataException) { }
        }

        [Fact]
        public void ReadVInt_InvalidMarker_ThrowsInvalidDataException()
        {
            try
            {
                var span = new byte[] { 0x00 }.AsSpan();
                span.ReadVInt();
                Assert.Fail("Expected InvalidDataException");
            }
            catch (InvalidDataException) { }
        }

        public static TheoryData<byte[]> ReadVIntIncompleteData => new()
        {
            new byte[] { 0x40 }, // Missing bytes
            new byte[] { 0x20, 0x00 }, // Missing bytes
            new byte[] { 0x01, 0x00, 0x00, 0x00 } // Missing bytes
        };

        [Theory]
        [MemberData(nameof(ReadVIntIncompleteData))]
        public void ReadVInt_IncompleteSpan_ThrowsInvalidDataException(byte[] input)
        {
            try
            {
                var span = input.AsSpan();
                span.ReadVInt();
                Assert.Fail("Expected InvalidDataException");
            }
            catch (InvalidDataException) { }
        }

        [Theory]
        [InlineData(9)]
        [InlineData(0)]
        [InlineData(-1)]
        public void ReadVInt_InvalidMaxLength_ThrowsArgumentOutOfRangeException(int maxLength)
        {
            try
            {
                var span = new byte[] { 0x80 }.AsSpan();
                span.ReadVInt(maxLength);
                Assert.Fail("Expected ArgumentOutOfRangeException");
            }
            catch (ArgumentOutOfRangeException) { }
        }

        [Fact]
        public void ReadVInt_ExceedsMaxLength_ThrowsInvalidDataException()
        {
            try
            {
                // 2-byte VInt, but maxLength is 1
                var span = new byte[] { 0x40, 0x00 }.AsSpan();
                span.ReadVInt(1);
                Assert.Fail("Expected InvalidDataException");
            }
            catch (InvalidDataException) { }
        }

        // --- TryReadVInt ---

        public static TheoryData<byte[], int, ulong, ulong> TryReadVIntSuccessData => new()
        {
            { new byte[] { 0x80 }, 1, 0x80, 0 },
            { new byte[] { 0x40, 0x00 }, 2, 0x4000, 0 }
        };

        [Theory]
        [MemberData(nameof(TryReadVIntSuccessData))]
        public void TryReadVInt_ValidInput_Success(byte[] input, int expectedLength, ulong expectedEncodedValue, ulong expectedPayload)
        {
            var span = input.AsSpan();
            var success = span.TryReadVInt(out var result);

            Assert.True(success);
            Assert.Equal(expectedLength, result.Length);
            Assert.Equal(expectedEncodedValue, result.EncodedValue);
            Assert.Equal(expectedPayload, result.Value);
        }

        [Fact]
        public void TryReadVInt_EmptySpan_ReturnsFalse()
        {
            var span = Span<byte>.Empty;
            var success = span.TryReadVInt(out var result);
            Assert.False(success);
        }

        [Fact]
        public void TryReadVInt_InvalidMarker_ReturnsFalse()
        {
            var span = new byte[] { 0x00 }.AsSpan();
            var success = span.TryReadVInt(out var result);
            Assert.False(success);
        }

        [Fact]
        public void TryReadVInt_IncompleteSpan_ReturnsFalse()
        {
            var span = new byte[] { 0x40 }.AsSpan(); // 2-byte VInt, but only 1 byte provided
            var success = span.TryReadVInt(out var result);
            Assert.False(success);
        }

        [Fact]
        public void TryReadVInt_ExceedsMaxLength_ReturnsFalse()
        {
            var span = new byte[] { 0x40, 0x00 }.AsSpan();
            var success = span.TryReadVInt(out var result, 1);
            Assert.False(success);
        }

        [Theory]
        [InlineData(9)]
        [InlineData(0)]
        [InlineData(-1)]
        public void TryReadVInt_InvalidMaxLength_ThrowsArgumentOutOfRangeException(int maxLength)
        {
            try
            {
                var span = new byte[] { 0x80 }.AsSpan();
                span.TryReadVInt(out _, maxLength);
                Assert.Fail("Expected ArgumentOutOfRangeException");
            }
            catch (ArgumentOutOfRangeException) { }
        }

        // --- MoveReadVInt ---

        [Fact]
        public void MoveReadVInt_ValidInput_SuccessAndMovesSpan()
        {
            var buffer = new byte[] { 0x80, 0xFF }; // 1-byte VInt followed by some data
            var span = buffer.AsSpan();
            var result = span.MoveReadVInt();

            Assert.Equal(1, result.Length);
            Assert.Equal(0x80UL, result.EncodedValue);
            Assert.Equal(0UL, result.Value);
            Assert.Equal(1, span.Length); // Span moved forward by 1 byte
            Assert.Equal(0xFF, span[0]);
        }

        // --- TryMoveReadVInt ---

        [Fact]
        public void TryMoveReadVInt_ValidInput_SuccessAndMovesSpan()
        {
            var buffer = new byte[] { 0x40, 0x00, 0xFF }; // 2-byte VInt followed by some data
            var span = buffer.AsSpan();
            var success = span.TryMoveReadVInt(out var result);

            Assert.True(success);
            Assert.Equal(2, result.Length);
            Assert.Equal(0x4000UL, result.EncodedValue);
            Assert.Equal(0UL, result.Value);
            Assert.Equal(1, span.Length); // Span moved forward by 2 bytes
            Assert.Equal(0xFF, span[0]);
        }

        [Fact]
        public void TryMoveReadVInt_InvalidInput_ReturnsFalseAndDoesNotMoveSpan()
        {
            var buffer = new byte[] { 0x40 }; // Incomplete 2-byte VInt
            var span = buffer.AsSpan();
            var success = span.TryMoveReadVInt(out var result);

            Assert.False(success);
            Assert.Equal(1, span.Length); // Span should not move
        }

        // --- ReadOnlySpan Overloads ---

        [Fact]
        public void ReadOnlySpan_ReadVInt_Success()
        {
            ReadOnlySpan<byte> span = new byte[] { 0x80 }.AsSpan();
            var result = span.ReadVInt();
            Assert.Equal(1, result.Length);
        }

        [Fact]
        public void ReadOnlySpan_TryReadVInt_Success()
        {
            ReadOnlySpan<byte> span = new byte[] { 0x80 }.AsSpan();
            Assert.True(span.TryReadVInt(out var result));
            Assert.Equal(1, result.Length);
        }

        [Fact]
        public void ReadOnlySpan_MoveReadVInt_Success()
        {
            ReadOnlySpan<byte> span = new byte[] { 0x80, 0xFF }.AsSpan();
            var result = span.MoveReadVInt();
            Assert.Equal(1, result.Length);
            Assert.Equal(1, span.Length);
        }

        [Fact]
        public void ReadOnlySpan_TryMoveReadVInt_Success()
        {
            ReadOnlySpan<byte> span = new byte[] { 0x80, 0xFF }.AsSpan();
            Assert.True(span.TryMoveReadVInt(out var result));
            Assert.Equal(1, result.Length);
            Assert.Equal(1, span.Length);
        }
    }
}
