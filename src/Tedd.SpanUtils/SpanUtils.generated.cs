// This file is auto-generated. Do not modify.

using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Data;
#if !BEFORENETCOREAPP3
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;
#endif
namespace Tedd {
    public static partial class SpanUtils {

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe SByte ReadSByte( Span<byte>span) => SpanUtils.ReadSByte(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe SByte ReadSByte( ReadOnlySpan<byte>span) => SpanUtils.ReadSByte(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe SByte ReadSByte(Span<byte> span, out int length) {
            var ret = (SByte)span[0];
            length = sizeof(SByte);
            
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe SByte ReadSByte(ReadOnlySpan<byte> span, out int length) {
            var ret = (SByte)span[0];
            length = sizeof(SByte);
            
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Byte ReadByte( Span<byte>span) => SpanUtils.ReadByte(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Byte ReadByte( ReadOnlySpan<byte>span) => SpanUtils.ReadByte(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Byte ReadByte(Span<byte> span, out int length) {
            var ret = span[0];
            length = sizeof(Byte);
            
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Byte ReadByte(ReadOnlySpan<byte> span, out int length) {
            var ret = span[0];
            length = sizeof(Byte);
            
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt16 ReadUInt16( Span<byte>span) => SpanUtils.ReadUInt16(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt16 ReadUInt16( ReadOnlySpan<byte>span) => SpanUtils.ReadUInt16(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt16 ReadUInt16(Span<byte> span, out int length) {
            var ret = Unsafe.ReadUnaligned<UInt16>(ref MemoryMarshal.GetReference(span));
            length = sizeof(UInt16);
            
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt16 ReadUInt16(ReadOnlySpan<byte> span, out int length) {
            var ret = Unsafe.ReadUnaligned<UInt16>(ref MemoryMarshal.GetReference(span));
            length = sizeof(UInt16);
            
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int16 ReadInt16( Span<byte>span) => SpanUtils.ReadInt16(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int16 ReadInt16( ReadOnlySpan<byte>span) => SpanUtils.ReadInt16(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int16 ReadInt16(Span<byte> span, out int length) {
            var ret = Unsafe.ReadUnaligned<UInt16>(ref MemoryMarshal.GetReference(span));
            length = sizeof(Int16);
            
            return (Int16)ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int16 ReadInt16(ReadOnlySpan<byte> span, out int length) {
            var ret = Unsafe.ReadUnaligned<UInt16>(ref MemoryMarshal.GetReference(span));
            length = sizeof(Int16);
            
            return (Int16)ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt32 ReadUInt32( Span<byte>span) => SpanUtils.ReadUInt32(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt32 ReadUInt32( ReadOnlySpan<byte>span) => SpanUtils.ReadUInt32(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt32 ReadUInt32(Span<byte> span, out int length) {
            var ret = Unsafe.ReadUnaligned<UInt32>(ref MemoryMarshal.GetReference(span));
            length = sizeof(UInt32);
            
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt32 ReadUInt32(ReadOnlySpan<byte> span, out int length) {
            var ret = Unsafe.ReadUnaligned<UInt32>(ref MemoryMarshal.GetReference(span));
            length = sizeof(UInt32);
            
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int32 ReadInt32( Span<byte>span) => SpanUtils.ReadInt32(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int32 ReadInt32( ReadOnlySpan<byte>span) => SpanUtils.ReadInt32(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int32 ReadInt32(Span<byte> span, out int length) {
            var ret = Unsafe.ReadUnaligned<UInt32>(ref MemoryMarshal.GetReference(span));
            length = sizeof(Int32);
            
            return (Int32)ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int32 ReadInt32(ReadOnlySpan<byte> span, out int length) {
            var ret = Unsafe.ReadUnaligned<UInt32>(ref MemoryMarshal.GetReference(span));
            length = sizeof(Int32);
            
            return (Int32)ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt64 ReadUInt64( Span<byte>span) => SpanUtils.ReadUInt64(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt64 ReadUInt64( ReadOnlySpan<byte>span) => SpanUtils.ReadUInt64(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt64 ReadUInt64(Span<byte> span, out int length) {
            var ret = Unsafe.ReadUnaligned<UInt64>(ref MemoryMarshal.GetReference(span));
            length = sizeof(UInt64);
            
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt64 ReadUInt64(ReadOnlySpan<byte> span, out int length) {
            var ret = Unsafe.ReadUnaligned<UInt64>(ref MemoryMarshal.GetReference(span));
            length = sizeof(UInt64);
            
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int64 ReadInt64( Span<byte>span) => SpanUtils.ReadInt64(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int64 ReadInt64( ReadOnlySpan<byte>span) => SpanUtils.ReadInt64(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int64 ReadInt64(Span<byte> span, out int length) {
            var ret = Unsafe.ReadUnaligned<UInt64>(ref MemoryMarshal.GetReference(span));
            length = sizeof(Int64);
            
            return (Int64)ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int64 ReadInt64(ReadOnlySpan<byte> span, out int length) {
            var ret = Unsafe.ReadUnaligned<UInt64>(ref MemoryMarshal.GetReference(span));
            length = sizeof(Int64);
            
            return (Int64)ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Single ReadSingle( Span<byte>span) => SpanUtils.ReadSingle(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Single ReadSingle( ReadOnlySpan<byte>span) => SpanUtils.ReadSingle(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Single ReadSingle(Span<byte> span, out int length) {
#if NETSTANDARD21 || !BEFORENETCOREAPP3
            var r = BitConverter.Int32BitsToSingle(SpanUtils.ReadInt32(span, out _));
#else
            //Span<float> a = stackalloc float[1];
            //var ab = MemoryMarshal.Cast<float, byte>(a);
            //span.Slice(0, sizeof(float)).CopyTo(ab);
            //var r = a[0];
            var i = SpanUtils.ReadInt32(span, out _);
            var r = *(float*)(&i);
#endif
            length = sizeof(Single);
            
            return r;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Single ReadSingle(ReadOnlySpan<byte> span, out int length) {
#if NETSTANDARD21 || !BEFORENETCOREAPP3
            var r = BitConverter.Int32BitsToSingle(SpanUtils.ReadInt32(span, out _));
#else
            //Span<float> a = stackalloc float[1];
            //var ab = MemoryMarshal.Cast<float, byte>(a);
            //span.Slice(0, sizeof(float)).CopyTo(ab);
            //var r = a[0];
            var i = SpanUtils.ReadInt32(span, out _);
            var r = *(float*)(&i);
#endif
            length = sizeof(Single);
            
            return r;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Double ReadDouble( Span<byte>span) => SpanUtils.ReadDouble(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Double ReadDouble( ReadOnlySpan<byte>span) => SpanUtils.ReadDouble(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Double ReadDouble(Span<byte> span, out int length) {
#if NETSTANDARD21 || !BEFORENETCOREAPP3
            var r = BitConverter.Int64BitsToDouble(SpanUtils.ReadInt64(span, out _));
#else
            //Span<double> a = stackalloc double[1];
            //var ab = MemoryMarshal.Cast<double, byte>(a);
            //span.Slice(0, sizeof(double)).CopyTo(ab);
            //var r = a[0];
            var i = SpanUtils.ReadInt64(span, out _);
            var r = *(double*)(&i);
#endif
            length = sizeof(Double);
            
            return r;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Double ReadDouble(ReadOnlySpan<byte> span, out int length) {
#if NETSTANDARD21 || !BEFORENETCOREAPP3
            var r = BitConverter.Int64BitsToDouble(SpanUtils.ReadInt64(span, out _));
#else
            //Span<double> a = stackalloc double[1];
            //var ab = MemoryMarshal.Cast<double, byte>(a);
            //span.Slice(0, sizeof(double)).CopyTo(ab);
            //var r = a[0];
            var i = SpanUtils.ReadInt64(span, out _);
            var r = *(double*)(&i);
#endif
            length = sizeof(Double);
            
            return r;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Decimal ReadDecimal( Span<byte>span) => SpanUtils.ReadDecimal(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Decimal ReadDecimal( ReadOnlySpan<byte>span) => SpanUtils.ReadDecimal(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Decimal ReadDecimal(Span<byte> span, out int length) {
            Span<decimal> a = stackalloc decimal[1];
            var ab = MemoryMarshal.Cast<decimal, byte>(a);
            span.Slice(0, sizeof(decimal)).CopyTo(ab);
            length = sizeof(Decimal);
            
            return a[0];
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Decimal ReadDecimal(ReadOnlySpan<byte> span, out int length) {
            Span<decimal> a = stackalloc decimal[1];
            var ab = MemoryMarshal.Cast<decimal, byte>(a);
            span.Slice(0, sizeof(decimal)).CopyTo(ab);
            length = sizeof(Decimal);
            
            return a[0];
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Boolean ReadBoolean( Span<byte>span) => SpanUtils.ReadBoolean(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Boolean ReadBoolean( ReadOnlySpan<byte>span) => SpanUtils.ReadBoolean(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Boolean ReadBoolean(Span<byte> span, out int length) {
            var ret = span[0] != 0;
            length = sizeof(Boolean);
            
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Boolean ReadBoolean(ReadOnlySpan<byte> span, out int length) {
            var ret = span[0] != 0;
            length = sizeof(Boolean);
            
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Char ReadChar( Span<byte>span) => SpanUtils.ReadChar(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Char ReadChar( ReadOnlySpan<byte>span) => SpanUtils.ReadChar(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Char ReadChar(Span<byte> span, out int length) {
            var r = MemoryMarshal.Read<Char>(span);
            length = sizeof(Char);
            
            return r;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Char ReadChar(ReadOnlySpan<byte> span, out int length) {
            var r = MemoryMarshal.Read<Char>(span);
            length = sizeof(Char);
            
            return r;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Single ReadFloat( Span<byte>span) => SpanUtils.ReadFloat(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Single ReadFloat( ReadOnlySpan<byte>span) => SpanUtils.ReadFloat(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Single ReadFloat(Span<byte> span, out int length) {
#if NETSTANDARD21 || !BEFORENETCOREAPP3
            var r = BitConverter.Int32BitsToSingle(SpanUtils.ReadInt32(span, out _));
#else
            //Span<float> a = stackalloc float[1];
            //var ab = MemoryMarshal.Cast<float, byte>(a);
            //span.Slice(0, sizeof(float)).CopyTo(ab);
            //var r = a[0];
            var i = SpanUtils.ReadInt32(span, out _);
            var r = *(float*)(&i);
#endif
            length = sizeof(Single);
            
            return r;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Single ReadFloat(ReadOnlySpan<byte> span, out int length) {
#if NETSTANDARD21 || !BEFORENETCOREAPP3
            var r = BitConverter.Int32BitsToSingle(SpanUtils.ReadInt32(span, out _));
#else
            //Span<float> a = stackalloc float[1];
            //var ab = MemoryMarshal.Cast<float, byte>(a);
            //span.Slice(0, sizeof(float)).CopyTo(ab);
            //var r = a[0];
            var i = SpanUtils.ReadInt32(span, out _);
            var r = *(float*)(&i);
#endif
            length = sizeof(Single);
            
            return r;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int16 ReadShort( Span<byte>span) => SpanUtils.ReadShort(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int16 ReadShort( ReadOnlySpan<byte>span) => SpanUtils.ReadShort(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int16 ReadShort(Span<byte> span, out int length) {
            var ret = Unsafe.ReadUnaligned<UInt16>(ref MemoryMarshal.GetReference(span));
            length = sizeof(Int16);
            
            return (Int16)ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int16 ReadShort(ReadOnlySpan<byte> span, out int length) {
            var ret = Unsafe.ReadUnaligned<UInt16>(ref MemoryMarshal.GetReference(span));
            length = sizeof(Int16);
            
            return (Int16)ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt16 ReadUShort( Span<byte>span) => SpanUtils.ReadUShort(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt16 ReadUShort( ReadOnlySpan<byte>span) => SpanUtils.ReadUShort(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt16 ReadUShort(Span<byte> span, out int length) {
            var ret = Unsafe.ReadUnaligned<UInt16>(ref MemoryMarshal.GetReference(span));
            length = sizeof(UInt16);
            
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt16 ReadUShort(ReadOnlySpan<byte> span, out int length) {
            var ret = Unsafe.ReadUnaligned<UInt16>(ref MemoryMarshal.GetReference(span));
            length = sizeof(UInt16);
            
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int32 ReadInt( Span<byte>span) => SpanUtils.ReadInt(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int32 ReadInt( ReadOnlySpan<byte>span) => SpanUtils.ReadInt(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int32 ReadInt(Span<byte> span, out int length) {
            var ret = Unsafe.ReadUnaligned<UInt32>(ref MemoryMarshal.GetReference(span));
            length = sizeof(Int32);
            
            return (Int32)ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int32 ReadInt(ReadOnlySpan<byte> span, out int length) {
            var ret = Unsafe.ReadUnaligned<UInt32>(ref MemoryMarshal.GetReference(span));
            length = sizeof(Int32);
            
            return (Int32)ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt32 ReadUInt( Span<byte>span) => SpanUtils.ReadUInt(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt32 ReadUInt( ReadOnlySpan<byte>span) => SpanUtils.ReadUInt(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt32 ReadUInt(Span<byte> span, out int length) {
            var ret = Unsafe.ReadUnaligned<UInt32>(ref MemoryMarshal.GetReference(span));
            length = sizeof(UInt32);
            
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt32 ReadUInt(ReadOnlySpan<byte> span, out int length) {
            var ret = Unsafe.ReadUnaligned<UInt32>(ref MemoryMarshal.GetReference(span));
            length = sizeof(UInt32);
            
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int64 ReadLong( Span<byte>span) => SpanUtils.ReadLong(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int64 ReadLong( ReadOnlySpan<byte>span) => SpanUtils.ReadLong(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int64 ReadLong(Span<byte> span, out int length) {
            var ret = Unsafe.ReadUnaligned<UInt64>(ref MemoryMarshal.GetReference(span));
            length = sizeof(Int64);
            
            return (Int64)ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int64 ReadLong(ReadOnlySpan<byte> span, out int length) {
            var ret = Unsafe.ReadUnaligned<UInt64>(ref MemoryMarshal.GetReference(span));
            length = sizeof(Int64);
            
            return (Int64)ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt64 ReadULong( Span<byte>span) => SpanUtils.ReadULong(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt64 ReadULong( ReadOnlySpan<byte>span) => SpanUtils.ReadULong(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt64 ReadULong(Span<byte> span, out int length) {
            var ret = Unsafe.ReadUnaligned<UInt64>(ref MemoryMarshal.GetReference(span));
            length = sizeof(UInt64);
            
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt64 ReadULong(ReadOnlySpan<byte> span, out int length) {
            var ret = Unsafe.ReadUnaligned<UInt64>(ref MemoryMarshal.GetReference(span));
            length = sizeof(UInt64);
            
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Boolean ReadBool( Span<byte>span) => SpanUtils.ReadBool(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Boolean ReadBool( ReadOnlySpan<byte>span) => SpanUtils.ReadBool(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Boolean ReadBool(Span<byte> span, out int length) {
            var ret = span[0] != 0;
            length = sizeof(Boolean);
            
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Boolean ReadBool(ReadOnlySpan<byte> span, out int length) {
            var ret = span[0] != 0;
            length = sizeof(Boolean);
            
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt16 ReadVLQUInt16( Span<byte>span) => SpanUtils.ReadVLQUInt16(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt16 ReadVLQUInt16( ReadOnlySpan<byte>span) => SpanUtils.ReadVLQUInt16(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt16 ReadVLQUInt16(Span<byte> span, out int length) {
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


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt16 ReadVLQUInt16(ReadOnlySpan<byte> span, out int length) {
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


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int16 ReadVLQInt16( Span<byte>span) => SpanUtils.ReadVLQInt16(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int16 ReadVLQInt16( ReadOnlySpan<byte>span) => SpanUtils.ReadVLQInt16(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int16 ReadVLQInt16(Span<byte> span, out int length) {
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
                ret = (Int16)(ret * -1);

            
            return (Int16)ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int16 ReadVLQInt16(ReadOnlySpan<byte> span, out int length) {
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
                ret = (Int16)(ret * -1);

            
            return (Int16)ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt32 ReadVLQUInt32( Span<byte>span) => SpanUtils.ReadVLQUInt32(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt32 ReadVLQUInt32( ReadOnlySpan<byte>span) => SpanUtils.ReadVLQUInt32(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt32 ReadVLQUInt32(Span<byte> span, out int length) {
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


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt32 ReadVLQUInt32(ReadOnlySpan<byte> span, out int length) {
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


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int32 ReadVLQInt32( Span<byte>span) => SpanUtils.ReadVLQInt32(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int32 ReadVLQInt32( ReadOnlySpan<byte>span) => SpanUtils.ReadVLQInt32(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int32 ReadVLQInt32(Span<byte> span, out int length) {
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
                ret = (Int32)(ret * -1);

            
            return (Int32)ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int32 ReadVLQInt32(ReadOnlySpan<byte> span, out int length) {
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
                ret = (Int32)(ret * -1);

            
            return (Int32)ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt64 ReadVLQUInt64( Span<byte>span) => SpanUtils.ReadVLQUInt64(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt64 ReadVLQUInt64( ReadOnlySpan<byte>span) => SpanUtils.ReadVLQUInt64(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt64 ReadVLQUInt64(Span<byte> span, out int length) {
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


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt64 ReadVLQUInt64(ReadOnlySpan<byte> span, out int length) {
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


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int64 ReadVLQInt64( Span<byte>span) => SpanUtils.ReadVLQInt64(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int64 ReadVLQInt64( ReadOnlySpan<byte>span) => SpanUtils.ReadVLQInt64(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int64 ReadVLQInt64(Span<byte> span, out int length) {
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
                ret = (Int64)(ret * -1);

            
            return (Int64)ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int64 ReadVLQInt64(ReadOnlySpan<byte> span, out int length) {
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
                ret = (Int64)(ret * -1);

            
            return (Int64)ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt24 ReadUInt24( Span<byte>span) => SpanUtils.ReadUInt24(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt24 ReadUInt24( ReadOnlySpan<byte>span) => SpanUtils.ReadUInt24(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt24 ReadUInt24(Span<byte> span, out int length) {
            var ret = (UInt24)(Int32)(
                  ((UInt32)span[2] << (8 * 2))
                | ((UInt32)span[1] << (8 * 1))
                | ((UInt32)span[0])
                );
            length = 3;
            
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt24 ReadUInt24(ReadOnlySpan<byte> span, out int length) {
            var ret = (UInt24)(Int32)(
                  ((UInt32)span[2] << (8 * 2))
                | ((UInt32)span[1] << (8 * 1))
                | ((UInt32)span[0])
                );
            length = 3;
            
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt24 ReadVLQUInt24( Span<byte>span) => SpanUtils.ReadVLQUInt24(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt24 ReadVLQUInt24( ReadOnlySpan<byte>span) => SpanUtils.ReadVLQUInt24(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt24 ReadVLQUInt24(Span<byte> span, out int length) {
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


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt24 ReadVLQUInt24(ReadOnlySpan<byte> span, out int length) {
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


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Guid ReadGuid( Span<byte>span) => SpanUtils.ReadGuid(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Guid ReadGuid( ReadOnlySpan<byte>span) => SpanUtils.ReadGuid(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Guid ReadGuid(Span<byte> span, out int length) {
#if NETSTANDARD21 || !BEFORENETCOREAPP3
            var ret = new Guid(span.Slice(0, 16));
#else
            var ret = new Guid(span.Slice(0, 16).ToArray());
#endif
            length = 16;
            
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Guid ReadGuid(ReadOnlySpan<byte> span, out int length) {
#if NETSTANDARD21 || !BEFORENETCOREAPP3
            var ret = new Guid(span.Slice(0, 16));
#else
            var ret = new Guid(span.Slice(0, 16).ToArray());
#endif
            length = 16;
            
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Byte[] ReadBytes(Span<byte> span, int length) {
            var ret = span.Slice(0, length).ToArray();
            
            
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Byte[] ReadBytes(ReadOnlySpan<byte> span, int length) {
            var ret = span.Slice(0, length).ToArray();
            
            
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Span<byte> ReadSpan(Span<byte> span, int length) {
            var ret = span.Slice(0, length);
            
            
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe ReadOnlySpan<byte> ReadReadOnlySpan(Span<byte> span, int length) {
            var ret = span.Slice(0, length);
            
            
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe ReadOnlySpan<byte> ReadReadOnlySpan(ReadOnlySpan<byte> span, int length) {
            var ret = span.Slice(0, length);
            
            
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt32 ReadSize( Span<byte>span) => SpanUtils.ReadSize(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt32 ReadSize( ReadOnlySpan<byte>span) => SpanUtils.ReadSize(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt32 ReadSize(Span<byte> span, out int length) {
            var b1 = span[0];
            var s = b1 >> 6;

            length = s + 1;
            var ret = s switch
            {
                0b00 => (UInt32)b1 & 0b00111111,
                0b01 => (UInt32)SpanUtils.ReadUInt16BE(span) & 0b00111111_11111111,
                0b10 => (UInt32)SpanUtils.ReadUInt24BE(span) & 0b00111111_11111111_11111111,
                //case 0b11:
                _ => (UInt32)SpanUtils.ReadUInt32BE(span) & 0b00111111_11111111_11111111_11111111
            };
            
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt32 ReadSize(ReadOnlySpan<byte> span, out int length) {
            var b1 = span[0];
            var s = b1 >> 6;

            length = s + 1;
            var ret = s switch
            {
                0b00 => (UInt32)b1 & 0b00111111,
                0b01 => (UInt32)SpanUtils.ReadUInt16BE(span) & 0b00111111_11111111,
                0b10 => (UInt32)SpanUtils.ReadUInt24BE(span) & 0b00111111_11111111_11111111,
                //case 0b11:
                _ => (UInt32)SpanUtils.ReadUInt32BE(span) & 0b00111111_11111111_11111111_11111111
            };
            
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Byte[] ReadSizedBytes( Span<byte>span) => SpanUtils.ReadSizedBytes(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Byte[] ReadSizedBytes( ReadOnlySpan<byte>span) => SpanUtils.ReadSizedBytes(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Byte[] ReadSizedBytes(Span<byte> span, out int length) {
            var size = SpanUtils.ReadSize(span, out var len);
            length = len + (int)size;
            var ret = span.Slice(len, (int)size).ToArray();
            
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Byte[] ReadSizedBytes(ReadOnlySpan<byte> span, out int length) {
            var size = SpanUtils.ReadSize(span, out var len);
            length = len + (int)size;
            var ret = span.Slice(len, (int)size).ToArray();
            
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe String ReadSizedString( Span<byte>span) => SpanUtils.ReadSizedString(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe String ReadSizedString( ReadOnlySpan<byte>span) => SpanUtils.ReadSizedString(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe String ReadSizedString(Span<byte> span, out int length) {
            var size = SpanUtils.ReadSize(span, out var len);
            length = len + (int)size;
#if NETCOREAPP || NETSTANDARD21
            var ros = (ReadOnlySpan<byte>)span.Slice(len, (int)size);
            var ret = Encoding.UTF8.GetString(ros);
#else
            var bytes = span.Slice(len, (int)size).ToArray();
            var ret = Encoding.UTF8.GetString(bytes);
#endif
            
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe String ReadSizedString(ReadOnlySpan<byte> span, out int length) {
            var size = SpanUtils.ReadSize(span, out var len);
            length = len + (int)size;
#if NETCOREAPP || NETSTANDARD21
            var ros = (ReadOnlySpan<byte>)span.Slice(len, (int)size);
            var ret = Encoding.UTF8.GetString(ros);
#else
            var bytes = span.Slice(len, (int)size).ToArray();
            var ret = Encoding.UTF8.GetString(bytes);
#endif
            
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void Move(ref Span<byte> span, int length) => span = span.Slice(length);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void Move(ref ReadOnlySpan<byte> span, int length) => span = span.Slice(length);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe SByte MoveReadSByte(ref  Span<byte>span) => SpanUtils.MoveReadSByte(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe SByte MoveReadSByte(ref  ReadOnlySpan<byte>span) => SpanUtils.MoveReadSByte(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe SByte MoveReadSByte(ref Span<byte> span, out int length) {
            var ret = (SByte)span[0];
            length = sizeof(SByte);
            span = span.Slice(sizeof(SByte));
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe SByte MoveReadSByte(ref ReadOnlySpan<byte> span, out int length) {
            var ret = (SByte)span[0];
            length = sizeof(SByte);
            span = span.Slice(sizeof(SByte));
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Byte MoveReadByte(ref  Span<byte>span) => SpanUtils.MoveReadByte(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Byte MoveReadByte(ref  ReadOnlySpan<byte>span) => SpanUtils.MoveReadByte(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Byte MoveReadByte(ref Span<byte> span, out int length) {
            var ret = span[0];
            length = sizeof(Byte);
            span = span.Slice(sizeof(Byte));
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Byte MoveReadByte(ref ReadOnlySpan<byte> span, out int length) {
            var ret = span[0];
            length = sizeof(Byte);
            span = span.Slice(sizeof(Byte));
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt16 MoveReadUInt16(ref  Span<byte>span) => SpanUtils.MoveReadUInt16(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt16 MoveReadUInt16(ref  ReadOnlySpan<byte>span) => SpanUtils.MoveReadUInt16(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt16 MoveReadUInt16(ref Span<byte> span, out int length) {
            var ret = Unsafe.ReadUnaligned<UInt16>(ref MemoryMarshal.GetReference(span));
            length = sizeof(UInt16);
            span = span.Slice(sizeof(UInt16));
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt16 MoveReadUInt16(ref ReadOnlySpan<byte> span, out int length) {
            var ret = Unsafe.ReadUnaligned<UInt16>(ref MemoryMarshal.GetReference(span));
            length = sizeof(UInt16);
            span = span.Slice(sizeof(UInt16));
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int16 MoveReadInt16(ref  Span<byte>span) => SpanUtils.MoveReadInt16(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int16 MoveReadInt16(ref  ReadOnlySpan<byte>span) => SpanUtils.MoveReadInt16(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int16 MoveReadInt16(ref Span<byte> span, out int length) {
            var ret = Unsafe.ReadUnaligned<UInt16>(ref MemoryMarshal.GetReference(span));
            length = sizeof(Int16);
            span = span.Slice(sizeof(Int16));
            return (Int16)ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int16 MoveReadInt16(ref ReadOnlySpan<byte> span, out int length) {
            var ret = Unsafe.ReadUnaligned<UInt16>(ref MemoryMarshal.GetReference(span));
            length = sizeof(Int16);
            span = span.Slice(sizeof(Int16));
            return (Int16)ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt32 MoveReadUInt32(ref  Span<byte>span) => SpanUtils.MoveReadUInt32(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt32 MoveReadUInt32(ref  ReadOnlySpan<byte>span) => SpanUtils.MoveReadUInt32(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt32 MoveReadUInt32(ref Span<byte> span, out int length) {
            var ret = Unsafe.ReadUnaligned<UInt32>(ref MemoryMarshal.GetReference(span));
            length = sizeof(UInt32);
            span = span.Slice(sizeof(UInt32));
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt32 MoveReadUInt32(ref ReadOnlySpan<byte> span, out int length) {
            var ret = Unsafe.ReadUnaligned<UInt32>(ref MemoryMarshal.GetReference(span));
            length = sizeof(UInt32);
            span = span.Slice(sizeof(UInt32));
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int32 MoveReadInt32(ref  Span<byte>span) => SpanUtils.MoveReadInt32(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int32 MoveReadInt32(ref  ReadOnlySpan<byte>span) => SpanUtils.MoveReadInt32(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int32 MoveReadInt32(ref Span<byte> span, out int length) {
            var ret = Unsafe.ReadUnaligned<UInt32>(ref MemoryMarshal.GetReference(span));
            length = sizeof(Int32);
            span = span.Slice(sizeof(Int32));
            return (Int32)ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int32 MoveReadInt32(ref ReadOnlySpan<byte> span, out int length) {
            var ret = Unsafe.ReadUnaligned<UInt32>(ref MemoryMarshal.GetReference(span));
            length = sizeof(Int32);
            span = span.Slice(sizeof(Int32));
            return (Int32)ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt64 MoveReadUInt64(ref  Span<byte>span) => SpanUtils.MoveReadUInt64(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt64 MoveReadUInt64(ref  ReadOnlySpan<byte>span) => SpanUtils.MoveReadUInt64(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt64 MoveReadUInt64(ref Span<byte> span, out int length) {
            var ret = Unsafe.ReadUnaligned<UInt64>(ref MemoryMarshal.GetReference(span));
            length = sizeof(UInt64);
            span = span.Slice(sizeof(UInt64));
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt64 MoveReadUInt64(ref ReadOnlySpan<byte> span, out int length) {
            var ret = Unsafe.ReadUnaligned<UInt64>(ref MemoryMarshal.GetReference(span));
            length = sizeof(UInt64);
            span = span.Slice(sizeof(UInt64));
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int64 MoveReadInt64(ref  Span<byte>span) => SpanUtils.MoveReadInt64(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int64 MoveReadInt64(ref  ReadOnlySpan<byte>span) => SpanUtils.MoveReadInt64(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int64 MoveReadInt64(ref Span<byte> span, out int length) {
            var ret = Unsafe.ReadUnaligned<UInt64>(ref MemoryMarshal.GetReference(span));
            length = sizeof(Int64);
            span = span.Slice(sizeof(Int64));
            return (Int64)ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int64 MoveReadInt64(ref ReadOnlySpan<byte> span, out int length) {
            var ret = Unsafe.ReadUnaligned<UInt64>(ref MemoryMarshal.GetReference(span));
            length = sizeof(Int64);
            span = span.Slice(sizeof(Int64));
            return (Int64)ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Single MoveReadSingle(ref  Span<byte>span) => SpanUtils.MoveReadSingle(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Single MoveReadSingle(ref  ReadOnlySpan<byte>span) => SpanUtils.MoveReadSingle(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Single MoveReadSingle(ref Span<byte> span, out int length) {
#if NETSTANDARD21 || !BEFORENETCOREAPP3
            var r = BitConverter.Int32BitsToSingle(SpanUtils.ReadInt32(span, out _));
#else
            //Span<float> a = stackalloc float[1];
            //var ab = MemoryMarshal.Cast<float, byte>(a);
            //span.Slice(0, sizeof(float)).CopyTo(ab);
            //var r = a[0];
            var i = SpanUtils.ReadInt32(span, out _);
            var r = *(float*)(&i);
#endif
            length = sizeof(Single);
            span = span.Slice(sizeof(Single));
            return r;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Single MoveReadSingle(ref ReadOnlySpan<byte> span, out int length) {
#if NETSTANDARD21 || !BEFORENETCOREAPP3
            var r = BitConverter.Int32BitsToSingle(SpanUtils.ReadInt32(span, out _));
#else
            //Span<float> a = stackalloc float[1];
            //var ab = MemoryMarshal.Cast<float, byte>(a);
            //span.Slice(0, sizeof(float)).CopyTo(ab);
            //var r = a[0];
            var i = SpanUtils.ReadInt32(span, out _);
            var r = *(float*)(&i);
#endif
            length = sizeof(Single);
            span = span.Slice(sizeof(Single));
            return r;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Double MoveReadDouble(ref  Span<byte>span) => SpanUtils.MoveReadDouble(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Double MoveReadDouble(ref  ReadOnlySpan<byte>span) => SpanUtils.MoveReadDouble(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Double MoveReadDouble(ref Span<byte> span, out int length) {
#if NETSTANDARD21 || !BEFORENETCOREAPP3
            var r = BitConverter.Int64BitsToDouble(SpanUtils.ReadInt64(span, out _));
#else
            //Span<double> a = stackalloc double[1];
            //var ab = MemoryMarshal.Cast<double, byte>(a);
            //span.Slice(0, sizeof(double)).CopyTo(ab);
            //var r = a[0];
            var i = SpanUtils.ReadInt64(span, out _);
            var r = *(double*)(&i);
#endif
            length = sizeof(Double);
            span = span.Slice(sizeof(Double));
            return r;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Double MoveReadDouble(ref ReadOnlySpan<byte> span, out int length) {
#if NETSTANDARD21 || !BEFORENETCOREAPP3
            var r = BitConverter.Int64BitsToDouble(SpanUtils.ReadInt64(span, out _));
#else
            //Span<double> a = stackalloc double[1];
            //var ab = MemoryMarshal.Cast<double, byte>(a);
            //span.Slice(0, sizeof(double)).CopyTo(ab);
            //var r = a[0];
            var i = SpanUtils.ReadInt64(span, out _);
            var r = *(double*)(&i);
#endif
            length = sizeof(Double);
            span = span.Slice(sizeof(Double));
            return r;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Decimal MoveReadDecimal(ref  Span<byte>span) => SpanUtils.MoveReadDecimal(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Decimal MoveReadDecimal(ref  ReadOnlySpan<byte>span) => SpanUtils.MoveReadDecimal(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Decimal MoveReadDecimal(ref Span<byte> span, out int length) {
            Span<decimal> a = stackalloc decimal[1];
            var ab = MemoryMarshal.Cast<decimal, byte>(a);
            span.Slice(0, sizeof(decimal)).CopyTo(ab);
            length = sizeof(Decimal);
            span = span.Slice(sizeof(Decimal));
            return a[0];
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Decimal MoveReadDecimal(ref ReadOnlySpan<byte> span, out int length) {
            Span<decimal> a = stackalloc decimal[1];
            var ab = MemoryMarshal.Cast<decimal, byte>(a);
            span.Slice(0, sizeof(decimal)).CopyTo(ab);
            length = sizeof(Decimal);
            span = span.Slice(sizeof(Decimal));
            return a[0];
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Boolean MoveReadBoolean(ref  Span<byte>span) => SpanUtils.MoveReadBoolean(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Boolean MoveReadBoolean(ref  ReadOnlySpan<byte>span) => SpanUtils.MoveReadBoolean(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Boolean MoveReadBoolean(ref Span<byte> span, out int length) {
            var ret = span[0] != 0;
            length = sizeof(Boolean);
            span = span.Slice(sizeof(Boolean));
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Boolean MoveReadBoolean(ref ReadOnlySpan<byte> span, out int length) {
            var ret = span[0] != 0;
            length = sizeof(Boolean);
            span = span.Slice(sizeof(Boolean));
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Char MoveReadChar(ref  Span<byte>span) => SpanUtils.MoveReadChar(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Char MoveReadChar(ref  ReadOnlySpan<byte>span) => SpanUtils.MoveReadChar(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Char MoveReadChar(ref Span<byte> span, out int length) {
            var r = MemoryMarshal.Read<Char>(span);
            length = sizeof(Char);
            span = span.Slice(sizeof(Char));
            return r;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Char MoveReadChar(ref ReadOnlySpan<byte> span, out int length) {
            var r = MemoryMarshal.Read<Char>(span);
            length = sizeof(Char);
            span = span.Slice(sizeof(Char));
            return r;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Single MoveReadFloat(ref  Span<byte>span) => SpanUtils.MoveReadFloat(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Single MoveReadFloat(ref  ReadOnlySpan<byte>span) => SpanUtils.MoveReadFloat(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Single MoveReadFloat(ref Span<byte> span, out int length) {
#if NETSTANDARD21 || !BEFORENETCOREAPP3
            var r = BitConverter.Int32BitsToSingle(SpanUtils.ReadInt32(span, out _));
#else
            //Span<float> a = stackalloc float[1];
            //var ab = MemoryMarshal.Cast<float, byte>(a);
            //span.Slice(0, sizeof(float)).CopyTo(ab);
            //var r = a[0];
            var i = SpanUtils.ReadInt32(span, out _);
            var r = *(float*)(&i);
#endif
            length = sizeof(Single);
            span = span.Slice(sizeof(Single));
            return r;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Single MoveReadFloat(ref ReadOnlySpan<byte> span, out int length) {
#if NETSTANDARD21 || !BEFORENETCOREAPP3
            var r = BitConverter.Int32BitsToSingle(SpanUtils.ReadInt32(span, out _));
#else
            //Span<float> a = stackalloc float[1];
            //var ab = MemoryMarshal.Cast<float, byte>(a);
            //span.Slice(0, sizeof(float)).CopyTo(ab);
            //var r = a[0];
            var i = SpanUtils.ReadInt32(span, out _);
            var r = *(float*)(&i);
#endif
            length = sizeof(Single);
            span = span.Slice(sizeof(Single));
            return r;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int16 MoveReadShort(ref  Span<byte>span) => SpanUtils.MoveReadShort(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int16 MoveReadShort(ref  ReadOnlySpan<byte>span) => SpanUtils.MoveReadShort(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int16 MoveReadShort(ref Span<byte> span, out int length) {
            var ret = Unsafe.ReadUnaligned<UInt16>(ref MemoryMarshal.GetReference(span));
            length = sizeof(Int16);
            span = span.Slice(sizeof(Int16));
            return (Int16)ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int16 MoveReadShort(ref ReadOnlySpan<byte> span, out int length) {
            var ret = Unsafe.ReadUnaligned<UInt16>(ref MemoryMarshal.GetReference(span));
            length = sizeof(Int16);
            span = span.Slice(sizeof(Int16));
            return (Int16)ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt16 MoveReadUShort(ref  Span<byte>span) => SpanUtils.MoveReadUShort(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt16 MoveReadUShort(ref  ReadOnlySpan<byte>span) => SpanUtils.MoveReadUShort(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt16 MoveReadUShort(ref Span<byte> span, out int length) {
            var ret = Unsafe.ReadUnaligned<UInt16>(ref MemoryMarshal.GetReference(span));
            length = sizeof(UInt16);
            span = span.Slice(sizeof(UInt16));
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt16 MoveReadUShort(ref ReadOnlySpan<byte> span, out int length) {
            var ret = Unsafe.ReadUnaligned<UInt16>(ref MemoryMarshal.GetReference(span));
            length = sizeof(UInt16);
            span = span.Slice(sizeof(UInt16));
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int32 MoveReadInt(ref  Span<byte>span) => SpanUtils.MoveReadInt(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int32 MoveReadInt(ref  ReadOnlySpan<byte>span) => SpanUtils.MoveReadInt(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int32 MoveReadInt(ref Span<byte> span, out int length) {
            var ret = Unsafe.ReadUnaligned<UInt32>(ref MemoryMarshal.GetReference(span));
            length = sizeof(Int32);
            span = span.Slice(sizeof(Int32));
            return (Int32)ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int32 MoveReadInt(ref ReadOnlySpan<byte> span, out int length) {
            var ret = Unsafe.ReadUnaligned<UInt32>(ref MemoryMarshal.GetReference(span));
            length = sizeof(Int32);
            span = span.Slice(sizeof(Int32));
            return (Int32)ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt32 MoveReadUInt(ref  Span<byte>span) => SpanUtils.MoveReadUInt(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt32 MoveReadUInt(ref  ReadOnlySpan<byte>span) => SpanUtils.MoveReadUInt(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt32 MoveReadUInt(ref Span<byte> span, out int length) {
            var ret = Unsafe.ReadUnaligned<UInt32>(ref MemoryMarshal.GetReference(span));
            length = sizeof(UInt32);
            span = span.Slice(sizeof(UInt32));
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt32 MoveReadUInt(ref ReadOnlySpan<byte> span, out int length) {
            var ret = Unsafe.ReadUnaligned<UInt32>(ref MemoryMarshal.GetReference(span));
            length = sizeof(UInt32);
            span = span.Slice(sizeof(UInt32));
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int64 MoveReadLong(ref  Span<byte>span) => SpanUtils.MoveReadLong(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int64 MoveReadLong(ref  ReadOnlySpan<byte>span) => SpanUtils.MoveReadLong(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int64 MoveReadLong(ref Span<byte> span, out int length) {
            var ret = Unsafe.ReadUnaligned<UInt64>(ref MemoryMarshal.GetReference(span));
            length = sizeof(Int64);
            span = span.Slice(sizeof(Int64));
            return (Int64)ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int64 MoveReadLong(ref ReadOnlySpan<byte> span, out int length) {
            var ret = Unsafe.ReadUnaligned<UInt64>(ref MemoryMarshal.GetReference(span));
            length = sizeof(Int64);
            span = span.Slice(sizeof(Int64));
            return (Int64)ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt64 MoveReadULong(ref  Span<byte>span) => SpanUtils.MoveReadULong(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt64 MoveReadULong(ref  ReadOnlySpan<byte>span) => SpanUtils.MoveReadULong(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt64 MoveReadULong(ref Span<byte> span, out int length) {
            var ret = Unsafe.ReadUnaligned<UInt64>(ref MemoryMarshal.GetReference(span));
            length = sizeof(UInt64);
            span = span.Slice(sizeof(UInt64));
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt64 MoveReadULong(ref ReadOnlySpan<byte> span, out int length) {
            var ret = Unsafe.ReadUnaligned<UInt64>(ref MemoryMarshal.GetReference(span));
            length = sizeof(UInt64);
            span = span.Slice(sizeof(UInt64));
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Boolean MoveReadBool(ref  Span<byte>span) => SpanUtils.MoveReadBool(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Boolean MoveReadBool(ref  ReadOnlySpan<byte>span) => SpanUtils.MoveReadBool(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Boolean MoveReadBool(ref Span<byte> span, out int length) {
            var ret = span[0] != 0;
            length = sizeof(Boolean);
            span = span.Slice(sizeof(Boolean));
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Boolean MoveReadBool(ref ReadOnlySpan<byte> span, out int length) {
            var ret = span[0] != 0;
            length = sizeof(Boolean);
            span = span.Slice(sizeof(Boolean));
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt16 MoveReadVLQUInt16(ref  Span<byte>span) => SpanUtils.MoveReadVLQUInt16(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt16 MoveReadVLQUInt16(ref  ReadOnlySpan<byte>span) => SpanUtils.MoveReadVLQUInt16(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt16 MoveReadVLQUInt16(ref Span<byte> span, out int length) {
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
            span = span.Slice(length);
            return (UInt16)ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt16 MoveReadVLQUInt16(ref ReadOnlySpan<byte> span, out int length) {
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
            span = span.Slice(length);
            return (UInt16)ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int16 MoveReadVLQInt16(ref  Span<byte>span) => SpanUtils.MoveReadVLQInt16(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int16 MoveReadVLQInt16(ref  ReadOnlySpan<byte>span) => SpanUtils.MoveReadVLQInt16(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int16 MoveReadVLQInt16(ref Span<byte> span, out int length) {
            // Lower bound special case
            if (span[0] == 0b0100_0000)
            {
                length = 1;
                span = span.Slice(length);
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
                ret = (Int16)(ret * -1);

            span = span.Slice(length);
            return (Int16)ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int16 MoveReadVLQInt16(ref ReadOnlySpan<byte> span, out int length) {
            // Lower bound special case
            if (span[0] == 0b0100_0000)
            {
                length = 1;
                span = span.Slice(length);
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
                ret = (Int16)(ret * -1);

            span = span.Slice(length);
            return (Int16)ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt32 MoveReadVLQUInt32(ref  Span<byte>span) => SpanUtils.MoveReadVLQUInt32(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt32 MoveReadVLQUInt32(ref  ReadOnlySpan<byte>span) => SpanUtils.MoveReadVLQUInt32(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt32 MoveReadVLQUInt32(ref Span<byte> span, out int length) {
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
            span = span.Slice(length);
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt32 MoveReadVLQUInt32(ref ReadOnlySpan<byte> span, out int length) {
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
            span = span.Slice(length);
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int32 MoveReadVLQInt32(ref  Span<byte>span) => SpanUtils.MoveReadVLQInt32(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int32 MoveReadVLQInt32(ref  ReadOnlySpan<byte>span) => SpanUtils.MoveReadVLQInt32(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int32 MoveReadVLQInt32(ref Span<byte> span, out int length) {
            // Lower bound special case
            if (span[0] == 0b0100_0000)
            {
                length = 1;
                span = span.Slice(length);
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
                ret = (Int32)(ret * -1);

            span = span.Slice(length);
            return (Int32)ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int32 MoveReadVLQInt32(ref ReadOnlySpan<byte> span, out int length) {
            // Lower bound special case
            if (span[0] == 0b0100_0000)
            {
                length = 1;
                span = span.Slice(length);
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
                ret = (Int32)(ret * -1);

            span = span.Slice(length);
            return (Int32)ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt64 MoveReadVLQUInt64(ref  Span<byte>span) => SpanUtils.MoveReadVLQUInt64(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt64 MoveReadVLQUInt64(ref  ReadOnlySpan<byte>span) => SpanUtils.MoveReadVLQUInt64(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt64 MoveReadVLQUInt64(ref Span<byte> span, out int length) {
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
            span = span.Slice(length);
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt64 MoveReadVLQUInt64(ref ReadOnlySpan<byte> span, out int length) {
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
            span = span.Slice(length);
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int64 MoveReadVLQInt64(ref  Span<byte>span) => SpanUtils.MoveReadVLQInt64(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int64 MoveReadVLQInt64(ref  ReadOnlySpan<byte>span) => SpanUtils.MoveReadVLQInt64(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int64 MoveReadVLQInt64(ref Span<byte> span, out int length) {
            // Lower bound special case
            if (span[0] == 0b0100_0000)
            {
                length = 1;
                span = span.Slice(length);
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
                ret = (Int64)(ret * -1);

            span = span.Slice(length);
            return (Int64)ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int64 MoveReadVLQInt64(ref ReadOnlySpan<byte> span, out int length) {
            // Lower bound special case
            if (span[0] == 0b0100_0000)
            {
                length = 1;
                span = span.Slice(length);
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
                ret = (Int64)(ret * -1);

            span = span.Slice(length);
            return (Int64)ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt24 MoveReadUInt24(ref  Span<byte>span) => SpanUtils.MoveReadUInt24(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt24 MoveReadUInt24(ref  ReadOnlySpan<byte>span) => SpanUtils.MoveReadUInt24(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt24 MoveReadUInt24(ref Span<byte> span, out int length) {
            var ret = (UInt24)(Int32)(
                  ((UInt32)span[2] << (8 * 2))
                | ((UInt32)span[1] << (8 * 1))
                | ((UInt32)span[0])
                );
            length = 3;
            span = span.Slice(3);
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt24 MoveReadUInt24(ref ReadOnlySpan<byte> span, out int length) {
            var ret = (UInt24)(Int32)(
                  ((UInt32)span[2] << (8 * 2))
                | ((UInt32)span[1] << (8 * 1))
                | ((UInt32)span[0])
                );
            length = 3;
            span = span.Slice(3);
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt24 MoveReadVLQUInt24(ref  Span<byte>span) => SpanUtils.MoveReadVLQUInt24(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt24 MoveReadVLQUInt24(ref  ReadOnlySpan<byte>span) => SpanUtils.MoveReadVLQUInt24(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt24 MoveReadVLQUInt24(ref Span<byte> span, out int length) {
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
            span = span.Slice(length);
            return ret.ToUInt24();
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt24 MoveReadVLQUInt24(ref ReadOnlySpan<byte> span, out int length) {
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
            span = span.Slice(length);
            return ret.ToUInt24();
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Guid MoveReadGuid(ref  Span<byte>span) => SpanUtils.MoveReadGuid(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Guid MoveReadGuid(ref  ReadOnlySpan<byte>span) => SpanUtils.MoveReadGuid(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Guid MoveReadGuid(ref Span<byte> span, out int length) {
#if NETSTANDARD21 || !BEFORENETCOREAPP3
            var ret = new Guid(span.Slice(0, 16));
#else
            var ret = new Guid(span.Slice(0, 16).ToArray());
#endif
            length = 16;
            span = span.Slice(16);
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Guid MoveReadGuid(ref ReadOnlySpan<byte> span, out int length) {
#if NETSTANDARD21 || !BEFORENETCOREAPP3
            var ret = new Guid(span.Slice(0, 16));
#else
            var ret = new Guid(span.Slice(0, 16).ToArray());
#endif
            length = 16;
            span = span.Slice(16);
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Byte[] MoveReadBytes(ref Span<byte> span, int length) {
            var ret = span.Slice(0, length).ToArray();
            
            span = span.Slice(length);
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Byte[] MoveReadBytes(ref ReadOnlySpan<byte> span, int length) {
            var ret = span.Slice(0, length).ToArray();
            
            span = span.Slice(length);
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Span<byte> MoveReadSpan(ref Span<byte> span, int length) {
            var ret = span.Slice(0, length);
            
            span = span.Slice(length);
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe ReadOnlySpan<byte> MoveReadReadOnlySpan(ref Span<byte> span, int length) {
            var ret = span.Slice(0, length);
            
            span = span.Slice(length);
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe ReadOnlySpan<byte> MoveReadReadOnlySpan(ref ReadOnlySpan<byte> span, int length) {
            var ret = span.Slice(0, length);
            
            span = span.Slice(length);
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt32 MoveReadSize(ref  Span<byte>span) => SpanUtils.MoveReadSize(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt32 MoveReadSize(ref  ReadOnlySpan<byte>span) => SpanUtils.MoveReadSize(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt32 MoveReadSize(ref Span<byte> span, out int length) {
            var b1 = span[0];
            var s = b1 >> 6;

            length = s + 1;
            var ret = s switch
            {
                0b00 => (UInt32)b1 & 0b00111111,
                0b01 => (UInt32)SpanUtils.ReadUInt16BE(span) & 0b00111111_11111111,
                0b10 => (UInt32)SpanUtils.ReadUInt24BE(span) & 0b00111111_11111111_11111111,
                //case 0b11:
                _ => (UInt32)SpanUtils.ReadUInt32BE(span) & 0b00111111_11111111_11111111_11111111
            };
            span = span.Slice(length);
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt32 MoveReadSize(ref ReadOnlySpan<byte> span, out int length) {
            var b1 = span[0];
            var s = b1 >> 6;

            length = s + 1;
            var ret = s switch
            {
                0b00 => (UInt32)b1 & 0b00111111,
                0b01 => (UInt32)SpanUtils.ReadUInt16BE(span) & 0b00111111_11111111,
                0b10 => (UInt32)SpanUtils.ReadUInt24BE(span) & 0b00111111_11111111_11111111,
                //case 0b11:
                _ => (UInt32)SpanUtils.ReadUInt32BE(span) & 0b00111111_11111111_11111111_11111111
            };
            span = span.Slice(length);
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Byte[] MoveReadSizedBytes(ref  Span<byte>span) => SpanUtils.MoveReadSizedBytes(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Byte[] MoveReadSizedBytes(ref  ReadOnlySpan<byte>span) => SpanUtils.MoveReadSizedBytes(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Byte[] MoveReadSizedBytes(ref Span<byte> span, out int length) {
            var size = SpanUtils.ReadSize(span, out var len);
            length = len + (int)size;
            var ret = span.Slice(len, (int)size).ToArray();
            span = span.Slice(length);
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Byte[] MoveReadSizedBytes(ref ReadOnlySpan<byte> span, out int length) {
            var size = SpanUtils.ReadSize(span, out var len);
            length = len + (int)size;
            var ret = span.Slice(len, (int)size).ToArray();
            span = span.Slice(length);
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe String MoveReadSizedString(ref  Span<byte>span) => SpanUtils.MoveReadSizedString(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe String MoveReadSizedString(ref  ReadOnlySpan<byte>span) => SpanUtils.MoveReadSizedString(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe String MoveReadSizedString(ref Span<byte> span, out int length) {
            var size = SpanUtils.ReadSize(span, out var len);
            length = len + (int)size;
#if NETCOREAPP || NETSTANDARD21
            var ros = (ReadOnlySpan<byte>)span.Slice(len, (int)size);
            var ret = Encoding.UTF8.GetString(ros);
#else
            var bytes = span.Slice(len, (int)size).ToArray();
            var ret = Encoding.UTF8.GetString(bytes);
#endif
            span = span.Slice(length);
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe String MoveReadSizedString(ref ReadOnlySpan<byte> span, out int length) {
            var size = SpanUtils.ReadSize(span, out var len);
            length = len + (int)size;
#if NETCOREAPP || NETSTANDARD21
            var ros = (ReadOnlySpan<byte>)span.Slice(len, (int)size);
            var ret = Encoding.UTF8.GetString(ros);
#else
            var bytes = span.Slice(len, (int)size).ToArray();
            var ret = Encoding.UTF8.GetString(bytes);
#endif
            span = span.Slice(length);
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void Write(Span<byte>span, SByte value) => SpanUtils.Write(span, value, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void Write(Span<byte>span, SByte value, out int length) {
        span[0] = (byte)value;
        length = sizeof(SByte);
        
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void Write(Span<byte>span, Byte value) => SpanUtils.Write(span, value, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void Write(Span<byte>span, Byte value, out int length) {
        span[0] = value;
        length = sizeof(Byte);
        
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void Write(Span<byte>span, UInt16 value) => SpanUtils.Write(span, value, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void Write(Span<byte>span, UInt16 value, out int length) {
            if (span.Length < sizeof(UInt16))
                throw new ArgumentOutOfRangeException();
            Unsafe.WriteUnaligned(ref MemoryMarshal.GetReference(span), value);
            length = sizeof(UInt16);
            
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void Write(Span<byte>span, Int16 value) => SpanUtils.Write(span, value, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void Write(Span<byte>span, Int16 value, out int length) {
            if (span.Length < sizeof(UInt16))
                throw new ArgumentOutOfRangeException();
            Unsafe.WriteUnaligned(ref MemoryMarshal.GetReference(span), value);
            length = sizeof(Int16);
            
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void Write(Span<byte>span, UInt32 value) => SpanUtils.Write(span, value, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void Write(Span<byte>span, UInt32 value, out int length) {
            if (span.Length < sizeof(UInt32))
                throw new ArgumentOutOfRangeException();
            Unsafe.WriteUnaligned(ref MemoryMarshal.GetReference(span), value);
            length = sizeof(UInt32);
            
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void Write(Span<byte>span, Int32 value) => SpanUtils.Write(span, value, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void Write(Span<byte>span, Int32 value, out int length) {
            if (span.Length < sizeof(UInt32))
                throw new ArgumentOutOfRangeException();
            Unsafe.WriteUnaligned(ref MemoryMarshal.GetReference(span), value);
            length = sizeof(Int32);
            
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void Write(Span<byte>span, UInt64 value) => SpanUtils.Write(span, value, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void Write(Span<byte>span, UInt64 value, out int length) {
            if (span.Length < sizeof(UInt64))
                throw new ArgumentOutOfRangeException();
            Unsafe.WriteUnaligned(ref MemoryMarshal.GetReference(span), value);
            length = sizeof(UInt64);
            
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void Write(Span<byte>span, Int64 value) => SpanUtils.Write(span, value, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void Write(Span<byte>span, Int64 value, out int length) {
            if (span.Length < sizeof(UInt64))
                throw new ArgumentOutOfRangeException();
            Unsafe.WriteUnaligned(ref MemoryMarshal.GetReference(span), value);
            length = sizeof(Int64);
            
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void Write(Span<byte>span, Single value) => SpanUtils.Write(span, value, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void Write(Span<byte>span, Single value, out int length) {
#if NETSTANDARD21 || !BEFORENETCOREAPP3
            SpanUtils.Write(span, BitConverter.SingleToInt32Bits(value), out _);
#else
            //Span<float> a = stackalloc float[1] { value };
            //var ab = MemoryMarshal.Cast<float, byte>(a);
            //ab.CopyTo(span);
            var i = *(int*)(&value);
            SpanUtils.Write(span, i, out _);
#endif
            length = sizeof(Single);
            
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void Write(Span<byte>span, Double value) => SpanUtils.Write(span, value, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void Write(Span<byte>span, Double value, out int length) {
#if NETSTANDARD21 || !BEFORENETCOREAPP3
            SpanUtils.Write(span, BitConverter.DoubleToInt64Bits(value), out _);
#else
            //Span<double> a = stackalloc double[1] { value };
            //var ab = MemoryMarshal.Cast<double, byte>(a);
            //ab.CopyTo(span);
            var i = *(long*)(&value);
            SpanUtils.Write(span, i, out _);
#endif
            length = sizeof(Double);
            
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void Write(Span<byte>span, Decimal value) => SpanUtils.Write(span, value, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void Write(Span<byte>span, Decimal value, out int length) {
            Span<decimal> a = stackalloc decimal[1] { value };
            var ab = MemoryMarshal.Cast<decimal, byte>(a);
            ab.CopyTo(span);
            length = sizeof(Decimal);
            
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void Write(Span<byte>span, Boolean value) => SpanUtils.Write(span, value, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void Write(Span<byte>span, Boolean value, out int length) {
            span[0] = (byte)(value ? 1 : 0);
            length = sizeof(Boolean);
            
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void Write(Span<byte>span, Char value) => SpanUtils.Write(span, value, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void Write(Span<byte>span, Char value, out int length) {
            MemoryMarshal.Write(span, ref value);
            length = sizeof(Char);
            
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void WriteVLQ(Span<byte>span, UInt16 value) => SpanUtils.WriteVLQ(span, value, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void WriteVLQ(Span<byte>span, UInt16 value, out int length) {
            length = 0;
            while (value >= 0x80)
            {
                span[length++] = ((byte)(value | 0x80));
                value >>= 7;
            }
            span[length++] = (byte)value;
            
            
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void WriteVLQ(Span<byte>span, Int16 value) => SpanUtils.WriteVLQ(span, value, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void WriteVLQ(Span<byte>span, Int16 value, out int length) {
            length = 0;
            if (value < 0)
            {
                span[0] = 0b0100_0000;
                // Special case for lower bound, no more processing required
                if (value == Int16.MinValue) {
                    length = 1;
                    
                    return;
                }
                value *= -1;

            }
            else span[0] = 0b0000_0000;

            // Write first byte, special case as we only have room for 6 bits in this one
            span[0] |= (byte)(value & 0b0011_1111);
            value >>= 6;

            // Still got some left? Go at it with 7 bit increments
            while (value > 0)
            {
                // We need one more byte, set current bit flag for that
                span[length++] |= 0b1000_0000;
                // Then the next 7 bits. Note that we don't need to remove 8th bit as overflow always would set that anyway.
                span[length] = (byte)value;
                value >>= 7;
            }

            ++length;
            
            
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void WriteVLQ(Span<byte>span, UInt32 value) => SpanUtils.WriteVLQ(span, value, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void WriteVLQ(Span<byte>span, UInt32 value, out int length) {
            length = 0;
            while (value >= 0x80)
            {
                span[length++] = ((byte)(value | 0x80));
                value >>= 7;
            }
            span[length++] = (byte)value;
            
            
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void WriteVLQ(Span<byte>span, Int32 value) => SpanUtils.WriteVLQ(span, value, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void WriteVLQ(Span<byte>span, Int32 value, out int length) {
            length = 0;
            if (value < 0)
            {
                span[0] = 0b0100_0000;
                // Special case for lower bound, no more processing required
                if (value == Int32.MinValue) {
                    length = 1;
                    return;
                }
                value *= -1;

            }
            else span[0] = 0b0000_0000;

            // Write first byte, special case as we only have room for 6 bits in this one
            span[0] |= (byte)(value & 0b0011_1111);
            value >>= 6;

            // Still got some left? Go at it with 7 bit increments
            while (value > 0)
            {
                // We need one more byte, set current bit flag for that
                span[length++] |= 0b1000_0000;
                // Then the next 7 bits. Note that we don't need to remove 8th bit as overflow always would set that anyway.
                span[length] = (byte)value;
                value >>= 7;
            }
            ++length;
            
            
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void WriteVLQ(Span<byte>span, UInt64 value) => SpanUtils.WriteVLQ(span, value, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void WriteVLQ(Span<byte>span, UInt64 value, out int length) {
            length = 0;
            while (value >= 0x80)
            {
                span[length++] = ((byte)(value | 0x80));
                value >>= 7;
            }
            span[length++] = (byte)value;
            
            
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void WriteVLQ(Span<byte>span, Int64 value) => SpanUtils.WriteVLQ(span, value, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void WriteVLQ(Span<byte>span, Int64 value, out int length) {
            length = 0;
            if (value < 0)
            {
                span[0] = 0b0100_0000;
                // Special case for lower bound, no more processing required
                if (value == Int64.MinValue) {
                    length = 1;
                    return;
                }
                value *= -1;

            }
            else span[0] = 0b0000_0000;

            // Write first byte, special case as we only have room for 6 bits in this one
            span[0] |= (byte)(value & 0b0011_1111);
            value >>= 6;

            // Still got some left? Go at it with 7 bit increments
            while (value > 0)
            {
                // We need one more byte, set current bit flag for that
                span[length++] |= 0b1000_0000;
                // Then the next 7 bits. Note that we don't need to remove 8th bit as overflow always would set that anyway.
                span[length] = (byte)value;
                value >>= 7;
            }
            ++length;
            
            
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void Write(Span<byte>span, UInt24 value) => SpanUtils.Write(span, value, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void Write(Span<byte>span, UInt24 value, out int length) {
            //MemoryMarshal.Cast<byte, UInt32>(span)[0] = value;
            span[2] = (byte)(((Int32)value >> (8 * 2)) & 0xFF);
            span[0] = (byte)((Int32)value & 0xFF);
            span[1] = (byte)(((Int32)value >> (8 * 1)) & 0xFF);
            length = 3;
            
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void WriteVLQ(Span<byte>span, UInt24 value) => SpanUtils.WriteVLQ(span, value, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void WriteVLQ(Span<byte>span, UInt24 value, out int length) {
            length = 0;
            value = (UInt24)((UInt32)value & 0b11111111_11111111_11111111);
            while ((UInt32)value >= 0x80)
            {
                span[length++] = ((byte)((UInt32)value | 0x80));
                value = (UInt24)((UInt32)value >> 7);
            }
            span[length++] = (byte)value;
            
            
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void Write(Span<byte>span, Guid value) => SpanUtils.Write(span, value, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void Write(Span<byte>span, Guid value, out int length) {
#if NETSTANDARD21 || !BEFORENETCOREAPP3
            if (!value.TryWriteBytes(span))
                throw new ArgumentOutOfRangeException();
#else
            var array = new Span<byte>(value.ToByteArray());
            array.CopyTo(span);
#endif
            length = 16;
            
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void Write(Span<byte>span, Byte[] value) => SpanUtils.Write(span, value, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void Write(Span<byte>span, Byte[] value, out int length) {
            value.CopyTo(span);
            length = value.Length;
            
            
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void Write(Span<byte>span, Span<byte> value) => SpanUtils.Write(span, value, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void Write(Span<byte>span, Span<byte> value, out int length) {
            value.CopyTo(span);
            length = value.Length;
            
            
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void Write(Span<byte>span, ReadOnlySpan<byte> value) => SpanUtils.Write(span, value, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void Write(Span<byte>span, ReadOnlySpan<byte> value, out int length) {
            value.CopyTo(span);
            length = value.Length;
            
            
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void WriteSize(Span<byte>span, UInt32 value) => SpanUtils.WriteSize(span, value, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void WriteSize(Span<byte>span, UInt32 value, out int length) {
            length = SpanUtils.MeasureWriteSize(value);
            if (length == 1)
                SpanUtils.Write(span, (Byte)value);
            else if (length == 2)
                SpanUtils.WriteBE(span, (UInt16)((UInt16)value | (0b01 << 14)));
            // Even larger (up to 4,2M) we store length as 3 bytes
            else if (length == 3)
                SpanUtils.WriteBE(span, (UInt24)((UInt32)value | (0b10 << 22)));
            else if (length == 4)
                SpanUtils.WriteBE(span, (UInt32)((UInt32)value | (0b11 << 30)));

            
            
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void WriteSized(Span<byte>span, Byte[] value) => SpanUtils.WriteSized(span, value, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void WriteSized(Span<byte>span, Byte[] value, out int length) {
            var mbs = SpanUtils.MeasureWriteSize((UInt32)value.Length);
            var len = mbs + value.Length;
            if (len > span.Length)
                throw new ArgumentException("Data length too big for target span.", nameof(value));

            SpanUtils.WriteSize(span, (UInt32)value.Length, out _);
            value.CopyTo(span.Slice(mbs));
            length = len;
            
            
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void WriteSized(Span<byte>span, String value) => SpanUtils.WriteSized(span, value, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void WriteSized(Span<byte>span, String value, out int length) {
#if NETCOREAPP || NETSTANDARD21
            // We use GetByteCount followed by direct copy to avoid creating a byte array (avoid GC).
            // For larger strings this could cause 
            var strSize = (UInt32)Encoding.UTF8.GetByteCount(value);
            var mbs = SpanUtils.MeasureWriteSize((UInt32)strSize);
            var len = (int)mbs + (int)strSize;
            if (len > span.Length)
                throw new ArgumentException("Data length too big for target span.", nameof(value));

            SpanUtils.WriteSize(span, strSize, out _);

            Encoding.UTF8.GetBytes(value, span.Slice(mbs));
#else
            var bytes = Encoding.UTF8.GetBytes(value);
            if (bytes.Length > span.Length)
                throw new ArgumentException("String is too long.", nameof(value));

            SpanUtils.WriteSize(span, (UInt32)bytes.Length, out var mbs);
            var len = (int)mbs + bytes.Length;
            var s = span.Slice(mbs, bytes.Length);
            SpanUtils.Write(s, bytes, out _);
#endif
            length = len;
            
            
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void WriteSized(Span<byte>span, Span<byte> value) => SpanUtils.WriteSized(span, value, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void WriteSized(Span<byte>span, Span<byte> value, out int length) {
            var mbs = SpanUtils.MeasureWriteSize((UInt32)value.Length);
            var len = mbs + value.Length;
            if (len > span.Length)
                throw new ArgumentException("Data length too big for target span.", nameof(value));

            SpanUtils.WriteSize(span, (UInt32)value.Length, out _);
            value.CopyTo(span.Slice(mbs));
            length = len;
            
            
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void WriteSized(Span<byte>span, ReadOnlySpan<byte> value) => SpanUtils.WriteSized(span, value, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void WriteSized(Span<byte>span, ReadOnlySpan<byte> value, out int length) {
            var mbs = SpanUtils.MeasureWriteSize((UInt32)value.Length);
            var len = mbs + value.Length;
            if (len > span.Length)
                throw new ArgumentException("Data length too big for target span.", nameof(value));

            SpanUtils.WriteSize(span, (UInt32)value.Length, out _);
            value.CopyTo(span.Slice(mbs));
            length = len;
            
            
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void MoveWrite(ref Span<byte>span, SByte value) => SpanUtils.MoveWrite(ref span, value, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void MoveWrite(ref Span<byte>span, SByte value, out int length) {
        span[0] = (byte)value;
        length = sizeof(SByte);
        span = span.Slice(sizeof(SByte));
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void MoveWrite(ref Span<byte>span, Byte value) => SpanUtils.MoveWrite(ref span, value, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void MoveWrite(ref Span<byte>span, Byte value, out int length) {
        span[0] = value;
        length = sizeof(Byte);
        span = span.Slice(sizeof(Byte));
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void MoveWrite(ref Span<byte>span, UInt16 value) => SpanUtils.MoveWrite(ref span, value, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void MoveWrite(ref Span<byte>span, UInt16 value, out int length) {
            if (span.Length < sizeof(UInt16))
                throw new ArgumentOutOfRangeException();
            Unsafe.WriteUnaligned(ref MemoryMarshal.GetReference(span), value);
            length = sizeof(UInt16);
            span = span.Slice(sizeof(UInt16));
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void MoveWrite(ref Span<byte>span, Int16 value) => SpanUtils.MoveWrite(ref span, value, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void MoveWrite(ref Span<byte>span, Int16 value, out int length) {
            if (span.Length < sizeof(UInt16))
                throw new ArgumentOutOfRangeException();
            Unsafe.WriteUnaligned(ref MemoryMarshal.GetReference(span), value);
            length = sizeof(Int16);
            span = span.Slice(sizeof(Int16));
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void MoveWrite(ref Span<byte>span, UInt32 value) => SpanUtils.MoveWrite(ref span, value, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void MoveWrite(ref Span<byte>span, UInt32 value, out int length) {
            if (span.Length < sizeof(UInt32))
                throw new ArgumentOutOfRangeException();
            Unsafe.WriteUnaligned(ref MemoryMarshal.GetReference(span), value);
            length = sizeof(UInt32);
            span = span.Slice(sizeof(UInt32));
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void MoveWrite(ref Span<byte>span, Int32 value) => SpanUtils.MoveWrite(ref span, value, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void MoveWrite(ref Span<byte>span, Int32 value, out int length) {
            if (span.Length < sizeof(UInt32))
                throw new ArgumentOutOfRangeException();
            Unsafe.WriteUnaligned(ref MemoryMarshal.GetReference(span), value);
            length = sizeof(Int32);
            span = span.Slice(sizeof(Int32));
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void MoveWrite(ref Span<byte>span, UInt64 value) => SpanUtils.MoveWrite(ref span, value, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void MoveWrite(ref Span<byte>span, UInt64 value, out int length) {
            if (span.Length < sizeof(UInt64))
                throw new ArgumentOutOfRangeException();
            Unsafe.WriteUnaligned(ref MemoryMarshal.GetReference(span), value);
            length = sizeof(UInt64);
            span = span.Slice(sizeof(UInt64));
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void MoveWrite(ref Span<byte>span, Int64 value) => SpanUtils.MoveWrite(ref span, value, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void MoveWrite(ref Span<byte>span, Int64 value, out int length) {
            if (span.Length < sizeof(UInt64))
                throw new ArgumentOutOfRangeException();
            Unsafe.WriteUnaligned(ref MemoryMarshal.GetReference(span), value);
            length = sizeof(Int64);
            span = span.Slice(sizeof(Int64));
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void MoveWrite(ref Span<byte>span, Single value) => SpanUtils.MoveWrite(ref span, value, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void MoveWrite(ref Span<byte>span, Single value, out int length) {
#if NETSTANDARD21 || !BEFORENETCOREAPP3
            SpanUtils.Write(span, BitConverter.SingleToInt32Bits(value), out _);
#else
            //Span<float> a = stackalloc float[1] { value };
            //var ab = MemoryMarshal.Cast<float, byte>(a);
            //ab.CopyTo(span);
            var i = *(int*)(&value);
            SpanUtils.Write(span, i, out _);
#endif
            length = sizeof(Single);
            span = span.Slice(sizeof(Single));
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void MoveWrite(ref Span<byte>span, Double value) => SpanUtils.MoveWrite(ref span, value, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void MoveWrite(ref Span<byte>span, Double value, out int length) {
#if NETSTANDARD21 || !BEFORENETCOREAPP3
            SpanUtils.Write(span, BitConverter.DoubleToInt64Bits(value), out _);
#else
            //Span<double> a = stackalloc double[1] { value };
            //var ab = MemoryMarshal.Cast<double, byte>(a);
            //ab.CopyTo(span);
            var i = *(long*)(&value);
            SpanUtils.Write(span, i, out _);
#endif
            length = sizeof(Double);
            span = span.Slice(sizeof(Double));
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void MoveWrite(ref Span<byte>span, Decimal value) => SpanUtils.MoveWrite(ref span, value, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void MoveWrite(ref Span<byte>span, Decimal value, out int length) {
            Span<decimal> a = stackalloc decimal[1] { value };
            var ab = MemoryMarshal.Cast<decimal, byte>(a);
            ab.CopyTo(span);
            length = sizeof(Decimal);
            span = span.Slice(sizeof(Decimal));
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void MoveWrite(ref Span<byte>span, Boolean value) => SpanUtils.MoveWrite(ref span, value, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void MoveWrite(ref Span<byte>span, Boolean value, out int length) {
            span[0] = (byte)(value ? 1 : 0);
            length = sizeof(Boolean);
            span = span.Slice(sizeof(Boolean));
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void MoveWrite(ref Span<byte>span, Char value) => SpanUtils.MoveWrite(ref span, value, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void MoveWrite(ref Span<byte>span, Char value, out int length) {
            MemoryMarshal.Write(span, ref value);
            length = sizeof(Char);
            span = span.Slice(sizeof(Char));
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void MoveWriteVLQ(ref Span<byte>span, UInt16 value) => SpanUtils.MoveWriteVLQ(ref span, value, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void MoveWriteVLQ(ref Span<byte>span, UInt16 value, out int length) {
            length = 0;
            while (value >= 0x80)
            {
                span[length++] = ((byte)(value | 0x80));
                value >>= 7;
            }
            span[length++] = (byte)value;
            
            span = span.Slice(length);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void MoveWriteVLQ(ref Span<byte>span, Int16 value) => SpanUtils.MoveWriteVLQ(ref span, value, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void MoveWriteVLQ(ref Span<byte>span, Int16 value, out int length) {
            length = 0;
            if (value < 0)
            {
                span[0] = 0b0100_0000;
                // Special case for lower bound, no more processing required
                if (value == Int16.MinValue) {
                    length = 1;
                    span = span.Slice(length);
                    return;
                }
                value *= -1;

            }
            else span[0] = 0b0000_0000;

            // Write first byte, special case as we only have room for 6 bits in this one
            span[0] |= (byte)(value & 0b0011_1111);
            value >>= 6;

            // Still got some left? Go at it with 7 bit increments
            while (value > 0)
            {
                // We need one more byte, set current bit flag for that
                span[length++] |= 0b1000_0000;
                // Then the next 7 bits. Note that we don't need to remove 8th bit as overflow always would set that anyway.
                span[length] = (byte)value;
                value >>= 7;
            }

            ++length;
            
            span = span.Slice(length);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void MoveWriteVLQ(ref Span<byte>span, UInt32 value) => SpanUtils.MoveWriteVLQ(ref span, value, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void MoveWriteVLQ(ref Span<byte>span, UInt32 value, out int length) {
            length = 0;
            while (value >= 0x80)
            {
                span[length++] = ((byte)(value | 0x80));
                value >>= 7;
            }
            span[length++] = (byte)value;
            
            span = span.Slice(length);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void MoveWriteVLQ(ref Span<byte>span, Int32 value) => SpanUtils.MoveWriteVLQ(ref span, value, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void MoveWriteVLQ(ref Span<byte>span, Int32 value, out int length) {
            length = 0;
            if (value < 0)
            {
                span[0] = 0b0100_0000;
                // Special case for lower bound, no more processing required
                if (value == Int32.MinValue) {
                    length = 1;
                    return;
                }
                value *= -1;

            }
            else span[0] = 0b0000_0000;

            // Write first byte, special case as we only have room for 6 bits in this one
            span[0] |= (byte)(value & 0b0011_1111);
            value >>= 6;

            // Still got some left? Go at it with 7 bit increments
            while (value > 0)
            {
                // We need one more byte, set current bit flag for that
                span[length++] |= 0b1000_0000;
                // Then the next 7 bits. Note that we don't need to remove 8th bit as overflow always would set that anyway.
                span[length] = (byte)value;
                value >>= 7;
            }
            ++length;
            
            span = span.Slice(length);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void MoveWriteVLQ(ref Span<byte>span, UInt64 value) => SpanUtils.MoveWriteVLQ(ref span, value, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void MoveWriteVLQ(ref Span<byte>span, UInt64 value, out int length) {
            length = 0;
            while (value >= 0x80)
            {
                span[length++] = ((byte)(value | 0x80));
                value >>= 7;
            }
            span[length++] = (byte)value;
            
            span = span.Slice(length);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void MoveWriteVLQ(ref Span<byte>span, Int64 value) => SpanUtils.MoveWriteVLQ(ref span, value, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void MoveWriteVLQ(ref Span<byte>span, Int64 value, out int length) {
            length = 0;
            if (value < 0)
            {
                span[0] = 0b0100_0000;
                // Special case for lower bound, no more processing required
                if (value == Int64.MinValue) {
                    length = 1;
                    return;
                }
                value *= -1;

            }
            else span[0] = 0b0000_0000;

            // Write first byte, special case as we only have room for 6 bits in this one
            span[0] |= (byte)(value & 0b0011_1111);
            value >>= 6;

            // Still got some left? Go at it with 7 bit increments
            while (value > 0)
            {
                // We need one more byte, set current bit flag for that
                span[length++] |= 0b1000_0000;
                // Then the next 7 bits. Note that we don't need to remove 8th bit as overflow always would set that anyway.
                span[length] = (byte)value;
                value >>= 7;
            }
            ++length;
            
            span = span.Slice(length);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void MoveWrite(ref Span<byte>span, UInt24 value) => SpanUtils.MoveWrite(ref span, value, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void MoveWrite(ref Span<byte>span, UInt24 value, out int length) {
            //MemoryMarshal.Cast<byte, UInt32>(span)[0] = value;
            span[2] = (byte)(((Int32)value >> (8 * 2)) & 0xFF);
            span[0] = (byte)((Int32)value & 0xFF);
            span[1] = (byte)(((Int32)value >> (8 * 1)) & 0xFF);
            length = 3;
            span = span.Slice(3);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void MoveWriteVLQ(ref Span<byte>span, UInt24 value) => SpanUtils.MoveWriteVLQ(ref span, value, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void MoveWriteVLQ(ref Span<byte>span, UInt24 value, out int length) {
            length = 0;
            value = (UInt24)((UInt32)value & 0b11111111_11111111_11111111);
            while ((UInt32)value >= 0x80)
            {
                span[length++] = ((byte)((UInt32)value | 0x80));
                value = (UInt24)((UInt32)value >> 7);
            }
            span[length++] = (byte)value;
            
            span = span.Slice(length);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void MoveWrite(ref Span<byte>span, Guid value) => SpanUtils.MoveWrite(ref span, value, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void MoveWrite(ref Span<byte>span, Guid value, out int length) {
#if NETSTANDARD21 || !BEFORENETCOREAPP3
            if (!value.TryWriteBytes(span))
                throw new ArgumentOutOfRangeException();
#else
            var array = new Span<byte>(value.ToByteArray());
            array.CopyTo(span);
#endif
            length = 16;
            span = span.Slice(16);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void MoveWrite(ref Span<byte>span, Byte[] value) => SpanUtils.MoveWrite(ref span, value, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void MoveWrite(ref Span<byte>span, Byte[] value, out int length) {
            value.CopyTo(span);
            length = value.Length;
            
            span = span.Slice(length);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void MoveWrite(ref Span<byte>span, Span<byte> value) => SpanUtils.MoveWrite(ref span, value, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void MoveWrite(ref Span<byte>span, Span<byte> value, out int length) {
            value.CopyTo(span);
            length = value.Length;
            
            span = span.Slice(length);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void MoveWrite(ref Span<byte>span, ReadOnlySpan<byte> value) => SpanUtils.MoveWrite(ref span, value, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void MoveWrite(ref Span<byte>span, ReadOnlySpan<byte> value, out int length) {
            value.CopyTo(span);
            length = value.Length;
            
            span = span.Slice(length);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void MoveWriteSize(ref Span<byte>span, UInt32 value) => SpanUtils.MoveWriteSize(ref span, value, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void MoveWriteSize(ref Span<byte>span, UInt32 value, out int length) {
            length = SpanUtils.MeasureWriteSize(value);
            if (length == 1)
                SpanUtils.Write(span, (Byte)value);
            else if (length == 2)
                SpanUtils.WriteBE(span, (UInt16)((UInt16)value | (0b01 << 14)));
            // Even larger (up to 4,2M) we store length as 3 bytes
            else if (length == 3)
                SpanUtils.WriteBE(span, (UInt24)((UInt32)value | (0b10 << 22)));
            else if (length == 4)
                SpanUtils.WriteBE(span, (UInt32)((UInt32)value | (0b11 << 30)));

            
            span = span.Slice(length);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void MoveWriteSized(ref Span<byte>span, Byte[] value) => SpanUtils.MoveWriteSized(ref span, value, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void MoveWriteSized(ref Span<byte>span, Byte[] value, out int length) {
            var mbs = SpanUtils.MeasureWriteSize((UInt32)value.Length);
            var len = mbs + value.Length;
            if (len > span.Length)
                throw new ArgumentException("Data length too big for target span.", nameof(value));

            SpanUtils.WriteSize(span, (UInt32)value.Length, out _);
            value.CopyTo(span.Slice(mbs));
            length = len;
            
            span = span.Slice(length);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void MoveWriteSized(ref Span<byte>span, String value) => SpanUtils.MoveWriteSized(ref span, value, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void MoveWriteSized(ref Span<byte>span, String value, out int length) {
#if NETCOREAPP || NETSTANDARD21
            // We use GetByteCount followed by direct copy to avoid creating a byte array (avoid GC).
            // For larger strings this could cause 
            var strSize = (UInt32)Encoding.UTF8.GetByteCount(value);
            var mbs = SpanUtils.MeasureWriteSize((UInt32)strSize);
            var len = (int)mbs + (int)strSize;
            if (len > span.Length)
                throw new ArgumentException("Data length too big for target span.", nameof(value));

            SpanUtils.WriteSize(span, strSize, out _);

            Encoding.UTF8.GetBytes(value, span.Slice(mbs));
#else
            var bytes = Encoding.UTF8.GetBytes(value);
            if (bytes.Length > span.Length)
                throw new ArgumentException("String is too long.", nameof(value));

            SpanUtils.WriteSize(span, (UInt32)bytes.Length, out var mbs);
            var len = (int)mbs + bytes.Length;
            var s = span.Slice(mbs, bytes.Length);
            SpanUtils.Write(s, bytes, out _);
#endif
            length = len;
            
            span = span.Slice(length);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void MoveWriteSized(ref Span<byte>span, Span<byte> value) => SpanUtils.MoveWriteSized(ref span, value, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void MoveWriteSized(ref Span<byte>span, Span<byte> value, out int length) {
            var mbs = SpanUtils.MeasureWriteSize((UInt32)value.Length);
            var len = mbs + value.Length;
            if (len > span.Length)
                throw new ArgumentException("Data length too big for target span.", nameof(value));

            SpanUtils.WriteSize(span, (UInt32)value.Length, out _);
            value.CopyTo(span.Slice(mbs));
            length = len;
            
            span = span.Slice(length);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void MoveWriteSized(ref Span<byte>span, ReadOnlySpan<byte> value) => SpanUtils.MoveWriteSized(ref span, value, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void MoveWriteSized(ref Span<byte>span, ReadOnlySpan<byte> value, out int length) {
            var mbs = SpanUtils.MeasureWriteSize((UInt32)value.Length);
            var len = mbs + value.Length;
            if (len > span.Length)
                throw new ArgumentException("Data length too big for target span.", nameof(value));

            SpanUtils.WriteSize(span, (UInt32)value.Length, out _);
            value.CopyTo(span.Slice(mbs));
            length = len;
            
            span = span.Slice(length);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe SByte ReadSByteLE( Span<byte>span) => SpanUtils.ReadSByteLE(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe SByte ReadSByteLE( ReadOnlySpan<byte>span) => SpanUtils.ReadSByteLE(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe SByte ReadSByteLE(Span<byte> span, out int length) {
            var ret = (SByte)span[0];
            length = sizeof(SByte);
            
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe SByte ReadSByteLE(ReadOnlySpan<byte> span, out int length) {
            var ret = (SByte)span[0];
            length = sizeof(SByte);
            
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Byte ReadByteLE( Span<byte>span) => SpanUtils.ReadByteLE(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Byte ReadByteLE( ReadOnlySpan<byte>span) => SpanUtils.ReadByteLE(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Byte ReadByteLE(Span<byte> span, out int length) {
            var ret = span[0];
            length = sizeof(Byte);
            
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Byte ReadByteLE(ReadOnlySpan<byte> span, out int length) {
            var ret = span[0];
            length = sizeof(Byte);
            
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt16 ReadUInt16LE( Span<byte>span) => SpanUtils.ReadUInt16LE(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt16 ReadUInt16LE( ReadOnlySpan<byte>span) => SpanUtils.ReadUInt16LE(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt16 ReadUInt16LE(Span<byte> span, out int length) {
            var ret = Unsafe.ReadUnaligned<UInt16>(ref MemoryMarshal.GetReference(span));
            length = sizeof(UInt16);
            
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt16 ReadUInt16LE(ReadOnlySpan<byte> span, out int length) {
            var ret = Unsafe.ReadUnaligned<UInt16>(ref MemoryMarshal.GetReference(span));
            length = sizeof(UInt16);
            
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int16 ReadInt16LE( Span<byte>span) => SpanUtils.ReadInt16LE(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int16 ReadInt16LE( ReadOnlySpan<byte>span) => SpanUtils.ReadInt16LE(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int16 ReadInt16LE(Span<byte> span, out int length) {
            var ret = Unsafe.ReadUnaligned<UInt16>(ref MemoryMarshal.GetReference(span));
            length = sizeof(Int16);
            
            return (Int16)ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int16 ReadInt16LE(ReadOnlySpan<byte> span, out int length) {
            var ret = Unsafe.ReadUnaligned<UInt16>(ref MemoryMarshal.GetReference(span));
            length = sizeof(Int16);
            
            return (Int16)ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt32 ReadUInt32LE( Span<byte>span) => SpanUtils.ReadUInt32LE(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt32 ReadUInt32LE( ReadOnlySpan<byte>span) => SpanUtils.ReadUInt32LE(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt32 ReadUInt32LE(Span<byte> span, out int length) {
            var ret = Unsafe.ReadUnaligned<UInt32>(ref MemoryMarshal.GetReference(span));
            length = sizeof(UInt32);
            
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt32 ReadUInt32LE(ReadOnlySpan<byte> span, out int length) {
            var ret = Unsafe.ReadUnaligned<UInt32>(ref MemoryMarshal.GetReference(span));
            length = sizeof(UInt32);
            
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int32 ReadInt32LE( Span<byte>span) => SpanUtils.ReadInt32LE(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int32 ReadInt32LE( ReadOnlySpan<byte>span) => SpanUtils.ReadInt32LE(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int32 ReadInt32LE(Span<byte> span, out int length) {
            var ret = Unsafe.ReadUnaligned<UInt32>(ref MemoryMarshal.GetReference(span));
            length = sizeof(Int32);
            
            return (Int32)ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int32 ReadInt32LE(ReadOnlySpan<byte> span, out int length) {
            var ret = Unsafe.ReadUnaligned<UInt32>(ref MemoryMarshal.GetReference(span));
            length = sizeof(Int32);
            
            return (Int32)ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt64 ReadUInt64LE( Span<byte>span) => SpanUtils.ReadUInt64LE(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt64 ReadUInt64LE( ReadOnlySpan<byte>span) => SpanUtils.ReadUInt64LE(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt64 ReadUInt64LE(Span<byte> span, out int length) {
            var ret = Unsafe.ReadUnaligned<UInt64>(ref MemoryMarshal.GetReference(span));
            length = sizeof(UInt64);
            
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt64 ReadUInt64LE(ReadOnlySpan<byte> span, out int length) {
            var ret = Unsafe.ReadUnaligned<UInt64>(ref MemoryMarshal.GetReference(span));
            length = sizeof(UInt64);
            
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int64 ReadInt64LE( Span<byte>span) => SpanUtils.ReadInt64LE(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int64 ReadInt64LE( ReadOnlySpan<byte>span) => SpanUtils.ReadInt64LE(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int64 ReadInt64LE(Span<byte> span, out int length) {
            var ret = Unsafe.ReadUnaligned<UInt64>(ref MemoryMarshal.GetReference(span));
            length = sizeof(Int64);
            
            return (Int64)ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int64 ReadInt64LE(ReadOnlySpan<byte> span, out int length) {
            var ret = Unsafe.ReadUnaligned<UInt64>(ref MemoryMarshal.GetReference(span));
            length = sizeof(Int64);
            
            return (Int64)ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Single ReadSingleLE( Span<byte>span) => SpanUtils.ReadSingleLE(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Single ReadSingleLE( ReadOnlySpan<byte>span) => SpanUtils.ReadSingleLE(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Single ReadSingleLE(Span<byte> span, out int length) {
#if NETSTANDARD21 || !BEFORENETCOREAPP3
            var r = BitConverter.Int32BitsToSingle(SpanUtils.ReadInt32(span, out _));
#else
            //Span<float> a = stackalloc float[1];
            //var ab = MemoryMarshal.Cast<float, byte>(a);
            //span.Slice(0, sizeof(float)).CopyTo(ab);
            //var r = a[0];
            var i = SpanUtils.ReadInt32(span, out _);
            var r = *(float*)(&i);
#endif
            length = sizeof(Single);
            
            return r;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Single ReadSingleLE(ReadOnlySpan<byte> span, out int length) {
#if NETSTANDARD21 || !BEFORENETCOREAPP3
            var r = BitConverter.Int32BitsToSingle(SpanUtils.ReadInt32(span, out _));
#else
            //Span<float> a = stackalloc float[1];
            //var ab = MemoryMarshal.Cast<float, byte>(a);
            //span.Slice(0, sizeof(float)).CopyTo(ab);
            //var r = a[0];
            var i = SpanUtils.ReadInt32(span, out _);
            var r = *(float*)(&i);
#endif
            length = sizeof(Single);
            
            return r;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Double ReadDoubleLE( Span<byte>span) => SpanUtils.ReadDoubleLE(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Double ReadDoubleLE( ReadOnlySpan<byte>span) => SpanUtils.ReadDoubleLE(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Double ReadDoubleLE(Span<byte> span, out int length) {
#if NETSTANDARD21 || !BEFORENETCOREAPP3
            var r = BitConverter.Int64BitsToDouble(SpanUtils.ReadInt64(span, out _));
#else
            //Span<double> a = stackalloc double[1];
            //var ab = MemoryMarshal.Cast<double, byte>(a);
            //span.Slice(0, sizeof(double)).CopyTo(ab);
            //var r = a[0];
            var i = SpanUtils.ReadInt64(span, out _);
            var r = *(double*)(&i);
#endif
            length = sizeof(Double);
            
            return r;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Double ReadDoubleLE(ReadOnlySpan<byte> span, out int length) {
#if NETSTANDARD21 || !BEFORENETCOREAPP3
            var r = BitConverter.Int64BitsToDouble(SpanUtils.ReadInt64(span, out _));
#else
            //Span<double> a = stackalloc double[1];
            //var ab = MemoryMarshal.Cast<double, byte>(a);
            //span.Slice(0, sizeof(double)).CopyTo(ab);
            //var r = a[0];
            var i = SpanUtils.ReadInt64(span, out _);
            var r = *(double*)(&i);
#endif
            length = sizeof(Double);
            
            return r;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Decimal ReadDecimalLE( Span<byte>span) => SpanUtils.ReadDecimalLE(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Decimal ReadDecimalLE( ReadOnlySpan<byte>span) => SpanUtils.ReadDecimalLE(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Decimal ReadDecimalLE(Span<byte> span, out int length) {
            Span<decimal> a = stackalloc decimal[1];
            var ab = MemoryMarshal.Cast<decimal, byte>(a);
            span.Slice(0, sizeof(decimal)).CopyTo(ab);
            length = sizeof(Decimal);
            
            return a[0];
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Decimal ReadDecimalLE(ReadOnlySpan<byte> span, out int length) {
            Span<decimal> a = stackalloc decimal[1];
            var ab = MemoryMarshal.Cast<decimal, byte>(a);
            span.Slice(0, sizeof(decimal)).CopyTo(ab);
            length = sizeof(Decimal);
            
            return a[0];
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Boolean ReadBooleanLE( Span<byte>span) => SpanUtils.ReadBooleanLE(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Boolean ReadBooleanLE( ReadOnlySpan<byte>span) => SpanUtils.ReadBooleanLE(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Boolean ReadBooleanLE(Span<byte> span, out int length) {
            var ret = span[0] != 0;
            length = sizeof(Boolean);
            
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Boolean ReadBooleanLE(ReadOnlySpan<byte> span, out int length) {
            var ret = span[0] != 0;
            length = sizeof(Boolean);
            
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Char ReadCharLE( Span<byte>span) => SpanUtils.ReadCharLE(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Char ReadCharLE( ReadOnlySpan<byte>span) => SpanUtils.ReadCharLE(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Char ReadCharLE(Span<byte> span, out int length) {
            var r = MemoryMarshal.Read<Char>(span);
            length = sizeof(Char);
            
            return r;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Char ReadCharLE(ReadOnlySpan<byte> span, out int length) {
            var r = MemoryMarshal.Read<Char>(span);
            length = sizeof(Char);
            
            return r;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Single ReadFloatLE( Span<byte>span) => SpanUtils.ReadFloatLE(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Single ReadFloatLE( ReadOnlySpan<byte>span) => SpanUtils.ReadFloatLE(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Single ReadFloatLE(Span<byte> span, out int length) {
#if NETSTANDARD21 || !BEFORENETCOREAPP3
            var r = BitConverter.Int32BitsToSingle(SpanUtils.ReadInt32(span, out _));
#else
            //Span<float> a = stackalloc float[1];
            //var ab = MemoryMarshal.Cast<float, byte>(a);
            //span.Slice(0, sizeof(float)).CopyTo(ab);
            //var r = a[0];
            var i = SpanUtils.ReadInt32(span, out _);
            var r = *(float*)(&i);
#endif
            length = sizeof(Single);
            
            return r;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Single ReadFloatLE(ReadOnlySpan<byte> span, out int length) {
#if NETSTANDARD21 || !BEFORENETCOREAPP3
            var r = BitConverter.Int32BitsToSingle(SpanUtils.ReadInt32(span, out _));
#else
            //Span<float> a = stackalloc float[1];
            //var ab = MemoryMarshal.Cast<float, byte>(a);
            //span.Slice(0, sizeof(float)).CopyTo(ab);
            //var r = a[0];
            var i = SpanUtils.ReadInt32(span, out _);
            var r = *(float*)(&i);
#endif
            length = sizeof(Single);
            
            return r;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int16 ReadShortLE( Span<byte>span) => SpanUtils.ReadShortLE(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int16 ReadShortLE( ReadOnlySpan<byte>span) => SpanUtils.ReadShortLE(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int16 ReadShortLE(Span<byte> span, out int length) {
            var ret = Unsafe.ReadUnaligned<UInt16>(ref MemoryMarshal.GetReference(span));
            length = sizeof(Int16);
            
            return (Int16)ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int16 ReadShortLE(ReadOnlySpan<byte> span, out int length) {
            var ret = Unsafe.ReadUnaligned<UInt16>(ref MemoryMarshal.GetReference(span));
            length = sizeof(Int16);
            
            return (Int16)ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt16 ReadUShortLE( Span<byte>span) => SpanUtils.ReadUShortLE(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt16 ReadUShortLE( ReadOnlySpan<byte>span) => SpanUtils.ReadUShortLE(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt16 ReadUShortLE(Span<byte> span, out int length) {
            var ret = Unsafe.ReadUnaligned<UInt16>(ref MemoryMarshal.GetReference(span));
            length = sizeof(UInt16);
            
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt16 ReadUShortLE(ReadOnlySpan<byte> span, out int length) {
            var ret = Unsafe.ReadUnaligned<UInt16>(ref MemoryMarshal.GetReference(span));
            length = sizeof(UInt16);
            
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int32 ReadIntLE( Span<byte>span) => SpanUtils.ReadIntLE(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int32 ReadIntLE( ReadOnlySpan<byte>span) => SpanUtils.ReadIntLE(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int32 ReadIntLE(Span<byte> span, out int length) {
            var ret = Unsafe.ReadUnaligned<UInt32>(ref MemoryMarshal.GetReference(span));
            length = sizeof(Int32);
            
            return (Int32)ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int32 ReadIntLE(ReadOnlySpan<byte> span, out int length) {
            var ret = Unsafe.ReadUnaligned<UInt32>(ref MemoryMarshal.GetReference(span));
            length = sizeof(Int32);
            
            return (Int32)ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt32 ReadUIntLE( Span<byte>span) => SpanUtils.ReadUIntLE(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt32 ReadUIntLE( ReadOnlySpan<byte>span) => SpanUtils.ReadUIntLE(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt32 ReadUIntLE(Span<byte> span, out int length) {
            var ret = Unsafe.ReadUnaligned<UInt32>(ref MemoryMarshal.GetReference(span));
            length = sizeof(UInt32);
            
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt32 ReadUIntLE(ReadOnlySpan<byte> span, out int length) {
            var ret = Unsafe.ReadUnaligned<UInt32>(ref MemoryMarshal.GetReference(span));
            length = sizeof(UInt32);
            
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int64 ReadLongLE( Span<byte>span) => SpanUtils.ReadLongLE(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int64 ReadLongLE( ReadOnlySpan<byte>span) => SpanUtils.ReadLongLE(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int64 ReadLongLE(Span<byte> span, out int length) {
            var ret = Unsafe.ReadUnaligned<UInt64>(ref MemoryMarshal.GetReference(span));
            length = sizeof(Int64);
            
            return (Int64)ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int64 ReadLongLE(ReadOnlySpan<byte> span, out int length) {
            var ret = Unsafe.ReadUnaligned<UInt64>(ref MemoryMarshal.GetReference(span));
            length = sizeof(Int64);
            
            return (Int64)ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt64 ReadULongLE( Span<byte>span) => SpanUtils.ReadULongLE(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt64 ReadULongLE( ReadOnlySpan<byte>span) => SpanUtils.ReadULongLE(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt64 ReadULongLE(Span<byte> span, out int length) {
            var ret = Unsafe.ReadUnaligned<UInt64>(ref MemoryMarshal.GetReference(span));
            length = sizeof(UInt64);
            
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt64 ReadULongLE(ReadOnlySpan<byte> span, out int length) {
            var ret = Unsafe.ReadUnaligned<UInt64>(ref MemoryMarshal.GetReference(span));
            length = sizeof(UInt64);
            
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Boolean ReadBoolLE( Span<byte>span) => SpanUtils.ReadBoolLE(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Boolean ReadBoolLE( ReadOnlySpan<byte>span) => SpanUtils.ReadBoolLE(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Boolean ReadBoolLE(Span<byte> span, out int length) {
            var ret = span[0] != 0;
            length = sizeof(Boolean);
            
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Boolean ReadBoolLE(ReadOnlySpan<byte> span, out int length) {
            var ret = span[0] != 0;
            length = sizeof(Boolean);
            
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt24 ReadUInt24LE( Span<byte>span) => SpanUtils.ReadUInt24LE(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt24 ReadUInt24LE( ReadOnlySpan<byte>span) => SpanUtils.ReadUInt24LE(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt24 ReadUInt24LE(Span<byte> span, out int length) {
            var ret = (UInt24)(Int32)(
                  ((UInt32)span[2] << (8 * 2))
                | ((UInt32)span[1] << (8 * 1))
                | ((UInt32)span[0])
                );
            length = 3;
            
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt24 ReadUInt24LE(ReadOnlySpan<byte> span, out int length) {
            var ret = (UInt24)(Int32)(
                  ((UInt32)span[2] << (8 * 2))
                | ((UInt32)span[1] << (8 * 1))
                | ((UInt32)span[0])
                );
            length = 3;
            
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe SByte MoveReadSByteLE(ref  Span<byte>span) => SpanUtils.MoveReadSByteLE(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe SByte MoveReadSByteLE(ref  ReadOnlySpan<byte>span) => SpanUtils.MoveReadSByteLE(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe SByte MoveReadSByteLE(ref Span<byte> span, out int length) {
            var ret = (SByte)span[0];
            length = sizeof(SByte);
            span = span.Slice(sizeof(SByte));
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe SByte MoveReadSByteLE(ref ReadOnlySpan<byte> span, out int length) {
            var ret = (SByte)span[0];
            length = sizeof(SByte);
            span = span.Slice(sizeof(SByte));
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Byte MoveReadByteLE(ref  Span<byte>span) => SpanUtils.MoveReadByteLE(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Byte MoveReadByteLE(ref  ReadOnlySpan<byte>span) => SpanUtils.MoveReadByteLE(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Byte MoveReadByteLE(ref Span<byte> span, out int length) {
            var ret = span[0];
            length = sizeof(Byte);
            span = span.Slice(sizeof(Byte));
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Byte MoveReadByteLE(ref ReadOnlySpan<byte> span, out int length) {
            var ret = span[0];
            length = sizeof(Byte);
            span = span.Slice(sizeof(Byte));
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt16 MoveReadUInt16LE(ref  Span<byte>span) => SpanUtils.MoveReadUInt16LE(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt16 MoveReadUInt16LE(ref  ReadOnlySpan<byte>span) => SpanUtils.MoveReadUInt16LE(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt16 MoveReadUInt16LE(ref Span<byte> span, out int length) {
            var ret = Unsafe.ReadUnaligned<UInt16>(ref MemoryMarshal.GetReference(span));
            length = sizeof(UInt16);
            span = span.Slice(sizeof(UInt16));
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt16 MoveReadUInt16LE(ref ReadOnlySpan<byte> span, out int length) {
            var ret = Unsafe.ReadUnaligned<UInt16>(ref MemoryMarshal.GetReference(span));
            length = sizeof(UInt16);
            span = span.Slice(sizeof(UInt16));
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int16 MoveReadInt16LE(ref  Span<byte>span) => SpanUtils.MoveReadInt16LE(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int16 MoveReadInt16LE(ref  ReadOnlySpan<byte>span) => SpanUtils.MoveReadInt16LE(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int16 MoveReadInt16LE(ref Span<byte> span, out int length) {
            var ret = Unsafe.ReadUnaligned<UInt16>(ref MemoryMarshal.GetReference(span));
            length = sizeof(Int16);
            span = span.Slice(sizeof(Int16));
            return (Int16)ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int16 MoveReadInt16LE(ref ReadOnlySpan<byte> span, out int length) {
            var ret = Unsafe.ReadUnaligned<UInt16>(ref MemoryMarshal.GetReference(span));
            length = sizeof(Int16);
            span = span.Slice(sizeof(Int16));
            return (Int16)ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt32 MoveReadUInt32LE(ref  Span<byte>span) => SpanUtils.MoveReadUInt32LE(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt32 MoveReadUInt32LE(ref  ReadOnlySpan<byte>span) => SpanUtils.MoveReadUInt32LE(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt32 MoveReadUInt32LE(ref Span<byte> span, out int length) {
            var ret = Unsafe.ReadUnaligned<UInt32>(ref MemoryMarshal.GetReference(span));
            length = sizeof(UInt32);
            span = span.Slice(sizeof(UInt32));
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt32 MoveReadUInt32LE(ref ReadOnlySpan<byte> span, out int length) {
            var ret = Unsafe.ReadUnaligned<UInt32>(ref MemoryMarshal.GetReference(span));
            length = sizeof(UInt32);
            span = span.Slice(sizeof(UInt32));
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int32 MoveReadInt32LE(ref  Span<byte>span) => SpanUtils.MoveReadInt32LE(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int32 MoveReadInt32LE(ref  ReadOnlySpan<byte>span) => SpanUtils.MoveReadInt32LE(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int32 MoveReadInt32LE(ref Span<byte> span, out int length) {
            var ret = Unsafe.ReadUnaligned<UInt32>(ref MemoryMarshal.GetReference(span));
            length = sizeof(Int32);
            span = span.Slice(sizeof(Int32));
            return (Int32)ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int32 MoveReadInt32LE(ref ReadOnlySpan<byte> span, out int length) {
            var ret = Unsafe.ReadUnaligned<UInt32>(ref MemoryMarshal.GetReference(span));
            length = sizeof(Int32);
            span = span.Slice(sizeof(Int32));
            return (Int32)ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt64 MoveReadUInt64LE(ref  Span<byte>span) => SpanUtils.MoveReadUInt64LE(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt64 MoveReadUInt64LE(ref  ReadOnlySpan<byte>span) => SpanUtils.MoveReadUInt64LE(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt64 MoveReadUInt64LE(ref Span<byte> span, out int length) {
            var ret = Unsafe.ReadUnaligned<UInt64>(ref MemoryMarshal.GetReference(span));
            length = sizeof(UInt64);
            span = span.Slice(sizeof(UInt64));
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt64 MoveReadUInt64LE(ref ReadOnlySpan<byte> span, out int length) {
            var ret = Unsafe.ReadUnaligned<UInt64>(ref MemoryMarshal.GetReference(span));
            length = sizeof(UInt64);
            span = span.Slice(sizeof(UInt64));
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int64 MoveReadInt64LE(ref  Span<byte>span) => SpanUtils.MoveReadInt64LE(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int64 MoveReadInt64LE(ref  ReadOnlySpan<byte>span) => SpanUtils.MoveReadInt64LE(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int64 MoveReadInt64LE(ref Span<byte> span, out int length) {
            var ret = Unsafe.ReadUnaligned<UInt64>(ref MemoryMarshal.GetReference(span));
            length = sizeof(Int64);
            span = span.Slice(sizeof(Int64));
            return (Int64)ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int64 MoveReadInt64LE(ref ReadOnlySpan<byte> span, out int length) {
            var ret = Unsafe.ReadUnaligned<UInt64>(ref MemoryMarshal.GetReference(span));
            length = sizeof(Int64);
            span = span.Slice(sizeof(Int64));
            return (Int64)ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Single MoveReadSingleLE(ref  Span<byte>span) => SpanUtils.MoveReadSingleLE(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Single MoveReadSingleLE(ref  ReadOnlySpan<byte>span) => SpanUtils.MoveReadSingleLE(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Single MoveReadSingleLE(ref Span<byte> span, out int length) {
#if NETSTANDARD21 || !BEFORENETCOREAPP3
            var r = BitConverter.Int32BitsToSingle(SpanUtils.ReadInt32(span, out _));
#else
            //Span<float> a = stackalloc float[1];
            //var ab = MemoryMarshal.Cast<float, byte>(a);
            //span.Slice(0, sizeof(float)).CopyTo(ab);
            //var r = a[0];
            var i = SpanUtils.ReadInt32(span, out _);
            var r = *(float*)(&i);
#endif
            length = sizeof(Single);
            span = span.Slice(sizeof(Single));
            return r;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Single MoveReadSingleLE(ref ReadOnlySpan<byte> span, out int length) {
#if NETSTANDARD21 || !BEFORENETCOREAPP3
            var r = BitConverter.Int32BitsToSingle(SpanUtils.ReadInt32(span, out _));
#else
            //Span<float> a = stackalloc float[1];
            //var ab = MemoryMarshal.Cast<float, byte>(a);
            //span.Slice(0, sizeof(float)).CopyTo(ab);
            //var r = a[0];
            var i = SpanUtils.ReadInt32(span, out _);
            var r = *(float*)(&i);
#endif
            length = sizeof(Single);
            span = span.Slice(sizeof(Single));
            return r;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Double MoveReadDoubleLE(ref  Span<byte>span) => SpanUtils.MoveReadDoubleLE(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Double MoveReadDoubleLE(ref  ReadOnlySpan<byte>span) => SpanUtils.MoveReadDoubleLE(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Double MoveReadDoubleLE(ref Span<byte> span, out int length) {
#if NETSTANDARD21 || !BEFORENETCOREAPP3
            var r = BitConverter.Int64BitsToDouble(SpanUtils.ReadInt64(span, out _));
#else
            //Span<double> a = stackalloc double[1];
            //var ab = MemoryMarshal.Cast<double, byte>(a);
            //span.Slice(0, sizeof(double)).CopyTo(ab);
            //var r = a[0];
            var i = SpanUtils.ReadInt64(span, out _);
            var r = *(double*)(&i);
#endif
            length = sizeof(Double);
            span = span.Slice(sizeof(Double));
            return r;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Double MoveReadDoubleLE(ref ReadOnlySpan<byte> span, out int length) {
#if NETSTANDARD21 || !BEFORENETCOREAPP3
            var r = BitConverter.Int64BitsToDouble(SpanUtils.ReadInt64(span, out _));
#else
            //Span<double> a = stackalloc double[1];
            //var ab = MemoryMarshal.Cast<double, byte>(a);
            //span.Slice(0, sizeof(double)).CopyTo(ab);
            //var r = a[0];
            var i = SpanUtils.ReadInt64(span, out _);
            var r = *(double*)(&i);
#endif
            length = sizeof(Double);
            span = span.Slice(sizeof(Double));
            return r;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Decimal MoveReadDecimalLE(ref  Span<byte>span) => SpanUtils.MoveReadDecimalLE(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Decimal MoveReadDecimalLE(ref  ReadOnlySpan<byte>span) => SpanUtils.MoveReadDecimalLE(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Decimal MoveReadDecimalLE(ref Span<byte> span, out int length) {
            Span<decimal> a = stackalloc decimal[1];
            var ab = MemoryMarshal.Cast<decimal, byte>(a);
            span.Slice(0, sizeof(decimal)).CopyTo(ab);
            length = sizeof(Decimal);
            span = span.Slice(sizeof(Decimal));
            return a[0];
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Decimal MoveReadDecimalLE(ref ReadOnlySpan<byte> span, out int length) {
            Span<decimal> a = stackalloc decimal[1];
            var ab = MemoryMarshal.Cast<decimal, byte>(a);
            span.Slice(0, sizeof(decimal)).CopyTo(ab);
            length = sizeof(Decimal);
            span = span.Slice(sizeof(Decimal));
            return a[0];
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Boolean MoveReadBooleanLE(ref  Span<byte>span) => SpanUtils.MoveReadBooleanLE(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Boolean MoveReadBooleanLE(ref  ReadOnlySpan<byte>span) => SpanUtils.MoveReadBooleanLE(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Boolean MoveReadBooleanLE(ref Span<byte> span, out int length) {
            var ret = span[0] != 0;
            length = sizeof(Boolean);
            span = span.Slice(sizeof(Boolean));
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Boolean MoveReadBooleanLE(ref ReadOnlySpan<byte> span, out int length) {
            var ret = span[0] != 0;
            length = sizeof(Boolean);
            span = span.Slice(sizeof(Boolean));
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Char MoveReadCharLE(ref  Span<byte>span) => SpanUtils.MoveReadCharLE(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Char MoveReadCharLE(ref  ReadOnlySpan<byte>span) => SpanUtils.MoveReadCharLE(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Char MoveReadCharLE(ref Span<byte> span, out int length) {
            var r = MemoryMarshal.Read<Char>(span);
            length = sizeof(Char);
            span = span.Slice(sizeof(Char));
            return r;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Char MoveReadCharLE(ref ReadOnlySpan<byte> span, out int length) {
            var r = MemoryMarshal.Read<Char>(span);
            length = sizeof(Char);
            span = span.Slice(sizeof(Char));
            return r;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Single MoveReadFloatLE(ref  Span<byte>span) => SpanUtils.MoveReadFloatLE(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Single MoveReadFloatLE(ref  ReadOnlySpan<byte>span) => SpanUtils.MoveReadFloatLE(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Single MoveReadFloatLE(ref Span<byte> span, out int length) {
#if NETSTANDARD21 || !BEFORENETCOREAPP3
            var r = BitConverter.Int32BitsToSingle(SpanUtils.ReadInt32(span, out _));
#else
            //Span<float> a = stackalloc float[1];
            //var ab = MemoryMarshal.Cast<float, byte>(a);
            //span.Slice(0, sizeof(float)).CopyTo(ab);
            //var r = a[0];
            var i = SpanUtils.ReadInt32(span, out _);
            var r = *(float*)(&i);
#endif
            length = sizeof(Single);
            span = span.Slice(sizeof(Single));
            return r;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Single MoveReadFloatLE(ref ReadOnlySpan<byte> span, out int length) {
#if NETSTANDARD21 || !BEFORENETCOREAPP3
            var r = BitConverter.Int32BitsToSingle(SpanUtils.ReadInt32(span, out _));
#else
            //Span<float> a = stackalloc float[1];
            //var ab = MemoryMarshal.Cast<float, byte>(a);
            //span.Slice(0, sizeof(float)).CopyTo(ab);
            //var r = a[0];
            var i = SpanUtils.ReadInt32(span, out _);
            var r = *(float*)(&i);
#endif
            length = sizeof(Single);
            span = span.Slice(sizeof(Single));
            return r;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int16 MoveReadShortLE(ref  Span<byte>span) => SpanUtils.MoveReadShortLE(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int16 MoveReadShortLE(ref  ReadOnlySpan<byte>span) => SpanUtils.MoveReadShortLE(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int16 MoveReadShortLE(ref Span<byte> span, out int length) {
            var ret = Unsafe.ReadUnaligned<UInt16>(ref MemoryMarshal.GetReference(span));
            length = sizeof(Int16);
            span = span.Slice(sizeof(Int16));
            return (Int16)ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int16 MoveReadShortLE(ref ReadOnlySpan<byte> span, out int length) {
            var ret = Unsafe.ReadUnaligned<UInt16>(ref MemoryMarshal.GetReference(span));
            length = sizeof(Int16);
            span = span.Slice(sizeof(Int16));
            return (Int16)ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt16 MoveReadUShortLE(ref  Span<byte>span) => SpanUtils.MoveReadUShortLE(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt16 MoveReadUShortLE(ref  ReadOnlySpan<byte>span) => SpanUtils.MoveReadUShortLE(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt16 MoveReadUShortLE(ref Span<byte> span, out int length) {
            var ret = Unsafe.ReadUnaligned<UInt16>(ref MemoryMarshal.GetReference(span));
            length = sizeof(UInt16);
            span = span.Slice(sizeof(UInt16));
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt16 MoveReadUShortLE(ref ReadOnlySpan<byte> span, out int length) {
            var ret = Unsafe.ReadUnaligned<UInt16>(ref MemoryMarshal.GetReference(span));
            length = sizeof(UInt16);
            span = span.Slice(sizeof(UInt16));
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int32 MoveReadIntLE(ref  Span<byte>span) => SpanUtils.MoveReadIntLE(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int32 MoveReadIntLE(ref  ReadOnlySpan<byte>span) => SpanUtils.MoveReadIntLE(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int32 MoveReadIntLE(ref Span<byte> span, out int length) {
            var ret = Unsafe.ReadUnaligned<UInt32>(ref MemoryMarshal.GetReference(span));
            length = sizeof(Int32);
            span = span.Slice(sizeof(Int32));
            return (Int32)ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int32 MoveReadIntLE(ref ReadOnlySpan<byte> span, out int length) {
            var ret = Unsafe.ReadUnaligned<UInt32>(ref MemoryMarshal.GetReference(span));
            length = sizeof(Int32);
            span = span.Slice(sizeof(Int32));
            return (Int32)ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt32 MoveReadUIntLE(ref  Span<byte>span) => SpanUtils.MoveReadUIntLE(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt32 MoveReadUIntLE(ref  ReadOnlySpan<byte>span) => SpanUtils.MoveReadUIntLE(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt32 MoveReadUIntLE(ref Span<byte> span, out int length) {
            var ret = Unsafe.ReadUnaligned<UInt32>(ref MemoryMarshal.GetReference(span));
            length = sizeof(UInt32);
            span = span.Slice(sizeof(UInt32));
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt32 MoveReadUIntLE(ref ReadOnlySpan<byte> span, out int length) {
            var ret = Unsafe.ReadUnaligned<UInt32>(ref MemoryMarshal.GetReference(span));
            length = sizeof(UInt32);
            span = span.Slice(sizeof(UInt32));
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int64 MoveReadLongLE(ref  Span<byte>span) => SpanUtils.MoveReadLongLE(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int64 MoveReadLongLE(ref  ReadOnlySpan<byte>span) => SpanUtils.MoveReadLongLE(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int64 MoveReadLongLE(ref Span<byte> span, out int length) {
            var ret = Unsafe.ReadUnaligned<UInt64>(ref MemoryMarshal.GetReference(span));
            length = sizeof(Int64);
            span = span.Slice(sizeof(Int64));
            return (Int64)ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int64 MoveReadLongLE(ref ReadOnlySpan<byte> span, out int length) {
            var ret = Unsafe.ReadUnaligned<UInt64>(ref MemoryMarshal.GetReference(span));
            length = sizeof(Int64);
            span = span.Slice(sizeof(Int64));
            return (Int64)ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt64 MoveReadULongLE(ref  Span<byte>span) => SpanUtils.MoveReadULongLE(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt64 MoveReadULongLE(ref  ReadOnlySpan<byte>span) => SpanUtils.MoveReadULongLE(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt64 MoveReadULongLE(ref Span<byte> span, out int length) {
            var ret = Unsafe.ReadUnaligned<UInt64>(ref MemoryMarshal.GetReference(span));
            length = sizeof(UInt64);
            span = span.Slice(sizeof(UInt64));
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt64 MoveReadULongLE(ref ReadOnlySpan<byte> span, out int length) {
            var ret = Unsafe.ReadUnaligned<UInt64>(ref MemoryMarshal.GetReference(span));
            length = sizeof(UInt64);
            span = span.Slice(sizeof(UInt64));
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Boolean MoveReadBoolLE(ref  Span<byte>span) => SpanUtils.MoveReadBoolLE(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Boolean MoveReadBoolLE(ref  ReadOnlySpan<byte>span) => SpanUtils.MoveReadBoolLE(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Boolean MoveReadBoolLE(ref Span<byte> span, out int length) {
            var ret = span[0] != 0;
            length = sizeof(Boolean);
            span = span.Slice(sizeof(Boolean));
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Boolean MoveReadBoolLE(ref ReadOnlySpan<byte> span, out int length) {
            var ret = span[0] != 0;
            length = sizeof(Boolean);
            span = span.Slice(sizeof(Boolean));
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt24 MoveReadUInt24LE(ref  Span<byte>span) => SpanUtils.MoveReadUInt24LE(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt24 MoveReadUInt24LE(ref  ReadOnlySpan<byte>span) => SpanUtils.MoveReadUInt24LE(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt24 MoveReadUInt24LE(ref Span<byte> span, out int length) {
            var ret = (UInt24)(Int32)(
                  ((UInt32)span[2] << (8 * 2))
                | ((UInt32)span[1] << (8 * 1))
                | ((UInt32)span[0])
                );
            length = 3;
            span = span.Slice(3);
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt24 MoveReadUInt24LE(ref ReadOnlySpan<byte> span, out int length) {
            var ret = (UInt24)(Int32)(
                  ((UInt32)span[2] << (8 * 2))
                | ((UInt32)span[1] << (8 * 1))
                | ((UInt32)span[0])
                );
            length = 3;
            span = span.Slice(3);
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void WriteLE(Span<byte>span, SByte value) => SpanUtils.WriteLE(span, value, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void WriteLE(Span<byte>span, SByte value, out int length) {
        span[0] = (byte)value;
        length = sizeof(SByte);
        
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void WriteLE(Span<byte>span, Byte value) => SpanUtils.WriteLE(span, value, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void WriteLE(Span<byte>span, Byte value, out int length) {
        span[0] = value;
        length = sizeof(Byte);
        
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void WriteLE(Span<byte>span, UInt16 value) => SpanUtils.WriteLE(span, value, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void WriteLE(Span<byte>span, UInt16 value, out int length) {
            if (span.Length < sizeof(UInt16))
                throw new ArgumentOutOfRangeException();
            Unsafe.WriteUnaligned(ref MemoryMarshal.GetReference(span), value);
            length = sizeof(UInt16);
            
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void WriteLE(Span<byte>span, Int16 value) => SpanUtils.WriteLE(span, value, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void WriteLE(Span<byte>span, Int16 value, out int length) {
            if (span.Length < sizeof(UInt16))
                throw new ArgumentOutOfRangeException();
            Unsafe.WriteUnaligned(ref MemoryMarshal.GetReference(span), value);
            length = sizeof(Int16);
            
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void WriteLE(Span<byte>span, UInt32 value) => SpanUtils.WriteLE(span, value, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void WriteLE(Span<byte>span, UInt32 value, out int length) {
            if (span.Length < sizeof(UInt32))
                throw new ArgumentOutOfRangeException();
            Unsafe.WriteUnaligned(ref MemoryMarshal.GetReference(span), value);
            length = sizeof(UInt32);
            
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void WriteLE(Span<byte>span, Int32 value) => SpanUtils.WriteLE(span, value, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void WriteLE(Span<byte>span, Int32 value, out int length) {
            if (span.Length < sizeof(UInt32))
                throw new ArgumentOutOfRangeException();
            Unsafe.WriteUnaligned(ref MemoryMarshal.GetReference(span), value);
            length = sizeof(Int32);
            
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void WriteLE(Span<byte>span, UInt64 value) => SpanUtils.WriteLE(span, value, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void WriteLE(Span<byte>span, UInt64 value, out int length) {
            if (span.Length < sizeof(UInt64))
                throw new ArgumentOutOfRangeException();
            Unsafe.WriteUnaligned(ref MemoryMarshal.GetReference(span), value);
            length = sizeof(UInt64);
            
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void WriteLE(Span<byte>span, Int64 value) => SpanUtils.WriteLE(span, value, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void WriteLE(Span<byte>span, Int64 value, out int length) {
            if (span.Length < sizeof(UInt64))
                throw new ArgumentOutOfRangeException();
            Unsafe.WriteUnaligned(ref MemoryMarshal.GetReference(span), value);
            length = sizeof(Int64);
            
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void WriteLE(Span<byte>span, Single value) => SpanUtils.WriteLE(span, value, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void WriteLE(Span<byte>span, Single value, out int length) {
#if NETSTANDARD21 || !BEFORENETCOREAPP3
            SpanUtils.Write(span, BitConverter.SingleToInt32Bits(value), out _);
#else
            //Span<float> a = stackalloc float[1] { value };
            //var ab = MemoryMarshal.Cast<float, byte>(a);
            //ab.CopyTo(span);
            var i = *(int*)(&value);
            SpanUtils.Write(span, i, out _);
#endif
            length = sizeof(Single);
            
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void WriteLE(Span<byte>span, Double value) => SpanUtils.WriteLE(span, value, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void WriteLE(Span<byte>span, Double value, out int length) {
#if NETSTANDARD21 || !BEFORENETCOREAPP3
            SpanUtils.Write(span, BitConverter.DoubleToInt64Bits(value), out _);
#else
            //Span<double> a = stackalloc double[1] { value };
            //var ab = MemoryMarshal.Cast<double, byte>(a);
            //ab.CopyTo(span);
            var i = *(long*)(&value);
            SpanUtils.Write(span, i, out _);
#endif
            length = sizeof(Double);
            
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void WriteLE(Span<byte>span, Decimal value) => SpanUtils.WriteLE(span, value, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void WriteLE(Span<byte>span, Decimal value, out int length) {
            Span<decimal> a = stackalloc decimal[1] { value };
            var ab = MemoryMarshal.Cast<decimal, byte>(a);
            ab.CopyTo(span);
            length = sizeof(Decimal);
            
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void WriteLE(Span<byte>span, Boolean value) => SpanUtils.WriteLE(span, value, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void WriteLE(Span<byte>span, Boolean value, out int length) {
            span[0] = (byte)(value ? 1 : 0);
            length = sizeof(Boolean);
            
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void WriteLE(Span<byte>span, Char value) => SpanUtils.WriteLE(span, value, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void WriteLE(Span<byte>span, Char value, out int length) {
            MemoryMarshal.Write(span, ref value);
            length = sizeof(Char);
            
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void WriteLE(Span<byte>span, UInt24 value) => SpanUtils.WriteLE(span, value, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void WriteLE(Span<byte>span, UInt24 value, out int length) {
            //MemoryMarshal.Cast<byte, UInt32>(span)[0] = value;
            span[2] = (byte)(((Int32)value >> (8 * 2)) & 0xFF);
            span[0] = (byte)((Int32)value & 0xFF);
            span[1] = (byte)(((Int32)value >> (8 * 1)) & 0xFF);
            length = 3;
            
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void MoveWriteLE(ref Span<byte>span, SByte value) => SpanUtils.MoveWriteLE(ref span, value, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void MoveWriteLE(ref Span<byte>span, SByte value, out int length) {
        span[0] = (byte)value;
        length = sizeof(SByte);
        span = span.Slice(sizeof(SByte));
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void MoveWriteLE(ref Span<byte>span, Byte value) => SpanUtils.MoveWriteLE(ref span, value, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void MoveWriteLE(ref Span<byte>span, Byte value, out int length) {
        span[0] = value;
        length = sizeof(Byte);
        span = span.Slice(sizeof(Byte));
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void MoveWriteLE(ref Span<byte>span, UInt16 value) => SpanUtils.MoveWriteLE(ref span, value, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void MoveWriteLE(ref Span<byte>span, UInt16 value, out int length) {
            if (span.Length < sizeof(UInt16))
                throw new ArgumentOutOfRangeException();
            Unsafe.WriteUnaligned(ref MemoryMarshal.GetReference(span), value);
            length = sizeof(UInt16);
            span = span.Slice(sizeof(UInt16));
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void MoveWriteLE(ref Span<byte>span, Int16 value) => SpanUtils.MoveWriteLE(ref span, value, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void MoveWriteLE(ref Span<byte>span, Int16 value, out int length) {
            if (span.Length < sizeof(UInt16))
                throw new ArgumentOutOfRangeException();
            Unsafe.WriteUnaligned(ref MemoryMarshal.GetReference(span), value);
            length = sizeof(Int16);
            span = span.Slice(sizeof(Int16));
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void MoveWriteLE(ref Span<byte>span, UInt32 value) => SpanUtils.MoveWriteLE(ref span, value, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void MoveWriteLE(ref Span<byte>span, UInt32 value, out int length) {
            if (span.Length < sizeof(UInt32))
                throw new ArgumentOutOfRangeException();
            Unsafe.WriteUnaligned(ref MemoryMarshal.GetReference(span), value);
            length = sizeof(UInt32);
            span = span.Slice(sizeof(UInt32));
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void MoveWriteLE(ref Span<byte>span, Int32 value) => SpanUtils.MoveWriteLE(ref span, value, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void MoveWriteLE(ref Span<byte>span, Int32 value, out int length) {
            if (span.Length < sizeof(UInt32))
                throw new ArgumentOutOfRangeException();
            Unsafe.WriteUnaligned(ref MemoryMarshal.GetReference(span), value);
            length = sizeof(Int32);
            span = span.Slice(sizeof(Int32));
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void MoveWriteLE(ref Span<byte>span, UInt64 value) => SpanUtils.MoveWriteLE(ref span, value, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void MoveWriteLE(ref Span<byte>span, UInt64 value, out int length) {
            if (span.Length < sizeof(UInt64))
                throw new ArgumentOutOfRangeException();
            Unsafe.WriteUnaligned(ref MemoryMarshal.GetReference(span), value);
            length = sizeof(UInt64);
            span = span.Slice(sizeof(UInt64));
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void MoveWriteLE(ref Span<byte>span, Int64 value) => SpanUtils.MoveWriteLE(ref span, value, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void MoveWriteLE(ref Span<byte>span, Int64 value, out int length) {
            if (span.Length < sizeof(UInt64))
                throw new ArgumentOutOfRangeException();
            Unsafe.WriteUnaligned(ref MemoryMarshal.GetReference(span), value);
            length = sizeof(Int64);
            span = span.Slice(sizeof(Int64));
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void MoveWriteLE(ref Span<byte>span, Single value) => SpanUtils.MoveWriteLE(ref span, value, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void MoveWriteLE(ref Span<byte>span, Single value, out int length) {
#if NETSTANDARD21 || !BEFORENETCOREAPP3
            SpanUtils.Write(span, BitConverter.SingleToInt32Bits(value), out _);
#else
            //Span<float> a = stackalloc float[1] { value };
            //var ab = MemoryMarshal.Cast<float, byte>(a);
            //ab.CopyTo(span);
            var i = *(int*)(&value);
            SpanUtils.Write(span, i, out _);
#endif
            length = sizeof(Single);
            span = span.Slice(sizeof(Single));
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void MoveWriteLE(ref Span<byte>span, Double value) => SpanUtils.MoveWriteLE(ref span, value, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void MoveWriteLE(ref Span<byte>span, Double value, out int length) {
#if NETSTANDARD21 || !BEFORENETCOREAPP3
            SpanUtils.Write(span, BitConverter.DoubleToInt64Bits(value), out _);
#else
            //Span<double> a = stackalloc double[1] { value };
            //var ab = MemoryMarshal.Cast<double, byte>(a);
            //ab.CopyTo(span);
            var i = *(long*)(&value);
            SpanUtils.Write(span, i, out _);
#endif
            length = sizeof(Double);
            span = span.Slice(sizeof(Double));
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void MoveWriteLE(ref Span<byte>span, Decimal value) => SpanUtils.MoveWriteLE(ref span, value, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void MoveWriteLE(ref Span<byte>span, Decimal value, out int length) {
            Span<decimal> a = stackalloc decimal[1] { value };
            var ab = MemoryMarshal.Cast<decimal, byte>(a);
            ab.CopyTo(span);
            length = sizeof(Decimal);
            span = span.Slice(sizeof(Decimal));
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void MoveWriteLE(ref Span<byte>span, Boolean value) => SpanUtils.MoveWriteLE(ref span, value, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void MoveWriteLE(ref Span<byte>span, Boolean value, out int length) {
            span[0] = (byte)(value ? 1 : 0);
            length = sizeof(Boolean);
            span = span.Slice(sizeof(Boolean));
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void MoveWriteLE(ref Span<byte>span, Char value) => SpanUtils.MoveWriteLE(ref span, value, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void MoveWriteLE(ref Span<byte>span, Char value, out int length) {
            MemoryMarshal.Write(span, ref value);
            length = sizeof(Char);
            span = span.Slice(sizeof(Char));
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void MoveWriteLE(ref Span<byte>span, UInt24 value) => SpanUtils.MoveWriteLE(ref span, value, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void MoveWriteLE(ref Span<byte>span, UInt24 value, out int length) {
            //MemoryMarshal.Cast<byte, UInt32>(span)[0] = value;
            span[2] = (byte)(((Int32)value >> (8 * 2)) & 0xFF);
            span[0] = (byte)((Int32)value & 0xFF);
            span[1] = (byte)(((Int32)value >> (8 * 1)) & 0xFF);
            length = 3;
            span = span.Slice(3);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe SByte ReadSByteBE( Span<byte>span) => SpanUtils.ReadSByteBE(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe SByte ReadSByteBE( ReadOnlySpan<byte>span) => SpanUtils.ReadSByteBE(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe SByte ReadSByteBE(Span<byte> span, out int length) {
            var ret = (SByte)span[0];
            length = sizeof(SByte);
            
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe SByte ReadSByteBE(ReadOnlySpan<byte> span, out int length) {
            var ret = (SByte)span[0];
            length = sizeof(SByte);
            
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Byte ReadByteBE( Span<byte>span) => SpanUtils.ReadByteBE(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Byte ReadByteBE( ReadOnlySpan<byte>span) => SpanUtils.ReadByteBE(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Byte ReadByteBE(Span<byte> span, out int length) {
            var ret = span[0];
            length = sizeof(Byte);
            
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Byte ReadByteBE(ReadOnlySpan<byte> span, out int length) {
            var ret = span[0];
            length = sizeof(Byte);
            
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt16 ReadUInt16BE( Span<byte>span) => SpanUtils.ReadUInt16BE(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt16 ReadUInt16BE( ReadOnlySpan<byte>span) => SpanUtils.ReadUInt16BE(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt16 ReadUInt16BE(Span<byte> span, out int length) {
           var ret = (UInt16)(
                  ((UInt16)span[0] << (8 * 1))
                | ((UInt16)span[1])
                );
            length = sizeof(UInt16);
            
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt16 ReadUInt16BE(ReadOnlySpan<byte> span, out int length) {
           var ret = (UInt16)(
                  ((UInt16)span[0] << (8 * 1))
                | ((UInt16)span[1])
                );
            length = sizeof(UInt16);
            
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int16 ReadInt16BE( Span<byte>span) => SpanUtils.ReadInt16BE(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int16 ReadInt16BE( ReadOnlySpan<byte>span) => SpanUtils.ReadInt16BE(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int16 ReadInt16BE(Span<byte> span, out int length) {
           var ret = (UInt16)(
                  ((UInt16)span[0] << (8 * 1))
                | ((UInt16)span[1])
                );
            length = sizeof(Int16);
            
            return (Int16)ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int16 ReadInt16BE(ReadOnlySpan<byte> span, out int length) {
           var ret = (UInt16)(
                  ((UInt16)span[0] << (8 * 1))
                | ((UInt16)span[1])
                );
            length = sizeof(Int16);
            
            return (Int16)ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt32 ReadUInt32BE( Span<byte>span) => SpanUtils.ReadUInt32BE(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt32 ReadUInt32BE( ReadOnlySpan<byte>span) => SpanUtils.ReadUInt32BE(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt32 ReadUInt32BE(Span<byte> span, out int length) {
            // return MemoryMarshal.Cast<byte, UInt32>(span)[0];
            var ret = (UInt32)(
                  ((UInt32)span[3])
                | ((UInt32)span[2] << (8 * 1))
                | ((UInt32)span[1] << (8 * 2))
                | ((UInt32)span[0] << (8 * 3))
                );
            length = sizeof(UInt32);
            
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt32 ReadUInt32BE(ReadOnlySpan<byte> span, out int length) {
            // return MemoryMarshal.Cast<byte, UInt32>(span)[0];
            var ret = (UInt32)(
                  ((UInt32)span[3])
                | ((UInt32)span[2] << (8 * 1))
                | ((UInt32)span[1] << (8 * 2))
                | ((UInt32)span[0] << (8 * 3))
                );
            length = sizeof(UInt32);
            
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int32 ReadInt32BE( Span<byte>span) => SpanUtils.ReadInt32BE(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int32 ReadInt32BE( ReadOnlySpan<byte>span) => SpanUtils.ReadInt32BE(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int32 ReadInt32BE(Span<byte> span, out int length) {
            // return (Int32)MemoryMarshal.Cast<byte, UInt32>(span)[0];
            var ret = (UInt32)(
                  ((UInt32)span[3])
                | ((UInt32)span[2] << (8 * 1))
                | ((UInt32)span[1] << (8 * 2))
                | ((UInt32)span[0] << (8 * 3))
                );
            length = sizeof(Int32);
            
            return (Int32)ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int32 ReadInt32BE(ReadOnlySpan<byte> span, out int length) {
            // return (Int32)MemoryMarshal.Cast<byte, UInt32>(span)[0];
            var ret = (UInt32)(
                  ((UInt32)span[3])
                | ((UInt32)span[2] << (8 * 1))
                | ((UInt32)span[1] << (8 * 2))
                | ((UInt32)span[0] << (8 * 3))
                );
            length = sizeof(Int32);
            
            return (Int32)ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt64 ReadUInt64BE( Span<byte>span) => SpanUtils.ReadUInt64BE(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt64 ReadUInt64BE( ReadOnlySpan<byte>span) => SpanUtils.ReadUInt64BE(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt64 ReadUInt64BE(Span<byte> span, out int length) {
            //return MemoryMarshal.Cast<byte, UInt64>(span)[0];
            // 16% more speed if we read in reverse order due to removal of redundant compiler checks.
            // https://github.com/tedd/Tedd.SpanUtils/issues/3
            var ret = (UInt64)(
                  ((UInt64)span[7])
                | ((UInt64)span[6] << (8 * 1))
                | ((UInt64)span[5] << (8 * 2))
                | ((UInt64)span[4] << (8 * 3))
                | ((UInt64)span[3] << (8 * 4))
                | ((UInt64)span[2] << (8 * 5))
                | ((UInt64)span[1] << (8 * 6))
                | ((UInt64)span[0] << (8 * 7))
                );
            length = sizeof(UInt64);
            
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt64 ReadUInt64BE(ReadOnlySpan<byte> span, out int length) {
            //return MemoryMarshal.Cast<byte, UInt64>(span)[0];
            // 16% more speed if we read in reverse order due to removal of redundant compiler checks.
            // https://github.com/tedd/Tedd.SpanUtils/issues/3
            var ret = (UInt64)(
                  ((UInt64)span[7])
                | ((UInt64)span[6] << (8 * 1))
                | ((UInt64)span[5] << (8 * 2))
                | ((UInt64)span[4] << (8 * 3))
                | ((UInt64)span[3] << (8 * 4))
                | ((UInt64)span[2] << (8 * 5))
                | ((UInt64)span[1] << (8 * 6))
                | ((UInt64)span[0] << (8 * 7))
                );
            length = sizeof(UInt64);
            
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int64 ReadInt64BE( Span<byte>span) => SpanUtils.ReadInt64BE(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int64 ReadInt64BE( ReadOnlySpan<byte>span) => SpanUtils.ReadInt64BE(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int64 ReadInt64BE(Span<byte> span, out int length) {
            //return (Int64)MemoryMarshal.Cast<byte, UInt64>(span)[0];
            // 16% more speed if we read in reverse order due to removal of redundant compiler checks.
            // https://github.com/tedd/Tedd.SpanUtils/issues/3
            var ret = (UInt64)(
                  ((UInt64)span[7])
                | ((UInt64)span[6] << (8 * 1))
                | ((UInt64)span[5] << (8 * 2))
                | ((UInt64)span[4] << (8 * 3))
                | ((UInt64)span[3] << (8 * 4))
                | ((UInt64)span[2] << (8 * 5))
                | ((UInt64)span[1] << (8 * 6))
                | ((UInt64)span[0] << (8 * 7))
                );
            length = sizeof(Int64);
            
            return (Int64)ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int64 ReadInt64BE(ReadOnlySpan<byte> span, out int length) {
            //return (Int64)MemoryMarshal.Cast<byte, UInt64>(span)[0];
            // 16% more speed if we read in reverse order due to removal of redundant compiler checks.
            // https://github.com/tedd/Tedd.SpanUtils/issues/3
            var ret = (UInt64)(
                  ((UInt64)span[7])
                | ((UInt64)span[6] << (8 * 1))
                | ((UInt64)span[5] << (8 * 2))
                | ((UInt64)span[4] << (8 * 3))
                | ((UInt64)span[3] << (8 * 4))
                | ((UInt64)span[2] << (8 * 5))
                | ((UInt64)span[1] << (8 * 6))
                | ((UInt64)span[0] << (8 * 7))
                );
            length = sizeof(Int64);
            
            return (Int64)ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Single ReadSingleBE( Span<byte>span) => SpanUtils.ReadSingleBE(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Single ReadSingleBE( ReadOnlySpan<byte>span) => SpanUtils.ReadSingleBE(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Single ReadSingleBE(Span<byte> span, out int length) {
#if NETSTANDARD21 || !BEFORENETCOREAPP3
            var r = BitConverter.Int32BitsToSingle(SpanUtils.ReadInt32BE(span, out _));
#else
            //Span<float> a = stackalloc float[1];
            //var ab = MemoryMarshal.Cast<float, byte>(a);
            //span.Slice(0, sizeof(float)).CopyTo(ab);
            //var r = a[0];
            var i = SpanUtils.ReadInt32BE(span, out _);
            var r = *(float*)(&i);
#endif
            length = sizeof(Single);
            
            return r;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Single ReadSingleBE(ReadOnlySpan<byte> span, out int length) {
#if NETSTANDARD21 || !BEFORENETCOREAPP3
            var r = BitConverter.Int32BitsToSingle(SpanUtils.ReadInt32BE(span, out _));
#else
            //Span<float> a = stackalloc float[1];
            //var ab = MemoryMarshal.Cast<float, byte>(a);
            //span.Slice(0, sizeof(float)).CopyTo(ab);
            //var r = a[0];
            var i = SpanUtils.ReadInt32BE(span, out _);
            var r = *(float*)(&i);
#endif
            length = sizeof(Single);
            
            return r;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Double ReadDoubleBE( Span<byte>span) => SpanUtils.ReadDoubleBE(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Double ReadDoubleBE( ReadOnlySpan<byte>span) => SpanUtils.ReadDoubleBE(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Double ReadDoubleBE(Span<byte> span, out int length) {
#if NETSTANDARD21 || !BEFORENETCOREAPP3
            var r = BitConverter.Int64BitsToDouble(SpanUtils.ReadInt64BE(span, out _));
#else
            //Span<double> a = stackalloc double[1];
            //var ab = MemoryMarshal.Cast<double, byte>(a);
            //span.Slice(0, sizeof(double)).CopyTo(ab);
            //var r = a[0];
            var i = SpanUtils.ReadInt64BE(span, out _);
            var r = *(double*)(&i);
#endif
            length = sizeof(Double);
            
            return r;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Double ReadDoubleBE(ReadOnlySpan<byte> span, out int length) {
#if NETSTANDARD21 || !BEFORENETCOREAPP3
            var r = BitConverter.Int64BitsToDouble(SpanUtils.ReadInt64BE(span, out _));
#else
            //Span<double> a = stackalloc double[1];
            //var ab = MemoryMarshal.Cast<double, byte>(a);
            //span.Slice(0, sizeof(double)).CopyTo(ab);
            //var r = a[0];
            var i = SpanUtils.ReadInt64BE(span, out _);
            var r = *(double*)(&i);
#endif
            length = sizeof(Double);
            
            return r;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Decimal ReadDecimalBE( Span<byte>span) => SpanUtils.ReadDecimalBE(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Decimal ReadDecimalBE( ReadOnlySpan<byte>span) => SpanUtils.ReadDecimalBE(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Decimal ReadDecimalBE(Span<byte> span, out int length) {
            Span<decimal> a = stackalloc decimal[1];
            var ab = MemoryMarshal.Cast<decimal, byte>(a);
            span.Slice(0, sizeof(decimal)).CopyTo(ab);
            length = sizeof(Decimal);
            
            return a[0];
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Decimal ReadDecimalBE(ReadOnlySpan<byte> span, out int length) {
            Span<decimal> a = stackalloc decimal[1];
            var ab = MemoryMarshal.Cast<decimal, byte>(a);
            span.Slice(0, sizeof(decimal)).CopyTo(ab);
            length = sizeof(Decimal);
            
            return a[0];
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Boolean ReadBooleanBE( Span<byte>span) => SpanUtils.ReadBooleanBE(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Boolean ReadBooleanBE( ReadOnlySpan<byte>span) => SpanUtils.ReadBooleanBE(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Boolean ReadBooleanBE(Span<byte> span, out int length) {
            var ret = span[0] != 0;
            length = sizeof(Boolean);
            
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Boolean ReadBooleanBE(ReadOnlySpan<byte> span, out int length) {
            var ret = span[0] != 0;
            length = sizeof(Boolean);
            
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Char ReadCharBE( Span<byte>span) => SpanUtils.ReadCharBE(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Char ReadCharBE( ReadOnlySpan<byte>span) => SpanUtils.ReadCharBE(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Char ReadCharBE(Span<byte> span, out int length) {
            var r = MemoryMarshal.Read<Char>(span);
            length = sizeof(Char);
            
            return r;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Char ReadCharBE(ReadOnlySpan<byte> span, out int length) {
            var r = MemoryMarshal.Read<Char>(span);
            length = sizeof(Char);
            
            return r;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Single ReadFloatBE( Span<byte>span) => SpanUtils.ReadFloatBE(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Single ReadFloatBE( ReadOnlySpan<byte>span) => SpanUtils.ReadFloatBE(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Single ReadFloatBE(Span<byte> span, out int length) {
#if NETSTANDARD21 || !BEFORENETCOREAPP3
            var r = BitConverter.Int32BitsToSingle(SpanUtils.ReadInt32BE(span, out _));
#else
            //Span<float> a = stackalloc float[1];
            //var ab = MemoryMarshal.Cast<float, byte>(a);
            //span.Slice(0, sizeof(float)).CopyTo(ab);
            //var r = a[0];
            var i = SpanUtils.ReadInt32BE(span, out _);
            var r = *(float*)(&i);
#endif
            length = sizeof(Single);
            
            return r;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Single ReadFloatBE(ReadOnlySpan<byte> span, out int length) {
#if NETSTANDARD21 || !BEFORENETCOREAPP3
            var r = BitConverter.Int32BitsToSingle(SpanUtils.ReadInt32BE(span, out _));
#else
            //Span<float> a = stackalloc float[1];
            //var ab = MemoryMarshal.Cast<float, byte>(a);
            //span.Slice(0, sizeof(float)).CopyTo(ab);
            //var r = a[0];
            var i = SpanUtils.ReadInt32BE(span, out _);
            var r = *(float*)(&i);
#endif
            length = sizeof(Single);
            
            return r;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int16 ReadShortBE( Span<byte>span) => SpanUtils.ReadShortBE(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int16 ReadShortBE( ReadOnlySpan<byte>span) => SpanUtils.ReadShortBE(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int16 ReadShortBE(Span<byte> span, out int length) {
           var ret = (UInt16)(
                  ((UInt16)span[0] << (8 * 1))
                | ((UInt16)span[1])
                );
            length = sizeof(Int16);
            
            return (Int16)ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int16 ReadShortBE(ReadOnlySpan<byte> span, out int length) {
           var ret = (UInt16)(
                  ((UInt16)span[0] << (8 * 1))
                | ((UInt16)span[1])
                );
            length = sizeof(Int16);
            
            return (Int16)ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt16 ReadUShortBE( Span<byte>span) => SpanUtils.ReadUShortBE(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt16 ReadUShortBE( ReadOnlySpan<byte>span) => SpanUtils.ReadUShortBE(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt16 ReadUShortBE(Span<byte> span, out int length) {
           var ret = (UInt16)(
                  ((UInt16)span[0] << (8 * 1))
                | ((UInt16)span[1])
                );
            length = sizeof(UInt16);
            
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt16 ReadUShortBE(ReadOnlySpan<byte> span, out int length) {
           var ret = (UInt16)(
                  ((UInt16)span[0] << (8 * 1))
                | ((UInt16)span[1])
                );
            length = sizeof(UInt16);
            
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int32 ReadIntBE( Span<byte>span) => SpanUtils.ReadIntBE(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int32 ReadIntBE( ReadOnlySpan<byte>span) => SpanUtils.ReadIntBE(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int32 ReadIntBE(Span<byte> span, out int length) {
            // return (Int32)MemoryMarshal.Cast<byte, UInt32>(span)[0];
            var ret = (UInt32)(
                  ((UInt32)span[3])
                | ((UInt32)span[2] << (8 * 1))
                | ((UInt32)span[1] << (8 * 2))
                | ((UInt32)span[0] << (8 * 3))
                );
            length = sizeof(Int32);
            
            return (Int32)ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int32 ReadIntBE(ReadOnlySpan<byte> span, out int length) {
            // return (Int32)MemoryMarshal.Cast<byte, UInt32>(span)[0];
            var ret = (UInt32)(
                  ((UInt32)span[3])
                | ((UInt32)span[2] << (8 * 1))
                | ((UInt32)span[1] << (8 * 2))
                | ((UInt32)span[0] << (8 * 3))
                );
            length = sizeof(Int32);
            
            return (Int32)ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt32 ReadUIntBE( Span<byte>span) => SpanUtils.ReadUIntBE(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt32 ReadUIntBE( ReadOnlySpan<byte>span) => SpanUtils.ReadUIntBE(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt32 ReadUIntBE(Span<byte> span, out int length) {
            // return MemoryMarshal.Cast<byte, UInt32>(span)[0];
            var ret = (UInt32)(
                  ((UInt32)span[3])
                | ((UInt32)span[2] << (8 * 1))
                | ((UInt32)span[1] << (8 * 2))
                | ((UInt32)span[0] << (8 * 3))
                );
            length = sizeof(UInt32);
            
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt32 ReadUIntBE(ReadOnlySpan<byte> span, out int length) {
            // return MemoryMarshal.Cast<byte, UInt32>(span)[0];
            var ret = (UInt32)(
                  ((UInt32)span[3])
                | ((UInt32)span[2] << (8 * 1))
                | ((UInt32)span[1] << (8 * 2))
                | ((UInt32)span[0] << (8 * 3))
                );
            length = sizeof(UInt32);
            
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int64 ReadLongBE( Span<byte>span) => SpanUtils.ReadLongBE(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int64 ReadLongBE( ReadOnlySpan<byte>span) => SpanUtils.ReadLongBE(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int64 ReadLongBE(Span<byte> span, out int length) {
            //return (Int64)MemoryMarshal.Cast<byte, UInt64>(span)[0];
            // 16% more speed if we read in reverse order due to removal of redundant compiler checks.
            // https://github.com/tedd/Tedd.SpanUtils/issues/3
            var ret = (UInt64)(
                  ((UInt64)span[7])
                | ((UInt64)span[6] << (8 * 1))
                | ((UInt64)span[5] << (8 * 2))
                | ((UInt64)span[4] << (8 * 3))
                | ((UInt64)span[3] << (8 * 4))
                | ((UInt64)span[2] << (8 * 5))
                | ((UInt64)span[1] << (8 * 6))
                | ((UInt64)span[0] << (8 * 7))
                );
            length = sizeof(Int64);
            
            return (Int64)ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int64 ReadLongBE(ReadOnlySpan<byte> span, out int length) {
            //return (Int64)MemoryMarshal.Cast<byte, UInt64>(span)[0];
            // 16% more speed if we read in reverse order due to removal of redundant compiler checks.
            // https://github.com/tedd/Tedd.SpanUtils/issues/3
            var ret = (UInt64)(
                  ((UInt64)span[7])
                | ((UInt64)span[6] << (8 * 1))
                | ((UInt64)span[5] << (8 * 2))
                | ((UInt64)span[4] << (8 * 3))
                | ((UInt64)span[3] << (8 * 4))
                | ((UInt64)span[2] << (8 * 5))
                | ((UInt64)span[1] << (8 * 6))
                | ((UInt64)span[0] << (8 * 7))
                );
            length = sizeof(Int64);
            
            return (Int64)ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt64 ReadULongBE( Span<byte>span) => SpanUtils.ReadULongBE(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt64 ReadULongBE( ReadOnlySpan<byte>span) => SpanUtils.ReadULongBE(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt64 ReadULongBE(Span<byte> span, out int length) {
            //return MemoryMarshal.Cast<byte, UInt64>(span)[0];
            // 16% more speed if we read in reverse order due to removal of redundant compiler checks.
            // https://github.com/tedd/Tedd.SpanUtils/issues/3
            var ret = (UInt64)(
                  ((UInt64)span[7])
                | ((UInt64)span[6] << (8 * 1))
                | ((UInt64)span[5] << (8 * 2))
                | ((UInt64)span[4] << (8 * 3))
                | ((UInt64)span[3] << (8 * 4))
                | ((UInt64)span[2] << (8 * 5))
                | ((UInt64)span[1] << (8 * 6))
                | ((UInt64)span[0] << (8 * 7))
                );
            length = sizeof(UInt64);
            
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt64 ReadULongBE(ReadOnlySpan<byte> span, out int length) {
            //return MemoryMarshal.Cast<byte, UInt64>(span)[0];
            // 16% more speed if we read in reverse order due to removal of redundant compiler checks.
            // https://github.com/tedd/Tedd.SpanUtils/issues/3
            var ret = (UInt64)(
                  ((UInt64)span[7])
                | ((UInt64)span[6] << (8 * 1))
                | ((UInt64)span[5] << (8 * 2))
                | ((UInt64)span[4] << (8 * 3))
                | ((UInt64)span[3] << (8 * 4))
                | ((UInt64)span[2] << (8 * 5))
                | ((UInt64)span[1] << (8 * 6))
                | ((UInt64)span[0] << (8 * 7))
                );
            length = sizeof(UInt64);
            
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Boolean ReadBoolBE( Span<byte>span) => SpanUtils.ReadBoolBE(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Boolean ReadBoolBE( ReadOnlySpan<byte>span) => SpanUtils.ReadBoolBE(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Boolean ReadBoolBE(Span<byte> span, out int length) {
            var ret = span[0] != 0;
            length = sizeof(Boolean);
            
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Boolean ReadBoolBE(ReadOnlySpan<byte> span, out int length) {
            var ret = span[0] != 0;
            length = sizeof(Boolean);
            
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt24 ReadUInt24BE( Span<byte>span) => SpanUtils.ReadUInt24BE(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt24 ReadUInt24BE( ReadOnlySpan<byte>span) => SpanUtils.ReadUInt24BE(span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt24 ReadUInt24BE(Span<byte> span, out int length) {
            var ret = (UInt24)(Int32)(
                  ((UInt32)span[2])
                | ((UInt32)span[1] << (8 * 1))
                | ((UInt32)span[0] << (8 * 2))
                );
            length = 3;
            
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt24 ReadUInt24BE(ReadOnlySpan<byte> span, out int length) {
            var ret = (UInt24)(Int32)(
                  ((UInt32)span[2])
                | ((UInt32)span[1] << (8 * 1))
                | ((UInt32)span[0] << (8 * 2))
                );
            length = 3;
            
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe SByte MoveReadSByteBE(ref  Span<byte>span) => SpanUtils.MoveReadSByteBE(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe SByte MoveReadSByteBE(ref  ReadOnlySpan<byte>span) => SpanUtils.MoveReadSByteBE(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe SByte MoveReadSByteBE(ref Span<byte> span, out int length) {
            var ret = (SByte)span[0];
            length = sizeof(SByte);
            span = span.Slice(sizeof(SByte));
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe SByte MoveReadSByteBE(ref ReadOnlySpan<byte> span, out int length) {
            var ret = (SByte)span[0];
            length = sizeof(SByte);
            span = span.Slice(sizeof(SByte));
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Byte MoveReadByteBE(ref  Span<byte>span) => SpanUtils.MoveReadByteBE(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Byte MoveReadByteBE(ref  ReadOnlySpan<byte>span) => SpanUtils.MoveReadByteBE(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Byte MoveReadByteBE(ref Span<byte> span, out int length) {
            var ret = span[0];
            length = sizeof(Byte);
            span = span.Slice(sizeof(Byte));
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Byte MoveReadByteBE(ref ReadOnlySpan<byte> span, out int length) {
            var ret = span[0];
            length = sizeof(Byte);
            span = span.Slice(sizeof(Byte));
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt16 MoveReadUInt16BE(ref  Span<byte>span) => SpanUtils.MoveReadUInt16BE(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt16 MoveReadUInt16BE(ref  ReadOnlySpan<byte>span) => SpanUtils.MoveReadUInt16BE(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt16 MoveReadUInt16BE(ref Span<byte> span, out int length) {
           var ret = (UInt16)(
                  ((UInt16)span[0] << (8 * 1))
                | ((UInt16)span[1])
                );
            length = sizeof(UInt16);
            span = span.Slice(sizeof(UInt16));
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt16 MoveReadUInt16BE(ref ReadOnlySpan<byte> span, out int length) {
           var ret = (UInt16)(
                  ((UInt16)span[0] << (8 * 1))
                | ((UInt16)span[1])
                );
            length = sizeof(UInt16);
            span = span.Slice(sizeof(UInt16));
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int16 MoveReadInt16BE(ref  Span<byte>span) => SpanUtils.MoveReadInt16BE(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int16 MoveReadInt16BE(ref  ReadOnlySpan<byte>span) => SpanUtils.MoveReadInt16BE(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int16 MoveReadInt16BE(ref Span<byte> span, out int length) {
           var ret = (UInt16)(
                  ((UInt16)span[0] << (8 * 1))
                | ((UInt16)span[1])
                );
            length = sizeof(Int16);
            span = span.Slice(sizeof(Int16));
            return (Int16)ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int16 MoveReadInt16BE(ref ReadOnlySpan<byte> span, out int length) {
           var ret = (UInt16)(
                  ((UInt16)span[0] << (8 * 1))
                | ((UInt16)span[1])
                );
            length = sizeof(Int16);
            span = span.Slice(sizeof(Int16));
            return (Int16)ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt32 MoveReadUInt32BE(ref  Span<byte>span) => SpanUtils.MoveReadUInt32BE(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt32 MoveReadUInt32BE(ref  ReadOnlySpan<byte>span) => SpanUtils.MoveReadUInt32BE(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt32 MoveReadUInt32BE(ref Span<byte> span, out int length) {
            // return MemoryMarshal.Cast<byte, UInt32>(span)[0];
            var ret = (UInt32)(
                  ((UInt32)span[3])
                | ((UInt32)span[2] << (8 * 1))
                | ((UInt32)span[1] << (8 * 2))
                | ((UInt32)span[0] << (8 * 3))
                );
            length = sizeof(UInt32);
            span = span.Slice(sizeof(UInt32));
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt32 MoveReadUInt32BE(ref ReadOnlySpan<byte> span, out int length) {
            // return MemoryMarshal.Cast<byte, UInt32>(span)[0];
            var ret = (UInt32)(
                  ((UInt32)span[3])
                | ((UInt32)span[2] << (8 * 1))
                | ((UInt32)span[1] << (8 * 2))
                | ((UInt32)span[0] << (8 * 3))
                );
            length = sizeof(UInt32);
            span = span.Slice(sizeof(UInt32));
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int32 MoveReadInt32BE(ref  Span<byte>span) => SpanUtils.MoveReadInt32BE(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int32 MoveReadInt32BE(ref  ReadOnlySpan<byte>span) => SpanUtils.MoveReadInt32BE(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int32 MoveReadInt32BE(ref Span<byte> span, out int length) {
            // return (Int32)MemoryMarshal.Cast<byte, UInt32>(span)[0];
            var ret = (UInt32)(
                  ((UInt32)span[3])
                | ((UInt32)span[2] << (8 * 1))
                | ((UInt32)span[1] << (8 * 2))
                | ((UInt32)span[0] << (8 * 3))
                );
            length = sizeof(Int32);
            span = span.Slice(sizeof(Int32));
            return (Int32)ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int32 MoveReadInt32BE(ref ReadOnlySpan<byte> span, out int length) {
            // return (Int32)MemoryMarshal.Cast<byte, UInt32>(span)[0];
            var ret = (UInt32)(
                  ((UInt32)span[3])
                | ((UInt32)span[2] << (8 * 1))
                | ((UInt32)span[1] << (8 * 2))
                | ((UInt32)span[0] << (8 * 3))
                );
            length = sizeof(Int32);
            span = span.Slice(sizeof(Int32));
            return (Int32)ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt64 MoveReadUInt64BE(ref  Span<byte>span) => SpanUtils.MoveReadUInt64BE(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt64 MoveReadUInt64BE(ref  ReadOnlySpan<byte>span) => SpanUtils.MoveReadUInt64BE(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt64 MoveReadUInt64BE(ref Span<byte> span, out int length) {
            //return MemoryMarshal.Cast<byte, UInt64>(span)[0];
            // 16% more speed if we read in reverse order due to removal of redundant compiler checks.
            // https://github.com/tedd/Tedd.SpanUtils/issues/3
            var ret = (UInt64)(
                  ((UInt64)span[7])
                | ((UInt64)span[6] << (8 * 1))
                | ((UInt64)span[5] << (8 * 2))
                | ((UInt64)span[4] << (8 * 3))
                | ((UInt64)span[3] << (8 * 4))
                | ((UInt64)span[2] << (8 * 5))
                | ((UInt64)span[1] << (8 * 6))
                | ((UInt64)span[0] << (8 * 7))
                );
            length = sizeof(UInt64);
            span = span.Slice(sizeof(UInt64));
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt64 MoveReadUInt64BE(ref ReadOnlySpan<byte> span, out int length) {
            //return MemoryMarshal.Cast<byte, UInt64>(span)[0];
            // 16% more speed if we read in reverse order due to removal of redundant compiler checks.
            // https://github.com/tedd/Tedd.SpanUtils/issues/3
            var ret = (UInt64)(
                  ((UInt64)span[7])
                | ((UInt64)span[6] << (8 * 1))
                | ((UInt64)span[5] << (8 * 2))
                | ((UInt64)span[4] << (8 * 3))
                | ((UInt64)span[3] << (8 * 4))
                | ((UInt64)span[2] << (8 * 5))
                | ((UInt64)span[1] << (8 * 6))
                | ((UInt64)span[0] << (8 * 7))
                );
            length = sizeof(UInt64);
            span = span.Slice(sizeof(UInt64));
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int64 MoveReadInt64BE(ref  Span<byte>span) => SpanUtils.MoveReadInt64BE(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int64 MoveReadInt64BE(ref  ReadOnlySpan<byte>span) => SpanUtils.MoveReadInt64BE(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int64 MoveReadInt64BE(ref Span<byte> span, out int length) {
            //return (Int64)MemoryMarshal.Cast<byte, UInt64>(span)[0];
            // 16% more speed if we read in reverse order due to removal of redundant compiler checks.
            // https://github.com/tedd/Tedd.SpanUtils/issues/3
            var ret = (UInt64)(
                  ((UInt64)span[7])
                | ((UInt64)span[6] << (8 * 1))
                | ((UInt64)span[5] << (8 * 2))
                | ((UInt64)span[4] << (8 * 3))
                | ((UInt64)span[3] << (8 * 4))
                | ((UInt64)span[2] << (8 * 5))
                | ((UInt64)span[1] << (8 * 6))
                | ((UInt64)span[0] << (8 * 7))
                );
            length = sizeof(Int64);
            span = span.Slice(sizeof(Int64));
            return (Int64)ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int64 MoveReadInt64BE(ref ReadOnlySpan<byte> span, out int length) {
            //return (Int64)MemoryMarshal.Cast<byte, UInt64>(span)[0];
            // 16% more speed if we read in reverse order due to removal of redundant compiler checks.
            // https://github.com/tedd/Tedd.SpanUtils/issues/3
            var ret = (UInt64)(
                  ((UInt64)span[7])
                | ((UInt64)span[6] << (8 * 1))
                | ((UInt64)span[5] << (8 * 2))
                | ((UInt64)span[4] << (8 * 3))
                | ((UInt64)span[3] << (8 * 4))
                | ((UInt64)span[2] << (8 * 5))
                | ((UInt64)span[1] << (8 * 6))
                | ((UInt64)span[0] << (8 * 7))
                );
            length = sizeof(Int64);
            span = span.Slice(sizeof(Int64));
            return (Int64)ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Single MoveReadSingleBE(ref  Span<byte>span) => SpanUtils.MoveReadSingleBE(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Single MoveReadSingleBE(ref  ReadOnlySpan<byte>span) => SpanUtils.MoveReadSingleBE(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Single MoveReadSingleBE(ref Span<byte> span, out int length) {
#if NETSTANDARD21 || !BEFORENETCOREAPP3
            var r = BitConverter.Int32BitsToSingle(SpanUtils.ReadInt32BE(span, out _));
#else
            //Span<float> a = stackalloc float[1];
            //var ab = MemoryMarshal.Cast<float, byte>(a);
            //span.Slice(0, sizeof(float)).CopyTo(ab);
            //var r = a[0];
            var i = SpanUtils.ReadInt32BE(span, out _);
            var r = *(float*)(&i);
#endif
            length = sizeof(Single);
            span = span.Slice(sizeof(Single));
            return r;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Single MoveReadSingleBE(ref ReadOnlySpan<byte> span, out int length) {
#if NETSTANDARD21 || !BEFORENETCOREAPP3
            var r = BitConverter.Int32BitsToSingle(SpanUtils.ReadInt32BE(span, out _));
#else
            //Span<float> a = stackalloc float[1];
            //var ab = MemoryMarshal.Cast<float, byte>(a);
            //span.Slice(0, sizeof(float)).CopyTo(ab);
            //var r = a[0];
            var i = SpanUtils.ReadInt32BE(span, out _);
            var r = *(float*)(&i);
#endif
            length = sizeof(Single);
            span = span.Slice(sizeof(Single));
            return r;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Double MoveReadDoubleBE(ref  Span<byte>span) => SpanUtils.MoveReadDoubleBE(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Double MoveReadDoubleBE(ref  ReadOnlySpan<byte>span) => SpanUtils.MoveReadDoubleBE(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Double MoveReadDoubleBE(ref Span<byte> span, out int length) {
#if NETSTANDARD21 || !BEFORENETCOREAPP3
            var r = BitConverter.Int64BitsToDouble(SpanUtils.ReadInt64BE(span, out _));
#else
            //Span<double> a = stackalloc double[1];
            //var ab = MemoryMarshal.Cast<double, byte>(a);
            //span.Slice(0, sizeof(double)).CopyTo(ab);
            //var r = a[0];
            var i = SpanUtils.ReadInt64BE(span, out _);
            var r = *(double*)(&i);
#endif
            length = sizeof(Double);
            span = span.Slice(sizeof(Double));
            return r;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Double MoveReadDoubleBE(ref ReadOnlySpan<byte> span, out int length) {
#if NETSTANDARD21 || !BEFORENETCOREAPP3
            var r = BitConverter.Int64BitsToDouble(SpanUtils.ReadInt64BE(span, out _));
#else
            //Span<double> a = stackalloc double[1];
            //var ab = MemoryMarshal.Cast<double, byte>(a);
            //span.Slice(0, sizeof(double)).CopyTo(ab);
            //var r = a[0];
            var i = SpanUtils.ReadInt64BE(span, out _);
            var r = *(double*)(&i);
#endif
            length = sizeof(Double);
            span = span.Slice(sizeof(Double));
            return r;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Decimal MoveReadDecimalBE(ref  Span<byte>span) => SpanUtils.MoveReadDecimalBE(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Decimal MoveReadDecimalBE(ref  ReadOnlySpan<byte>span) => SpanUtils.MoveReadDecimalBE(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Decimal MoveReadDecimalBE(ref Span<byte> span, out int length) {
            Span<decimal> a = stackalloc decimal[1];
            var ab = MemoryMarshal.Cast<decimal, byte>(a);
            span.Slice(0, sizeof(decimal)).CopyTo(ab);
            length = sizeof(Decimal);
            span = span.Slice(sizeof(Decimal));
            return a[0];
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Decimal MoveReadDecimalBE(ref ReadOnlySpan<byte> span, out int length) {
            Span<decimal> a = stackalloc decimal[1];
            var ab = MemoryMarshal.Cast<decimal, byte>(a);
            span.Slice(0, sizeof(decimal)).CopyTo(ab);
            length = sizeof(Decimal);
            span = span.Slice(sizeof(Decimal));
            return a[0];
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Boolean MoveReadBooleanBE(ref  Span<byte>span) => SpanUtils.MoveReadBooleanBE(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Boolean MoveReadBooleanBE(ref  ReadOnlySpan<byte>span) => SpanUtils.MoveReadBooleanBE(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Boolean MoveReadBooleanBE(ref Span<byte> span, out int length) {
            var ret = span[0] != 0;
            length = sizeof(Boolean);
            span = span.Slice(sizeof(Boolean));
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Boolean MoveReadBooleanBE(ref ReadOnlySpan<byte> span, out int length) {
            var ret = span[0] != 0;
            length = sizeof(Boolean);
            span = span.Slice(sizeof(Boolean));
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Char MoveReadCharBE(ref  Span<byte>span) => SpanUtils.MoveReadCharBE(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Char MoveReadCharBE(ref  ReadOnlySpan<byte>span) => SpanUtils.MoveReadCharBE(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Char MoveReadCharBE(ref Span<byte> span, out int length) {
            var r = MemoryMarshal.Read<Char>(span);
            length = sizeof(Char);
            span = span.Slice(sizeof(Char));
            return r;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Char MoveReadCharBE(ref ReadOnlySpan<byte> span, out int length) {
            var r = MemoryMarshal.Read<Char>(span);
            length = sizeof(Char);
            span = span.Slice(sizeof(Char));
            return r;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Single MoveReadFloatBE(ref  Span<byte>span) => SpanUtils.MoveReadFloatBE(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Single MoveReadFloatBE(ref  ReadOnlySpan<byte>span) => SpanUtils.MoveReadFloatBE(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Single MoveReadFloatBE(ref Span<byte> span, out int length) {
#if NETSTANDARD21 || !BEFORENETCOREAPP3
            var r = BitConverter.Int32BitsToSingle(SpanUtils.ReadInt32BE(span, out _));
#else
            //Span<float> a = stackalloc float[1];
            //var ab = MemoryMarshal.Cast<float, byte>(a);
            //span.Slice(0, sizeof(float)).CopyTo(ab);
            //var r = a[0];
            var i = SpanUtils.ReadInt32BE(span, out _);
            var r = *(float*)(&i);
#endif
            length = sizeof(Single);
            span = span.Slice(sizeof(Single));
            return r;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Single MoveReadFloatBE(ref ReadOnlySpan<byte> span, out int length) {
#if NETSTANDARD21 || !BEFORENETCOREAPP3
            var r = BitConverter.Int32BitsToSingle(SpanUtils.ReadInt32BE(span, out _));
#else
            //Span<float> a = stackalloc float[1];
            //var ab = MemoryMarshal.Cast<float, byte>(a);
            //span.Slice(0, sizeof(float)).CopyTo(ab);
            //var r = a[0];
            var i = SpanUtils.ReadInt32BE(span, out _);
            var r = *(float*)(&i);
#endif
            length = sizeof(Single);
            span = span.Slice(sizeof(Single));
            return r;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int16 MoveReadShortBE(ref  Span<byte>span) => SpanUtils.MoveReadShortBE(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int16 MoveReadShortBE(ref  ReadOnlySpan<byte>span) => SpanUtils.MoveReadShortBE(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int16 MoveReadShortBE(ref Span<byte> span, out int length) {
           var ret = (UInt16)(
                  ((UInt16)span[0] << (8 * 1))
                | ((UInt16)span[1])
                );
            length = sizeof(Int16);
            span = span.Slice(sizeof(Int16));
            return (Int16)ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int16 MoveReadShortBE(ref ReadOnlySpan<byte> span, out int length) {
           var ret = (UInt16)(
                  ((UInt16)span[0] << (8 * 1))
                | ((UInt16)span[1])
                );
            length = sizeof(Int16);
            span = span.Slice(sizeof(Int16));
            return (Int16)ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt16 MoveReadUShortBE(ref  Span<byte>span) => SpanUtils.MoveReadUShortBE(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt16 MoveReadUShortBE(ref  ReadOnlySpan<byte>span) => SpanUtils.MoveReadUShortBE(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt16 MoveReadUShortBE(ref Span<byte> span, out int length) {
           var ret = (UInt16)(
                  ((UInt16)span[0] << (8 * 1))
                | ((UInt16)span[1])
                );
            length = sizeof(UInt16);
            span = span.Slice(sizeof(UInt16));
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt16 MoveReadUShortBE(ref ReadOnlySpan<byte> span, out int length) {
           var ret = (UInt16)(
                  ((UInt16)span[0] << (8 * 1))
                | ((UInt16)span[1])
                );
            length = sizeof(UInt16);
            span = span.Slice(sizeof(UInt16));
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int32 MoveReadIntBE(ref  Span<byte>span) => SpanUtils.MoveReadIntBE(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int32 MoveReadIntBE(ref  ReadOnlySpan<byte>span) => SpanUtils.MoveReadIntBE(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int32 MoveReadIntBE(ref Span<byte> span, out int length) {
            // return (Int32)MemoryMarshal.Cast<byte, UInt32>(span)[0];
            var ret = (UInt32)(
                  ((UInt32)span[3])
                | ((UInt32)span[2] << (8 * 1))
                | ((UInt32)span[1] << (8 * 2))
                | ((UInt32)span[0] << (8 * 3))
                );
            length = sizeof(Int32);
            span = span.Slice(sizeof(Int32));
            return (Int32)ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int32 MoveReadIntBE(ref ReadOnlySpan<byte> span, out int length) {
            // return (Int32)MemoryMarshal.Cast<byte, UInt32>(span)[0];
            var ret = (UInt32)(
                  ((UInt32)span[3])
                | ((UInt32)span[2] << (8 * 1))
                | ((UInt32)span[1] << (8 * 2))
                | ((UInt32)span[0] << (8 * 3))
                );
            length = sizeof(Int32);
            span = span.Slice(sizeof(Int32));
            return (Int32)ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt32 MoveReadUIntBE(ref  Span<byte>span) => SpanUtils.MoveReadUIntBE(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt32 MoveReadUIntBE(ref  ReadOnlySpan<byte>span) => SpanUtils.MoveReadUIntBE(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt32 MoveReadUIntBE(ref Span<byte> span, out int length) {
            // return MemoryMarshal.Cast<byte, UInt32>(span)[0];
            var ret = (UInt32)(
                  ((UInt32)span[3])
                | ((UInt32)span[2] << (8 * 1))
                | ((UInt32)span[1] << (8 * 2))
                | ((UInt32)span[0] << (8 * 3))
                );
            length = sizeof(UInt32);
            span = span.Slice(sizeof(UInt32));
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt32 MoveReadUIntBE(ref ReadOnlySpan<byte> span, out int length) {
            // return MemoryMarshal.Cast<byte, UInt32>(span)[0];
            var ret = (UInt32)(
                  ((UInt32)span[3])
                | ((UInt32)span[2] << (8 * 1))
                | ((UInt32)span[1] << (8 * 2))
                | ((UInt32)span[0] << (8 * 3))
                );
            length = sizeof(UInt32);
            span = span.Slice(sizeof(UInt32));
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int64 MoveReadLongBE(ref  Span<byte>span) => SpanUtils.MoveReadLongBE(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int64 MoveReadLongBE(ref  ReadOnlySpan<byte>span) => SpanUtils.MoveReadLongBE(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int64 MoveReadLongBE(ref Span<byte> span, out int length) {
            //return (Int64)MemoryMarshal.Cast<byte, UInt64>(span)[0];
            // 16% more speed if we read in reverse order due to removal of redundant compiler checks.
            // https://github.com/tedd/Tedd.SpanUtils/issues/3
            var ret = (UInt64)(
                  ((UInt64)span[7])
                | ((UInt64)span[6] << (8 * 1))
                | ((UInt64)span[5] << (8 * 2))
                | ((UInt64)span[4] << (8 * 3))
                | ((UInt64)span[3] << (8 * 4))
                | ((UInt64)span[2] << (8 * 5))
                | ((UInt64)span[1] << (8 * 6))
                | ((UInt64)span[0] << (8 * 7))
                );
            length = sizeof(Int64);
            span = span.Slice(sizeof(Int64));
            return (Int64)ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Int64 MoveReadLongBE(ref ReadOnlySpan<byte> span, out int length) {
            //return (Int64)MemoryMarshal.Cast<byte, UInt64>(span)[0];
            // 16% more speed if we read in reverse order due to removal of redundant compiler checks.
            // https://github.com/tedd/Tedd.SpanUtils/issues/3
            var ret = (UInt64)(
                  ((UInt64)span[7])
                | ((UInt64)span[6] << (8 * 1))
                | ((UInt64)span[5] << (8 * 2))
                | ((UInt64)span[4] << (8 * 3))
                | ((UInt64)span[3] << (8 * 4))
                | ((UInt64)span[2] << (8 * 5))
                | ((UInt64)span[1] << (8 * 6))
                | ((UInt64)span[0] << (8 * 7))
                );
            length = sizeof(Int64);
            span = span.Slice(sizeof(Int64));
            return (Int64)ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt64 MoveReadULongBE(ref  Span<byte>span) => SpanUtils.MoveReadULongBE(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt64 MoveReadULongBE(ref  ReadOnlySpan<byte>span) => SpanUtils.MoveReadULongBE(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt64 MoveReadULongBE(ref Span<byte> span, out int length) {
            //return MemoryMarshal.Cast<byte, UInt64>(span)[0];
            // 16% more speed if we read in reverse order due to removal of redundant compiler checks.
            // https://github.com/tedd/Tedd.SpanUtils/issues/3
            var ret = (UInt64)(
                  ((UInt64)span[7])
                | ((UInt64)span[6] << (8 * 1))
                | ((UInt64)span[5] << (8 * 2))
                | ((UInt64)span[4] << (8 * 3))
                | ((UInt64)span[3] << (8 * 4))
                | ((UInt64)span[2] << (8 * 5))
                | ((UInt64)span[1] << (8 * 6))
                | ((UInt64)span[0] << (8 * 7))
                );
            length = sizeof(UInt64);
            span = span.Slice(sizeof(UInt64));
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt64 MoveReadULongBE(ref ReadOnlySpan<byte> span, out int length) {
            //return MemoryMarshal.Cast<byte, UInt64>(span)[0];
            // 16% more speed if we read in reverse order due to removal of redundant compiler checks.
            // https://github.com/tedd/Tedd.SpanUtils/issues/3
            var ret = (UInt64)(
                  ((UInt64)span[7])
                | ((UInt64)span[6] << (8 * 1))
                | ((UInt64)span[5] << (8 * 2))
                | ((UInt64)span[4] << (8 * 3))
                | ((UInt64)span[3] << (8 * 4))
                | ((UInt64)span[2] << (8 * 5))
                | ((UInt64)span[1] << (8 * 6))
                | ((UInt64)span[0] << (8 * 7))
                );
            length = sizeof(UInt64);
            span = span.Slice(sizeof(UInt64));
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Boolean MoveReadBoolBE(ref  Span<byte>span) => SpanUtils.MoveReadBoolBE(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Boolean MoveReadBoolBE(ref  ReadOnlySpan<byte>span) => SpanUtils.MoveReadBoolBE(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Boolean MoveReadBoolBE(ref Span<byte> span, out int length) {
            var ret = span[0] != 0;
            length = sizeof(Boolean);
            span = span.Slice(sizeof(Boolean));
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Boolean MoveReadBoolBE(ref ReadOnlySpan<byte> span, out int length) {
            var ret = span[0] != 0;
            length = sizeof(Boolean);
            span = span.Slice(sizeof(Boolean));
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt24 MoveReadUInt24BE(ref  Span<byte>span) => SpanUtils.MoveReadUInt24BE(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt24 MoveReadUInt24BE(ref  ReadOnlySpan<byte>span) => SpanUtils.MoveReadUInt24BE(ref span, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt24 MoveReadUInt24BE(ref Span<byte> span, out int length) {
            var ret = (UInt24)(Int32)(
                  ((UInt32)span[2])
                | ((UInt32)span[1] << (8 * 1))
                | ((UInt32)span[0] << (8 * 2))
                );
            length = 3;
            span = span.Slice(3);
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe UInt24 MoveReadUInt24BE(ref ReadOnlySpan<byte> span, out int length) {
            var ret = (UInt24)(Int32)(
                  ((UInt32)span[2])
                | ((UInt32)span[1] << (8 * 1))
                | ((UInt32)span[0] << (8 * 2))
                );
            length = 3;
            span = span.Slice(3);
            return ret;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void WriteBE(Span<byte>span, SByte value) => SpanUtils.WriteBE(span, value, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void WriteBE(Span<byte>span, SByte value, out int length) {
        span[0] = (byte)value;
        length = sizeof(SByte);
        
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void WriteBE(Span<byte>span, Byte value) => SpanUtils.WriteBE(span, value, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void WriteBE(Span<byte>span, Byte value, out int length) {
        span[0] = value;
        length = sizeof(Byte);
        
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void WriteBE(Span<byte>span, UInt16 value) => SpanUtils.WriteBE(span, value, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void WriteBE(Span<byte>span, UInt16 value, out int length) {
            span[1] = (byte)(value & 0xFF);
            span[0] = (byte)(value >> (8 * 1));
            length = sizeof(UInt16);
            
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void WriteBE(Span<byte>span, Int16 value) => SpanUtils.WriteBE(span, value, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void WriteBE(Span<byte>span, Int16 value, out int length) {
            span[1] = (byte)(value & 0xFF);
            span[0] = (byte)(value >> (8 * 1));
            length = sizeof(Int16);
            
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void WriteBE(Span<byte>span, UInt32 value) => SpanUtils.WriteBE(span, value, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void WriteBE(Span<byte>span, UInt32 value, out int length) {
            //MemoryMarshal.Cast<byte, UInt32>(span)[0] = value;
            span[3] = (byte)(value & 0xFF);
            span[0] = (byte)(value >> (8 * 3));
            span[1] = (byte)((value >> (8 * 2)) & 0xFF);
            span[2] = (byte)((value >> (8 * 1)) & 0xFF);
            length = sizeof(UInt32);
            
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void WriteBE(Span<byte>span, Int32 value) => SpanUtils.WriteBE(span, value, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void WriteBE(Span<byte>span, Int32 value, out int length) {
            //MemoryMarshal.Cast<byte, UInt32>(span)[0] = value;
            span[3] = (byte)(value & 0xFF);
            span[0] = (byte)(value >> (8 * 3));
            span[1] = (byte)((value >> (8 * 2)) & 0xFF);
            span[2] = (byte)((value >> (8 * 1)) & 0xFF);
            length = sizeof(Int32);
            
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void WriteBE(Span<byte>span, UInt64 value) => SpanUtils.WriteBE(span, value, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void WriteBE(Span<byte>span, UInt64 value, out int length) {
            // 13% more speed if we write last first, then rest in sequence.
            // https://github.com/tedd/Tedd.SpanUtils/issues/3
            span[7] = (byte)(value & 0xFF);
            span[0] = (byte)(value >> (8 * 7));
            span[1] = (byte)((value >> (8 * 6)) & 0xFF);
            span[2] = (byte)((value >> (8 * 5)) & 0xFF);
            span[3] = (byte)((value >> (8 * 4)) & 0xFF);
            span[4] = (byte)((value >> (8 * 3)) & 0xFF);
            span[5] = (byte)((value >> (8 * 2)) & 0xFF);
            span[6] = (byte)((value >> (8 * 1)) & 0xFF);
            length = sizeof(UInt64);
            
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void WriteBE(Span<byte>span, Int64 value) => SpanUtils.WriteBE(span, value, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void WriteBE(Span<byte>span, Int64 value, out int length) {
            // 13% more speed if we write last first, then rest in sequence.
            // https://github.com/tedd/Tedd.SpanUtils/issues/3
            span[7] = (byte)(value & 0xFF);
            span[0] = (byte)(value >> (8 * 7));
            span[1] = (byte)((value >> (8 * 6)) & 0xFF);
            span[2] = (byte)((value >> (8 * 5)) & 0xFF);
            span[3] = (byte)((value >> (8 * 4)) & 0xFF);
            span[4] = (byte)((value >> (8 * 3)) & 0xFF);
            span[5] = (byte)((value >> (8 * 2)) & 0xFF);
            span[6] = (byte)((value >> (8 * 1)) & 0xFF);
            length = sizeof(Int64);
            
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void WriteBE(Span<byte>span, Single value) => SpanUtils.WriteBE(span, value, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void WriteBE(Span<byte>span, Single value, out int length) {
#if NETSTANDARD21 || !BEFORENETCOREAPP3
            SpanUtils.WriteBE(span, BitConverter.SingleToInt32Bits(value), out _);
#else
            //Span<float> a = stackalloc float[1] { value };
            //var ab = MemoryMarshal.Cast<float, byte>(a);
            //ab.CopyTo(span);
            var i = *(int*)(&value);
            SpanUtils.WriteBE(span, i, out _);
#endif
            length = sizeof(Single);
            
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void WriteBE(Span<byte>span, Double value) => SpanUtils.WriteBE(span, value, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void WriteBE(Span<byte>span, Double value, out int length) {
#if NETSTANDARD21 || !BEFORENETCOREAPP3
            SpanUtils.WriteBE(span, BitConverter.DoubleToInt64Bits(value), out _);
#else
            //Span<double> a = stackalloc double[1] { value };
            //var ab = MemoryMarshal.Cast<double, byte>(a);
            //ab.CopyTo(span);
            var i = *(long*)(&value);
            SpanUtils.WriteBE(span, i, out _);
#endif
            length = sizeof(Double);
            
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void WriteBE(Span<byte>span, Decimal value) => SpanUtils.WriteBE(span, value, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void WriteBE(Span<byte>span, Decimal value, out int length) {
            Span<decimal> a = stackalloc decimal[1] { value };
            var ab = MemoryMarshal.Cast<decimal, byte>(a);
            ab.CopyTo(span);
            length = sizeof(Decimal);
            
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void WriteBE(Span<byte>span, Boolean value) => SpanUtils.WriteBE(span, value, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void WriteBE(Span<byte>span, Boolean value, out int length) {
            span[0] = (byte)(value ? 1 : 0);
            length = sizeof(Boolean);
            
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void WriteBE(Span<byte>span, Char value) => SpanUtils.WriteBE(span, value, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void WriteBE(Span<byte>span, Char value, out int length) {
            MemoryMarshal.Write(span, ref value);
            length = sizeof(Char);
            
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void WriteBE(Span<byte>span, UInt24 value) => SpanUtils.WriteBE(span, value, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void WriteBE(Span<byte>span, UInt24 value, out int length) {
            //MemoryMarshal.Cast<byte, UInt32>(span)[0] = value;
            span[2] = (byte)((Int32)value & 0xFF);
            span[0] = (byte)(((Int32)value >> (8 * 2)) & 0xFF);
            span[1] = (byte)(((Int32)value >> (8 * 1)) & 0xFF);
            length = 3;
            
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void MoveWriteBE(ref Span<byte>span, SByte value) => SpanUtils.MoveWriteBE(ref span, value, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void MoveWriteBE(ref Span<byte>span, SByte value, out int length) {
        span[0] = (byte)value;
        length = sizeof(SByte);
        span = span.Slice(sizeof(SByte));
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void MoveWriteBE(ref Span<byte>span, Byte value) => SpanUtils.MoveWriteBE(ref span, value, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void MoveWriteBE(ref Span<byte>span, Byte value, out int length) {
        span[0] = value;
        length = sizeof(Byte);
        span = span.Slice(sizeof(Byte));
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void MoveWriteBE(ref Span<byte>span, UInt16 value) => SpanUtils.MoveWriteBE(ref span, value, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void MoveWriteBE(ref Span<byte>span, UInt16 value, out int length) {
            span[1] = (byte)(value & 0xFF);
            span[0] = (byte)(value >> (8 * 1));
            length = sizeof(UInt16);
            span = span.Slice(sizeof(UInt16));
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void MoveWriteBE(ref Span<byte>span, Int16 value) => SpanUtils.MoveWriteBE(ref span, value, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void MoveWriteBE(ref Span<byte>span, Int16 value, out int length) {
            span[1] = (byte)(value & 0xFF);
            span[0] = (byte)(value >> (8 * 1));
            length = sizeof(Int16);
            span = span.Slice(sizeof(Int16));
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void MoveWriteBE(ref Span<byte>span, UInt32 value) => SpanUtils.MoveWriteBE(ref span, value, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void MoveWriteBE(ref Span<byte>span, UInt32 value, out int length) {
            //MemoryMarshal.Cast<byte, UInt32>(span)[0] = value;
            span[3] = (byte)(value & 0xFF);
            span[0] = (byte)(value >> (8 * 3));
            span[1] = (byte)((value >> (8 * 2)) & 0xFF);
            span[2] = (byte)((value >> (8 * 1)) & 0xFF);
            length = sizeof(UInt32);
            span = span.Slice(sizeof(UInt32));
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void MoveWriteBE(ref Span<byte>span, Int32 value) => SpanUtils.MoveWriteBE(ref span, value, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void MoveWriteBE(ref Span<byte>span, Int32 value, out int length) {
            //MemoryMarshal.Cast<byte, UInt32>(span)[0] = value;
            span[3] = (byte)(value & 0xFF);
            span[0] = (byte)(value >> (8 * 3));
            span[1] = (byte)((value >> (8 * 2)) & 0xFF);
            span[2] = (byte)((value >> (8 * 1)) & 0xFF);
            length = sizeof(Int32);
            span = span.Slice(sizeof(Int32));
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void MoveWriteBE(ref Span<byte>span, UInt64 value) => SpanUtils.MoveWriteBE(ref span, value, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void MoveWriteBE(ref Span<byte>span, UInt64 value, out int length) {
            // 13% more speed if we write last first, then rest in sequence.
            // https://github.com/tedd/Tedd.SpanUtils/issues/3
            span[7] = (byte)(value & 0xFF);
            span[0] = (byte)(value >> (8 * 7));
            span[1] = (byte)((value >> (8 * 6)) & 0xFF);
            span[2] = (byte)((value >> (8 * 5)) & 0xFF);
            span[3] = (byte)((value >> (8 * 4)) & 0xFF);
            span[4] = (byte)((value >> (8 * 3)) & 0xFF);
            span[5] = (byte)((value >> (8 * 2)) & 0xFF);
            span[6] = (byte)((value >> (8 * 1)) & 0xFF);
            length = sizeof(UInt64);
            span = span.Slice(sizeof(UInt64));
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void MoveWriteBE(ref Span<byte>span, Int64 value) => SpanUtils.MoveWriteBE(ref span, value, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void MoveWriteBE(ref Span<byte>span, Int64 value, out int length) {
            // 13% more speed if we write last first, then rest in sequence.
            // https://github.com/tedd/Tedd.SpanUtils/issues/3
            span[7] = (byte)(value & 0xFF);
            span[0] = (byte)(value >> (8 * 7));
            span[1] = (byte)((value >> (8 * 6)) & 0xFF);
            span[2] = (byte)((value >> (8 * 5)) & 0xFF);
            span[3] = (byte)((value >> (8 * 4)) & 0xFF);
            span[4] = (byte)((value >> (8 * 3)) & 0xFF);
            span[5] = (byte)((value >> (8 * 2)) & 0xFF);
            span[6] = (byte)((value >> (8 * 1)) & 0xFF);
            length = sizeof(Int64);
            span = span.Slice(sizeof(Int64));
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void MoveWriteBE(ref Span<byte>span, Single value) => SpanUtils.MoveWriteBE(ref span, value, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void MoveWriteBE(ref Span<byte>span, Single value, out int length) {
#if NETSTANDARD21 || !BEFORENETCOREAPP3
            SpanUtils.WriteBE(span, BitConverter.SingleToInt32Bits(value), out _);
#else
            //Span<float> a = stackalloc float[1] { value };
            //var ab = MemoryMarshal.Cast<float, byte>(a);
            //ab.CopyTo(span);
            var i = *(int*)(&value);
            SpanUtils.WriteBE(span, i, out _);
#endif
            length = sizeof(Single);
            span = span.Slice(sizeof(Single));
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void MoveWriteBE(ref Span<byte>span, Double value) => SpanUtils.MoveWriteBE(ref span, value, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void MoveWriteBE(ref Span<byte>span, Double value, out int length) {
#if NETSTANDARD21 || !BEFORENETCOREAPP3
            SpanUtils.WriteBE(span, BitConverter.DoubleToInt64Bits(value), out _);
#else
            //Span<double> a = stackalloc double[1] { value };
            //var ab = MemoryMarshal.Cast<double, byte>(a);
            //ab.CopyTo(span);
            var i = *(long*)(&value);
            SpanUtils.WriteBE(span, i, out _);
#endif
            length = sizeof(Double);
            span = span.Slice(sizeof(Double));
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void MoveWriteBE(ref Span<byte>span, Decimal value) => SpanUtils.MoveWriteBE(ref span, value, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void MoveWriteBE(ref Span<byte>span, Decimal value, out int length) {
            Span<decimal> a = stackalloc decimal[1] { value };
            var ab = MemoryMarshal.Cast<decimal, byte>(a);
            ab.CopyTo(span);
            length = sizeof(Decimal);
            span = span.Slice(sizeof(Decimal));
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void MoveWriteBE(ref Span<byte>span, Boolean value) => SpanUtils.MoveWriteBE(ref span, value, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void MoveWriteBE(ref Span<byte>span, Boolean value, out int length) {
            span[0] = (byte)(value ? 1 : 0);
            length = sizeof(Boolean);
            span = span.Slice(sizeof(Boolean));
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void MoveWriteBE(ref Span<byte>span, Char value) => SpanUtils.MoveWriteBE(ref span, value, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void MoveWriteBE(ref Span<byte>span, Char value, out int length) {
            MemoryMarshal.Write(span, ref value);
            length = sizeof(Char);
            span = span.Slice(sizeof(Char));
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void MoveWriteBE(ref Span<byte>span, UInt24 value) => SpanUtils.MoveWriteBE(ref span, value, out _);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void MoveWriteBE(ref Span<byte>span, UInt24 value, out int length) {
            //MemoryMarshal.Cast<byte, UInt32>(span)[0] = value;
            span[2] = (byte)((Int32)value & 0xFF);
            span[0] = (byte)(((Int32)value >> (8 * 2)) & 0xFF);
            span[1] = (byte)(((Int32)value >> (8 * 1)) & 0xFF);
            length = 3;
            span = span.Slice(3);
        }

    }

}
