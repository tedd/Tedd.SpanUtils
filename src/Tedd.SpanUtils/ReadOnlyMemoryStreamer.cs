using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace Tedd
{
    /// <summary>A fixed-capacity binary stream over caller-owned ReadOnlyMemory.</summary>
    public partial class ReadOnlyMemoryStreamer : Stream
    {
        private readonly ReadOnlyMemory<byte> Memory;
        private int _position;
        private readonly int _length;
        private bool _disposed;

        public ReadOnlyMemoryStreamer(ReadOnlyMemory<byte> memory) : this(memory, memory.Length) { }

        public ReadOnlyMemoryStreamer(ReadOnlyMemory<byte> memory, int length)
        {
            if ((uint)length > (uint)memory.Length) throw new ArgumentOutOfRangeException(nameof(length));
            Memory = memory;
            _length = length;
        }

        public int Capacity { get { EnsureOpen(); return Memory.Length; } }
        public int MaxLength => Capacity;
        public int Remaining { get { EnsureOpen(); return Math.Max(0, _length - _position); } }
        public ReadOnlyMemory<byte> WrittenMemory { get { EnsureOpen(); return Memory.Slice(0, _length); } }
        public override bool CanRead => !_disposed;
        public override bool CanSeek => !_disposed;
        public override bool CanWrite => false;
        public override long Length { get { EnsureOpen(); return _length; } }

        public override long Position
        {
            get { EnsureOpen(); return _position; }
            set
            {
                EnsureOpen();
                if ((ulong)value > (ulong)Memory.Length) throw new ArgumentOutOfRangeException(nameof(value));
                _position = (int)value;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void EnsureOpen()
        {
            if (_disposed) throw new ObjectDisposedException(nameof(ReadOnlyMemoryStreamer));
        }

        private ReadOnlySpan<byte> ReadBuffer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { EnsureOpen(); return Memory.Span.Slice(_position, Math.Max(0, _length - _position)); }
        }

        public override long Seek(long offset, SeekOrigin origin)
        {
            EnsureOpen();
            _position = StreamBounds.Seek(_position, _length, Memory.Length, offset, origin);
            return _position;
        }

        public override void Flush() => EnsureOpen();
        public override Task FlushAsync(CancellationToken cancellationToken)
        {
            EnsureOpen();
            return cancellationToken.IsCancellationRequested ? Task.FromCanceled(cancellationToken) : Task.CompletedTask;
        }

        public void Clear(bool all = false) { EnsureOpen(); throw new NotSupportedException("The stream is read-only."); }
        public override void SetLength(long value) { EnsureOpen(); throw new NotSupportedException("The stream is read-only."); }
        public override void Write(byte[] buffer, int offset, int count) { EnsureOpen(); throw new NotSupportedException("The stream is read-only."); }
        public override void Write(ReadOnlySpan<byte> buffer) { EnsureOpen(); throw new NotSupportedException("The stream is read-only."); }
        public override void WriteByte(byte value) { EnsureOpen(); throw new NotSupportedException("The stream is read-only."); }

        public override int Read(byte[] buffer, int offset, int count)
        {
            StreamBounds.ValidateBuffer(buffer, offset, count);
            return Read(buffer.AsSpan(offset, count));
        }

        public override int Read(Span<byte> buffer)
        {
            var source = ReadBuffer;
            int count = Math.Min(buffer.Length, source.Length);
            source.Slice(0, count).CopyTo(buffer);
            _position += count;
            return count;
        }

        public override int ReadByte()
        {
            EnsureOpen();
            return _position < _length ? Memory.Span[_position++] : -1;
        }

#if NET7_0_OR_GREATER
        public new void ReadExactly(Span<byte> buffer)
#else
        public void ReadExactly(Span<byte> buffer)
#endif
        {
            var source = ReadBuffer;
            if (buffer.Length > source.Length) throw new EndOfStreamException();
            source.Slice(0, buffer.Length).CopyTo(buffer);
            _position += buffer.Length;
        }

        public bool TryRead(Span<byte> buffer)
        {
            var source = ReadBuffer;
            if (buffer.Length > source.Length) return false;
            source.Slice(0, buffer.Length).CopyTo(buffer);
            _position += buffer.Length;
            return true;
        }

        public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
        {
            StreamBounds.ValidateBuffer(buffer, offset, count);
            EnsureOpen();
            if (cancellationToken.IsCancellationRequested) return Task.FromCanceled<int>(cancellationToken);
            try { return Task.FromResult(Read(buffer.AsSpan(offset, count))); }
            catch (Exception exception) { return Task.FromException<int>(exception); }
        }

        public override ValueTask<int> ReadAsync(Memory<byte> buffer, CancellationToken cancellationToken = default)
        {
            EnsureOpen();
            if (cancellationToken.IsCancellationRequested) return new ValueTask<int>(Task.FromCanceled<int>(cancellationToken));
            try { return new ValueTask<int>(Read(buffer.Span)); }
            catch (Exception exception) { return new ValueTask<int>(Task.FromException<int>(exception)); }
        }

        public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
        {
            EnsureOpen();
            if (cancellationToken.IsCancellationRequested) return Task.FromCanceled(cancellationToken);
            return Task.FromException(new NotSupportedException("The stream is read-only."));
        }

        public override ValueTask WriteAsync(ReadOnlyMemory<byte> buffer, CancellationToken cancellationToken = default)
        {
            EnsureOpen();
            if (cancellationToken.IsCancellationRequested) return new ValueTask(Task.FromCanceled(cancellationToken));
            return new ValueTask(Task.FromException(new NotSupportedException("The stream is read-only.")));
        }

        protected override void Dispose(bool disposing)
        {
            _disposed = true;
            base.Dispose(disposing);
        }
    }
}
