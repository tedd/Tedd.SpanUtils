using System;
using Xunit;
using Tedd;

namespace Tedd.SpanUtilsTests
{
    public class VIntTests
    {
        [Theory]
        [InlineData(0, 1)]
        [InlineData(126, 1)]
        [InlineData(127, 2)]
        [InlineData(128, 2)]
        [InlineData(16382, 2)]
        [InlineData(16383, 3)]
        [InlineData(16384, 3)]
        [InlineData((1UL << 21) - 2, 3)]
        [InlineData((1UL << 21) - 1, 4)]
        [InlineData((1UL << 21), 4)]
        [InlineData((1UL << 28) - 2, 4)]
        [InlineData((1UL << 28) - 1, 5)]
        [InlineData((1UL << 28), 5)]
        [InlineData((1UL << 35) - 2, 5)]
        [InlineData((1UL << 35) - 1, 6)]
        [InlineData((1UL << 35), 6)]
        [InlineData((1UL << 42) - 2, 6)]
        [InlineData((1UL << 42) - 1, 7)]
        [InlineData((1UL << 42), 7)]
        [InlineData((1UL << 49) - 2, 7)]
        [InlineData((1UL << 49) - 1, 8)]
        [InlineData((1UL << 49), 8)]
        [InlineData((1UL << 56) - 2, 8)]
        [InlineData((1UL << 56) - 1, 9)]
        [InlineData((1UL << 56), 9)]
        [InlineData((1UL << 63) - 2, 9)]
        [InlineData((1UL << 63) - 1, 10)]
        [InlineData((1UL << 63), 10)]
        [InlineData(ulong.MaxValue - 1, 10)]
        [InlineData(ulong.MaxValue, 10)] // Note: max size for ulong is 10 bytes for 7-bit encoding
        public void TestGetSize(ulong value, int expectedSize)
        {
            Assert.Equal(expectedSize, VInt.GetSize(value));
        }

        [Fact]
        public void TestVIntConstructorAndToString()
        {
            var v = new VInt(1, 0, 126);
            Assert.Equal(1, v.Length);
            Assert.Equal((ulong)0, v.EncodedValue);
            Assert.Equal((ulong)126, v.Value);
            Assert.Equal(1, v.Size); // get size returns 1 for 126

            var str = v.ToString();
            Assert.Contains("value = 126", str);
            Assert.Contains("length = 1", str);
            Assert.Contains("encoded = 0", str);
        }
    }
}
