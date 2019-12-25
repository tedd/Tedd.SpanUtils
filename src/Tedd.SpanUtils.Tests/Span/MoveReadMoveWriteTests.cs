using System;
using System.Linq;
using Xunit;
using Tedd;

namespace Tedd.SpanUtils.Tests.Span
{
    public class MoveReadMoveWriteTests
    {
        private int count = 100;
        private int writeRepeatCount = 10;

        [Fact]
        public void TestSByte()
        {
            var rnd = new System.Random();
            for (var c = 0; c < count; c++)
            {
                var mem = new byte[sizeof(SByte) * writeRepeatCount];
                var span1 = new Span<byte>(mem);
                var span2 = new Span<byte>(mem);
                var a = new sbyte[writeRepeatCount];

                for (var i = 0; i < writeRepeatCount; i++)
                {
                    var n = rnd.NextSByte();
                    a[i] = n;
                    span1.MoveWrite(n);
                }

                // Ensure span is not zero
                Assert.NotEqual(0, span2.ToArray().Select(b => (int)b).Sum());
                for (var i = 0; i < writeRepeatCount; i++)
                {
                    var r = span2.MoveReadSByte();
                    Assert.Equal(a[i], r);
                }
            }
        }

        [Fact]
        public void TestByte()
        {
            var rnd = new System.Random();
            for (var c = 0; c < count; c++)
            {
                var mem = new byte[sizeof(Byte) * writeRepeatCount];
                var span1 = new Span<byte>(mem);
                var span2 = new Span<byte>(mem);
                var a = new Byte[writeRepeatCount];

                for (var i = 0; i < writeRepeatCount; i++)
                {
                    var n = rnd.NextByte();
                    a[i] = n;
                    span1.MoveWrite(n);
                }

                // Ensure span is not zero
                Assert.NotEqual(0, span2.ToArray().Select(b => (int)b).Sum());
                for (var i = 0; i < writeRepeatCount; i++)
                {
                    var r = span2.MoveReadByte();
                    Assert.Equal(a[i], r);
                }
            }
        }

        [Fact]
        public void TestInt16()
        {
            var rnd = new System.Random();
            for (var c = 0; c < count; c++)
            {
                var mem = new byte[sizeof(Int16) * writeRepeatCount];
                var span1 = new Span<byte>(mem);
                var span2 = new Span<byte>(mem);
                var a = new Int16[writeRepeatCount];

                for (var i = 0; i < writeRepeatCount; i++)
                {
                    var n = rnd.NextInt16();
                    a[i] = n;
                    span1.MoveWrite(n);
                }

                // Ensure span is not zero
                Assert.NotEqual(0, span2.ToArray().Select(b => (int)b).Sum());
                for (var i = 0; i < writeRepeatCount; i++)
                {
                    var r = span2.MoveReadInt16();
                    Assert.Equal(a[i], r);
                }
            }
        }

        [Fact]
        public void TestUInt16()
        {
            var rnd = new System.Random();
            for (var c = 0; c < count; c++)
            {
                var mem = new byte[sizeof(UInt16) * writeRepeatCount];
                var span1 = new Span<byte>(mem);
                var span2 = new Span<byte>(mem);
                var a = new UInt16[writeRepeatCount];

                for (var i = 0; i < writeRepeatCount; i++)
                {
                    var n = rnd.NextUInt16();
                    a[i] = n;
                    span1.MoveWrite(n);
                }

                // Ensure span is not zero
                Assert.NotEqual(0, span2.ToArray().Select(b => (int)b).Sum());
                for (var i = 0; i < writeRepeatCount; i++)
                {
                    var r = span2.MoveReadUInt16();
                    Assert.Equal(a[i], r);
                }
            }
        }

        [Fact]
        public void TestUInt24()
        {
            var rnd = new System.Random();
            for (var c = 0; c < count; c++)
            {
                var mem = new byte[sizeof(UInt24) * writeRepeatCount];
                var span1 = new Span<byte>(mem);
                var span2 = new Span<byte>(mem);
                var a = new UInt24[writeRepeatCount];

                for (var i = 0; i < writeRepeatCount; i++)
                {
                    var n = rnd.NextUInt32().ToUInt24();
                    a[i] = n;
                    span1.MoveWrite(n);
                }

                // Ensure span is not zero
                Assert.NotEqual(0, span2.ToArray().Select(b => (int)b).Sum());
                for (var i = 0; i < writeRepeatCount; i++)
                {
                    var r = span2.MoveReadUInt24();
                    Assert.Equal(a[i], r);
                }
            }
        }

        [Fact]
        public void TestInt32()
        {
            var rnd = new System.Random();
            for (var c = 0; c < count; c++)
            {
                var mem = new byte[sizeof(Int32) * writeRepeatCount];
                var span1 = new Span<byte>(mem);
                var span2 = new Span<byte>(mem);
                var a = new Int32[writeRepeatCount];

                for (var i = 0; i < writeRepeatCount; i++)
                {
                    var n = rnd.NextInt32();
                    a[i] = n;
                    span1.MoveWrite(n);
                }

                // Ensure span is not zero
                Assert.NotEqual(0, span2.ToArray().Select(b => (int)b).Sum());
                for (var i = 0; i < writeRepeatCount; i++)
                {
                    var r = span2.MoveReadInt32();
                    Assert.Equal(a[i], r);
                }
            }
        }

        [Fact]
        public void TestUInt32()
        {
            var rnd = new System.Random();
            for (var c = 0; c < count; c++)
            {
                var mem = new byte[sizeof(UInt32) * writeRepeatCount];
                var span1 = new Span<byte>(mem);
                var span2 = new Span<byte>(mem);
                var a = new UInt32[writeRepeatCount];


                for (var i = 0; i < writeRepeatCount; i++)
                {
                    var n = rnd.NextUInt32();
                    a[i] = n;
                    span1.MoveWrite(n);
                }

                // Ensure span is not zero
                Assert.NotEqual(0, span2.ToArray().Select(b => (int)b).Sum());
                for (var i = 0; i < writeRepeatCount; i++)
                {
                    var r = span2.MoveReadUInt32();
                    Assert.Equal(a[i], r);
                }
            }
        }


        [Fact]
        public void TestInt64()
        {
            var rnd = new System.Random();
            for (var c = 0; c < count; c++)
            {
                var mem = new byte[sizeof(Int64) * writeRepeatCount];
                var span1 = new Span<byte>(mem);
                var span2 = new Span<byte>(mem);
                var a = new Int64[writeRepeatCount];

                for (var i = 0; i < writeRepeatCount; i++)
                {
                    var n = rnd.NextInt64();
                    a[i] = n;
                    span1.MoveWrite(n);
                }

                // Ensure span is not zero
                Assert.NotEqual(0, span2.ToArray().Select(b => (int)b).Sum());
                for (var i = 0; i < writeRepeatCount; i++)
                {
                    var r = span2.MoveReadInt64();
                    Assert.Equal(a[i], r);
                }
            }
        }

        [Fact]
        public void TestUInt64()
        {
            var rnd = new System.Random();
            for (var c = 0; c < count; c++)
            {
                var mem = new byte[sizeof(UInt64) * writeRepeatCount];
                var span1 = new Span<byte>(mem);
                var span2 = new Span<byte>(mem);
                var a = new UInt64[writeRepeatCount];

                for (var i = 0; i < writeRepeatCount; i++)
                {
                    var n = rnd.NextUInt64();
                    a[i] = n;
                    span1.MoveWrite(n);
                }

                // Ensure span is not zero
                Assert.NotEqual(0, span2.ToArray().Select(b => (int)b).Sum());
                for (var i = 0; i < writeRepeatCount; i++)
                {
                    var r = span2.MoveReadUInt64();
                    Assert.Equal(a[i], r);
                }
            }
        }

        [Fact]
        public void TestGuid()
        {
            for (var c = 0; c < count; c++)
            {
                var mem = new byte[16 * writeRepeatCount];
                var span1 = new Span<byte>(mem);
                var span2 = new Span<byte>(mem);
                var a = new Guid[writeRepeatCount];

                for (var i = 0; i < writeRepeatCount; i++)
                {
                    var n = Guid.NewGuid();
                    a[i] = n;
                    span1.MoveWrite(n);
                }

                // Ensure span is not zero
                    Assert.NotEqual(0, span2.ToArray().Select(b => (int)b).Sum());
                for (var i = 0; i < writeRepeatCount; i++)
                {
                    var r = span2.MoveReadGuid();
                    Assert.Equal(a[i], r);
                }
            }

        }


        [Fact]
        public void TestBytes()
        {
            var rnd = new Random();
            for (var c = 0; c < count; c++)
            {
                var memSize = rnd.Next(0, 10_000);
                var mem = new byte[(memSize + 4) * writeRepeatCount];
                var answer = new byte[memSize * writeRepeatCount];
                rnd.NextBytes(answer);
                var span1 = new Span<byte>(mem);
                var span2 = new Span<byte>(mem);

                for (var i = 0; i < writeRepeatCount; i++)
                {
                    var a = new Span<byte>(answer).Slice(memSize * i, memSize).ToArray();
                    span1.MoveWrite(a);
                }

                // Ensure span is not zero
                if (memSize > 0 && answer[0] != 0)
                    Assert.NotEqual(0, span2.ToArray().Select(b => (int)b).Sum());
                var ac = 0;
                for (var wrc = 0; wrc < writeRepeatCount; wrc++)
                {
                    var r = span2.MoveReadBytes(memSize);

                    for (var i = 0; i < r.Length; i++)
                        Assert.Equal(answer[ac++], r[i]);
                }

                Assert.Throws<ArgumentException>(() =>
                {
                    var s = new Span<byte>(mem);
                    s.MoveWrite(new byte[mem.Length + 1]);
                });
            }

        }

        [Fact]
        public void TestSpan()
        {
            var rnd = new Random();
            for (var c = 0; c < count; c++)
            {
                var memSize = rnd.Next(0, 10_000);
                var mem = new byte[(memSize + 4) * writeRepeatCount];
                var answer = new byte[memSize * writeRepeatCount];
                rnd.NextBytes(answer);
                var span1 = new Span<byte>(mem);
                var span2 = new Span<byte>(mem);

                for (var i = 0; i < writeRepeatCount; i++)
                {
                    var a = new Span<byte>(answer).Slice(memSize * i, memSize);
                    span1.MoveWrite(a);
                }

                // Ensure span is not zero
                if (memSize > 0 && answer[0] != 0)
                    Assert.NotEqual(0, span2.ToArray().Select(b => (int)b).Sum());
                var ac = 0;
                for (var wrc = 0; wrc < writeRepeatCount; wrc++)
                {
                    var r = span2.MoveReadBytes(memSize);

                    for (var i = 0; i < r.Length; i++)
                        Assert.Equal(answer[ac++], r[i]);
                }

                Assert.Throws<ArgumentException>(() =>
                {
                    var s = new Span<byte>(mem);
                    s.Write(new Span<byte>(new byte[mem.Length + 1]));
                });
            }
        }

        [Fact]
        public void TestReadOnlySpan()
        {
            var rnd = new Random();
            for (var c = 0; c < count; c++)
            {
                var memSize = rnd.Next(0, 10_000);
                var mem = new byte[(memSize + 4) * writeRepeatCount];
                var answer = new byte[memSize * writeRepeatCount];
                rnd.NextBytes(answer);
                var span1 = new Span<byte>(mem);
                var span2 = new Span<byte>(mem);

                for (var i = 0; i < writeRepeatCount; i++)
                {
                    var a = new ReadOnlySpan<byte>(answer).Slice(memSize * i, memSize);
                    span1.MoveWrite(a);
                }

                // Ensure span is not zero
                if (memSize > 0 && answer[0] != 0)
                    Assert.NotEqual(0, span2.ToArray().Select(b => (int)b).Sum());
                var ac = 0;
                for (var wrc = 0; wrc < writeRepeatCount; wrc++)
                {
                    var r = span2.MoveReadBytes(memSize);

                    for (var i = 0; i < r.Length; i++)
                        Assert.Equal(answer[ac++], r[i]);
                }

                Assert.Throws<ArgumentException>(() =>
                {
                    var s = new Span<byte>(mem);
                    s.MoveWrite(new ReadOnlySpan<byte>(new byte[mem.Length + 1]));
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
                var mem = new byte[(memSize + 4) * writeRepeatCount * 2];
                var answer = new string[writeRepeatCount];
                var span1 = new Span<byte>(mem);
                var span2 = new Span<byte>(mem);

                for (var i = 0; i < writeRepeatCount; i++)
                {
                    var str = rnd.NextString("abcæøå诶	比西αβγ", memSize);
                    answer[i] = str;
                    span1.MoveWriteWithHeader(str);
                }

                // Ensure span is not zero
                if (memSize > 0 && answer[0][0] != 0)
                    Assert.NotEqual(0, span2.ToArray().Select(b => (int)b).Sum());
                for (var i = 0; i < writeRepeatCount; i++)
                {
                    var r = span2.MoveReadStringWithHeader(out var len);
                    Assert.Equal(answer[i], r);
                }
            }

        }


    }
}
