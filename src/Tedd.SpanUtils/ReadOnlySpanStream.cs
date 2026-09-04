using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace Tedd
{
    /// <summary>A fixed-capacity, allocation-free binary reader over caller-owned read-only memory.</summary>
    public ref partial struct ReadOnlySpanStream
    {
        private ReadOnlySpan<byte> Span;
        private int _position;
        private readonly int _length;

        public ReadOnlySpanStream(ReadOnlySpan<byte> span) : this(span, span.Length) { }

        public ReadOnlySpanStream(ReadOnlySpan<byte> span, int length)
        {
            if ((uint)length > (uint)span.Length) throw new ArgumentOutOfRangeException(nameof(length));
            Span = span;
            _position = 0;
            _length = length;
        }

        public int Length => _length;
        public int Capacity => Span.Length;
        public int MaxLength => Capacity;
        public int Remaining => Math.Max(0, _length - _position);
        public ReadOnlySpan<byte> WrittenSpan => Span.Slice(0, _length);
        public bool CanRead => true;
        public bool CanWrite => false;
        public bool CanSeek => true;

        public int Position
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)] get => _position;
            set
            {
                if ((uint)value > (uint)Span.Length) throw new ArgumentOutOfRangeException(nameof(value));
                _position = value;
            }
        }

        private ReadOnlySpan<byte> ReadBuffer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => Span.Slice(_position, Math.Max(0, _length - _position));
        }

        public long Seek(long offset, SeekOrigin origin)
        {
            _position = StreamBounds.Seek(_position, _length, Capacity, offset, origin);
            return _position;
        }

        public void SetLength(long value) => throw new NotSupportedException("The stream is read-only.");
        public void Flush() { }
        public void Write(byte[] buffer, int offset, int count) => throw new NotSupportedException("The stream is read-only.");

        public int Read(byte[] buffer, int offset, int count)
        {
            StreamBounds.ValidateBuffer(buffer, offset, count);
            return Read(buffer.AsSpan(offset, count));
        }

        public int Read(scoped Span<byte> buffer)
        {
            int count = Math.Min(buffer.Length, Remaining);
            ReadBuffer.Slice(0, count).CopyTo(buffer);
            _position += count;
            return count;
        }

        public void ReadExactly(scoped Span<byte> buffer)
        {
            if (buffer.Length > Remaining) throw new EndOfStreamException();
            ReadBuffer.Slice(0, buffer.Length).CopyTo(buffer);
            _position += buffer.Length;
        }

        public bool TryRead(scoped Span<byte> buffer)
        {
            if (buffer.Length > Remaining) return false;
            ReadExactly(buffer);
            return true;
        }
    }
}
