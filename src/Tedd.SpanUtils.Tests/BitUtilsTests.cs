using System;
using Xunit;
using Tedd;

namespace Tedd.SpanUtilsTests
{
    public class BitUtilsTests
    {
        [Theory]
        [InlineData(0ul, 64)]
        [InlineData(1ul, 63)]
        [InlineData(2ul, 62)]
        [InlineData(3ul, 62)]
        [InlineData(0xFFul, 56)]
        [InlineData(0xFFFFul, 48)]
        [InlineData(0xFFFFFFFFul, 32)]
        [InlineData(0x100000000ul, 31)]
        [InlineData(0x200000000ul, 30)]
        [InlineData(0x8000000000000000ul, 0)]
        [InlineData(0xFFFFFFFFFFFFFFFFul, 0)]
        public void LeadingZeroCountTest(ulong value, int expectedCount)
        {
            ulong val = value;
            int count = BitUtils.LeadingZeroCount(ref val);
            Assert.Equal(expectedCount, count);
        }

        [Theory]
        [InlineData(0ul, 64)]
        [InlineData(1ul, 63)]
        [InlineData(2ul, 62)]
        [InlineData(3ul, 62)]
        [InlineData(0xFFul, 56)]
        [InlineData(0xFFFFul, 48)]
        [InlineData(0xFFFFFFFFul, 32)]
        [InlineData(0x100000000ul, 31)]
        [InlineData(0x200000000ul, 30)]
        [InlineData(0x8000000000000000ul, 0)]
        [InlineData(0xFFFFFFFFFFFFFFFFul, 0)]
        public void LzCntSoftwareFallbackTest(ulong value, int expectedCount)
        {
            int count = BitUtils.LzCntSoftwareFallback(value);
            Assert.Equal(expectedCount, count);
        }

        [Theory]
        [InlineData(0u, 0)]
        [InlineData(1u, 0)]
        [InlineData(2u, 1)]
        [InlineData(3u, 1)]
        [InlineData(0xFFu, 7)]
        [InlineData(0xFFFFu, 15)]
        [InlineData(0xFFFFFFFFu, 31)]
        public void Log2SoftwareFallbackTest(uint value, int expectedLog2)
        {
            int log2 = BitUtils.Log2SoftwareFallback(value);
            Assert.Equal(expectedLog2, log2);
        }
    }
}
