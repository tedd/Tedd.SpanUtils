using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace Tedd
{
    public static partial class SpanRead
    {

        #region VInt
        /// <summary>
        /// Read VInt (EBML Variable Length Integer)
        /// </summary>
        /// <param name="length">The maximum number of bytes possible.</param>
        /// <returns>Value</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VInt ReadVInt(this Span<byte> span, int maxLength)
        {
            if (span.Length == 0)
            {
                throw new InvalidDataException("Invalid Variable Int");
            }

            uint b1 = span[0];
            ulong raw = b1;
            uint mask = 0xFF00;

            span = span.Slice(1);

            for (int i = 0; i < maxLength; ++i)
            {
                mask >>= 1;

                if ((b1 & mask) != 0)
                {
                    ulong value = raw & ~mask;

                    for (int j = 0; j < i; ++j)
                    {
                        byte b = span[j];
                        raw = (raw << 8) | b;
                        value = (value << 8) | b;
                    }

                    return new VInt(i + 1, raw, value);
                }
            }

            throw new InvalidDataException("Invalid Variable Int");
        }
        #endregion

//        public static Single ReadSingle2(this Span<byte> span)
//        {
//#if NETSTANDARD21 || AFTERNETCOREAPP3
//            return BitConverter.Int32BitsToSingle(SpanUtils.ReadInt32(span));
//#endif
//        }
        //#region aliases
        ///// <summary>
        ///// Alias for ReadShort()
        ///// </summary>
        ///// <returns></returns>
        //[MethodImpl(MethodImplOptions.AggressiveInlining)]
        //public static Int16 ReadShort(this Span<byte> span) => span.ReadInt16();
        ///// <summary>
        ///// Alias for ReadUInt16()
        ///// </summary>
        ///// <returns></returns>
        //[MethodImpl(MethodImplOptions.AggressiveInlining)]
        //public static UInt16 ReadUShort(this Span<byte> span) => span.ReadUInt16();
        ///// <summary>
        ///// Alias for ReadInt32()
        ///// </summary>
        ///// <returns></returns>
        //[MethodImpl(MethodImplOptions.AggressiveInlining)]
        //public static Int32 ReadInt(this Span<byte> span) => span.ReadInt32();
        ///// <summary>
        ///// Alias for ReadUInt32()
        ///// </summary>
        ///// <returns></returns>
        //[MethodImpl(MethodImplOptions.AggressiveInlining)]
        //public static UInt32 ReadUInt(this Span<byte> span) => span.ReadUInt32();
        ///// <summary>
        ///// Alias for ReadInt64()
        ///// </summary>
        ///// <returns></returns>
        //[MethodImpl(MethodImplOptions.AggressiveInlining)]
        //public static Int64 ReadLong(this Span<byte> span) => span.ReadInt64();
        ///// <summary>
        ///// Alias for ReadUInt64()
        ///// </summary>
        ///// <returns></returns>
        //[MethodImpl(MethodImplOptions.AggressiveInlining)]
        //public static UInt64 ReadULong(this Span<byte> span) => span.ReadUInt64();
        //#endregion
    }
}