using System;
using System.Data;
using Xunit;

namespace Tedd.Tests
{
    public class ReadOnlySpanStreamTests
    {
        [Fact]
        public void Properties_InitialState_Correct()
        {
            var data = new byte[] { 1, 2, 3, 4, 5 };
            var span = new ReadOnlySpan<byte>(data);
            var stream = new ReadOnlySpanStream(span);

            Assert.True(stream.CanRead);
            Assert.True(stream.CanSeek);
            Assert.False(stream.CanWrite);
            Assert.Equal(0, stream.Position);
            Assert.Equal(5, stream.Length);
        }

        [Theory]
        [InlineData(0, 0)]
        [InlineData(2, 2)]
        [InlineData(5, 5)]
        public void Position_SetValid_UpdatesCorrectly(int positionToSet, int expectedPosition)
        {
            var data = new byte[] { 1, 2, 3, 4, 5 };
            var span = new ReadOnlySpan<byte>(data);
            var stream = new ReadOnlySpanStream(span);

            stream.Position = positionToSet;
            Assert.Equal(expectedPosition, stream.Position);
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(6)]
        public void Position_SetInvalid_ThrowsArgumentOutOfRangeException(int positionToSet)
        {
            var data = new byte[] { 1, 2, 3, 4, 5 };
            var span = new ReadOnlySpan<byte>(data);
            var stream = new ReadOnlySpanStream(span);

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
            // Set length explicitly smaller, then set position past it
            var data = new byte[] { 1, 2, 3, 4, 5 };
            var span = new ReadOnlySpan<byte>(data);
            var stream = new ReadOnlySpanStream(span);
            stream.SetLength(2); // Artificially reduce length to test internal logic

            stream.Position = 4;

            Assert.Equal(4, stream.Length);
            Assert.Equal(4, stream.Position);
        }


        [Theory]
        [InlineData(0, 0)]
        [InlineData(3, 3)]
        [InlineData(5, 5)]
        public void SetLength_ValidLength_UpdatesCorrectly(int newLength, int expectedLength)
        {
            var data = new byte[] { 1, 2, 3, 4, 5 };
            var span = new ReadOnlySpan<byte>(data);
            var stream = new ReadOnlySpanStream(span);

            stream.SetLength(newLength);
            Assert.Equal(expectedLength, stream.Length);
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(6)]
        public void SetLength_InvalidLength_ThrowsArgumentOutOfRangeException(int newLength)
        {
            var data = new byte[] { 1, 2, 3, 4, 5 };
            var span = new ReadOnlySpan<byte>(data);
            var stream = new ReadOnlySpanStream(span);

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
            var span = new ReadOnlySpan<byte>(data);
            var stream = new ReadOnlySpanStream(span);

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
            var span = new ReadOnlySpan<byte>(data);
            var stream = new ReadOnlySpanStream(span);
            stream.Position = startPosition;

            var buffer = new byte[countToRead];
            int readCount = stream.Read(buffer, 0, countToRead);

            Assert.Equal(expectedReadCount, readCount);
            Assert.Equal(startPosition + expectedReadCount, stream.Position);

            for(int i=0; i<expectedReadCount; i++)
            {
                Assert.Equal(expectedBytes[i], buffer[i]);
            }
        }

        [Fact]
        public void Read_NullBuffer_ThrowsArgumentNullException()
        {
            var data = new byte[] { 1, 2, 3, 4, 5 };
            var span = new ReadOnlySpan<byte>(data);
            var stream = new ReadOnlySpanStream(span);

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
            var span = new ReadOnlySpan<byte>(data);
            var stream = new ReadOnlySpanStream(span);
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
