using System;
using System.Linq;
using System.Runtime.InteropServices;
using Xunit;

namespace Tedd.SpanUtilsTests
{
    public class MemoryViewTests
    {
        [Fact]
        public void WritableMemoryViewsAliasTheOriginalBuffer()
        {
            var bytes = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            using var stream = new MemoryStreamer(bytes, 6);
            Memory<byte> first = stream.ReadMemory(2);
            first.Span[1] = 9;
            Assert.Equal(9, bytes[1]);
            Assert.True(MemoryMarshal.TryGetArray((ReadOnlyMemory<byte>)first, out var segment));
            Assert.Same(bytes, segment.Array);
            Assert.Equal(0, segment.Offset);
            Assert.Equal(2, segment.Count);
            Assert.True(stream.TryReadMemory(2, out var second));
            Assert.Equal(new byte[] { 3, 4 }, second.ToArray());
            Assert.False(stream.TryReadMemory(3, out var missing));
            Assert.True(missing.IsEmpty);
            Assert.Throws<ArgumentOutOfRangeException>(() => stream.ReadMemory(3));
            Assert.Throws<ArgumentOutOfRangeException>(() => stream.ReadMemory(-1));
            Assert.False(stream.TryReadMemory(-1, out _));
            Assert.Equal(4, stream.Position);
            Assert.Equal(6, stream.Length);
            stream.Position = 8;
            Assert.True(stream.ReadMemory(0).IsEmpty);
            Assert.False(stream.TryReadMemory(1, out _));
            Assert.Equal(8, stream.Position);
        }

        [Fact]
        public void ReadOnlyMemoryViewsAliasSlicedBackingMemory()
        {
            var bytes = new byte[] { 10, 20, 30, 40, 50, 60 };
            using var stream = new ReadOnlyMemoryStreamer(bytes.AsMemory(1, 4), 3);
            ReadOnlyMemory<byte> first = stream.ReadMemory(2);
            Assert.True(MemoryMarshal.TryGetArray(first, out var segment));
            Assert.Same(bytes, segment.Array);
            Assert.Equal(1, segment.Offset);
            bytes[2] = 99;
            Assert.Equal(new byte[] { 20, 99 }, first.ToArray());
            Assert.False(stream.TryReadMemory(2, out _));
            Assert.Throws<ArgumentOutOfRangeException>(() => stream.ReadMemory(2));
            Assert.Equal(2, stream.Position);
            Assert.True(stream.TryReadMemory(1, out var last));
            Assert.Equal(40, last.Span[0]);
            Assert.Equal(3, stream.Position);
            Assert.Equal(3, stream.Length);
        }

        [Fact]
        public void SizedMemoryViewsExcludePrefixAndReportTotalConsumedLength()
        {
            var bytes = new byte[128];
            using var writer = new MemoryStreamer(bytes, 0);
            writer.WriteMemory(new byte[] { 42 }, out int rawLength);
            writer.WriteSizedMemory(new byte[] { 10, 20, 30 }, out int sizedLength);
            Assert.Equal(1, rawLength);
            Assert.Equal(4, sizedLength);
            writer.Position = rawLength;
            Memory<byte> writable = writer.ReadSizedMemory(out int consumed);
            Assert.Equal(sizedLength, consumed);
            Assert.Equal(5, writer.Position);
            writable.Span[0] = 99;
            Assert.Equal(99, bytes[2]);
            using var reader = new ReadOnlyMemoryStreamer(writer.WrittenMemory);
            reader.Position = rawLength;
            Assert.True(reader.TryReadSizedMemory(out var readOnly, out consumed));
            Assert.Equal(sizedLength, consumed);
            Assert.Equal(new byte[] { 99, 20, 30 }, readOnly.ToArray());
            Assert.True(MemoryMarshal.TryGetArray(readOnly, out var segment));
            Assert.Same(bytes, segment.Array);
            Assert.Equal(2, segment.Offset);
            reader.Position = rawLength;
            Assert.Equal(readOnly, reader.ReadSizedMemory());
            writer.Position = rawLength;
            Assert.True(writer.TryReadSizedMemory(out var second));
            Assert.Equal(writable, second);
        }

        [Theory]
        [InlineData(new byte[] { 0x40 })]
        [InlineData(new byte[] { 3, 1, 2 })]
        public void TruncatedSizedMemoryDoesNotAdvance(byte[] bytes)
        {
            using var writable = new MemoryStreamer(bytes);
            Assert.False(writable.TryReadSizedMemory(out var missing, out int length));
            Assert.True(missing.IsEmpty);
            Assert.Equal(0, length);
            Assert.ThrowsAny<ArgumentException>(() => writable.ReadSizedMemory());
            Assert.Equal(0, writable.Position);
            using var readOnly = new ReadOnlyMemoryStreamer(bytes);
            Assert.False(readOnly.TryReadSizedMemory(out var readOnlyMissing, out length));
            Assert.True(readOnlyMissing.IsEmpty);
            Assert.Equal(0, length);
            Assert.ThrowsAny<ArgumentException>(() => readOnly.ReadSizedMemory());
            Assert.Equal(0, readOnly.Position);
            Assert.Equal(bytes.Length, writable.Length);
            Assert.Equal(bytes.Length, readOnly.Length);
        }

        [Fact]
        public void SizedMemoryReadsRespectLogicalLengthAndMultiBytePrefixes()
        {
            var bytes = new byte[128];
            var payload = Enumerable.Range(0, 64).Select(value => (byte)value).ToArray();
            using var writer = new MemoryStreamer(bytes, 0);
            Assert.True(writer.TryWriteSizedMemory(payload, out int written));
            Assert.Equal(66, written);
            writer.Position = 0;
            Assert.Equal(payload, writer.ReadSizedMemory().ToArray());
            using var reader = new ReadOnlyMemoryStreamer(bytes, 65);
            Assert.False(reader.TryReadSizedMemory(out _, out int consumed));
            Assert.Equal(0, consumed);
            Assert.Equal(0, reader.Position);
            writer.SetLength(65);
            writer.Position = 0;
            Assert.False(writer.TryReadSizedMemory(out _));
            Assert.Equal(0, writer.Position);
        }

        [Fact]
        public void MemoryWriteHelpersPreserveOverlappingInputAndFailAtomically()
        {
            var bytes = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            using var stream = new MemoryStreamer(bytes, 0);
            stream.WriteSizedMemory(bytes.AsMemory(0, 4));
            Assert.Equal(new byte[] { 4, 1, 2, 3, 4 }, bytes.AsSpan(0, 5).ToArray());
            Assert.Equal(5, stream.Length);
            var snapshot = bytes.ToArray();
            Assert.False(stream.TryWriteSizedMemory(new byte[3], out int written));
            Assert.Equal(0, written);
            Assert.False(stream.TryWriteMemory(new byte[4]));
            Assert.Throws<ArgumentException>(() => stream.WriteSizedMemory(new byte[3]));
            Assert.Equal(snapshot, bytes);
            Assert.Equal(5, stream.Position);
            Assert.Equal(5, stream.Length);
            Assert.True(stream.TryWriteMemory(new byte[] { 9 }, out written));
            Assert.Equal(1, written);
            Assert.Equal(6, stream.Length);
        }

        [Fact]
        public void EmptySizedMemoryStillConsumesItsPrefix()
        {
            using var stream = new MemoryStreamer(new byte[2], 0);
            Assert.True(stream.TryWriteSizedMemory(ReadOnlyMemory<byte>.Empty, out int written));
            Assert.Equal(1, written);
            stream.Position = 0;
            Assert.True(stream.TryReadSizedMemory(out var empty, out int consumed));
            Assert.True(empty.IsEmpty);
            Assert.Equal(1, consumed);
            Assert.Equal(1, stream.Position);
            using var readOnly = new ReadOnlyMemoryStreamer(stream.WrittenMemory);
            Assert.True(readOnly.TryReadSizedMemory(out var readOnlyEmpty));
            Assert.True(readOnlyEmpty.IsEmpty);
            Assert.Equal(1, readOnly.Position);
        }
        [Fact]
        public void MemoryViewsEnforceDisposalWithoutInvalidatingPriorViews()
        {
            var bytes = new byte[] { 1, 2, 3, 4 };
            var stream = new MemoryStreamer(bytes);
            var view = stream.ReadMemory(2);
            stream.Dispose();
            Assert.Equal(new byte[] { 1, 2 }, view.ToArray());
            Assert.Throws<ObjectDisposedException>(() => stream.ReadMemory(0));
            Assert.Throws<ObjectDisposedException>(() => stream.TryReadMemory(0, out _));
            Assert.Throws<ObjectDisposedException>(() => stream.ReadSizedMemory());
            Assert.Throws<ObjectDisposedException>(() => stream.TryReadSizedMemory(out _));
            Assert.Throws<ObjectDisposedException>(() => stream.WriteMemory(ReadOnlyMemory<byte>.Empty));
            Assert.Throws<ObjectDisposedException>(() => stream.TryWriteSizedMemory(ReadOnlyMemory<byte>.Empty));
            var readOnly = new ReadOnlyMemoryStreamer(bytes);
            readOnly.Dispose();
            Assert.Throws<ObjectDisposedException>(() => readOnly.ReadMemory(0));
            Assert.Throws<ObjectDisposedException>(() => readOnly.TryReadMemory(0, out _));
            Assert.Throws<ObjectDisposedException>(() => readOnly.ReadSizedMemory());
            Assert.Throws<ObjectDisposedException>(() => readOnly.TryReadSizedMemory(out _));
        }
    }
}
