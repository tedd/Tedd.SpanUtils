using System;
using System.Linq;
using Xunit;
using Tedd;

namespace Tedd.SpanUtils.Tests.ReadOnlySpan
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
                var span2 = new ReadOnlySpan<byte>(mem);
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
                var span2 = new ReadOnlySpan<byte>(mem);
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
                var span2 = new ReadOnlySpan<byte>(mem);
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
                var span2 = new ReadOnlySpan<byte>(mem);
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
                var span2 = new ReadOnlySpan<byte>(mem);
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
                var span2 = new ReadOnlySpan<byte>(mem);
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
                var span2 = new ReadOnlySpan<byte>(mem);
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
                var span2 = new ReadOnlySpan<byte>(mem);
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
                var span2 = new ReadOnlySpan<byte>(mem);
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
                var span2 = new ReadOnlySpan<byte>(mem);
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



        //        [Fact]
        //        public void TestSize()
        //        {
        //            var mem = new byte[4];
        //            var rnd = new Random();
        //            for (var c = 0; c < count * 100_000; c++)
        //            {
        //                var sr = rnd.Next(0, 4);
        //#pragma warning disable 8509
        //                var a = sr switch
        //#pragma warning restore 8509
        //                {
        //                    0 => (UInt32)rnd.Next(0, 0b00111111),
        //                    1 => (UInt32)rnd.Next(0, 0b00111111_11111111),
        //                    2 => (UInt32)rnd.Next(0, 0b00111111_11111111_11111111),
        //                    3 => (UInt32)rnd.Next(0, 0b00111111_11111111_11111111_11111111)
        //                };
        //                var span1 = new Span<byte>(mem);
        //                span1.Fill(0);
        //                var span2 = new ReadOnlySpan<byte>(mem);

        //                var s = span1.WriteSize(a);
        //                // Number of bytes must match
        //                Assert.Equal(sr + 1, s);
        //                // Size must match
        //                var bs = span2.MoveReadSize(out var size);
        //                Assert.Equal(bs, s);
        //                Assert.Equal(a, size);
        //            }

        //        }

        [Fact]
        public void TestBytesWithHeader()
        {
            var rnd = new Random();
            for (var c = 0; c < count; c++)
            {
                var memSize = rnd.Next(0, 10_000);
                var mem = new byte[(memSize + 4) * writeRepeatCount];
                var answer = new byte[memSize * writeRepeatCount];
                rnd.NextBytes(answer);
                var span1 = new Span<byte>(mem);
                var span2 = new ReadOnlySpan<byte>(mem);

                for (var i = 0; i < writeRepeatCount; i++)
                {
                    var a = new Span<byte>(answer).Slice(memSize * i, memSize).ToArray();
                    span1.MoveWriteWithHeader(a);
                }

                // Ensure span is not zero
                if (memSize > 0 && answer[0] != 0)
                    Assert.NotEqual(0, span2.ToArray().Select(b => (int)b).Sum());
                var ac = 0;
                for (var wrc = 0; wrc < writeRepeatCount; wrc++)
                {
                    var r = span2.MoveReadBytesWithHeader(out var len);

                    for (var i = 0; i < r.Length; i++)
                        Assert.Equal(answer[ac++], r[i]);
                }

                Assert.Throws<ArgumentException>(() =>
                {
                    var s = new Span<byte>(mem);
                    s.MoveWriteWithHeader(new byte[mem.Length + 1]);
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
                var mem = new byte[(memSize + 4) * writeRepeatCount];
                var answer = new byte[memSize * writeRepeatCount];
                rnd.NextBytes(answer);
                var span1 = new Span<byte>(mem);
                var span2 = new ReadOnlySpan<byte>(mem);

                for (var i = 0; i < writeRepeatCount; i++)
                {
                    var a = new Span<byte>(answer).Slice(memSize * i, memSize);
                    span1.MoveWriteWithHeader(a);
                }

                // Ensure span is not zero
                if (memSize > 0 && answer[0] != 0)
                    Assert.NotEqual(0, span2.ToArray().Select(b => (int)b).Sum());
                var ac = 0;
                for (var wrc = 0; wrc < writeRepeatCount; wrc++)
                {
                    var r = span2.MoveReadBytesWithHeader(out var len);

                    for (var i = 0; i < r.Length; i++)
                        Assert.Equal(answer[ac++], r[i]);
                }

                Assert.Throws<ArgumentException>(() =>
                {
                    var s = new Span<byte>(mem);
                    s.MoveWriteWithHeader(new Span<byte>(new byte[mem.Length + 1]));
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
                var mem = new byte[(memSize + 4) * writeRepeatCount];
                var answer = new byte[memSize * writeRepeatCount];
                rnd.NextBytes(answer);
                var span1 = new Span<byte>(mem);
                var span2 = new ReadOnlySpan<byte>(mem);

                for (var i = 0; i < writeRepeatCount; i++)
                {
                    var a = new ReadOnlySpan<byte>(answer).Slice(memSize * i, memSize);
                    span1.MoveWriteWithHeader(a);
                }

                // Ensure span is not zero
                if (memSize > 0 && answer[0] != 0)
                    Assert.NotEqual(0, span2.ToArray().Select(b => (int)b).Sum());
                var ac = 0;
                for (var wrc = 0; wrc < writeRepeatCount; wrc++)
                {
                    var r = span2.MoveReadBytesWithHeader(out var len);

                    for (var i = 0; i < r.Length; i++)
                        Assert.Equal(answer[ac++], r[i]);
                }

                Assert.Throws<ArgumentException>(() =>
                {
                    var s = new Span<byte>(mem);
                    s.MoveWriteWithHeader(new ReadOnlySpan<byte>(new byte[mem.Length + 1]));
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
                var mem = new byte[(1024 + 4) * writeRepeatCount*2];
                var answer = new string[writeRepeatCount];
                var span1 = new Span<byte>(mem);
                var span2 = new ReadOnlySpan<byte>(mem);

                for (var i = 0; i < writeRepeatCount; i++)
                {
                    var str = rnd.NextString("abcæøå诶	比西αβγ", memSize);
                    //var str = rnd.NextString("abcdefghijklm", rnd.Next(0, 1024));
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
