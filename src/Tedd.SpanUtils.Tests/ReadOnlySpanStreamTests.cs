using System;
using Xunit;
using Tedd;

namespace Tedd.SpanUtilsTests
{
    public class ReadOnlySpanStreamTests
    {
        [Fact]
        public void TestProperties()
        {
            var mem = new byte[100];
            var stream = new ReadOnlySpanStream(mem);

            Assert.True(stream.CanRead);
            Assert.True(stream.CanSeek);
            Assert.False(stream.CanWrite);

            Assert.Equal(100, stream.Length);
            Assert.Equal(0, stream.Position);
        }

        [Fact]
        public void TestPosition()
        {
            var mem = new byte[100];
            var stream = new ReadOnlySpanStream(mem);

            stream.Position = 50;
            Assert.Equal(50, stream.Position);
            Assert.Equal(100, stream.Length);

            stream.Position = 100;
            Assert.Equal(100, stream.Position);

            // Validating out of range position
            bool threw = false;
            try
            {
                stream.Position = 101;
            }
            catch (ArgumentOutOfRangeException)
            {
                threw = true;
            }
            Assert.True(threw, "Expected ArgumentOutOfRangeException for Position > Length");

            threw = false;
            try
            {
                stream.Position = -1;
            }
            catch (ArgumentOutOfRangeException)
            {
                threw = true;
            }
            Assert.True(threw, "Expected ArgumentOutOfRangeException for Position < 0");
        }

        [Fact]
        public void TestSetLength()
        {
            var mem = new byte[100];
            var stream = new ReadOnlySpanStream(mem);

            stream.SetLength(50);
            Assert.Equal(50, stream.Length);

            stream.SetLength(0);
            Assert.Equal(0, stream.Length);

            bool threw = false;
            try
            {
                stream.SetLength(101);
            }
            catch (ArgumentOutOfRangeException)
            {
                threw = true;
            }
            Assert.True(threw, "Expected ArgumentOutOfRangeException for SetLength > span.Length");

            threw = false;
            try
            {
                stream.SetLength(-1);
            }
            catch (ArgumentOutOfRangeException)
            {
                threw = true;
            }
            Assert.True(threw, "Expected ArgumentOutOfRangeException for SetLength < 0");
        }

        [Fact]
        public void TestFlush()
        {
            var mem = new byte[100];
            var stream = new ReadOnlySpanStream(mem);
            stream.Flush(); // Should not throw
        }

        [Theory]
        [InlineData(0, 10, 10)]
        [InlineData(50, 50, 50)]
        [InlineData(90, 20, 10)] // count is greater than remaining length
        [InlineData(100, 10, 0)] // past the end
        public void TestRead(int startPos, int readCount, int expectedReadCount)
        {
            var mem = new byte[100];
            for (int i = 0; i < 100; i++) mem[i] = (byte)i;
            var stream = new ReadOnlySpanStream(mem);
            stream.Position = startPos;

            var buffer = new byte[readCount];
            int read = stream.Read(buffer, 0, readCount);

            Assert.Equal(expectedReadCount, read);
            Assert.Equal(startPos + expectedReadCount, stream.Position);

            for (int i = 0; i < expectedReadCount; i++)
            {
                Assert.Equal(mem[startPos + i], buffer[i]);
            }
        }

        [Fact]
        public void TestReadExceptions()
        {
            var mem = new byte[100];
            var stream = new ReadOnlySpanStream(mem);

            bool threw = false;
            try
            {
                stream.Read(null, 0, 10);
            }
            catch (ArgumentNullException)
            {
                threw = true;
            }
            Assert.True(threw, "Expected ArgumentNullException for null buffer in Read");

            // ArgumentOutOfRangeException from standard array Slice
            threw = false;
            try
            {
                stream.Read(new byte[10], -1, 5);
            }
            catch (ArgumentOutOfRangeException)
            {
                threw = true;
            }
            Assert.True(threw, "Expected ArgumentOutOfRangeException for negative offset");
        }

        [Fact]
        public void TestWriteExceptions()
        {
            var mem = new byte[100];
            var stream = new ReadOnlySpanStream(mem);

            bool threw = false;
            try
            {
                stream.Write(new byte[10], 0, 10);
            }
            catch (Exception)
            {
                threw = true;
            }
            Assert.True(threw, "Expected Exception for Write");
        }

        [Fact]
        public void TestGeneratedMethods()
        {
            var mem = new byte[100];
            for (int i = 0; i < 100; i++) mem[i] = (byte)i;
            var stream = new ReadOnlySpanStream(mem);

            Assert.Equal(0, stream.ReadByte());
            Assert.Equal(1, stream.ReadSByte());
            Assert.Equal(2, stream.Position);

            int length = 0;
            var b = stream.ReadByte(out length);
            Assert.Equal(2, b);
            Assert.Equal(1, length);
            Assert.Equal(3, stream.Position);

            var sb = stream.ReadSByte(out length);
            Assert.Equal(3, sb);
            Assert.Equal(1, length);
            Assert.Equal(4, stream.Position);

            var s = stream.ReadInt16();
            Assert.Equal(6, stream.Position);

            s = stream.ReadInt16(out length);
            Assert.Equal(2, length);
            Assert.Equal(8, stream.Position);
        }
    }
}
