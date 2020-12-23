using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace Tedd
{
    public static class SpanRead
    {
        #region Primitives
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte ReadByte(this Span<byte> span) => span[0];

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte ReadSByte(this Span<byte> span) => (sbyte)span[0];

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 ReadInt16(this Span<byte> span) => (Int16)span.ReadUInt16();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 ReadUInt16(this Span<byte> span)
        {
            //return MemoryMarshal.Cast<byte, UInt16>(span)[0];
            return (UInt16)(
                  ((UInt16)span[0] << (8 * 1))
                | ((UInt16)span[1]));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt24 ReadUInt24(this Span<byte> span)
        {
            // return MemoryMarshal.Cast<byte, UInt32>(span)[0];
            return (UInt24)(Int32)(
                ((UInt32)span[2])
                | ((UInt32)span[1] << (8 * 1))
                | ((UInt32)span[0] << (8 * 2))
                  );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 ReadInt32(this Span<byte> span) => (Int32)span.ReadUInt32();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 ReadUInt32(this Span<byte> span)
        {
            // return MemoryMarshal.Cast<byte, UInt32>(span)[0];
            return (UInt32)(
                ((UInt32)span[3])
                | ((UInt32)span[2] << (8 * 1))
                | ((UInt32)span[1] << (8 * 2))
                | ((UInt32)span[0] << (8 * 3))
                );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 ReadInt64(this Span<byte> span) => (Int64)span.ReadUInt64();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 ReadUInt64(this Span<byte> span)
        {
            //return MemoryMarshal.Cast<byte, UInt64>(span)[0];
            // 16% more speed if we read in reverse order due to removal of redundant compiler checks.
            // https://github.com/tedd/Tedd.SpanUtils/issues/3
            return (UInt64)(
                ((UInt64)span[7])
                | ((UInt64)span[6] << (8 * 1))
                | ((UInt64)span[5] << (8 * 2))
                | ((UInt64)span[4] << (8 * 3))
                | ((UInt64)span[3] << (8 * 4))
                | ((UInt64)span[2] << (8 * 5))
                | ((UInt64)span[1] << (8 * 6))
                | ((UInt64)span[0] << (8 * 7))
                );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool ReadBool(this Span<byte> span) => span[0] != 0;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static char ReadChar(this Span<byte> span)
        {
            Span<char> a = stackalloc char[1];
            var ab = MemoryMarshal.Cast<char, byte>(a);
            span.Slice(0,sizeof(char)).CopyTo(ab);
            return a[0];
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float ReadFloat(this Span<byte> span)
        {
            Span<float> a = stackalloc float[1];
            var ab = MemoryMarshal.Cast<float, byte>(a);
            span.Slice(0,sizeof(float)).CopyTo(ab);
            return a[0];
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double ReadDouble(this Span<byte> span)
        {
            Span<double> a = stackalloc double[1];
            var ab = MemoryMarshal.Cast<double, byte>(a);
            span.Slice(0,sizeof(double)).CopyTo(ab);
            return a[0];
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static decimal ReadDecimal(this Span<byte> span)
        {
            Span<decimal> a = stackalloc decimal[1];
            var ab = MemoryMarshal.Cast<decimal, byte>(a);
            span.Slice(0,sizeof(decimal)).CopyTo(ab);
            return a[0];
        }
       
        #endregion

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Guid ReadGuid(this Span<byte> span) => new Guid(span.Slice(0, 16).ToArray());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 ReadSize(this Span<byte> span, out int totalLength)
        {
            var b1 = span[0];
            var s = b1 >> 6;

            totalLength = s + 1;
            switch (s)
            {
                case 0b00:
                    return (UInt32) b1 & 0b00111111;
                case 0b01:
                    return (UInt32) span.ReadUInt16() & 0b00111111_11111111;
                case 0b10:
                    return (UInt32) span.ReadUInt24() & 0b00111111_11111111_11111111;
                //case 0b11:
                default:
                    return (UInt32) span.ReadUInt32() & 0b00111111_11111111_11111111_11111111;
            }

        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte[] ReadBytes(this Span<byte> span, int length)
        {
            return span.Slice(0, length).ToArray();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte[] SizedReadBytes(this Span<byte> span, out int totalLength)
        {
            var size = span.ReadSize(out var len);
            totalLength = len + (int)size;
            return span.Slice(len, (int)size).ToArray();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string SizedReadString(this Span<byte> span, out int totalLength)
        {
            var size = span.ReadSize(out var len);
            totalLength = len + (int)size;
#if NETCOREAPP || NETSTANDARD21
            var ros = (ReadOnlySpan<byte>)span.Slice(len, (int)size);
            return Encoding.UTF8.GetString(ros);
#else
            var bytes = span.Slice(len, (int)size).ToArray();
            return Encoding.UTF8.GetString(bytes);
#endif
        }


        #region VLQ
        /// <summary>
        /// Read VLQ (Variable Length Quantity) of Int16 (short), this can be up to 3 bytes in length.
        /// Use (out _) as parameter to ignore length.
        /// </summary>
        /// <example>
        /// The <paramref name="length"/> returns number of bytes this VLQ is stored as.
        /// <code>var value = span.ReadVLQInt16(out var length);</code>
        /// Or, if you want to ignore length, simply use _ syntax and compiler will optimize it way:
        /// <code>var value = span.ReadVLQInt16(out _);</code>
        /// </example>
        /// <param name="length">Number of bytes read.</param>
        /// <returns>Value</returns>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 ReadVLQInt16(this Span<byte> span, out int length)
        {
            // Lower bound special case
            if (span[0] == 0b0100_0000)
            {
                length = 1;
                return Int16.MinValue;
            }

            var i = 0;
            var shift = 0;
            Int32 ret = 0;

            ret |= (Int32)(span[0] & 0b0011_1111) << shift;
            shift += 6;

            while ((span[i++] & 0b1000_0000) != 0)
            {
                if (i == sizeof(Int16) + 2)
                    throw new OverflowException($"VLQ exceeded {sizeof(Int16) + 1} bytes");

                ret |= (Int32)(span[i] & 0b0111_1111) << shift;
                shift += 7;
            }

            length = i;

            if ((span[0] & 0b0100_0000) != 0)
                return (Int16)(ret * -1);

            return (Int16)ret;
        }
        /// <summary>
        /// Read VLQ (Variable Length Quantity) of UInt16 (ushort), this can be up to 3 bytes in length.
        /// Use (out _) as parameter to ignore length.
        /// </summary>
        /// <example>
        /// The <paramref name="length"/> returns number of bytes this VLQ is stored as.
        /// <code>var value = span.ReadVLQUInt16(out var length);</code>
        /// Or, if you want to ignore length, simply use _ syntax and compiler will optimize it way:
        /// <code>var value = span.ReadVLQUInt16(out _);</code>
        /// </example>
        /// <param name="length">Number of bytes read.</param>
        /// <returns>Value</returns>
        public static UInt16 ReadVLQUInt16(this Span<byte> span, out int length)
        {
            var i = 0;
            var shift = 0;
            UInt32 ret = 0;
            do
            {
                if (i == sizeof(UInt16) + 2)
                    throw new OverflowException($"VLQ exceeded {sizeof(UInt16) + 1} bytes");

                ret |= (UInt32)(span[i] & 0b0111_1111) << shift;
                shift += 7;
            } while ((span[i++] & 0b1000_0000) != 0);

            length = i;
            return (UInt16)ret;
        }
        /// <summary>
        /// Read VLQ (Variable Length Quantity) of UInt24 (long), this can be up to 4 bytes in length.
        /// Use (out _) as parameter to ignore length.
        /// </summary>
        /// <example>
        /// The <paramref name="length"/> returns number of bytes this VLQ is stored as.
        /// <code>var value = span.ReadVLQUInt24(out var length);</code>
        /// Or, if you want to ignore length, simply use _ syntax and compiler will optimize it way:
        /// <code>var value = span.ReadVLQUInt24(out _);</code>
        /// </example>
        /// <param name="length">Number of bytes read.</param>
        /// <returns>Value</returns>

        public static UInt24 ReadVLQUInt24(this Span<byte> span, out int length)
        {
            var i = 0;
            var shift = 0;
            UInt32 ret = 0;
            do
            {
                if (i == 3 + 2)
                    throw new OverflowException($"VLQ exceeded {3 + 1} bytes");

                ret |= (UInt32)(span[i] & 0b0111_1111) << shift;
                shift += 7;
            } while ((span[i++] & 0b1000_0000) != 0);

            length = i;
            return ret.ToUInt24();
        }

        /// <summary>
        /// Read VLQ (Variable Length Quantity) of Int32 (int), this can be up to 5 bytes in length.
        /// Use (out _) as parameter to ignore length.
        /// </summary>
        /// <example>
        /// The <paramref name="length"/> returns number of bytes this VLQ is stored as.
        /// <code>var value = span.ReadVLQInt32(out var length);</code>
        /// Or, if you want to ignore length, simply use _ syntax and compiler will optimize it way:
        /// <code>var value = span.ReadVLQInt32(out _);</code>
        /// </example>
        /// <param name="length">Number of bytes read.</param>
        /// <returns>Value</returns>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 ReadVLQInt32(this Span<byte> span, out int length)
        {
            // Lower bound special case
            if (span[0] == 0b0100_0000)
            {
                length = 1;
                return Int32.MinValue;
            }


            var i = 0;
            var shift = 0;
            Int32 ret = 0;

            ret |= (Int32)(span[0] & 0b0011_1111) << shift;
            shift += 6;

            while ((span[i++] & 0b1000_0000) != 0)
            {
                if (i == sizeof(Int32) + 2)
                    throw new OverflowException($"VLQ exceeded {sizeof(Int32) + 1} bytes");

                ret |= (Int32)(span[i] & 0b0111_1111) << shift;
                shift += 7;
            }

            length = i;

            if ((span[0] & 0b0100_0000) != 0)
                return (Int32)(ret * -1);

            return (Int32)ret;
        }
        /// <summary>
        /// Read VLQ (Variable Length Quantity) of UInt32 (uint), this can be up to 5 bytes in length.
        /// Use (out _) as parameter to ignore length.
        /// </summary>
        /// <example>
        /// The <paramref name="length"/> returns number of bytes this VLQ is stored as.
        /// <code>var value = span.ReadVLQUInt32(out var length);</code>
        /// Or, if you want to ignore length, simply use _ syntax and compiler will optimize it way:
        /// <code>var value = span.ReadVLQUInt32(out _);</code>
        /// </example>
        /// <param name="length">Number of bytes read.</param>
        /// <returns>Value</returns>

        public static UInt32 ReadVLQUInt32(this Span<byte> span, out int length)
        {
            var i = 0;
            var shift = 0;
            UInt32 ret = 0;
            do
            {
                if (i == sizeof(UInt32) + 2)
                    throw new OverflowException($"VLQ exceeded {sizeof(UInt32) + 1} bytes");

                ret |= (UInt32)(span[i] & 0b0111_1111) << shift;
                shift += 7;
            } while ((span[i++] & 0b1000_0000) != 0);

            length = i;
            return ret;
        }
        /// <summary>
        /// Read VLQ (Variable Length Quantity) of Int64 (long), this can be up to 10 bytes in length.
        /// Use (out _) as parameter to ignore length.
        /// </summary>
        /// <example>
        /// The <paramref name="length"/> returns number of bytes this VLQ is stored as.
        /// <code>var value = span.ReadVLQInt64(out var length);</code>
        /// Or, if you want to ignore length, simply use _ syntax and compiler will optimize it way:
        /// <code>var value = span.ReadVLQInt64(out _);</code>
        /// </example>
        /// <param name="length">Number of bytes read.</param>
        /// <returns>Value</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 ReadVLQInt64(this Span<byte> span, out int length)
        {
            // Lower bound special case
            if (span[0] == 0b0100_0000)
            {
                length = 1;
                return Int64.MinValue;
            }

            var i = 0;
            var shift = 0;
            Int64 ret = 0;

            ret |= (Int64)(span[0] & 0b0011_1111) << shift;
            shift += 6;

            while ((span[i++] & 0b1000_0000) != 0)
            {
                if (i == sizeof(Int64) + 3)
                    throw new OverflowException($"VLQ exceeded {sizeof(Int64) + 2} bytes");

                ret |= (Int64)(span[i] & 0b0111_1111) << shift;
                shift += 7;
            }

            length = i;

            if ((span[0] & 0b0100_0000) != 0)
                return (Int64)(ret * -1);

            return (Int64)ret;
        }
        /// <summary>
        /// Read VLQ (Variable Length Quantity) of UInt64 (ulong), this can be up to 10 bytes in length.
        /// Use (out _) as parameter to ignore length.
        /// </summary>
        /// <example>
        /// The <paramref name="length"/> returns number of bytes this VLQ is stored as.
        /// <code>var value = span.ReadVLQUInt64(out var length);</code>
        /// Or, if you want to ignore length, simply use _ syntax and compiler will optimize it way:
        /// <code>var value = span.ReadVLQUInt64(out _);</code>
        /// </example>
        /// <param name="length">Number of bytes read.</param>
        /// <returns>Value</returns>
        public static UInt64 ReadVLQUInt64(this Span<byte> span, out int length)
        {
            var i = 0;
            var shift = 0;
            UInt64 ret = 0;
            do
            {
                if (i == sizeof(UInt64) + 3)
                    throw new OverflowException($"VLQ exceeded {sizeof(UInt64) + 2} bytes");

                ret |= ((UInt64)(span[i] & 0b0111_1111) << shift);
                shift += 7;
            } while ((span[i++] & 0b1000_0000) != 0);

            length = i;
            return ret;
        }

        #endregion

        #region aliases
        /// <summary>
        /// Alias for ReadShort()
        /// </summary>
        /// <returns></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 ReadShort(this Span<byte> span) => span.ReadInt16();
        /// <summary>
        /// Alias for ReadUInt16()
        /// </summary>
        /// <returns></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 ReadUShort(this Span<byte> span) => span.ReadUInt16();
        /// <summary>
        /// Alias for ReadInt32()
        /// </summary>
        /// <returns></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 ReadInt(this Span<byte> span) => span.ReadInt32();
        /// <summary>
        /// Alias for ReadUInt32()
        /// </summary>
        /// <returns></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 ReadUInt(this Span<byte> span) => span.ReadUInt32();
        /// <summary>
        /// Alias for ReadInt64()
        /// </summary>
        /// <returns></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 ReadLong(this Span<byte> span) => span.ReadInt64();
        /// <summary>
        /// Alias for ReadUInt64()
        /// </summary>
        /// <returns></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 ReadULong(this Span<byte> span) => span.ReadUInt64();
        #endregion
    }
}