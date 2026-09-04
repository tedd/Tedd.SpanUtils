using System;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Tedd.SpanUtilsTests
{
    public class StreamV2Tests
    {
        [Fact]
        public void SpanCursorUsesLogicalLengthAndClearsGaps()
        {
            var bytes = Enumerable.Repeat((byte)0xCC, 16).ToArray();
            var stream = new SpanStream(bytes, 0);
            stream.Position = 4;
            Assert.Equal(0, stream.Length);
            stream.Write(0x01020304);
            Assert.Equal(8, stream.Length);
            Assert.Equal(new byte[4], bytes.AsSpan(0, 4).ToArray());
            Assert.Equal(8, stream.Seek(0, SeekOrigin.End));
            stream.Seek(-4, SeekOrigin.End);
            Assert.Equal(0x01020304, stream.ReadInt32());
            Assert.Equal(0, stream.Read(new byte[16]));
            Assert.Equal(8, stream.Position);
            Assert.Equal(8, stream.Length);
            stream.SetLength(2);
            Assert.Equal(2, stream.Position);
            Assert.Equal(0, stream.Read(new byte[16]));
        }

        [Fact]
        public void SpanReadsAndFailedWritesDoNotAdvanceOrMutate()
        {
            var bytes = Enumerable.Repeat((byte)0xCC, 8).ToArray();
            var stream = new SpanStream(bytes, 1);
            bool threw = false;
            try { stream.ReadInt64(); }
            catch (ArgumentOutOfRangeException) { threw = true; }
            Assert.True(threw);
            Assert.Equal(0, stream.Position);
            Assert.False(stream.TryReadInt64(out _));
            var destination = new byte[] { 9, 9 };
            Assert.False(stream.TryRead(destination));
            Assert.Equal(new byte[] { 9, 9 }, destination);
            stream.Position = 7;
            Assert.False(stream.TryWrite(123));
            threw = false;
            try { stream.WriteSized("payload"); }
            catch (ArgumentException) { threw = true; }
            Assert.True(threw);
            Assert.Equal(7, stream.Position);
            Assert.Equal(1, stream.Length);
            Assert.All(bytes, value => Assert.Equal(0xCC, value));
        }

        [Fact]
        public void ReadOnlySpanHonorsLengthAndSupportsTryReads()
        {
            var stream = new ReadOnlySpanStream(new byte[] { 1, 2, 3, 4 }, 2);
            Assert.True(stream.TryReadByte(out var value));
            Assert.Equal(1, value);
            Assert.False(stream.TryReadInt32(out _));
            Assert.Equal(1, stream.Position);
            var output = new byte[4];
            Assert.Equal(1, stream.Read(output));
            Assert.Equal(2, output[0]);
            Assert.Equal(2, stream.Seek(0, SeekOrigin.End));
            stream.Position = 4;
            Assert.Equal(0, stream.Read(output));
            Assert.Equal(2, stream.Length);
            bool threw = false;
            try { stream.SetLength(1); }
            catch (NotSupportedException) { threw = true; }
            Assert.True(threw);
        }

        [Fact]
        public void ClearErasesLogicalContentRegardlessOfCursor()
        {
            var bytes = Enumerable.Repeat((byte)0xCC, 8).ToArray();
            var span = new SpanStream(bytes, 4);
            span.Position = 1;
            span.Clear();
            Assert.Equal(new byte[4], bytes.AsSpan(0, 4).ToArray());
            Assert.Equal(0xCC, bytes[4]);
            Assert.Equal(0, span.Length);
            span.Clear(true);
            Assert.All(bytes, value => Assert.Equal(0, value));
            bytes.AsSpan().Fill(0xCC);
            using var memory = new MemoryStreamer(bytes, 4);
            memory.Position = 1;
            memory.Clear();
            Assert.Equal(new byte[4], bytes.AsSpan(0, 4).ToArray());
            Assert.Equal(0xCC, bytes[4]);
            Assert.Equal(0, memory.Length);
            memory.Clear(true);
            Assert.All(bytes, value => Assert.Equal(0, value));
        }

        [Fact]
        public void MemoryStreamOverridesHonorEofAndLength()
        {
            using var memory = new MemoryStreamer(new byte[16], 0);
            Stream stream = memory;
            stream.Write(new byte[] { 1, 2, 3 }.AsSpan());
            stream.WriteByte(4);
            Assert.Equal(4, stream.Length);
            stream.Position = 0;
            Assert.Equal(1, stream.ReadByte());
            var output = new byte[16];
            Assert.Equal(3, stream.Read(output.AsSpan()));
            Assert.Equal(new byte[] { 2, 3, 4 }, output.AsSpan(0, 3).ToArray());
            Assert.Equal(-1, memory.ReadByte());
            Assert.Equal(-1, stream.ReadByte());
            Assert.Equal(4, stream.Length);
            stream.Position = 12;
            Assert.Equal(4, stream.Length);
            Assert.Equal(-1, stream.ReadByte());
            stream.WriteByte(5);
            Assert.Equal(13, stream.Length);
            Assert.Equal(new byte[8], memory.WrittenMemory.Span.Slice(4, 8).ToArray());
        }

        [Fact]
        public void SeekUsesLogicalEndAndRejectsInvalidInputAtomically()
        {
            using var stream = new MemoryStreamer(new byte[16], 8);
            Assert.Equal(8, stream.Seek(0, SeekOrigin.End));
            Assert.Equal(6, stream.Seek(-2, SeekOrigin.End));
            Assert.Equal(7, stream.Seek(1, SeekOrigin.Current));
            Assert.Equal(8, stream.Length);
            Assert.Throws<ArgumentOutOfRangeException>(() => stream.Seek(long.MaxValue, SeekOrigin.Current));
            Assert.Throws<ArgumentOutOfRangeException>(() => stream.Seek(long.MinValue, SeekOrigin.End));
            Assert.Throws<ArgumentOutOfRangeException>(() => stream.Seek(0, (SeekOrigin)9));
            Assert.Equal(7, stream.Position);
            using var readOnly = new ReadOnlyMemoryStreamer(new byte[16], 8);
            Assert.Equal(8, readOnly.Seek(0, SeekOrigin.End));
            Assert.Equal(6, readOnly.Seek(-2, SeekOrigin.End));
            Assert.Throws<ArgumentOutOfRangeException>(() => readOnly.Seek(long.MaxValue, SeekOrigin.End));
            Assert.Equal(6, readOnly.Position);
        }

        [Fact]
        public void SetLengthClearsExpansionAndClampsPosition()
        {
            var bytes = Enumerable.Repeat((byte)0xCC, 8).ToArray();
            using var stream = new MemoryStreamer(bytes, 2);
            stream.SetLength(6);
            Assert.Equal(new byte[4], bytes.AsSpan(2, 4).ToArray());
            stream.Position = 6;
            stream.SetLength(1);
            Assert.Equal(1, stream.Position);
            Assert.Equal(-1, stream.ReadByte());
            Assert.Throws<ArgumentOutOfRangeException>(() => stream.SetLength(-1));
            Assert.Throws<ArgumentOutOfRangeException>(() => stream.SetLength(9));
        }

        [Fact]
        public void TypedMemoryOperationsAreAtomicAtLogicalEnd()
        {
            var bytes = Enumerable.Repeat((byte)0xCC, 8).ToArray();
            using var stream = new MemoryStreamer(bytes, 1);
            Assert.Throws<ArgumentOutOfRangeException>(() => stream.ReadInt64());
            Assert.False(stream.TryReadInt64(out _));
            Assert.Equal(0, stream.Position);
            Assert.Equal(1, stream.Length);
            Assert.Throws<EndOfStreamException>(() => stream.ReadExactly(new byte[2]));
            Assert.Equal(0, stream.Position);
            stream.Position = 7;
            Assert.Throws<ArgumentException>(() => stream.WriteSized("payload"));
            Assert.False(stream.TryWrite(123));
            Assert.Equal(7, stream.Position);
            Assert.Equal(1, stream.Length);
            Assert.All(bytes, value => Assert.Equal(0xCC, value));
        }

        [Fact]
        public void ReadOnlyMemoryEnforcesItsContract()
        {
            using var stream = new ReadOnlyMemoryStreamer(new byte[] { 1, 2, 3, 4 }, 2);
            Assert.False(stream.CanWrite);
            Assert.Throws<NotSupportedException>(() => stream.SetLength(1));
            Assert.Throws<NotSupportedException>(() => stream.WriteByte(1));
            Assert.Throws<NotSupportedException>(() => stream.Write(new byte[1].AsSpan()));
            Assert.Throws<NotSupportedException>(() => stream.Clear());
            Assert.Throws<ArgumentOutOfRangeException>(() => stream.ReadInt64());
            Assert.Equal(0, stream.Position);
            Assert.True(stream.TryReadByte(out var value));
            Assert.Equal(1, value);
            Assert.Equal(2, stream.ReadByte());
            Assert.Equal(-1, stream.ReadByte());
        }

        [Fact]
        public void DisposalAppliesToTypedAndStandardOperations()
        {
            var stream = new MemoryStreamer(new byte[16]);
            stream.Dispose();
            Assert.False(stream.CanRead);
            Assert.False(stream.CanWrite);
            Assert.False(stream.CanSeek);
            Assert.Throws<ObjectDisposedException>(() => stream.ReadByte());
            Assert.Throws<ObjectDisposedException>(() => stream.ReadInt32());
            Assert.Throws<ObjectDisposedException>(() => stream.TryReadInt32(out _));
            Assert.Throws<ObjectDisposedException>(() => stream.Write(1));
            Assert.Throws<ObjectDisposedException>(() => stream.TryWrite(1));
            Assert.Throws<ObjectDisposedException>(() => stream.Flush());
            var readOnly = new ReadOnlyMemoryStreamer(new byte[16]);
            readOnly.Dispose();
            Assert.False(readOnly.CanRead);
            Assert.False(readOnly.CanSeek);
            Assert.Throws<ObjectDisposedException>(() => readOnly.ReadByte());
            Assert.Throws<ObjectDisposedException>(() => readOnly.ReadInt32());
            Assert.Throws<ObjectDisposedException>(() => readOnly.TryReadInt32(out _));
        }

        [Fact]
        public async Task AsyncMemoryOverridesCompleteAndHonorCancellation()
        {
            using var stream = new MemoryStreamer(new byte[16], 0);
            await stream.WriteAsync(new byte[] { 1, 2, 3 }.AsMemory());
            Assert.Equal(3, stream.Length);
            var canceled = new CancellationToken(true);
            await Assert.ThrowsAnyAsync<OperationCanceledException>(() => stream.WriteAsync(new byte[] { 4 }.AsMemory(), canceled).AsTask());
            Assert.Equal(3, stream.Position);
            stream.Position = 0;
            var output = new byte[16];
            var read = stream.ReadAsync(output.AsMemory());
            Assert.True(read.IsCompletedSuccessfully);
            Assert.Equal(3, await read);
            await Assert.ThrowsAnyAsync<OperationCanceledException>(() => stream.ReadAsync(output.AsMemory(), canceled).AsTask());
            Assert.Equal(3, stream.Position);
            using var readOnly = new ReadOnlyMemoryStreamer(output, 3);
            Assert.Equal(3, await readOnly.ReadAsync(new byte[16].AsMemory()));
            await Assert.ThrowsAsync<NotSupportedException>(() => readOnly.WriteAsync(new byte[1].AsMemory()).AsTask());
        }

        [Fact]
        public void VariableReadersValidateBeforeAdvancing()
        {
            using var memory = new MemoryStreamer(new byte[128], 0);
            Assert.True(memory.TryWriteVInt(16_383, out int vintLength));
            Assert.True(memory.TryWriteVLQ(long.MinValue, out int vlqLength));
            Assert.True(memory.TryWriteSized("text", out int textLength));
            Assert.Equal(vintLength + vlqLength + textLength, memory.Length);
            memory.Position = 0;
            Assert.True(memory.TryReadVInt(out var vint));
            Assert.Equal(16_383UL, vint.Value);
            Assert.True(memory.TryReadVLQInt64(out var signed));
            Assert.Equal(long.MinValue, signed);
            Assert.True(memory.TryReadSizedString(out var text));
            Assert.Equal("text", text);
            Assert.Equal(memory.Length, memory.Position);

            var span = new SpanStream(new byte[32], 0);
            span.WriteVInt(127);
            span.WriteSized(new byte[] { 1, 2, 3 });
            var reader = new ReadOnlySpanStream(span.WrittenSpan);
            Assert.Equal(127UL, reader.ReadVInt().Value);
            Assert.True(reader.TryReadSizedReadOnlySpan(out var payload, out int consumed));
            Assert.Equal(new byte[] { 1, 2, 3 }, payload.ToArray());
            Assert.Equal(4, consumed);
            Assert.Equal(reader.Length, reader.Position);

            var truncatedPayload = new ReadOnlySpanStream(new byte[] { 3, 1, 2 });
            Assert.False(truncatedPayload.TryReadSizedReadOnlySpan(out _, out consumed));
            Assert.Equal(0, consumed);
            Assert.Equal(0, truncatedPayload.Position);
            var truncatedVlq = new ReadOnlySpanStream(new byte[] { 0x80 });
            Assert.False(truncatedVlq.TryReadVLQUInt64(out _));
            Assert.Equal(0, truncatedVlq.Position);
            var truncatedVInt = new ReadOnlySpanStream(new byte[] { 0x40 });
            Assert.False(truncatedVInt.TryReadVInt(out _));
            Assert.Equal(0, truncatedVInt.Position);
        }

        [Fact]
        public void TryPrimitiveRejectsInvalidRepresentationsAndValues()
        {
            var bytes = new byte[16];
            bytes[12] = 1; // Decimal reserved flag bit in the portable little-endian representation.
            using var reader = new ReadOnlyMemoryStreamer(bytes);
            Assert.False(reader.TryReadDecimalLE(out _, out int consumed));
            Assert.Equal(0, consumed);
            Assert.Equal(0, reader.Position);
            using var writer = new MemoryStreamer(bytes);
            Assert.False(writer.TryWriteInt24(8_388_608, out int written));
            Assert.Equal(0, written);
            Assert.Equal(0, writer.Position);
            Assert.Equal(1, bytes[12]);
        }
        [Fact]
        public void SpanWriterSupportsTemporaryBuffersAndRawUtf8()
        {
            var stream = new SpanStream(new byte[32], 0);
            stream.Write(stackalloc byte[] { 1, 2 });
            Assert.True(stream.TryWrite(stackalloc byte[] { 3, 4 }));
            stream.WriteSized(stackalloc byte[] { 5, 6 });
            stream.WriteString("æ", out int utf8Length);
            Assert.Equal(2, utf8Length);
            stream.Position = 0;
            Assert.True(stream.TryReadSpan(4, out var payload));
            Assert.Equal(new byte[] { 1, 2, 3, 4 }, payload.ToArray());
            Assert.True(stream.TryReadSizedReadOnlySpan(out var sizedPayload));
            Assert.Equal(new byte[] { 5, 6 }, sizedPayload.ToArray());
            Assert.True(stream.TryReadString(utf8Length, out var text));
            Assert.Equal("æ", text);
            Assert.Equal(stream.Length, stream.Position);
            Assert.False(stream.TryRead(stackalloc byte[1]));
            var readOnly = new ReadOnlySpanStream(stream.WrittenSpan);
            readOnly.ReadExactly(stackalloc byte[2]);
            Assert.Equal(2, readOnly.Position);
        }
        [Fact]
        public void NewPrimitiveWrappersRoundTrip()
        {
            using var stream = new MemoryStreamer(new byte[128], 0);
            stream.WriteInt24BE(-12345);
#if NET6_0_OR_GREATER && !STANDARD_ASSET
            stream.WriteBE((Half)1.5);
#endif
#if NET7_0_OR_GREATER && !STANDARD_ASSET
            stream.WriteBE((Int128)long.MaxValue + 1);
            stream.WriteLE((UInt128)ulong.MaxValue + 1);
#endif
            long length = stream.Length;
            stream.Position = 0;
            Assert.Equal(-12345, stream.ReadInt24BE());
#if NET6_0_OR_GREATER && !STANDARD_ASSET
            Assert.Equal((Half)1.5, stream.ReadHalfBE());
#endif
#if NET7_0_OR_GREATER && !STANDARD_ASSET
            Assert.Equal((Int128)long.MaxValue + 1, stream.ReadInt128BE());
            Assert.Equal((UInt128)ulong.MaxValue + 1, stream.ReadUInt128LE());
#endif
            Assert.Equal(length, stream.Position);
            Assert.Equal(length, stream.Length);
        }
    }
}
