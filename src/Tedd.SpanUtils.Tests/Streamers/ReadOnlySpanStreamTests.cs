using System;
using System.IO;
using System.Data;
using System.Buffers;
using Xunit;
using Tedd;

namespace Tedd.SpanUtilsTests.Streamers
{
    public class ReadOnlySpanStreamTests
    {
        [Theory]
        [InlineData(0)]
        [InlineData(10)]
        [InlineData(100)]
        public void TestLength(int size)
        {
            var pool = ArrayPool<byte>.Shared;
            var mem = pool.Rent(size);
            try
            {
                var memory = new ReadOnlySpan<byte>(mem, 0, size);
                var stream = new ReadOnlySpanStream(memory);
                Assert.Equal(size, stream.Length);
            }
            finally
            {
                pool.Return(mem);
            }
        }

        [Fact]
        public void TestCapabilities()
        {
            var pool = ArrayPool<byte>.Shared;
            var mem = pool.Rent(10);
            try
            {
                var memory = new ReadOnlySpan<byte>(mem, 0, 10);
                var stream = new ReadOnlySpanStream(memory);
                Assert.True(stream.CanRead);
                Assert.True(stream.CanSeek);
                Assert.False(stream.CanWrite);
            }
            finally
            {
                pool.Return(mem);
            }
        }

        [Theory]
        [InlineData(10, 0)]
        [InlineData(10, 5)]
        [InlineData(10, 10)]
        public void TestPositionGetSet(int size, int position)
        {
            var pool = ArrayPool<byte>.Shared;
            var mem = pool.Rent(size);
            try
            {
                var memory = new ReadOnlySpan<byte>(mem, 0, size);
                var stream = new ReadOnlySpanStream(memory);
                stream.Position = position;
                Assert.Equal(position, stream.Position);
            }
            finally
            {
                pool.Return(mem);
            }
        }

        [Theory]
        [InlineData(10, -1)]
        [InlineData(10, 11)]
        public void TestPositionSetOutOfBounds(int size, int position)
        {
            var pool = ArrayPool<byte>.Shared;
            var mem = pool.Rent(size);
            try
            {
                var memory = new ReadOnlySpan<byte>(mem, 0, size);
                var stream = new ReadOnlySpanStream(memory);

                bool thrown = false;
                try
                {
                    stream.Position = position;
                }
                catch (ArgumentOutOfRangeException)
                {
                    thrown = true;
                }
                Assert.True(thrown, "Expected ArgumentOutOfRangeException");
            }
            finally
            {
                pool.Return(mem);
            }
        }

        [Theory]
        [InlineData(20, 10)]
        [InlineData(20, 20)]
        public void TestSetLength(int size, int length)
        {
            var pool = ArrayPool<byte>.Shared;
            var mem = pool.Rent(size);
            try
            {
                var memory = new ReadOnlySpan<byte>(mem, 0, size);
                var stream = new ReadOnlySpanStream(memory);
                stream.SetLength(length);
                Assert.Equal(length, stream.Length);
            }
            finally
            {
                pool.Return(mem);
            }
        }

        [Theory]
        [InlineData(20, -1)]
        [InlineData(20, 21)]
        public void TestSetLengthOutOfBounds(int size, int length)
        {
            var pool = ArrayPool<byte>.Shared;
            var mem = pool.Rent(size);
            try
            {
                var memory = new ReadOnlySpan<byte>(mem, 0, size);
                var stream = new ReadOnlySpanStream(memory);

                bool thrown = false;
                try
                {
                    stream.SetLength(length);
                }
                catch (ArgumentOutOfRangeException)
                {
                    thrown = true;
                }
                Assert.True(thrown, "Expected ArgumentOutOfRangeException");
            }
            finally
            {
                pool.Return(mem);
            }
        }

        [Fact]
        public void TestFlush()
        {
            var pool = ArrayPool<byte>.Shared;
            var mem = pool.Rent(10);
            try
            {
                var memory = new ReadOnlySpan<byte>(mem, 0, 10);
                var stream = new ReadOnlySpanStream(memory);
                stream.Flush(); // should not throw
            }
            finally
            {
                pool.Return(mem);
            }
        }

        [Theory]
        [InlineData(10, 5, 0, 5, 5)]
        [InlineData(10, 10, 0, 10, 10)]
        [InlineData(10, 10, 0, 5, 5)]
        [InlineData(10, 10, 5, 5, 5)]
        public void TestRead(int memSize, int bufferSize, int offset, int count, int expectedRead)
        {
            var pool = ArrayPool<byte>.Shared;
            var mem = pool.Rent(memSize);
            var bufferArray = pool.Rent(bufferSize);

            try
            {
                for (int i = 0; i < memSize; i++) mem[i] = (byte)(i + 1);

                var memory = new ReadOnlySpan<byte>(mem, 0, memSize);
                var stream = new ReadOnlySpanStream(memory);

                var bytesRead = stream.Read(bufferArray, offset, count);
                Assert.Equal(expectedRead, bytesRead);

                for (int i = 0; i < expectedRead; i++)
                {
                    Assert.Equal(mem[i], bufferArray[offset + i]);
                }
            }
            finally
            {
                pool.Return(mem);
                pool.Return(bufferArray);
            }
        }

        [Fact]
        public void TestReadNullBuffer()
        {
            var pool = ArrayPool<byte>.Shared;
            var mem = pool.Rent(10);
            try
            {
                var memory = new ReadOnlySpan<byte>(mem, 0, 10);
                var stream = new ReadOnlySpanStream(memory);

                bool thrown = false;
                try
                {
                    stream.Read(null, 0, 5);
                }
                catch (ArgumentNullException)
                {
                    thrown = true;
                }
                Assert.True(thrown, "Expected ArgumentNullException");
            }
            finally
            {
                pool.Return(mem);
            }
        }

        [Fact]
        public void TestWriteThrowsReadOnlyException()
        {
            var pool = ArrayPool<byte>.Shared;
            var mem = pool.Rent(10);
            var bufferArray = pool.Rent(5);
            try
            {
                var memory = new ReadOnlySpan<byte>(mem, 0, 10);
                var stream = new ReadOnlySpanStream(memory);

                bool thrown = false;
                try
                {
                    stream.Write(bufferArray, 0, 5);
                }
                catch (ReadOnlyException)
                {
                    thrown = true;
                }
                Assert.True(thrown, "Expected ReadOnlyException");
            }
            finally
            {
                pool.Return(mem);
                pool.Return(bufferArray);
            }
        }
    }
}
