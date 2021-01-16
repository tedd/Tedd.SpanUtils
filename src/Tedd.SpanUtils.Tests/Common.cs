using System;
using Xunit;

namespace Tedd.SpanUtilsTests
{
    public class Common
    {

        [Fact]
        public void TestMeasureOverflow()
        {
            var mem = new byte[1];
            Assert.Throws<ArgumentException>(() =>
            {
                var span1 = new Span<byte>(mem);
                _ = SpanUtils.MeasureWriteSize(UInt32.MaxValue);
            });
        }


        [Fact]
        public void TestInt24()
        {
            UInt32 u32 = 0x11_22_33_44;
            Int32 i32 = 0x01_22_33_44F;

            UInt24 u32_24 = u32.ToUInt24();
            UInt24 i32_24 = i32.ToUInt24();

            UInt32 bu32 = u32_24.ToUInt32();
            Int32 bi32 = i32_24.ToInt32();

            Assert.Equal((UInt32)u32_24, bu32);
            Assert.Equal((Int32)i32_24, bi32);

            Assert.Equal((UInt32)((u32<<8)>>8), (UInt32)u32_24);
            Assert.Equal((Int32)((i32<<8)>>8), (Int32)i32_24);
        }

    }
}
