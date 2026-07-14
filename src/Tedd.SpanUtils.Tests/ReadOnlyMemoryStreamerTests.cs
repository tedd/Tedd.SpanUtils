using System;
using System.Data;
using System.IO;
using Xunit;

namespace Tedd.Tests
{
    public class ReadOnlyMemoryStreamerTests
    {
        [Fact]
        public void Properties_InitialState_Correct()
        {
            var data = new byte[] { 1, 2, 3, 4, 5 };
            var memory = new ReadOnlyMemory<byte>(data);
            var stream = new ReadOnlyMemoryStreamer(memory);

            Assert.True(stream.CanRead);
            Assert.True(stream.CanSeek);
            Assert.False(stream.CanWrite);
            Assert.Equal(0, stream.Position);
            Assert.Equal(5, stream.Length);
            Assert.Equal(5, stream.MaxLength);
        }

        [Fact]
        public void Clear_AlwaysThrowsReadOnlyException()
        {
            var data = new byte[] { 1, 2, 3, 4, 5 };
            var memory = new ReadOnlyMemory<byte>(data);
            var stream = new ReadOnlyMemoryStreamer(memory);

            bool exceptionThrown = false;
            try
            {
                stream.Clear();
            }
            catch (ReadOnlyException)
            {
                exceptionThrown = true;
            }
            Assert.True(exceptionThrown);

            exceptionThrown = false;
            try
            {
                stream.Clear(true);
            }
            catch (ReadOnlyException)
            {
                exceptionThrown = true;
            }
            Assert.True(exceptionThrown);
        }

        [Theory]
        [InlineData(0, 0)]
        [InlineData(2, 2)]
        [InlineData(5, 5)]
        public void Position_SetValid_UpdatesCorrectly(int positionToSet, int expectedPosition)
        {
            var data = new byte[] { 1, 2, 3, 4, 5 };
            var memory = new ReadOnlyMemory<byte>(data);
            var stream = new ReadOnlyMemoryStreamer(memory);

            stream.Position = positionToSet;
            Assert.Equal(expectedPosition, stream.Position);
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(6)]
        public void Position_SetInvalid_ThrowsArgumentOutOfRangeException(long positionToSet)
        {
            var data = new byte[] { 1, 2, 3, 4, 5 };
            var memory = new ReadOnlyMemory<byte>(data);
            var stream = new ReadOnlyMemoryStreamer(memory);

            bool exceptionThrown = false;
            try
            {
                stream.Position = positionToSet;
            }
            catch (ArgumentOutOfRangeException)
            {
                exceptionThrown = true;
            }
            Assert.True(exceptionThrown);
        }

        [Fact]
        public void Position_SetPastLength_UpdatesLength()
        {
            var data = new byte[] { 1, 2, 3, 4, 5 };
            var memory = new ReadOnlyMemory<byte>(data);
            var stream = new ReadOnlyMemoryStreamer(memory);

            stream.SetLength(2); // explicit internal _length set
            stream.Position = 4;

            Assert.Equal(4, stream.Length);
            Assert.Equal(4, stream.Position);
        }

        [Theory]
        [InlineData(0, SeekOrigin.Begin, 0)]
        [InlineData(3, SeekOrigin.Begin, 3)]
        [InlineData(0, SeekOrigin.End, 4)]
        [InlineData(2, SeekOrigin.End, 2)]
        [InlineData(4, SeekOrigin.End, 0)]
        [InlineData(1, SeekOrigin.Current, 1)]
        [InlineData(3, SeekOrigin.Current, 3)]
        public void Seek_ValidInputs_ReturnsExpectedPosition(long offset, SeekOrigin origin, long expectedPosition)
        {
            var data = new byte[] { 1, 2, 3, 4, 5 };
            var memory = new ReadOnlyMemory<byte>(data);
            var stream = new ReadOnlyMemoryStreamer(memory);

            // SeekOrigin.Current depends on starting position
            if (origin == SeekOrigin.Current && offset == 3)
                stream.Position = 0; // Starts at 0, offset +3 -> 3

            var newPos = stream.Seek(offset, origin);
            Assert.Equal(expectedPosition, newPos);
            Assert.Equal(expectedPosition, stream.Position);
        }

        [Theory]
        [InlineData(0, 0)]
        [InlineData(3, 3)]
        [InlineData(5, 5)]
        public void SetLength_ValidLength_UpdatesCorrectly(long newLength, long expectedLength)
        {
            var data = new byte[] { 1, 2, 3, 4, 5 };
            var memory = new ReadOnlyMemory<byte>(data);
            var stream = new ReadOnlyMemoryStreamer(memory);

            stream.SetLength(newLength);
            Assert.Equal(expectedLength, stream.Length);
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(6)]
        public void SetLength_InvalidLength_ThrowsArgumentOutOfRangeException(long newLength)
        {
            var data = new byte[] { 1, 2, 3, 4, 5 };
            var memory = new ReadOnlyMemory<byte>(data);
            var stream = new ReadOnlyMemoryStreamer(memory);

            bool exceptionThrown = false;
            try
            {
                stream.SetLength(newLength);
            }
            catch (ArgumentOutOfRangeException)
            {
                exceptionThrown = true;
            }
            Assert.True(exceptionThrown);
        }

        [Fact]
        public void Flush_DoesNotThrow()
        {
            var data = new byte[] { 1, 2, 3, 4, 5 };
            var memory = new ReadOnlyMemory<byte>(data);
            var stream = new ReadOnlyMemoryStreamer(memory);

            // Should do nothing and not throw
            stream.Flush();
        }

        [Theory]
        [InlineData(0, 3, new byte[] { 1, 2, 3 }, 3)]
        [InlineData(2, 2, new byte[] { 3, 4 }, 2)]
        [InlineData(4, 2, new byte[] { 5 }, 1)] // Attempt to read past end, only reads available
        [InlineData(5, 1, new byte[] { }, 0)] // At end, reads nothing
        public void Read_ValidInputs_ReadsCorrectly(int startPosition, int countToRead, byte[] expectedBytes, int expectedReadCount)
        {
            var data = new byte[] { 1, 2, 3, 4, 5 };
            var memory = new ReadOnlyMemory<byte>(data);
            var stream = new ReadOnlyMemoryStreamer(memory);
            stream.Position = startPosition;

            var buffer = new byte[countToRead];
            int readCount = stream.Read(buffer, 0, countToRead);

            Assert.Equal(expectedReadCount, readCount);
            Assert.Equal(startPosition + expectedReadCount, stream.Position);

            for(int i = 0; i < expectedReadCount; i++)
            {
                Assert.Equal(expectedBytes[i], buffer[i]);
            }
        }

        [Fact]
        public void Read_NullBuffer_ThrowsArgumentNullException()
        {
            var data = new byte[] { 1, 2, 3, 4, 5 };
            var memory = new ReadOnlyMemory<byte>(data);
            var stream = new ReadOnlyMemoryStreamer(memory);

            bool exceptionThrown = false;
            try
            {
                stream.Read(null!, 0, 1);
            }
            catch (ArgumentNullException)
            {
                exceptionThrown = true;
            }
            Assert.True(exceptionThrown);
        }

        [Fact]
        public void Write_AlwaysThrowsReadOnlyException()
        {
            var data = new byte[] { 1, 2, 3, 4, 5 };
            var memory = new ReadOnlyMemory<byte>(data);
            var stream = new ReadOnlyMemoryStreamer(memory);
            var buffer = new byte[] { 9 };

            bool exceptionThrown = false;
            try
            {
                stream.Write(buffer, 0, 1);
            }
            catch (ReadOnlyException)
            {
                exceptionThrown = true;
            }
            Assert.True(exceptionThrown);
        }
    }
}
