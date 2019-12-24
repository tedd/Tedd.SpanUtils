using System;
using System.Linq;
using Xunit;
using Tedd;

namespace Tedd.SpanUtils.Tests.Span
{
    public class ReadWriteTests
    {
        private int count = 100;

        [Fact]
        public void TestSByte()
        {
            var rnd = new System.Random();
            var mem = new byte[sizeof(SByte)];
            var span = new Span<byte>(mem);
            var roSpan = new Span<byte>(mem);
            for (var c = 0; c < count; c++)
            {
                span.Fill(rnd.NextByte());
                SByte a = 0;
                // Pick any number except zero
                while ((a = rnd.NextSByte()) == 0) { }
                span.Write(a);
                // Ensure span is not zero
                Assert.NotEqual(0, span.ToArray().Select(b => (int)b).Sum());
                var r = roSpan.ReadSByte();
                Assert.Equal(a, r);
            }
        }

        [Fact]
        public void TestUByte()
        {
            var rnd = new System.Random();
            var mem = new byte[sizeof(SByte)];
            var span = new Span<byte>(mem);
            var roSpan = new Span<byte>(mem);
            for (var c = 0; c < count; c++)
            {
                span.Fill(rnd.NextByte());
                Byte a = 0;
                // Pick any number except zero
                while ((a = rnd.NextByte()) == 0) { }
                span.Write(a);
                // Ensure span is not zero
                Assert.NotEqual(0, span.ToArray().Select(b => (int)b).Sum());
                var r = roSpan.ReadByte();
                Assert.Equal(a, r);
            }
        }

        [Fact]
        public void TestInt16()
        {
            var rnd = new System.Random();
            var mem = new byte[sizeof(Int16)];
            var span = new Span<byte>(mem);
            var roSpan = new Span<byte>(mem);
            for (var c = 0; c < count; c++)
            {
                span.Fill(rnd.NextByte());
                Int16 a = 0;
                // Pick any number except zero
                while ((a = rnd.NextInt16()) == 0) { }
                span.Write(a);
                // Ensure span is not zero
                Assert.NotEqual(0, span.ToArray().Select(b => (int)b).Sum());
                var r = roSpan.ReadInt16();
                Assert.Equal(a, r);
            }
        }

        [Fact]
        public void TestUInt16()
        {
            var rnd = new System.Random();
            var mem = new byte[sizeof(UInt16)];
            var span = new Span<byte>(mem);
            var roSpan = new Span<byte>(mem);
            for (var c = 0; c < count; c++)
            {
                span.Fill(rnd.NextByte());
                UInt16 a = 0;
                // Pick any number except zero
                while ((a = rnd.NextUInt16()) == 0) { }
                span.Write(a);
                // Ensure span is not zero
                Assert.NotEqual(0, span.ToArray().Select(b => (int)b).Sum());
                var r = roSpan.ReadUInt16();
                Assert.Equal(a, r);
            }
        }

        [Fact]
        public void TestUInt24()
        {
            var rnd = new System.Random();
            var mem = new byte[sizeof(UInt24)];
            var span = new Span<byte>(mem);
            var roSpan = new Span<byte>(mem);
            for (var c = 0; c < count; c++)
            {
                span.Fill(rnd.NextByte());
                UInt24 a = 0;
                // Pick any number except zero
                while ((a = rnd.NextUInt32().ToUInt24()) == 0) { }
                span.Write(a);
                // Ensure span is not zero
                Assert.NotEqual(0, span.ToArray().Select(b => (int)b).Sum());
                var r = roSpan.ReadUInt24();
                Assert.Equal(a, r);
            }
        }

        [Fact]
        public void TestInt32()
        {
            var rnd = new System.Random();
            var mem = new byte[sizeof(Int32)];
            var span = new Span<byte>(mem);
            var roSpan = new Span<byte>(mem);
            for (var c = 0; c < count; c++)
            {
                span.Fill(rnd.NextByte());
                Int32 a = 0;
                // Pick any number except zero
                while ((a = rnd.NextInt32()) == 0) { }
                span.Write(a);
                // Ensure span is not zero
                Assert.NotEqual(0, span.ToArray().Select(b => (int)b).Sum());
                var r = roSpan.ReadInt32();
                Assert.Equal(a, r);
            }
        }

        [Fact]
        public void TestUInt32()
        {
            var rnd = new System.Random();
            var mem = new byte[sizeof(UInt32)];
            var span = new Span<byte>(mem);
            var roSpan = new Span<byte>(mem);

            for (var c = 0; c < count; c++)
            {
                span.Fill(rnd.NextByte());
                UInt32 a = 0;
                // Pick any number except zero
                while ((a = rnd.NextUInt32()) == 0) { }
                span.Write(a);
                // Ensure span is not zero
                Assert.NotEqual(0, span.ToArray().Select(b => (int)b).Sum());
                var r = roSpan.ReadUInt32();
                Assert.Equal(a, r);
            }
        }
        [Fact]
        public void TestInt64()
        {
            var rnd = new System.Random();
            var mem = new byte[sizeof(Int64)];
            var span = new Span<byte>(mem);
            var roSpan = new Span<byte>(mem);

            for (var c = 0; c < count; c++)
            {
                span.Fill(rnd.NextByte());
                Int64 a = 0;
                // Pick any number except zero
                while ((a = rnd.NextInt64()) == 0) { }
                span.Write(a);
                // Ensure span is not zero
                Assert.NotEqual(0, span.ToArray().Select(b => (int)b).Sum());
                var r = roSpan.ReadInt64();
                Assert.Equal(a, r);
            }
        }

        [Fact]
        public void TestUInt64()
        {
            var rnd = new System.Random();
            var mem = new byte[sizeof(UInt64)];
            var span = new Span<byte>(mem);
            var roSpan = new Span<byte>(mem);

            for (var c = 0; c < count; c++)
            {
                span.Fill(rnd.NextByte());
                UInt64 a = 0;
                // Pick any number except zero
                while ((a = rnd.NextUInt64()) == 0) { }
                span.Write(a);
                // Ensure span is not zero
                Assert.NotEqual(0, span.ToArray().Select(b => (int)b).Sum());
                var r = roSpan.ReadUInt64();
                Assert.Equal(a, r);
            }
        }

        [Fact]
        public void TestGuid()
        {
            for (var c = 0; c < count; c++)
            {
                var mem = new byte[16];
                var span1 = new Span<byte>(mem);
                var span2 = new Span<byte>(mem);

                var n = Guid.NewGuid();
                span1.Write(n);

                // Ensure span is not zero
                Assert.NotEqual(0, span2.ToArray().Select(b => (int)b).Sum());
                var r = span2.ReadGuid();
                Assert.Equal(n, r);
            }

        }
    }
}
