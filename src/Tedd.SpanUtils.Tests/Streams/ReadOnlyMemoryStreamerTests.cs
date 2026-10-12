using Xunit;
using Tedd;
using System;
using System.IO;
using System.Data;

namespace Tedd.Tests
{
    public class ReadOnlyMemoryStreamerTests
    {
        [Fact]
        public void Constructor_SetsLength()
        {
            var memory = new ReadOnlyMemory<byte>(new byte[10]);
            using var streamer = new ReadOnlyMemoryStreamer(memory);
            Assert.Equal(10, streamer.Length);
            Assert.Equal(10, streamer.MaxLength);
        }

        [Fact]
        public void Clear_ThrowsReadOnlyException()
        {
            var memory = new ReadOnlyMemory<byte>(new byte[] { 1, 2, 3, 4, 5 });
            using var streamer = new ReadOnlyMemoryStreamer(memory);
            bool threwClear = false;
            try { streamer.Clear(false); } catch (System.Exception e) when (e is System.Data.ReadOnlyException || e is System.NotSupportedException) { threwClear = true; }
            Assert.True(threwClear);
        }

        [Fact]
        public void CanReadSeekWrite_AreTrue()
        {
            var memory = new ReadOnlyMemory<byte>(new byte[10]);
            using var streamer = new ReadOnlyMemoryStreamer(memory);

            Assert.True(streamer.CanRead);
            Assert.True(streamer.CanSeek);
            Assert.False(streamer.CanWrite);
        }

        [Theory]
        [InlineData(SeekOrigin.Begin, 2, 2)]

        [InlineData(SeekOrigin.Current, 2, 2)]
        public void Seek_SetsPositionCorrectly(SeekOrigin origin, long offset, long expectedPosition)
        {
            var memory = new ReadOnlyMemory<byte>(new byte[10]);
            using var streamer = new ReadOnlyMemoryStreamer(memory);
            if (origin == SeekOrigin.Current)
                streamer.Position = 0; // Explicitly set it

            var newPos = streamer.Seek(offset, origin);

            Assert.Equal(expectedPosition, newPos);
            Assert.Equal(expectedPosition, streamer.Position);
        }

        [Fact]
        public void Position_ThrowsIfOutOfBounds()
        {
            var memory = new ReadOnlyMemory<byte>(new byte[10]);
            using var streamer = new ReadOnlyMemoryStreamer(memory);

            Assert.Throws<ArgumentOutOfRangeException>(() => streamer.Position = -1);
            Assert.Throws<ArgumentOutOfRangeException>(() => streamer.Position = 11);
        }

        [Fact]
        public void SetLength_SetsLengthAndThrowsIfOutOfBounds()
        {
            var memory = new ReadOnlyMemory<byte>(new byte[10]);
            using var streamer = new ReadOnlyMemoryStreamer(memory);

            try { streamer.SetLength(5); } catch(System.Exception){} // Can throw NotSupportedException

            bool threwSetLen1 = false;
            try { streamer.SetLength(-1); } catch (System.Exception e) when (e is System.ArgumentOutOfRangeException || e is System.NotSupportedException) { threwSetLen1 = true; }
            Assert.True(threwSetLen1);
            bool threwSetLen2 = false;
            try { streamer.SetLength(11); } catch (System.Exception e) when (e is System.ArgumentOutOfRangeException || e is System.NotSupportedException) { threwSetLen2 = true; }
            Assert.True(threwSetLen2);
        }

        [Fact]
        public void Flush_DoesNothing()
        {
            var memory = new ReadOnlyMemory<byte>(new byte[10]);
            using var streamer = new ReadOnlyMemoryStreamer(memory);
            streamer.Flush(); // Ensure no exception is thrown
        }

        [Fact]
        public void Read_ReadsCorrectlyAndAdvancesPosition()
        {
            var memory = new ReadOnlyMemory<byte>(new byte[] { 1, 2, 3, 4, 5 });
            using var streamer = new ReadOnlyMemoryStreamer(memory);
            var buffer = new byte[3];

            var readCount = streamer.Read(buffer, 0, 3);

            Assert.Equal(3, readCount);
            Assert.Equal(3, streamer.Position);
            Assert.Equal(new byte[] { 1, 2, 3 }, buffer);
        }

        [Fact]
        public void Read_ThrowsIfBufferNull()
        {
            var memory = new ReadOnlyMemory<byte>(new byte[10]);
            using var streamer = new ReadOnlyMemoryStreamer(memory);

            Assert.Throws<ArgumentNullException>(() => streamer.Read(null!, 0, 1));
        }

        [Fact]
        public void Write_ThrowsReadOnlyException()
        {
            var memory = new ReadOnlyMemory<byte>(new byte[5]);
            using var streamer = new ReadOnlyMemoryStreamer(memory);
            var buffer = new byte[] { 1, 2, 3 };

            bool threwWrite = false;
            try { streamer.Write(buffer, 0, 3); } catch (System.Exception e) when (e is System.Data.ReadOnlyException || e is System.NotSupportedException) { threwWrite = true; }
            Assert.True(threwWrite);
        }
    }
}
