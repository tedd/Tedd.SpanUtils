using System;
using System.Buffers.Binary;
using Xunit;

namespace Tedd.SpanUtilsTests
{
    public class BulkEndianTests
    {
        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(7)]
        [InlineData(32)]
        [InlineData(257)]
        public void MatchesScalarAndPreservesTail(int count)
        {
            int[] source = new int[count];
            int[] destination = new int[count + 1];
            for (int i = 0; i < count; i++) source[i] = unchecked(i * 0x1234567 + int.MinValue);
            destination[count] = 42;
            SpanUtils.ReverseEndianness(source, destination);
            for (int i = 0; i < count; i++)
                Assert.Equal(BinaryPrimitives.ReverseEndianness(source[i]), destination[i]);
            Assert.Equal(42, destination[count]);
        }

        [Theory]
        [InlineData(0, 0)]
        [InlineData(0, 1)]
        [InlineData(1, 0)]
        public void OverlapPreservesSourceValues(int sourceOffset, int destinationOffset)
        {
            long[] buffer = new long[66];
            for (int i = 0; i < buffer.Length; i++) buffer[i] = (long)i << 32 | (uint)(i + 1);
            long[] original = (long[])buffer.Clone();
            SpanUtils.ReverseEndianness(buffer.AsSpan(sourceOffset, 65), buffer.AsSpan(destinationOffset, 65));
            for (int i = 0; i < 65; i++)
                Assert.Equal(BinaryPrimitives.ReverseEndianness(original[sourceOffset + i]), buffer[destinationOffset + i]);
        }

        [Fact]
        public void RejectsShortDestinationBeforeWriting()
        {
            short[] destination = { 23 };
            Assert.Throws<ArgumentException>(() => SpanUtils.ReverseEndianness(new short[2], destination));
            Assert.Equal((short)23, destination[0]);
        }

        [Fact]
        public void AllWidthsPreserveBits()
        {
            ushort[] u16 = { 0x8123 };
            uint[] u32 = { 0x81234567 };
            ulong[] u64 = { 0x8123456789abcdef };
            SpanUtils.ReverseEndianness(u16, u16);
            SpanUtils.ReverseEndianness(u32, u32);
            SpanUtils.ReverseEndianness(u64, u64);
            Assert.Equal((ushort)0x2381, u16[0]);
            Assert.Equal(0x67452381u, u32[0]);
            Assert.Equal(0xefcdab8967452381ul, u64[0]);
#if NET10_0_OR_GREATER && !STANDARD_ASSET
            Int128[] i128 = { ((Int128)long.MinValue << 64) | 1 };
            UInt128[] u128 = { UInt128.MaxValue - 2 };
            var expectedSigned = BinaryPrimitives.ReverseEndianness(i128[0]);
            var expectedUnsigned = BinaryPrimitives.ReverseEndianness(u128[0]);
            SpanUtils.ReverseEndianness(i128, i128);
            SpanUtils.ReverseEndianness(u128, u128);
            Assert.Equal(expectedSigned, i128[0]);
            Assert.Equal(expectedUnsigned, u128[0]);
#endif
        }
    }
}
