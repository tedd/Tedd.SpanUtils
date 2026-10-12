using System;
using System.Data;
using System.Linq;
using Xunit;
using Tedd;

namespace Tedd.Tests
{
    public class SpanUtilsExtensionMethodsTests
    {
        [Theory]
        [InlineData(200)]
        public void MoveRead_Primitives(int size)
        {
            var data = new byte[size];
            var writeSpan = new Span<byte>(data);

            var s = writeSpan;
            s.MoveWrite((SByte)0x7F);
            s.MoveWrite((Byte)0xFF);
            s.MoveWrite((UInt16)0xFFFF);
            s.MoveWrite((Int16)(-12345));
            s.MoveWrite((UInt32)0xFFFFFFFF);
            s.MoveWrite((Int32)(-12345678));
            s.MoveWrite((UInt64)0xFFFFFFFFFFFFFFFF);
            s.MoveWrite((Int64)(-1234567890123456));
            s.MoveWrite((Single)123.45f);
            s.MoveWrite((Double)12345.6789);
            s.MoveWrite((Decimal)12345.6789M);
            s.MoveWrite(true);
            s.MoveWrite('A');

            // Test Span<byte> extensions
            var readSpan = new Span<byte>(data);
            Assert.Equal(0x7F, readSpan.MoveReadSByte(out var l1)); Assert.Equal(1, l1);
            Assert.Equal(0xFF, readSpan.MoveReadByte(out var l2)); Assert.Equal(1, l2);
            Assert.Equal(0xFFFF, readSpan.MoveReadUInt16(out var l3)); Assert.Equal(2, l3);
            Assert.Equal(-12345, readSpan.MoveReadInt16(out var l4)); Assert.Equal(2, l4);
            Assert.Equal(0xFFFFFFFF, readSpan.MoveReadUInt32(out var l5)); Assert.Equal(4, l5);
            Assert.Equal(-12345678, readSpan.MoveReadInt32(out var l6)); Assert.Equal(4, l6);
            Assert.Equal(0xFFFFFFFFFFFFFFFF, readSpan.MoveReadUInt64(out var l7)); Assert.Equal(8, l7);
            Assert.Equal(-1234567890123456, readSpan.MoveReadInt64(out var l8)); Assert.Equal(8, l8);
            Assert.Equal(123.45f, readSpan.MoveReadSingle(out var l9)); Assert.Equal(4, l9);
            Assert.Equal(12345.6789, readSpan.MoveReadDouble(out var l10)); Assert.Equal(8, l10);
            Assert.Equal(12345.6789M, readSpan.MoveReadDecimal(out var l11)); Assert.Equal(16, l11);
            Assert.True(readSpan.MoveReadBoolean(out var l12)); Assert.Equal(1, l12);
            Assert.Equal('A', readSpan.MoveReadChar(out var l13)); Assert.Equal(2, l13);

            // Test ReadOnlySpan<byte> extensions
            var roReadSpan = new ReadOnlySpan<byte>(data);
            Assert.Equal(0x7F, roReadSpan.MoveReadSByte(out l1)); Assert.Equal(1, l1);
            Assert.Equal(0xFF, roReadSpan.MoveReadByte(out l2)); Assert.Equal(1, l2);
            Assert.Equal(0xFFFF, roReadSpan.MoveReadUInt16(out l3)); Assert.Equal(2, l3);
            Assert.Equal(-12345, roReadSpan.MoveReadInt16(out l4)); Assert.Equal(2, l4);
            Assert.Equal(0xFFFFFFFF, roReadSpan.MoveReadUInt32(out l5)); Assert.Equal(4, l5);
            Assert.Equal(-12345678, roReadSpan.MoveReadInt32(out l6)); Assert.Equal(4, l6);
            Assert.Equal(0xFFFFFFFFFFFFFFFF, roReadSpan.MoveReadUInt64(out l7)); Assert.Equal(8, l7);
            Assert.Equal(-1234567890123456, roReadSpan.MoveReadInt64(out l8)); Assert.Equal(8, l8);
            Assert.Equal(123.45f, roReadSpan.MoveReadSingle(out l9)); Assert.Equal(4, l9);
            Assert.Equal(12345.6789, roReadSpan.MoveReadDouble(out l10)); Assert.Equal(8, l10);
            Assert.Equal(12345.6789M, roReadSpan.MoveReadDecimal(out l11)); Assert.Equal(16, l11);
            Assert.True(roReadSpan.MoveReadBoolean(out l12)); Assert.Equal(1, l12);
            Assert.Equal('A', roReadSpan.MoveReadChar(out l13)); Assert.Equal(2, l13);
        }

        [Theory]
        [InlineData(200)]
        public void MoveRead_Primitives_NoLengthParam(int size)
        {
            var data = new byte[size];
            var writeSpan = new Span<byte>(data);

            var s = writeSpan;
            s.MoveWrite((SByte)0x7F);
            s.MoveWrite((Byte)0xFF);
            s.MoveWrite((UInt16)0xFFFF);
            s.MoveWrite((Int16)(-12345));
            s.MoveWrite((UInt32)0xFFFFFFFF);
            s.MoveWrite((Int32)(-12345678));
            s.MoveWrite((UInt64)0xFFFFFFFFFFFFFFFF);
            s.MoveWrite((Int64)(-1234567890123456));
            s.MoveWrite((Single)123.45f);
            s.MoveWrite((Double)12345.6789);
            s.MoveWrite((Decimal)12345.6789M);
            s.MoveWrite(true);
            s.MoveWrite('A');

            // Test Span<byte> extensions
            var readSpan = new Span<byte>(data);
            Assert.Equal(0x7F, readSpan.MoveReadSByte());
            Assert.Equal(0xFF, readSpan.MoveReadByte());
            Assert.Equal(0xFFFF, readSpan.MoveReadUInt16());
            Assert.Equal(-12345, readSpan.MoveReadInt16());
            Assert.Equal(0xFFFFFFFF, readSpan.MoveReadUInt32());
            Assert.Equal(-12345678, readSpan.MoveReadInt32());
            Assert.Equal(0xFFFFFFFFFFFFFFFF, readSpan.MoveReadUInt64());
            Assert.Equal(-1234567890123456, readSpan.MoveReadInt64());
            Assert.Equal(123.45f, readSpan.MoveReadSingle());
            Assert.Equal(12345.6789, readSpan.MoveReadDouble());
            Assert.Equal(12345.6789M, readSpan.MoveReadDecimal());
            Assert.True(readSpan.MoveReadBoolean());
            Assert.Equal('A', readSpan.MoveReadChar());

            // Test ReadOnlySpan<byte> extensions
            var roReadSpan = new ReadOnlySpan<byte>(data);
            Assert.Equal(0x7F, roReadSpan.MoveReadSByte());
            Assert.Equal(0xFF, roReadSpan.MoveReadByte());
            Assert.Equal(0xFFFF, roReadSpan.MoveReadUInt16());
            Assert.Equal(-12345, roReadSpan.MoveReadInt16());
            Assert.Equal(0xFFFFFFFF, roReadSpan.MoveReadUInt32());
            Assert.Equal(-12345678, roReadSpan.MoveReadInt32());
            Assert.Equal(0xFFFFFFFFFFFFFFFF, roReadSpan.MoveReadUInt64());
            Assert.Equal(-1234567890123456, roReadSpan.MoveReadInt64());
            Assert.Equal(123.45f, roReadSpan.MoveReadSingle());
            Assert.Equal(12345.6789, roReadSpan.MoveReadDouble());
            Assert.Equal(12345.6789M, roReadSpan.MoveReadDecimal());
            Assert.True(roReadSpan.MoveReadBoolean());
            Assert.Equal('A', roReadSpan.MoveReadChar());
        }

        [Theory]
        [InlineData(100)]
        public void MoveRead_Aliases(int size)
        {
            var data = new byte[size];
            var writeSpan = new Span<byte>(data);
            var s = writeSpan;
            s.MoveWrite((Single)123.45f);
            s.MoveWrite((Int16)(-12345));
            s.MoveWrite((UInt16)0xFFFF);

            var readSpan = new Span<byte>(data);
            Assert.Equal(123.45f, readSpan.MoveReadFloat(out var l1));
            Assert.Equal(-12345, readSpan.MoveReadShort(out var l2));
            Assert.Equal(0xFFFF, readSpan.MoveReadUShort(out var l3));

            var roReadSpan = new ReadOnlySpan<byte>(data);
            Assert.Equal(123.45f, roReadSpan.MoveReadFloat());
            Assert.Equal(-12345, roReadSpan.MoveReadShort());
            Assert.Equal(0xFFFF, roReadSpan.MoveReadUShort());
        }

        [Theory]
        [InlineData(200)]
        public void ReadSizedBytesAndString(int size)
        {
            var data = new byte[size];
            var writeSpan = new Span<byte>(data);

            var s1 = writeSpan;
            s1.MoveWriteSized("Hello Aegis");
            s1.MoveWriteSized(new byte[] { 1, 2, 3 }.AsSpan());

            var span = new Span<byte>(data);
            var str1 = span.ReadSizedString(out var l1);
            Assert.Equal("Hello Aegis", str1);
            Assert.True(l1 > 0);
            span = span.Slice(l1);

            var bytes1 = span.ReadSizedBytes(out var l2);
            Assert.Equal(3, bytes1.Length);
            Assert.Equal(1, bytes1[0]);
            Assert.True(l2 > 0);

            var spanNoLength = new Span<byte>(data);
            var str2 = spanNoLength.ReadSizedString(out var l3);
            Assert.Equal("Hello Aegis", str2);
            spanNoLength = spanNoLength.Slice(l3);
            Assert.Equal(3, spanNoLength.ReadSizedBytes().Length);

            var roSpan = new ReadOnlySpan<byte>(data);
            var str3 = roSpan.ReadSizedString(out var l4);
            Assert.Equal("Hello Aegis", str3);
            roSpan = roSpan.Slice(l4);
            Assert.Equal(3, roSpan.ReadSizedBytes(out var l5).Length);

            var roSpanNoLength = new ReadOnlySpan<byte>(data);
            var str4 = roSpanNoLength.ReadSizedString(out var l6);
            Assert.Equal("Hello Aegis", str4);
            roSpanNoLength = roSpanNoLength.Slice(l6);
            Assert.Equal(3, roSpanNoLength.ReadSizedBytes().Length);
        }
    }
}
