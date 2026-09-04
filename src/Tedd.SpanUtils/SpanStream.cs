using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace Tedd
{
    /// <summary>A fixed-capacity, allocation-free binary stream over caller-owned memory.</summary>
    public ref partial struct SpanStream
    {
        private Span<byte> Span;
        private int _position;
        private int _length;

        public SpanStream(Span<byte> span) : this(span, span.Length) { }

        /// <summary>Wraps a buffer with an explicit logical length; use zero for a new writer.</summary>
        public SpanStream(Span<byte> span, int length)
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
        public Span<byte> WrittenSpan => Span.Slice(0, _length);
        public bool CanRead => true;
        public bool CanWrite => true;
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

        private Span<byte> ReadBuffer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => Span.Slice(_position, Math.Max(0, _length - _position));
        }

        private Span<byte> WriteBuffer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)] get => Span.Slice(_position);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void AdvanceWrite(int count)
        {
            if (count == 0) return;
            if (_position > _length) Span.Slice(_length, _position - _length).Clear();
            _position += count;
            if (_position > _length) _length = _position;
        }

        public long Seek(long offset, SeekOrigin origin)
        {
            _position = StreamBounds.Seek(_position, _length, Capacity, offset, origin);
            return _position;
        }

        public void SetLength(long value)
        {
            if ((ulong)value > (ulong)Span.Length) throw new ArgumentOutOfRangeException(nameof(value));
            int length = (int)value;
            if (length > _length) Span.Slice(_length, length - _length).Clear();
            _length = length;
            if (_position > length) _position = length;
        }

        /// <summary>Zeroes the logical content (or the entire capacity) and resets length and position.</summary>
        public void Clear(bool all = false)
        {
            Span.Slice(0, all ? Span.Length : _length).Clear();
            _position = 0;
            _length = 0;
        }

        public void Flush() { }

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

        /// <summary>Reads all requested bytes, throwing without advancing if insufficient content remains.</summary>
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

        public void Write(byte[] buffer, int offset, int count)
        {
            StreamBounds.ValidateBuffer(buffer, offset, count);
            Write((ReadOnlySpan<byte>)buffer.AsSpan(offset, count));
        }

        public void WriteByte(byte value) => Write(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte MeasureWriteSize(uint value) => value.MeasureWriteSize();
    }
}
