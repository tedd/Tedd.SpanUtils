using Xunit;
using Tedd;
using System;
using System.IO;
using System.Data;

namespace Tedd.Tests
{
    public class SpanStreamTests
    {
        [Fact]
        public void Constructor_SetsLengthAndPosition()
        {
            var span = new Span<byte>(new byte[10]);
            var stream = new SpanStream(span);
            Assert.Equal(10, stream.Length);
            Assert.Equal(0, stream.Position);
        }

        [Fact]
        public void Position_SetsAndThrowsIfOutOfBounds()
        {
            var span = new Span<byte>(new byte[10]);
            var stream = new SpanStream(span);

            stream.Position = 5;
            Assert.Equal(5, stream.Position);

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
            var span = new Span<byte>(new byte[10]);
            var stream = new SpanStream(span);

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
            var span = new Span<byte>(new byte[10]);
            var stream = new SpanStream(span);
            stream.Flush(); // Ensure no exception is thrown
        }

        [Fact]
        public void Clear_ClearsUntilPosition()
        {
            var buffer = new byte[] { 1, 2, 3, 4, 5 };
            var span = new Span<byte>(buffer);
            var stream = new SpanStream(span);
            stream.Position = 2;
            stream.Clear(false);

            Assert.Equal(0, stream.Position);
            Assert.True(stream.Length == 5 || stream.Length == 0);
            Assert.Equal(new byte[] { 0, 0, 3, 4, 5 }, buffer);
        }

        [Fact]
        public void Clear_All_ClearsWholeMemory()
        {
            var buffer = new byte[] { 1, 2, 3, 4, 5 };
            var span = new Span<byte>(buffer);
            var stream = new SpanStream(span);
            stream.Position = 2;
            stream.Clear(true);

            Assert.Equal(0, stream.Position);
            Assert.True(stream.Length == 5 || stream.Length == 0);
            Assert.Equal(new byte[] { 0, 0, 0, 0, 0 }, buffer);
        }

        [Fact]
        public void Properties_AreCorrect()
        {
            var span = new Span<byte>(new byte[10]);
            var stream = new SpanStream(span);

            Assert.True(stream.CanRead);
            Assert.True(stream.CanSeek);
            Assert.True(stream.CanWrite);
        }

        [Fact]
        public void Read_ReadsCorrectlyAndAdvancesPosition()
        {
            var span = new Span<byte>(new byte[] { 1, 2, 3, 4, 5 });
            var stream = new SpanStream(span);
            var buffer = new byte[3];

            var readCount = stream.Read(buffer, 0, 3);

            Assert.Equal(3, readCount);
            Assert.Equal(3, stream.Position);
            Assert.Equal(new byte[] { 1, 2, 3 }, buffer);
        }

        [Fact]
        public void Read_ThrowsIfBufferNull()
        {
            var span = new Span<byte>(new byte[10]);
            var stream = new SpanStream(span);

            bool threw = false;
            try { stream.Read(null!, 0, 1); } catch (ArgumentNullException) { threw = true; }
            Assert.True(threw);
        }

        [Fact]
        public void Write_WritesCorrectlyAndAdvancesPosition()
        {
            var buffer = new byte[5];
            var span = new Span<byte>(buffer);
            var stream = new SpanStream(span);
            var writeBuffer = new byte[] { 1, 2, 3 };

            stream.Write(writeBuffer, 0, 3);

            Assert.Equal(3, stream.Position);
            Assert.Equal(new byte[] { 1, 2, 3, 0, 0 }, buffer);
        }

        [Fact]
        public void Write_ThrowsIfBufferNull()
        {
            var span = new Span<byte>(new byte[10]);
            var stream = new SpanStream(span);

            bool threw = false;
            try { stream.Write(null!, 0, 1); } catch (ArgumentNullException) { threw = true; }
            Assert.True(threw);
        }

        [Fact]
        public void MeasureWriteSize_DelegatesToUInt32Extensions()
        {
            var span = new Span<byte>(new byte[10]);
            var stream = new SpanStream(span);

            Assert.Equal(((uint)126).MeasureWriteSize(), stream.MeasureWriteSize(126));
            Assert.Equal(((uint)128).MeasureWriteSize(), stream.MeasureWriteSize(128));
        }
    }
}
