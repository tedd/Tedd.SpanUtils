using System;
using System.Buffers.Binary;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using Xunit;

namespace Tedd.SpanUtilsTests
{
    public class CoreV2Tests
    {
        [Fact]
        public void ExplicitEndianUsesWireOrderAndPreservesFloatBits()
        {
            Span<byte> bytes = stackalloc byte[16];
            bytes.WriteBE(0x0123456789ABCDEFUL);
            Assert.Equal(new byte[] { 1, 35, 69, 103, 137, 171, 205, 239 }, bytes.Slice(0, 8).ToArray());
            Assert.Equal(0x0123456789ABCDEFUL, bytes.ReadUInt64BE());
            bytes.WriteLE(0x0123456789ABCDEFUL);
            Assert.Equal(new byte[] { 239, 205, 171, 137, 103, 69, 35, 1 }, bytes.Slice(0, 8).ToArray());
            bytes.WriteBE('\u1234');
            Assert.Equal(new byte[] { 0x12, 0x34 }, bytes.Slice(0, 2).ToArray());
            Assert.Equal('\u1234', bytes.ReadCharBE());
            foreach (var bits in new[] { 0, int.MinValue, 0x7F800000, unchecked((int)0xFF800000), 0x7FC12345 })
            {
                bytes.WriteBE(BitConverter.Int32BitsToSingle(bits));
                Assert.Equal(bits, BitConverter.SingleToInt32Bits(bytes.ReadSingleBE()));
            }
        }

        [Fact]
        public void GuidBigEndianMatchesRfcAndDefaultMatchesDotNet()
        {
            var value = Guid.Parse("00112233-4455-6677-8899-aabbccddeeff");
            Span<byte> bytes = stackalloc byte[16];
            bytes.WriteBE(value);
            Assert.Equal(new byte[] { 0, 0x11, 0x22, 0x33, 0x44, 0x55, 0x66, 0x77, 0x88, 0x99, 0xAA, 0xBB, 0xCC, 0xDD, 0xEE, 0xFF }, bytes.ToArray());
            Assert.Equal(value, bytes.ReadGuidBE());
            bytes.Write(value);
            Assert.Equal(value.ToByteArray(), bytes.ToArray());
            Assert.Equal(value, bytes.ReadGuidLE());
        }

        [Fact]
        public void DecimalPortableFormatsMatchDocumentedWords()
        {
            Span<byte> bytes = stackalloc byte[16];
            var values = new[] { decimal.MinValue, decimal.MaxValue, 0m, -1m, 123.4500m, new decimal(0, 0, 0, true, 28) };
            foreach (var value in values)
            {
                bytes.Write(value);
                Assert.Equal(value, bytes.ReadDecimal());
                bytes.WriteLE(value);
                var bits = decimal.GetBits(value);
                for (var index = 0; index < 4; index++)
                    Assert.Equal(bits[index], BinaryPrimitives.ReadInt32LittleEndian(bytes.Slice(index * 4)));
                Assert.Equal(bits, decimal.GetBits(bytes.ReadDecimalLE()));
                bytes.WriteBE(value);
                for (var index = 0; index < 4; index++)
                    Assert.Equal(bits[index], BinaryPrimitives.ReadInt32BigEndian(bytes.Slice(index * 4)));
                Assert.Equal(bits, decimal.GetBits(bytes.ReadDecimalBE()));
            }
            bytes.Clear();
            bytes[12] = 1;
            Assert.False(bytes.TryReadDecimalBE(out _, out var consumed));
            Assert.Equal(0, consumed);
            var malformed = bytes.ToArray();
            Assert.Throws<InvalidDataException>(() => SpanUtils.ReadDecimalBE(malformed));
        }

        [Theory]
        [InlineData(-8388608)]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(8388607)]
        public void Signed24RoundTripsWithExactlyThreeBytes(int value)
        {
            Span<byte> bytes = stackalloc byte[4];
            bytes[3] = 0xA5;
            bytes.WriteInt24LE(value, out var written);
            Assert.Equal(3, written);
            Assert.Equal(value, bytes.ReadInt24LE());
            bytes.WriteInt24BE(value);
            Assert.Equal(value, bytes.ReadInt24BE());
            Assert.Equal(0xA5, bytes[3]);
        }

        [Fact]
        public void FailedTryOperationsPreserveDataAndCursor()
        {
            var buffer = Enumerable.Repeat((byte)0xA5, 4).ToArray();
            Span<byte> cursor = buffer;
            Assert.False(cursor.TryMoveWrite(ulong.MaxValue, out var written));
            Assert.Equal(0, written);
            Assert.Equal(4, cursor.Length);
            Assert.False(cursor.TryMoveReadUInt64(out _, out var consumed));
            Assert.Equal(0, consumed);
            Assert.Equal(4, cursor.Length);
            Assert.False(cursor.TryWriteInt24(8388608));
            Assert.False(cursor.TryWriteVLQ(ulong.MaxValue));
            Assert.False(cursor.TryWriteSized("more than four bytes"));
            Assert.Equal(Enumerable.Repeat((byte)0xA5, 4), buffer);
            Assert.False(cursor.TryReadBytes(-1, out _));
        }

        [Fact]
        public void NativeReadsRejectShortBuffers()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => SpanUtils.ReadInt64(new byte[7]));
            Assert.Throws<ArgumentOutOfRangeException>(() => SpanUtils.ReadUInt32(new byte[3]));
            Assert.Throws<ArgumentOutOfRangeException>(() => SpanUtils.Write(new byte[7], 42L));
        }

        [Fact]
        public void SignedMinimaAdvanceByOneByte()
        {
            Span<byte> bytes = stackalloc byte[3];
            var writer = bytes;
            writer.MoveWriteVLQ(short.MinValue);
            writer.MoveWriteVLQ(int.MinValue);
            writer.MoveWriteVLQ(long.MinValue);
            Assert.True(writer.IsEmpty);
            Assert.Equal(new byte[] { 0x40, 0x40, 0x40 }, bytes.ToArray());
            ReadOnlySpan<byte> reader = bytes;
            Assert.Equal(short.MinValue, reader.MoveReadVLQInt16());
            Assert.Equal(int.MinValue, reader.MoveReadVLQInt32());
            Assert.Equal(long.MinValue, reader.MoveReadVLQInt64());
            Assert.True(reader.IsEmpty);
        }

        [Fact]
        public void VlqRejectsTruncatedAndOverflowingInputsWithoutAdvancing()
        {
            var invalid = new[] { new byte[] { 0x80 }, new byte[] { 0xFF, 0xFF, 4 }, Enumerable.Repeat((byte)0x80, 10).ToArray() };
            foreach (var bytes in invalid)
            {
                ReadOnlySpan<byte> cursor = bytes;
                Assert.False(cursor.TryMoveReadVLQUInt16(out _, out var length));
                Assert.Equal(0, length);
                Assert.Equal(bytes.Length, cursor.Length);
            }
            Assert.Throws<EndOfStreamException>(() => SpanUtils.ReadVLQUInt32(new byte[] { 0x80 }));
            Assert.Throws<OverflowException>(() => SpanUtils.ReadVLQUInt16(new byte[] { 0xFF, 0xFF, 4 }));
            var unsigned64Overflow = Enumerable.Repeat((byte)0xFF, 10).ToArray();
            unsigned64Overflow[9] = 2;
            Assert.False(SpanUtils.TryReadVLQUInt64(unsigned64Overflow, out _));
            Assert.False(SpanUtils.TryReadVLQInt64(unsigned64Overflow, out _));
            Assert.Throws<OverflowException>(() => SpanUtils.ReadVLQUInt64(unsigned64Overflow));
        }

        [Fact]
        public void VlqMeasuresAndRoundTripsAllWidthBoundaries()
        {
            Span<byte> bytes = stackalloc byte[10];
            for (var bit = 0; bit < 64; bit++)
            {
                foreach (var value in new[] { (1UL << bit) - 1, 1UL << bit, (1UL << bit) + 1 })
                {
                    bytes.WriteVLQ(value, out var length);
                    Assert.Equal((int)SpanUtils.MeasureVLQ(value), length);
                    Assert.Equal(value, bytes.ReadVLQUInt64(out var consumed));
                    Assert.Equal(length, consumed);
                }
            }
            foreach (var value in new[] { long.MinValue, long.MinValue + 1, -8192, -64, -63, -1, 0, 1, 63, 64, 8192, long.MaxValue })
            {
                bytes.WriteVLQ(value, out var length);
                Assert.Equal((int)SpanUtils.MeasureVLQ(value), length);
                Assert.Equal(value, bytes.ReadVLQInt64(out var consumed));
                Assert.Equal(length, consumed);
            }
        }

        [Fact]
        public void SizedSpanReadsAreZeroCopyAndOverlappingWritesAreSafe()
        {
            var bytes = new byte[] { 10, 20, 30, 40, 0, 0 };
            Span<byte> span = bytes;
            span.WriteSized(span.Slice(0, 4), out var written);
            Assert.Equal(5, written);
            Assert.Equal(new byte[] { 4, 10, 20, 30, 40, 0 }, bytes);
            var payload = span.ReadSizedSpan(out var length);
            payload[0] = 99;
            Assert.Equal(99, bytes[1]);
            Assert.Equal(5, length);
            Assert.Equal(new byte[] { 4, 99 }, span.ReadBytes(2));
            ReadOnlySpan<byte> truncated = new byte[] { 4, 1, 2 };
            Assert.False(truncated.TryMoveReadSizedReadOnlySpan(out _, out var consumed));
            Assert.Equal(0, consumed);
            Assert.Equal(3, truncated.Length);
        }

        [Fact]
        public void RawUtf8StringUsesByteLengthAndPreservesDestinationOnFailure()
        {
            Span<byte> bytes = stackalloc byte[64];
            const string value = "Latin · Ελληνικά · 😀";
            bytes.WriteString(value, out var length);
            Assert.Equal(System.Text.Encoding.UTF8.GetByteCount(value), length);
            Assert.Equal(value, bytes.ReadString(length));
            Assert.True(bytes.TryReadString(length, out var decoded));
            Assert.Equal(value, decoded);
            Span<byte> tooSmall = stackalloc byte[1];
            tooSmall[0] = 0xA5;
            Assert.False(tooSmall.TryWriteString("😀"));
            Assert.Equal(0xA5, tooSmall[0]);
        }

        [Fact]
        public void VintBoundariesUnknownMarkersAndMalformedInputs()
        {
            Span<byte> bytes = stackalloc byte[8];
            for (var size = 1; size <= 8; size++)
            {
                var value = (1UL << (size * 7)) - 2;
                Assert.Equal(size, VInt.GetSize(value));
                Assert.Equal(size, bytes.WriteVInt(value));
                var decoded = bytes.ReadVInt();
                Assert.Equal(value, decoded.Value);
                Assert.Equal(size, decoded.Length);
                Assert.False(decoded.IsUnknown);
            }
            Assert.True(SpanUtils.ReadVInt(new byte[] { 0xFF }).IsUnknown);
            Assert.False(SpanUtils.TryReadVInt(new byte[] { 0 }, out _));
            Assert.False(SpanUtils.TryReadVInt(new byte[] { 1 }, out _));
            Assert.Throws<ArgumentOutOfRangeException>(() => VInt.GetSize(ulong.MaxValue));
            Assert.Throws<ArgumentOutOfRangeException>(() => VInt.GetSize(VInt.MaxValue + 1));
            Assert.False(bytes.TryWriteVInt(ulong.MaxValue, out _));
            ReadOnlySpan<byte> cursor = new byte[] { 0x40 };
            Assert.False(cursor.TryMoveReadVInt(out _));
            Assert.Equal(1, cursor.Length);
        }

#if NET6_0_OR_GREATER && !STANDARD_ASSET
        [Fact]
        public void HalfPreservesEveryBitPatternInBothOrders()
        {
            Span<byte> bytes = stackalloc byte[2];
            for (var bits = 0; bits <= ushort.MaxValue; bits++)
            {
                var value = BitConverter.Int16BitsToHalf((short)bits);
                bytes.WriteLE(value);
                Assert.Equal((short)bits, BitConverter.HalfToInt16Bits(bytes.ReadHalfLE()));
                bytes.WriteBE(value);
                Assert.Equal((short)bits, BitConverter.HalfToInt16Bits(bytes.ReadHalfBE()));
            }
        }
#endif
#if NET7_0_OR_GREATER && !STANDARD_ASSET
        [Fact]
        public void Int128UsesAllSixteenBytesInBothOrders()
        {
            Span<byte> bytes = stackalloc byte[16];
            foreach (var value in new[] { Int128.MinValue, -1, Int128.Zero, Int128.MaxValue })
            {
                bytes.WriteLE(value);
                Assert.Equal(value, bytes.ReadInt128LE());
                Assert.Equal(value, BinaryPrimitives.ReadInt128LittleEndian(bytes));
                bytes.WriteBE(value);
                Assert.Equal(value, bytes.ReadInt128BE());
            }
            bytes.WriteBE(UInt128.MaxValue);
            Assert.True(bytes.ToArray().All(value => value == 255));
            Assert.Equal(UInt128.MaxValue, bytes.ReadUInt128BE());
        }
#endif
    }
}
