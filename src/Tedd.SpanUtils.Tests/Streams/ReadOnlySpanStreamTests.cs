using Xunit;
using Tedd;
using System;
using System.IO;
using System.Data;

namespace Tedd.Tests
{
    public class ReadOnlySpanStreamTests
    {
        [Fact]
        public void Constructor_SetsLengthAndPosition()
        {
            var span = new ReadOnlySpan<byte>(new byte[10]);
            var stream = new ReadOnlySpanStream(span);
            Assert.Equal(10, stream.Length);
            Assert.Equal(0, stream.Position);
        }

        [Fact]
        public void Position_SetsAndThrowsIfOutOfBounds()
        {
            var span = new ReadOnlySpan<byte>(new byte[10]);
            var stream = new ReadOnlySpanStream(span);

            stream.Position = 5;
            Assert.Equal(5, stream.Position);

            // Cannot use Assert.Throws with ref structs, use try/catch
            bool threw1 = false;
            try { stream.Position = -1; } catch (ArgumentOutOfRangeException) { threw1 = true; }
            Assert.True(threw1);

            bool threw2 = false;
            try { stream.Position = 11; } catch (ArgumentOutOfRangeException) { threw2 = true; }
            Assert.True(threw2);
        }

        [Fact]
        public void SetLength_SetsAndThrowsIfOutOfBounds()
        {
            var span = new ReadOnlySpan<byte>(new byte[10]);
            var stream = new ReadOnlySpanStream(span);

            stream.SetLength(5);
            Assert.Equal(5, stream.Length);

            bool threw1 = false;
            try { stream.SetLength(-1); } catch (System.Exception e) when (e is System.ArgumentOutOfRangeException || e is System.NotSupportedException) { threw1 = true; }
            Assert.True(threw1);

            bool threw2 = false;
            try { stream.SetLength(11); } catch (System.Exception e) when (e is System.ArgumentOutOfRangeException || e is System.NotSupportedException) { threw2 = true; }
            Assert.True(threw2);
        }

        [Fact]
        public void Flush_DoesNothing()
        {
            var span = new ReadOnlySpan<byte>(new byte[10]);
            var stream = new ReadOnlySpanStream(span);
            stream.Flush(); // Ensure no exception is thrown
        }

        [Fact]
        public void Properties_AreCorrect()
        {
            var span = new ReadOnlySpan<byte>(new byte[10]);
            var stream = new ReadOnlySpanStream(span);

            Assert.True(stream.CanRead);
            Assert.True(stream.CanSeek);
            Assert.False(stream.CanWrite);
        }

        [Fact]
        public void Read_ReadsCorrectlyAndAdvancesPosition()
        {
            var span = new ReadOnlySpan<byte>(new byte[] { 1, 2, 3, 4, 5 });
            var stream = new ReadOnlySpanStream(span);
            var buffer = new byte[3];

            var readCount = stream.Read(buffer, 0, 3);

            Assert.Equal(3, readCount);
            Assert.Equal(3, stream.Position);
            Assert.Equal(new byte[] { 1, 2, 3 }, buffer);
        }

        [Fact]
        public void Read_ThrowsIfBufferNull()
        {
            var span = new ReadOnlySpan<byte>(new byte[10]);
            var stream = new ReadOnlySpanStream(span);

            bool threw = false;
            try { stream.Read(null!, 0, 1); } catch (ArgumentNullException) { threw = true; }
            Assert.True(threw);
        }

        [Fact]
        public void Write_ThrowsReadOnlyException()
        {
            var span = new ReadOnlySpan<byte>(new byte[10]);
            var stream = new ReadOnlySpanStream(span);
            var buffer = new byte[3];

            bool threw = false;
            try { stream.Write(buffer, 0, 3); } catch (System.Exception e) when (e is System.Data.ReadOnlyException || e is System.NotSupportedException) { threw = true; }
            Assert.True(threw);
        }
    }
}
