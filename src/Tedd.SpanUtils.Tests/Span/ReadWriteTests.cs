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


        [Fact]
        public void TestSize()
        {
            var mem = new byte[4];
            var rnd = new Random();
            for (var c = 0; c < count * 10_000; c++)
            {
                var sr = rnd.Next(0, 4);
#pragma warning disable 8509
                var a = sr switch
#pragma warning restore 8509
                {
                    0 => (UInt32)rnd.Next(0, 0b00111111),
                    1 => (UInt32)rnd.Next(0b01000000, 0b00111111_11111111),
                    2 => (UInt32)rnd.Next(0b01000000_00000000, 0b00111111_11111111_11111111),
                    3 => (UInt32)rnd.Next(0b01000000_00000000_00000000, 0b00111111_11111111_11111111_11111111)
                };
                var span1 = new Span<byte>(mem);
                span1.Fill(0);
                var span2 = new Span<byte>(mem);

                var s = span1.WriteSize(a);
                // Number of bytes must match
                Assert.Equal(sr + 1, s);
                // Size must match
                var size = span2.ReadSize(out var bs);
                Assert.Equal(bs, s);
                Assert.Equal(a, size);
            }

        }

        [Fact]
        public void TestBytesWithHeader()
        {
            var rnd = new Random();
            for (var c = 0; c < count; c++)
            {
                var memSize = rnd.Next(0, 10_000);
                var mem = new byte[memSize + 4];
                var answer = new byte[memSize];
                var span1 = new Span<byte>(mem);
                var span2 = new Span<byte>(mem);

                rnd.NextBytes(answer);
                span1.WriteWithHeader(answer);

                // Ensure span is not zero
                if (memSize > 0 && answer[0] != 0)
                    Assert.NotEqual(0, span2.ToArray().Select(b => (int)b).Sum());
                var r = span2.ReadBytesWithHeader(out var len);
                for (var i = 0; i < answer.Length; i++)
                    Assert.Equal(answer[i], r[i]);

                Assert.Throws<ArgumentException>(() =>
                {
                    var s = new Span<byte>(mem);
                    s.WriteWithHeader(new byte[mem.Length + 1]);
                });
            }

        }

        [Fact]
        public void TestSpanWithHeader()
        {
            var rnd = new Random();
            for (var c = 0; c < count; c++)
            {
                var memSize = rnd.Next(0, 10_000);
                var mem = new byte[memSize + 4];
                var answer = new byte[memSize];
                var aSpan = new Span<byte>(answer);
                var span1 = new Span<byte>(mem);
                var span2 = new Span<byte>(mem);

                rnd.NextBytes(answer);
                span1.WriteWithHeader(aSpan);

                // Ensure span is not zero
                if (memSize > 0 && answer[0] != 0)
                    Assert.NotEqual(0, span2.ToArray().Select(b => (int)b).Sum());
                var r = span2.ReadBytesWithHeader(out var len);
                for (var i = 0; i < answer.Length; i++)
                    Assert.Equal(answer[i], r[i]);

                Assert.Throws<ArgumentException>(() =>
                {
                    var s = new Span<byte>(mem);
                    s.WriteWithHeader(new Span<byte>(new byte[mem.Length + 1]));
                });
            }
        }
        [Fact]
        public void TestReadOnlySpanWithHeader()
        {
            var rnd = new Random();
            for (var c = 0; c < count; c++)
            {
                var memSize = rnd.Next(0, 10_000);
                var mem = new byte[memSize + 4];
                var answer = new byte[memSize];
                var aSpan = new ReadOnlySpan<byte>(answer);
                var span1 = new Span<byte>(mem);
                var span2 = new Span<byte>(mem);

                rnd.NextBytes(answer);
                span1.WriteWithHeader(aSpan);

                // Ensure span is not zero
                if (memSize > 0 && answer[0] != 0)
                    Assert.NotEqual(0, span2.ToArray().Select(b => (int)b).Sum());
                var r = span2.ReadBytesWithHeader(out var len);
                for (var i = 0; i < answer.Length; i++)
                    Assert.Equal(answer[i], r[i]);

                Assert.Throws<ArgumentException>(() =>
                {
                    var s = new Span<byte>(mem);
                    s.WriteWithHeader(new ReadOnlySpan<byte>(new byte[mem.Length + 1]));
                });
            }
        }

        [Fact]
        public void TestReadStringWithHeader()
        {
            var rnd = new Random();
            for (var c = 0; c < count; c++)
            {
                var memSize = rnd.Next(0, 1024);
                var mem = new byte[memSize + 4];
                var span1 = new Span<byte>(mem);
                var span2 = new Span<byte>(mem);

                var answer = rnd.NextString("abcæøå诶	比西αβγ", memSize);
                span1.WriteWithHeader(answer);


                // Ensure span is not zero
                if (memSize > 0 && answer[0] != 0)
                    Assert.NotEqual(0, span2.ToArray().Select(b => (int)b).Sum());
                var r = span2.ReadStringWithHeader(out var len);
                Assert.Equal(answer, r);
            }
        }



    }
}
