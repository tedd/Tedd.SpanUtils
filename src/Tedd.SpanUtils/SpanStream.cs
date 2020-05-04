using System;
using System.Data;
using System.Runtime.CompilerServices;

namespace Tedd
{
    /// <summary>
    /// A ref struct (allocated on stack) that gives similar functionality as System.IO.Stream.
    /// Additionally has all the read/write methods of this library. Read/write will progress position.
    /// </summary>
    public ref struct SpanStream
    {
        private const int SizeofGuid = 16;
        private const int SizeofUInt24 = 3;

        private readonly Span<byte> Span;
        private readonly ReadOnlySpan<byte> ROSpan;
        private int _position;
        public int Length;

        public int Position
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => _position;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                // value != 0 && 
                if (value > ROSpan.Length || value < 0)
                    throw new ArgumentOutOfRangeException(nameof(Position));
                _position = value;
                if (_position > Length)
                    Length = _position;
            }
        }

        public SpanStream(Span<byte> span)
        {
            Span = span;
            ROSpan = (ReadOnlySpan<byte>)span;
            _position = 0;
            Length = 0;
        }

        public SpanStream(ReadOnlySpan<byte> span)
        {
            ROSpan = span;
            _position = 0;
            Span = null;
            Length = 0;
        }

        /// <summary>Sets the length of the current stream.</summary>
        /// <param name="value">The desired length of the current stream in bytes.</param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">Attempt to set length that exceeds the underlying span.</exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetLength(long value)
        {
            if (value > ROSpan.Length || value < 0)
                throw new ArgumentOutOfRangeException(nameof(value));
            Length = (int)value;
        }


        /// <summary>Has no effect on Span.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Flush() { }


        /// <summary>
        /// Fills span with zero.
        /// </summary>
        /// <param name="all">Normally only clears until Length, set all to true to clear the whole underlying span.</param>
        public void Clear(bool all = false)
        {
            if (!CanWrite)
                throw new ReadOnlyException("Span is read-only.");

            if (all)
            {
                Span.Fill(0);
                _position = 0;
                return;
            }

            Span.Slice(0, _position).Fill(0);
            _position = 0;
        }

        /// <summary>Gets a value indicating whether the current stream supports reading.</summary>
        /// <returns>true if the stream supports reading; otherwise, false.</returns>
        public bool CanRead
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => true;
        }

        /// <summary>Gets a value indicating whether the current stream supports seeking.</summary>
        /// <returns>true if the stream supports seeking; otherwise, false.</returns>
        public bool CanSeek
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => true;
        }


        /// <summary>Gets a value indicating whether the current stream supports writing.</summary>
        /// <returns>true if the stream supports writing; otherwise, false.</returns>
        public bool CanWrite
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => Span != null;

        }

        #region Read / Write byte[]
        /// <summary>Reads a sequence of bytes from the current stream and advances the position within the stream by the number of bytes read.</summary>
        /// <param name="buffer">An array of bytes. When this method returns, the buffer contains the specified byte array with the values between offset and (offset + count - 1) replaced by the bytes read from the current source.</param>
        /// <param name="offset">The zero-based byte offset in buffer at which to begin storing the data read from the current stream.</param>
        /// <param name="count">The maximum number of bytes to be read from the current stream.</param>
        /// <returns>The total number of bytes read into the buffer. This can be less than the number of bytes requested if that many bytes are not currently available, or zero (0) if the end of the stream has been reached.</returns>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="buffer">buffer</paramref> is null.</exception>
        /// <exception cref="T:System.ArgumentOutOfRangeException"><paramref name="offset">offset</paramref> or <paramref name="count">count</paramref> is negative, greater than buffer size or greater than remaining destination length.</exception>
        public int Read(byte[] buffer, int offset, int count)
        {
            if (buffer is null)
                throw new ArgumentNullException(nameof(buffer));

            var dst = ((Span<byte>)buffer).Slice(offset, count);
            var src = ROSpan.Slice((int)_position, Math.Min(count, (int)Span.Length - (int)_position));
            src.CopyTo(dst);
            _position += src.Length;
            return src.Length;
        }

        /// <summary>When overridden in a derived class, writes a sequence of bytes to the current stream and advances the current position within this stream by the number of bytes written.</summary>
        /// <param name="buffer">An array of bytes. This method copies count bytes from buffer to the current stream.</param>
        /// <param name="offset">The zero-based byte offset in buffer at which to begin copying bytes to the current stream.</param>
        /// <param name="count">The number of bytes to be written to the current stream.</param>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="buffer">buffer</paramref> is null.</exception>
        /// <exception cref="T:System.ArgumentOutOfRangeException"><paramref name="offset">offset</paramref> or <paramref name="count">count</paramref> is negative, greater than buffer size or greater than remaining destination length.</exception>
        public void Write(byte[] buffer, int offset, int count)
        {
            if (!CanWrite)
                throw new ReadOnlyException("Span is read-only.");
            if (buffer is null)
                throw new ArgumentNullException(nameof(buffer));

            var src = ((Span<byte>)buffer).Slice(offset, count);
            var dst = Span.Slice((int)_position, count);
            src.CopyTo(dst);
            _position += count;
        }

        #endregion

        #region Write
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int Write(byte value)
        {
            if (!CanWrite)
                throw new ReadOnlyException("Span is read-only.");

            var ret = Span.Slice(Position, sizeof(Byte)).Write(value);
            Position += sizeof(Byte);
            return ret;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int Write(SByte value)
        {
            if (!CanWrite)
                throw new ReadOnlyException("Span is read-only.");

            var ret = Span.Slice(Position, sizeof(SByte)).Write(value);
            Position += sizeof(SByte);
            return ret;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int Write(Int16 value)
        {
            if (!CanWrite)
                throw new ReadOnlyException("Span is read-only.");

            var ret = Span.Slice(Position, sizeof(Int16)).Write(value);
            Position += sizeof(Int16);
            return ret;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int Write(UInt16 value)
        {
            if (!CanWrite)
                throw new ReadOnlyException("Span is read-only.");

            var ret = Span.Slice(Position, sizeof(UInt16)).Write(value);
            Position += sizeof(UInt16);
            return ret;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int Write(UInt24 value)
        {
            if (!CanWrite)
                throw new ReadOnlyException("Span is read-only.");

            var ret = Span.Slice(Position, (int)UInt24.Size).Write(value);
            Position += (int)UInt24.Size;
            return ret;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int Write(Int32 value)
        {
            if (!CanWrite)
                throw new ReadOnlyException("Span is read-only.");

            var ret = Span.Slice(Position, sizeof(Int32)).Write(value);
            Position += sizeof(Int32);
            return ret;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int Write(UInt32 value)
        {
            if (!CanWrite)
                throw new ReadOnlyException("Span is read-only.");

            var ret = Span.Slice(Position, sizeof(UInt32)).Write(value);
            Position += sizeof(UInt32);
            return ret;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int Write(Int64 value)
        {
            if (!CanWrite)
                throw new ReadOnlyException("Span is read-only.");

            var ret = Span.Slice(Position, sizeof(Int64)).Write(value);
            Position += sizeof(Int64);
            return ret;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int Write(UInt64 value)
        {
            if (!CanWrite)
                throw new ReadOnlyException("Span is read-only.");

            var ret = Span.Slice(Position, sizeof(UInt64)).Write(value);
            Position += sizeof(UInt64);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int Write(bool value)
        {
            if (!CanWrite)
                throw new ReadOnlyException("Span is read-only.");

            Span.Slice(Position, 1).Write(value);
            return 1;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int Write(Guid value)
        {
            if (!CanWrite)
                throw new ReadOnlyException("Span is read-only.");

            var ret = Span.Slice(Position, 16).Write(value);
            Position += 16;
            return ret;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int Write(byte[] value)
        {
            if (!CanWrite)
                throw new ReadOnlyException("Span is read-only.");

            var ret = Span.Slice(Position).Write(value);
            Position += value.Length;
            return ret;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int Write(Span<byte> value)
        {
            if (!CanWrite)
                throw new ReadOnlyException("Span is read-only.");

            var ret = Span.Slice(Position).Write(value);
            Position += value.Length;
            return ret;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int WriteSize(UInt32 value)
        {
            if (!CanWrite)
                throw new ReadOnlyException("Span is read-only.");

            var length = Span.Slice(Position).WriteSize(value);
            Position += length;
            return length;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int SizedWrite(string value)
        {
            if (!CanWrite)
                throw new ReadOnlyException("Span is read-only.");

            var length = Span.Slice(Position).SizedWrite(value);
            Position += length;
            return length;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int SizedWrite(byte[] value)
        {
            if (!CanWrite)
                throw new ReadOnlyException("Span is read-only.");

            var length = Span.Slice(Position).SizedWrite(value);
            Position += length;
            return length;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int SizedWrite(Span<byte> value)
        {
            if (!CanWrite)
                throw new ReadOnlyException("Span is read-only.");

            var length = Span.Slice(Position).SizedWrite(value);
            Position += length;
            return length;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int SizedWrite(ReadOnlySpan<byte> value)
        {
            if (!CanWrite)
                throw new ReadOnlyException("Span is read-only.");

            var length = Span.Slice(Position).SizedWrite(value);
            Position += length;
            return length;
        }
        /// <summary>
        /// Counts how many bytes WriteSize will use for a given value.
        /// </summary>
        /// <param name="span"></param>
        /// <param name="value"></param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte MeasureWriteSize(UInt32 value) => value.MeasureWriteSize();
        #endregion

        #region Read
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int ReadByte()
        {
            var ret = ROSpan.Slice(Position, sizeof(Byte)).ReadByte();
            Position += sizeof(Byte);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public sbyte ReadSByte()
        {
            var ret = ROSpan.Slice(Position, sizeof(SByte)).ReadSByte();
            Position += sizeof(SByte);
            return ret;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int16 ReadInt16()
        {
            var ret = ROSpan.Slice(Position, sizeof(Int16)).ReadInt16();
            Position += sizeof(Int16);
            return ret;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt16 ReadUInt16()
        {
            var ret = ROSpan.Slice(Position, sizeof(UInt16)).ReadUInt16();
            Position += sizeof(UInt16);
            return ret;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt24 ReadUInt24()
        {
            var ret = ROSpan.Slice(Position, SizeofUInt24).ReadUInt24();
            Position += SizeofUInt24;
            return ret;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int32 ReadInt32()
        {
            var ret = ROSpan.Slice(Position, sizeof(Int32)).ReadInt32();
            Position += sizeof(Int32);
            return ret;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt32 ReadUInt32()
        {
            var ret = ROSpan.Slice(Position, sizeof(UInt32)).ReadUInt32();
            Position += sizeof(UInt32);
            return ret;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int64 ReadInt64()
        {
            var ret = ROSpan.Slice(Position, sizeof(Int64)).ReadInt64();
            Position += sizeof(Int64);
            return ret;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt64 ReadUInt64()
        {
            var ret = ROSpan.Slice(Position, sizeof(UInt64)).ReadUInt64();
            Position += sizeof(UInt64);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Guid ReadGuid()
        {
            var ret = ROSpan.Slice(Position, SizeofGuid).ReadGuid();
            Position += SizeofGuid;
            return ret;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string SizedReadString(out int length)
        {
            var ret = ROSpan.Slice(Position).SizedReadString(out length);
            Position += length;
            return ret;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte[] SizedReadBytes(out int length)
        {
            var ret = ROSpan.Slice(Position).SizedReadBytes(out length);
            Position += length;
            return ret;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte[] ReadBytes(int length)
        {
            var ret = ROSpan.Slice(Position).ReadBytes(length);
            Position += length;
            return ret;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt32 ReadSize(out int length)
        {
            var ret = ROSpan.Slice(Position).ReadSize(out length);
            Position += length;
            return ret;
        }

        #endregion

        #region VLQ
        #region Write
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int WriteVLQ(Int16 value)
        {
            if (!CanWrite)
                throw new ReadOnlyException("Span is read-only.");

            var len = Span.Slice(Position).WriteVLQ(value);
            Position += len;
            return len;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int WriteVLQ(UInt16 value)
        {
            if (!CanWrite)
                throw new ReadOnlyException("Span is read-only.");

            var len = Span.Slice(Position).WriteVLQ(value);
            Position += len;
            return len;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int WriteVLQ(UInt24 value)
        {
            if (!CanWrite)
                throw new ReadOnlyException("Span is read-only.");

            var len = Span.Slice(Position).WriteVLQ(value);
            Position += len;
            return len;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int WriteVLQ(Int32 value)
        {
            if (!CanWrite)
                throw new ReadOnlyException("Span is read-only.");

            var len = Span.Slice(Position).WriteVLQ(value);
            Position += len;
            return len;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int WriteVLQ(UInt32 value)
        {
            if (!CanWrite)
                throw new ReadOnlyException("Span is read-only.");

            var len = Span.Slice(Position).WriteVLQ(value);
            Position += len;
            return len;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int WriteVLQ(Int64 value)
        {
            if (!CanWrite)
                throw new ReadOnlyException("Span is read-only.");

            var len = Span.Slice(Position).WriteVLQ(value);
            Position += len;
            return len;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int WriteVLQ(UInt64 value)
        {
            if (!CanWrite)
                throw new ReadOnlyException("Span is read-only.");

            var len = Span.Slice(Position).WriteVLQ(value);
            Position += len;
            return len;
        }
        #endregion
        #region Read
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int16 ReadVLQInt16(out int length)
        {
            var value = ROSpan.Slice(Position).ReadVLQInt16(out length);
            Position += length;
            return value;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt16 ReadVLQUInt16(out int length)
        {
            var value = ROSpan.Slice(Position).ReadVLQUInt16(out length);
            Position += length;
            return value;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt24 ReadVLQUInt24(out int length)
        {
            var value = ROSpan.Slice(Position).ReadVLQUInt24(out length);
            Position += length;
            return value;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int32 ReadVLQInt32(out int length)
        {
            var value = ROSpan.Slice(Position).ReadVLQInt32(out length);
            Position += length;
            return value;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt32 ReadVLQUInt32(out int length)
        {
            var value = ROSpan.Slice(Position).ReadVLQUInt32(out length);
            Position += length;
            return value;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int64 ReadVLQInt64(out int length)
        {
            var value = ROSpan.Slice(Position).ReadVLQInt64(out length);
            Position += length;
            return value;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt64 ReadVLQUInt64(out int length)
        {
            var value = ROSpan.Slice(Position).ReadVLQUInt64(out length);
            Position += length;
            return value;
        }


        #endregion
        #endregion


        #region aliases
        /// <summary>
        /// Alias for ReadShort()
        /// </summary>
        /// <returns></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int16 ReadShort() => ReadInt16();
        /// <summary>
        /// Alias for ReadUInt16()
        /// </summary>
        /// <returns></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt16 ReadUShort() => ReadUInt16();
        /// <summary>
        /// Alias for ReadInt32()
        /// </summary>
        /// <returns></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int32 ReadInt() => ReadInt32();
        /// <summary>
        /// Alias for ReadUInt32()
        /// </summary>
        /// <returns></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt32 ReadUInt() => ReadUInt32();
        /// <summary>
        /// Alias for ReadInt64()
        /// </summary>
        /// <returns></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int64 ReadLong() => ReadInt64();
        /// <summary>
        /// Alias for ReadUInt64()
        /// </summary>
        /// <returns></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt64 ReadULong() => ReadUInt64();
        #endregion
    }
}
