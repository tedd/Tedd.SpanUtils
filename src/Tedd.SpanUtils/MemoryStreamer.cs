using System;
using System.Data;
using System.IO;
using System.Runtime.CompilerServices;

namespace Tedd
{
    /// <summary>
    /// Since .Net already has a System.IO.MemoryStream this is named MemoryStreamer.
    /// It does the same as MemoryStream, but with Memory&lt;byte&gt;.
    /// Additionally has all the read/write methods of this library. Read/write will progress position.
    /// </summary>
    public class MemoryStreamer : Stream
    {
        private const int SizeofGuid = 16;
        private const int SizeofUInt24 = 3;

        private readonly Memory<byte> Memory;
        private readonly ReadOnlyMemory<byte> ROMemory;
        private int _position { get; set; }
        private bool _canWrite = false;
        private int _length;

        public MemoryStreamer(Memory<byte> memory)
        {
            Memory = memory;
            ROMemory = memory;
            _canWrite = true;
            _length = 0;
        }
        public MemoryStreamer(ReadOnlyMemory<byte> memory)
        {
            Memory = null;
            ROMemory = memory;
            _canWrite = false;
            _length = 0;
        }

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
                Memory.Span.Fill(0);
                _position = 0;
                return;
            }

            Memory.Span.Slice(0, _position).Fill(0);
            _position = 0;
        }

        #region Overrides of Stream

        /// <summary>Gets a value indicating whether the current stream supports reading.</summary>
        /// <returns>true if the stream supports reading; otherwise, false.</returns>
        public override bool CanRead
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => true;
        }

        /// <summary>Gets a value indicating whether the current stream supports seeking.</summary>
        /// <returns>true if the stream supports seeking; otherwise, false.</returns>
        public override bool CanSeek
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => true;
        }


        /// <summary>Gets a value indicating whether the current stream supports writing.</summary>
        /// <returns>true if the stream supports writing; otherwise, false.</returns>
        public override bool CanWrite
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => _canWrite;
        }


        /// <summary>Gets the length in bytes of the stream.</summary>
        /// <returns>A long value representing the length of the stream in bytes.</returns>
        public override long Length
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => _length;
        }

        /// <summary>Gets or sets the position within the current stream.</summary>
        /// <returns>The current position within the stream.</returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">The requested position is outside of range for the underlying Memory.</exception>
        public override long Position
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => _position;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                // value != 0 && 
                if (value > ROMemory.Span.Length || value < 0)
                    throw new ArgumentOutOfRangeException(nameof(Position));
                _position = (int)value;
                if (_position > Length)
                    _length = _position;
            }
        }


        /// <summary>Sets the position within the current stream.</summary>
        /// <param name="offset">A byte offset relative to the origin parameter.</param>
        /// <param name="origin">A value of type <see cref="T:System.IO.SeekOrigin"></see> indicating the reference point used to obtain the new position.</param>
        /// <returns>The new position within the current stream.</returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">The requested position is outside of range for the underlying Memory.</exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override long Seek(long offset, SeekOrigin origin)
        {
            if (origin == SeekOrigin.Begin)
                Position = offset;
            else if (origin == SeekOrigin.End)
                Position = Memory.Length - 1 - offset;
            else if (origin == SeekOrigin.Current)
                Position += offset;

            return Position;
        }

        /// <summary>Sets the length of the current stream.</summary>
        /// <param name="value">The desired length of the current stream in bytes.</param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">Attempt to set length that exceeds the underlying span.</exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void SetLength(long value)
        {
            if (value > ROMemory.Length || value < 0)
                throw new ArgumentOutOfRangeException(nameof(value));
            _length = (int)value;
        }


        /// <summary>Has no effect on Span.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void Flush() { }

        /// <summary>Reads a sequence of bytes from the current stream and advances the position within the stream by the number of bytes read.</summary>
        /// <param name="buffer">An array of bytes. When this method returns, the buffer contains the specified byte array with the values between offset and (offset + count - 1) replaced by the bytes read from the current source.</param>
        /// <param name="offset">The zero-based byte offset in buffer at which to begin storing the data read from the current stream.</param>
        /// <param name="count">The maximum number of bytes to be read from the current stream.</param>
        /// <returns>The total number of bytes read into the buffer. This can be less than the number of bytes requested if that many bytes are not currently available, or zero (0) if the end of the stream has been reached.</returns>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="buffer">buffer</paramref> is null.</exception>
        /// <exception cref="T:System.ArgumentOutOfRangeException"><paramref name="offset">offset</paramref> or <paramref name="count">count</paramref> is negative, greater than buffer size or greater than remaining destination length.</exception>
        public override int Read(byte[] buffer, int offset, int count)
        {
            //if (offset + count > buffer.Length)
            //    throw new ArgumentException($"The sum of offset and count is greater than the buffer length.");
            if (buffer is null)
                throw new ArgumentNullException(nameof(buffer));
            //if (offset < 0)
            //    throw new ArgumentOutOfRangeException(nameof(offset));
            //if (count < 0)
            //    throw new ArgumentOutOfRangeException(nameof(count));

            var dst = ((Span<byte>)buffer).Slice(offset, count);
            var src = Memory.Span.Slice((int)_position, Math.Min(count, (int)Memory.Length - (int)_position));
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
        public override void Write(byte[] buffer, int offset, int count)
        {
            //if (offset + count > buffer.Length)
            //    throw new ArgumentException($"The sum of offset and count is greater than the buffer length.");
            if (buffer is null)
                throw new ArgumentNullException(nameof(buffer));
            //if (offset < 0)
            //    throw new ArgumentOutOfRangeException(nameof(offset));
            //if (count < 0)
            //    throw new ArgumentOutOfRangeException(nameof(count));

            var src = ((Span<byte>)buffer).Slice(offset, count);
            var dst = Memory.Span.Slice((int)_position, count);
            src.CopyTo(dst);
            _position += count;
        }

        #endregion





        #region Read / Write byte[]
        /// <summary>Reads a sequence of bytes from the current stream and advances the position within the stream by the number of bytes read.</summary>
        /// <param name="buffer">An array of bytes. When this method returns, the buffer contains the specified byte array with the values between offset and (offset + count - 1) replaced by the bytes read from the current source.</param>
        /// <param name="offset">The zero-based byte offset in buffer at which to begin storing the data read from the current stream.</param>
        /// <param name="count">The maximum number of bytes to be read from the current stream.</param>
        /// <returns>The total number of bytes read into the buffer. This can be less than the number of bytes requested if that many bytes are not currently available, or zero (0) if the end of the stream has been reached.</returns>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="buffer">buffer</paramref> is null.</exception>
        /// <exception cref="T:System.ArgumentOutOfRangeException"><paramref name="offset">offset</paramref> or <paramref name="count">count</paramref> is negative, greater than buffer size or greater than remaining destination length.</exception>
        public int Read(in byte[] buffer, in int offset, in int count)
        {
            if (buffer is null)
                throw new ArgumentNullException(nameof(buffer));

            var dst = ((Span<byte>)buffer).Slice(offset, count);
            var src = ROMemory.Span.Slice((int)_position, Math.Min(count, (int)ROMemory.Span.Length - (int)_position));
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
        public void Write(in byte[] buffer, in int offset, in int count)
        {
            if (buffer is null)
                throw new ArgumentNullException(nameof(buffer));
            Write(new Span<byte>(buffer).Slice(offset, count));

            //if (!CanWrite)
            //    throw new ReadOnlyException("Span is read-only.");
            //if (buffer is null)
            //    throw new ArgumentNullException(nameof(buffer));

            //var src = ((Span<byte>)buffer).Slice(offset, count);
            //var dst = Memory.Span.Slice((int)_position, count);
            //src.CopyTo(dst);
            //_position += count;
        }

        #endregion

        #region Write
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int Write(in byte value)
        {
            if (!CanWrite)
                throw new ReadOnlyException("Span is read-only.");

            var ret = Memory.Span.Slice(_position, sizeof(Byte)).Write(value);
            Position += sizeof(Byte);
            return ret;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int Write(in SByte value)
        {
            if (!CanWrite)
                throw new ReadOnlyException("Span is read-only.");

            var ret = Memory.Span.Slice(_position, sizeof(SByte)).Write(value);
            Position += sizeof(SByte);
            return ret;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int Write(in Int16 value)
        {
            if (!CanWrite)
                throw new ReadOnlyException("Span is read-only.");

            var ret = Memory.Span.Slice(_position, sizeof(Int16)).Write(value);
            Position += sizeof(Int16);
            return ret;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int Write(in UInt16 value)
        {
            if (!CanWrite)
                throw new ReadOnlyException("Span is read-only.");

            var ret = Memory.Span.Slice(_position, sizeof(UInt16)).Write(value);
            Position += sizeof(UInt16);
            return ret;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int Write(in UInt24 value)
        {
            if (!CanWrite)
                throw new ReadOnlyException("Span is read-only.");

            var ret = Memory.Span.Slice(_position, (int)UInt24.Size).Write(value);
            Position += (int)UInt24.Size;
            return ret;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int Write(in Int32 value)
        {
            if (!CanWrite)
                throw new ReadOnlyException("Span is read-only.");

            var ret = Memory.Span.Slice(_position, sizeof(Int32)).Write(value);
            Position += sizeof(Int32);
            return ret;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int Write(in UInt32 value)
        {
            if (!CanWrite)
                throw new ReadOnlyException("Span is read-only.");

            var ret = Memory.Span.Slice(_position, sizeof(UInt32)).Write(value);
            Position += sizeof(UInt32);
            return ret;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int Write(in Int64 value)
        {
            if (!CanWrite)
                throw new ReadOnlyException("Span is read-only.");

            var ret = Memory.Span.Slice(_position, sizeof(Int64)).Write(value);
            Position += sizeof(Int64);
            return ret;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int Write(in UInt64 value)
        {
            if (!CanWrite)
                throw new ReadOnlyException("Span is read-only.");

            var ret = Memory.Span.Slice(_position, sizeof(UInt64)).Write(value);
            Position += sizeof(UInt64);
            return ret;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int Write(in Guid value)
        {
            if (!CanWrite)
                throw new ReadOnlyException("Span is read-only.");

            var ret = Memory.Span.Slice(_position, 16).Write(value);
            Position += 16;
            return ret;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int Write(in byte[] value)
        {
            if (!CanWrite)
                throw new ReadOnlyException("Span is read-only.");

            var ret = Memory.Span.Slice(_position).Write(value);
            Position += value.Length;
            return ret;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int Write(in Span<byte> value)
        {
            if (!CanWrite)
                throw new ReadOnlyException("Span is read-only.");

            var ret = Memory.Span.Slice(_position).Write(value);
            Position += value.Length;
            return ret;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int WriteSize(in UInt32 value)
        {
            if (!CanWrite)
                throw new ReadOnlyException("Span is read-only.");

            var length = Memory.Span.Slice(_position).WriteSize(value);
            Position += length;
            return length;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int SizedWrite(in string value)
        {
            if (!CanWrite)
                throw new ReadOnlyException("Span is read-only.");

            var length = Memory.Span.Slice(_position).SizedWrite(value);
            Position += length;
            return length;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int SizedWrite(in byte[] value)
        {
            if (!CanWrite)
                throw new ReadOnlyException("Span is read-only.");

            var length = Memory.Span.Slice(_position).SizedWrite(value);
            Position += length;
            return length;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int SizedWrite(in Span<byte> value)
        {
            if (!CanWrite)
                throw new ReadOnlyException("Span is read-only.");

            var length = Memory.Span.Slice(_position).SizedWrite(value);
            Position += length;
            return length;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int SizedWrite(in ReadOnlySpan<byte> value)
        {
            if (!CanWrite)
                throw new ReadOnlyException("Span is read-only.");

            var length = Memory.Span.Slice(_position).SizedWrite(value);
            Position += length;
            return length;
        }
        /// <summary>
        /// Counts how many bytes WriteSize will use for a given value.
        /// </summary>
        /// <param name="span"></param>
        /// <param name="value"></param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte MeasureWriteSize(in UInt32 value) => value.MeasureWriteSize();
        #endregion

        #region Read
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int ReadByte()
        {
            var ret = ROMemory.Span.Slice(_position, sizeof(Byte)).ReadByte();
            Position += sizeof(Byte);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public sbyte ReadSByte()
        {
            var ret = ROMemory.Span.Slice(_position, sizeof(SByte)).ReadSByte();
            Position += sizeof(SByte);
            return ret;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int16 ReadInt16()
        {
            var ret = ROMemory.Span.Slice(_position, sizeof(Int16)).ReadInt16();
            Position += sizeof(Int16);
            return ret;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt16 ReadUInt16()
        {
            var ret = ROMemory.Span.Slice(_position, sizeof(UInt16)).ReadUInt16();
            Position += sizeof(UInt16);
            return ret;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt24 ReadUInt24()
        {
            var ret = ROMemory.Span.Slice(_position, SizeofUInt24).ReadUInt24();
            Position += SizeofUInt24;
            return ret;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int32 ReadInt32()
        {
            var ret = ROMemory.Span.Slice(_position, sizeof(Int32)).ReadInt32();
            Position += sizeof(Int32);
            return ret;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt32 ReadUInt32()
        {
            var ret = ROMemory.Span.Slice(_position, sizeof(UInt32)).ReadUInt32();
            Position += sizeof(UInt32);
            return ret;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int64 ReadInt64()
        {
            var ret = ROMemory.Span.Slice(_position, sizeof(Int64)).ReadInt64();
            Position += sizeof(Int64);
            return ret;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt64 ReadUInt64()
        {
            var ret = ROMemory.Span.Slice(_position, sizeof(UInt64)).ReadUInt64();
            Position += sizeof(UInt64);
            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Guid ReadGuid()
        {
            var ret = ROMemory.Span.Slice(_position, SizeofGuid).ReadGuid();
            Position += SizeofGuid;
            return ret;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string SizedReadString(out int length)
        {
            var ret = ROMemory.Span.Slice(_position).SizedReadString(out length);
            Position += length;
            return ret;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte[] SizedReadBytes(out int length)
        {
            var ret = ROMemory.Span.Slice(_position).SizedReadBytes(out length);
            Position += length;
            return ret;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte[] ReadBytes(in int length)
        {
            var ret = ROMemory.Span.Slice(_position).ReadBytes(length);
            Position += length;
            return ret;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt32 ReadSize(out int length)
        {
            var ret = ROMemory.Span.Slice(_position).ReadSize(out length);
            Position += length;
            return ret;
        }

        #endregion

        #region VLQ
        #region Write
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int WriteVLQ(in Int16 value)
        {
            if (!CanWrite)
                throw new ReadOnlyException("Span is read-only.");

            var len = Memory.Span.Slice(_position).WriteVLQ(value);
            Position += len;
            return len;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int WriteVLQ(in UInt16 value)
        {
            if (!CanWrite)
                throw new ReadOnlyException("Span is read-only.");

            var len = Memory.Span.Slice(_position).WriteVLQ(value);
            Position += len;
            return len;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int WriteVLQ(in UInt24 value)
        {
            if (!CanWrite)
                throw new ReadOnlyException("Span is read-only.");

            var len = Memory.Span.Slice(_position).WriteVLQ(value);
            Position += len;
            return len;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int WriteVLQ(in Int32 value)
        {
            if (!CanWrite)
                throw new ReadOnlyException("Span is read-only.");

            var len = Memory.Span.Slice(_position).WriteVLQ(value);
            Position += len;
            return len;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int WriteVLQ(in UInt32 value)
        {
            if (!CanWrite)
                throw new ReadOnlyException("Span is read-only.");

            var len = Memory.Span.Slice(_position).WriteVLQ(value);
            Position += len;
            return len;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int WriteVLQ(in Int64 value)
        {
            if (!CanWrite)
                throw new ReadOnlyException("Span is read-only.");

            var len = Memory.Span.Slice(_position).WriteVLQ(value);
            Position += len;
            return len;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int WriteVLQ(in UInt64 value)
        {
            if (!CanWrite)
                throw new ReadOnlyException("Span is read-only.");

            var len = Memory.Span.Slice(_position).WriteVLQ(value);
            Position += len;
            return len;
        }
        #endregion
        #region Read
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int16 ReadVLQInt16(out int length)
        {
            var value = ROMemory.Span.Slice(_position).ReadVLQInt16(out length);
            Position += length;
            return value;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt16 ReadVLQUInt16(out int length)
        {
            var value = ROMemory.Span.Slice(_position).ReadVLQUInt16(out length);
            Position += length;
            return value;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt24 ReadVLQUInt24(out int length)
        {
            var value = ROMemory.Span.Slice(_position).ReadVLQUInt24(out length);
            Position += length;
            return value;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int32 ReadVLQInt32(out int length)
        {
            var value = ROMemory.Span.Slice(_position).ReadVLQInt32(out length);
            Position += length;
            return value;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt32 ReadVLQUInt32(out int length)
        {
            var value = ROMemory.Span.Slice(_position).ReadVLQUInt32(out length);
            Position += length;
            return value;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int64 ReadVLQInt64(out int length)
        {
            var value = ROMemory.Span.Slice(_position).ReadVLQInt64(out length);
            Position += length;
            return value;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt64 ReadVLQUInt64(out int length)
        {
            var value = ROMemory.Span.Slice(_position).ReadVLQUInt64(out length);
            Position += length;
            return value;
        }


        #endregion
        #endregion
    }
}