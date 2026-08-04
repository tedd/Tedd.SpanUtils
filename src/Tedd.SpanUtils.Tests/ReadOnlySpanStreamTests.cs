using System;
using System.Data;
using System.Linq;
using Xunit;
using Tedd;

namespace Tedd.Tests
{
    public class ReadOnlySpanStreamTests
    {
        [Theory]
        [InlineData(new byte[] { 1, 2, 3, 4, 5 })]
        public void BasicProperties(byte[] data)
        {
            var span = new ReadOnlySpan<byte>(data);
            var stream = new ReadOnlySpanStream(span);

            Assert.True(stream.CanRead);
            Assert.True(stream.CanSeek);
            Assert.False(stream.CanWrite);
            Assert.Equal(5, stream.Length);
            Assert.Equal(0, stream.Position);

            stream.Position = 2;
            Assert.Equal(2, stream.Position);

            // Should not throw, no effect
            stream.Flush();
        }

        [Theory]
        [InlineData(6)]
        [InlineData(-1)]
        public void PositionOutOfBounds(int pos)
        {
            var data = new byte[5];
            var stream = new ReadOnlySpanStream(data);

            bool caught = false;
            try { stream.Position = pos; }
            catch (ArgumentOutOfRangeException) { caught = true; }
            Assert.True(caught);
        }

        [Theory]
        [InlineData(3, false)]
        [InlineData(6, true)]
        [InlineData(-1, true)]
        public void SetLength(int len, bool throws)
        {
            var data = new byte[5];
            var stream = new ReadOnlySpanStream(data);

            if (throws)
            {
                bool caught = false;
                try { stream.SetLength(len); }
                catch (ArgumentOutOfRangeException) { caught = true; }
                Assert.True(caught);
            }
            else
            {
                stream.SetLength(len);
                Assert.Equal(len, stream.Length);
            }
        }

        [Theory]
        [InlineData(new byte[] { 10, 20, 30, 40, 50 })]
        public void Read_ByteArray(byte[] data)
        {
            var stream = new ReadOnlySpanStream(data);

            var buffer = new byte[3];
            var read = stream.Read(buffer, 0, 3);

            Assert.Equal(3, read);
            Assert.Equal(3, stream.Position);
            Assert.Equal(10, buffer[0]);
            Assert.Equal(20, buffer[1]);
            Assert.Equal(30, buffer[2]);

            // Test ArgumentNullException
            bool caught = false;
            try { stream.Read(null, 0, 1); }
            catch (ArgumentNullException) { caught = true; }
            Assert.True(caught);
        }

        [Theory]
        [InlineData(new byte[] { 1, 2, 3 })]
        public void Write_ByteArray_Throws(byte[] buffer)
        {
            var data = new byte[5];
            var stream = new ReadOnlySpanStream(data);

            bool caught = false;
            try { stream.Write(buffer, 0, 3); }
            catch (ReadOnlyException ex)
            {
                caught = true;
                Assert.Equal("Span is read-only.", ex.Message);
            }
            Assert.True(caught);
        }

        [Theory]
        [InlineData(100)]
        public void ReadGeneratedMethods(int size)
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

            var stream = new ReadOnlySpanStream(data);

            Assert.Equal(0x7F, stream.ReadSByte(out var l1));
            Assert.Equal(1, l1);

            Assert.Equal(0xFF, stream.ReadByte(out var l2));
            Assert.Equal(1, l2);

            Assert.Equal(0xFFFF, stream.ReadUInt16(out var l3));
            Assert.Equal(2, l3);

            Assert.Equal(-12345, stream.ReadInt16(out var l4));
            Assert.Equal(2, l4);

            Assert.Equal(0xFFFFFFFF, stream.ReadUInt32(out var l5));
            Assert.Equal(4, l5);

            Assert.Equal(-12345678, stream.ReadInt32(out var l6));
            Assert.Equal(4, l6);

            Assert.Equal(0xFFFFFFFFFFFFFFFF, stream.ReadUInt64(out var l7));
            Assert.Equal(8, l7);

            Assert.Equal(-1234567890123456, stream.ReadInt64(out var l8));
            Assert.Equal(8, l8);

            // Test parameterless generated read methods by seeking back and reading
            stream.Position = 0;
            Assert.Equal(0x7F, stream.ReadSByte());
            Assert.Equal(0xFF, stream.ReadByte());
            Assert.Equal(0xFFFF, stream.ReadUInt16());
            Assert.Equal(-12345, stream.ReadInt16());
            Assert.Equal(0xFFFFFFFF, stream.ReadUInt32());
            Assert.Equal(-12345678, stream.ReadInt32());
            Assert.Equal(0xFFFFFFFFFFFFFFFF, stream.ReadUInt64());
            Assert.Equal(-1234567890123456, stream.ReadInt64());
        }

        [Theory]
        [InlineData(100)]
        public void ReadGeneratedMethods_Part2(int size)
        {
            var data = new byte[size];
            var writeSpan = new Span<byte>(data);

            var s = writeSpan;
            s.MoveWrite((Single)123.45f);
            s.MoveWrite((Double)12345.6789);
            s.MoveWrite((Decimal)12345.6789M);
            s.MoveWrite(true);
            s.MoveWrite('A');

            var stream = new ReadOnlySpanStream(data);

            Assert.Equal(123.45f, stream.ReadSingle(out var l1));
            Assert.Equal(12345.6789, stream.ReadDouble(out var l2));
            Assert.Equal(12345.6789M, stream.ReadDecimal(out var l3));
            Assert.True(stream.ReadBoolean(out var l4));
            Assert.Equal('A', stream.ReadChar(out var l5));

            stream.Position = 0;
            Assert.Equal(123.45f, stream.ReadSingle());
            Assert.Equal(12345.6789, stream.ReadDouble());
            Assert.Equal(12345.6789M, stream.ReadDecimal());
            Assert.True(stream.ReadBoolean());
            Assert.Equal('A', stream.ReadChar());

            stream.Position = 0;
            Assert.Equal(123.45f, stream.ReadFloat());
            stream.Position = 0;
            Assert.Equal(123.45f, stream.ReadFloat(out var l6));
        }

        [Theory]
        [InlineData(100)]
        public void ReadGeneratedMethods_VLQ(int size)
        {
            var data = new byte[size];
            var writeStream = new SpanStream(data);
            writeStream.WriteVLQ((UInt16)4000);
            writeStream.WriteVLQ((Int16)(-4000));
            writeStream.WriteVLQ((UInt32)400000000);
            writeStream.WriteVLQ((Int32)(-400000000));
            writeStream.WriteVLQ((UInt64)4000000000000000);
            writeStream.WriteVLQ((Int64)(-4000000000000000));

            var stream = new ReadOnlySpanStream(data);
            Assert.Equal((UInt16)4000, stream.ReadVLQUInt16(out var l1));
            Assert.Equal((Int16)(-4000), stream.ReadVLQInt16(out var l2));
            Assert.Equal((UInt32)400000000, stream.ReadVLQUInt32(out var l3));
            Assert.Equal((Int32)(-400000000), stream.ReadVLQInt32(out var l4));
            Assert.Equal((UInt64)4000000000000000, stream.ReadVLQUInt64(out var l5));
            Assert.Equal((Int64)(-4000000000000000), stream.ReadVLQInt64(out var l6));

            stream.Position = 0;
            Assert.Equal((UInt16)4000, stream.ReadVLQUInt16());
            Assert.Equal((Int16)(-4000), stream.ReadVLQInt16());
            Assert.Equal((UInt32)400000000, stream.ReadVLQUInt32());
            Assert.Equal((Int32)(-400000000), stream.ReadVLQInt32());
            Assert.Equal((UInt64)4000000000000000, stream.ReadVLQUInt64());
            Assert.Equal((Int64)(-4000000000000000), stream.ReadVLQInt64());
        }

        [Theory]
        [InlineData(100)]
        public void ReadGeneratedMethods_Sized(int size)
        {
            var data = new byte[size];
            var writeStream = new SpanStream(data);
            writeStream.WriteSized("Hello");
            writeStream.WriteSized(new byte[] { 1, 2, 3 }.AsSpan());

            var stream = new ReadOnlySpanStream(data);
            Assert.Equal("Hello", stream.ReadSizedString(out var l1));
            var bytes = stream.ReadSizedBytes(out var l2);
            Assert.Equal(3, bytes.Length);
            Assert.Equal(1, bytes[0]);
            Assert.Equal(2, bytes[1]);
            Assert.Equal(3, bytes[2]);

            stream.Position = 0;
            Assert.Equal("Hello", stream.ReadSizedString());
            bytes = stream.ReadSizedBytes();
            Assert.Equal(3, bytes.Length);
        }
    }
}
