using System;
using System.IO;
using System.Data;
using System.Buffers;
using Xunit;
using Tedd;

namespace Tedd.SpanUtilsTests.Streamers
{
    public class ReadOnlyMemoryStreamerTests
    {
        [Theory]
        [InlineData(0)]
        [InlineData(10)]
        [InlineData(100)]
        public void TestLengthAndMaxLength(int size)
        {
            var pool = ArrayPool<byte>.Shared;
            var mem = pool.Rent(size);
            try
            {
                var memory = new ReadOnlyMemory<byte>(mem, 0, size);
                var stream = new ReadOnlyMemoryStreamer(memory);
                Assert.Equal(size, stream.Length);
                Assert.Equal(size, stream.MaxLength);
            }
            finally
            {
                pool.Return(mem);
            }
        }

        [Fact]
        public void TestClearThrowsReadOnlyException()
        {
            var pool = ArrayPool<byte>.Shared;
            var mem = pool.Rent(10);
            try
            {
                var memory = new ReadOnlyMemory<byte>(mem, 0, 10);
                var stream = new ReadOnlyMemoryStreamer(memory);
                Assert.Throws<ReadOnlyException>(() => stream.Clear());
                Assert.Throws<ReadOnlyException>(() => stream.Clear(true));
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
                var memory = new ReadOnlyMemory<byte>(mem, 0, 10);
                var stream = new ReadOnlyMemoryStreamer(memory);
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
                var memory = new ReadOnlyMemory<byte>(mem, 0, size);
                var stream = new ReadOnlyMemoryStreamer(memory);
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
                var memory = new ReadOnlyMemory<byte>(mem, 0, size);
                var stream = new ReadOnlyMemoryStreamer(memory);
                Assert.Throws<ArgumentOutOfRangeException>(() => stream.Position = position);
            }
            finally
            {
                pool.Return(mem);
            }
        }

        [Theory]
        [InlineData(20, 5, SeekOrigin.Begin, 5)]
        [InlineData(20, 5, SeekOrigin.End, 14)] // In ReadOnlyMemoryStreamer, Seek from End is Length - 1 - offset
        [InlineData(20, 5, SeekOrigin.Current, 5)]
        public void TestSeek(int size, long offset, SeekOrigin origin, long expectedPosition)
        {
            var pool = ArrayPool<byte>.Shared;
            var mem = pool.Rent(size);
            try
            {
                var memory = new ReadOnlyMemory<byte>(mem, 0, size);
                var stream = new ReadOnlyMemoryStreamer(memory);

                var pos = stream.Seek(offset, origin);
                Assert.Equal(expectedPosition, pos);
                Assert.Equal(expectedPosition, stream.Position);
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
                var memory = new ReadOnlyMemory<byte>(mem, 0, size);
                var stream = new ReadOnlyMemoryStreamer(memory);
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
                var memory = new ReadOnlyMemory<byte>(mem, 0, size);
                var stream = new ReadOnlyMemoryStreamer(memory);
                Assert.Throws<ArgumentOutOfRangeException>(() => stream.SetLength(length));
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
                var memory = new ReadOnlyMemory<byte>(mem, 0, 10);
                var stream = new ReadOnlyMemoryStreamer(memory);
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
            var buffer = pool.Rent(bufferSize);

            try
            {
                for (int i = 0; i < memSize; i++) mem[i] = (byte)(i + 1);

                var memory = new ReadOnlyMemory<byte>(mem, 0, memSize);
                var stream = new ReadOnlyMemoryStreamer(memory);

                var bytesRead = stream.Read(buffer, offset, count);
                Assert.Equal(expectedRead, bytesRead);

                for (int i = 0; i < expectedRead; i++)
                {
                    Assert.Equal(mem[i], buffer[offset + i]);
                }
            }
            finally
            {
                pool.Return(mem);
                pool.Return(buffer);
            }
        }

        [Fact]
        public void TestReadNullBuffer()
        {
            var pool = ArrayPool<byte>.Shared;
            var mem = pool.Rent(10);
            try
            {
                var memory = new ReadOnlyMemory<byte>(mem, 0, 10);
                var stream = new ReadOnlyMemoryStreamer(memory);
                Assert.Throws<ArgumentNullException>(() => stream.Read(null, 0, 5));
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
            var buffer = pool.Rent(5);
            try
            {
                var memory = new ReadOnlyMemory<byte>(mem, 0, 10);
                var stream = new ReadOnlyMemoryStreamer(memory);
                Assert.Throws<ReadOnlyException>(() => stream.Write(buffer, 0, 5));
            }
            finally
            {
                pool.Return(mem);
                pool.Return(buffer);
            }
        }
    }
}
