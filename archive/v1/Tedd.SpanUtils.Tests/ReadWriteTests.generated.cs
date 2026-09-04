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

using Xunit;
namespace Tedd
{
    public partial class ReadWriteTests
    {
        private Random _rnd = new Random();

        public void TestSByte()
        {
            var val = _rnd.NextSByte();
            var span = (Span<byte>)new byte[100];
            span.Write(val);
            var back = span.ReadSByte();
            Assert.Equal(val, back);
        }

        public void TestByte()
        {
            var val = _rnd.NextByte();
            var span = (Span<byte>)new byte[100];
            span.Write(val);
            var back = span.ReadByte();
            Assert.Equal(val, back);
        }

        public void TestUInt16()
        {
            var val = _rnd.NextUInt16();
            var span = (Span<byte>)new byte[100];
            span.Write(val);
            var back = span.ReadUInt16();
            Assert.Equal(val, back);
        }

        public void TestInt16()
        {
            var val = _rnd.NextInt16();
            var span = (Span<byte>)new byte[100];
            span.Write(val);
            var back = span.ReadInt16();
            Assert.Equal(val, back);
        }

        public void TestUInt32()
        {
            var val = _rnd.NextUInt32();
            var span = (Span<byte>)new byte[100];
            span.Write(val);
            var back = span.ReadUInt32();
            Assert.Equal(val, back);
        }

        public void TestInt32()
        {
            var val = _rnd.NextInt32();
            var span = (Span<byte>)new byte[100];
            span.Write(val);
            var back = span.ReadInt32();
            Assert.Equal(val, back);
        }

        public void TestUInt64()
        {
            var val = _rnd.NextUInt64();
            var span = (Span<byte>)new byte[100];
            span.Write(val);
            var back = span.ReadUInt64();
            Assert.Equal(val, back);
        }

        public void TestInt64()
        {
            var val = _rnd.NextInt64();
            var span = (Span<byte>)new byte[100];
            span.Write(val);
            var back = span.ReadInt64();
            Assert.Equal(val, back);
        }

        public void TestSingle()
        {
            var val = _rnd.NextSingle();
            var span = (Span<byte>)new byte[100];
            span.Write(val);
            var back = span.ReadSingle();
            Assert.Equal(val, back);
        }

        public void TestDouble()
        {
            var val = _rnd.NextDouble();
            var span = (Span<byte>)new byte[100];
            span.Write(val);
            var back = span.ReadDouble();
            Assert.Equal(val, back);
        }

        public void TestDecimal()
        {
            var val = _rnd.NextDecimal();
            var span = (Span<byte>)new byte[100];
            span.Write(val);
            var back = span.ReadDecimal();
            Assert.Equal(val, back);
        }

        public void TestBoolean()
        {
            var val = _rnd.NextBoolean();
            var span = (Span<byte>)new byte[100];
            span.Write(val);
            var back = span.ReadBoolean();
            Assert.Equal(val, back);
        }

        public void TestChar()
        {
            var val = _rnd.NextChar();
            var span = (Span<byte>)new byte[100];
            span.Write(val);
            var back = span.ReadChar();
            Assert.Equal(val, back);
        }

        public void TestUInt16()
        {
            var val = _rnd.NextUInt16();
            var span = (Span<byte>)new byte[100];
            span.Write(val);
            var back = span.ReadUInt16();
            Assert.Equal(val, back);
        }

        public void TestInt16()
        {
            var val = _rnd.NextInt16();
            var span = (Span<byte>)new byte[100];
            span.Write(val);
            var back = span.ReadInt16();
            Assert.Equal(val, back);
        }

        public void TestUInt32()
        {
            var val = _rnd.NextUInt32();
            var span = (Span<byte>)new byte[100];
            span.Write(val);
            var back = span.ReadUInt32();
            Assert.Equal(val, back);
        }

        public void TestInt32()
        {
            var val = _rnd.NextInt32();
            var span = (Span<byte>)new byte[100];
            span.Write(val);
            var back = span.ReadInt32();
            Assert.Equal(val, back);
        }

        public void TestUInt64()
        {
            var val = _rnd.NextUInt64();
            var span = (Span<byte>)new byte[100];
            span.Write(val);
            var back = span.ReadUInt64();
            Assert.Equal(val, back);
        }

        public void TestInt64()
        {
            var val = _rnd.NextInt64();
            var span = (Span<byte>)new byte[100];
            span.Write(val);
            var back = span.ReadInt64();
            Assert.Equal(val, back);
        }

        public void TestUInt24()
        {
            var val = _rnd.NextUInt24();
            var span = (Span<byte>)new byte[100];
            span.Write(val);
            var back = span.ReadUInt24();
            Assert.Equal(val, back);
        }

        public void TestUInt24()
        {
            var val = _rnd.NextUInt24();
            var span = (Span<byte>)new byte[100];
            span.Write(val);
            var back = span.ReadUInt24();
            Assert.Equal(val, back);
        }

        public void TestGuid()
        {
            var val = _rnd.NextGuid();
            var span = (Span<byte>)new byte[100];
            span.Write(val);
            var back = span.ReadGuid();
            Assert.Equal(val, back);
        }

        public void TestByte[]() {
            var val = _rnd.NextByte[]();
        var span = (Span<byte>)new byte[100];
        span.Write(val);
            var back = span.ReadByte[]();
        Assert.Equal(val, back);
        }

    public void TestSpan<byte>()
    {
        var val = _rnd.NextSpan<byte>();
        var span = (Span<byte>)new byte[100];
        span.Write(val);
        var back = span.ReadSpan<byte>();
        Assert.Equal(val, back);
    }

    public void TestReadOnlySpan<byte>()
    {
        var val = _rnd.NextReadOnlySpan<byte>();
        var span = (Span<byte>)new byte[100];
        span.Write(val);
        var back = span.ReadReadOnlySpan<byte>();
        Assert.Equal(val, back);
    }

    public void TestUInt32()
    {
        var val = _rnd.NextUInt32();
        var span = (Span<byte>)new byte[100];
        span.Write(val);
        var back = span.ReadUInt32();
        Assert.Equal(val, back);
    }

    public void TestByte[]() {
            var val = _rnd.NextByte[]();
    var span = (Span<byte>)new byte[100];
    span.Write(val);
            var back = span.ReadByte[]();
    Assert.Equal(val, back);
        }

public void TestString()
{
    var val = _rnd.NextString();
    var span = (Span<byte>)new byte[100];
    span.Write(val);
    var back = span.ReadString();
    Assert.Equal(val, back);
}

public void TestSpan<byte>()
{
    var val = _rnd.NextSpan<byte>();
    var span = (Span<byte>)new byte[100];
    span.Write(val);
    var back = span.ReadSpan<byte>();
    Assert.Equal(val, back);
}

public void TestReadOnlySpan<byte>()
{
    var val = _rnd.NextReadOnlySpan<byte>();
    var span = (Span<byte>)new byte[100];
    span.Write(val);
    var back = span.ReadReadOnlySpan<byte>();
    Assert.Equal(val, back);
}

    }

}
