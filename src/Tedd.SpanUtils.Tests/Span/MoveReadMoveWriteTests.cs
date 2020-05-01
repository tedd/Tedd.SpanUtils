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
                var memSize = rnd.Next(1, 10_000);
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
                var memSize = rnd.Next(1, 10_000);
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
                var memSize = rnd.Next(1, 10_000);
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
        public void TestSizedBytes()
        {
            var rnd = new Random();
            for (var c = 0; c < count; c++)
            {
                var memSize = rnd.Next(1, 10_000);
                var mem = new byte[(memSize + 4) * writeRepeatCount];
                var answer = new byte[memSize * writeRepeatCount];
                rnd.NextBytes(answer);
                var span1 = new Span<byte>(mem);
                var span2 = new Span<byte>(mem);

                for (var i = 0; i < writeRepeatCount; i++)
                {
                    var a = new Span<byte>(answer).Slice(memSize * i, memSize).ToArray();
                    span1.MoveSizedWrite(a);
                }

                // Ensure span is not zero
                if (memSize > 0 && answer[0] != 0)
                    Assert.NotEqual(0, span2.ToArray().Select(b => (int)b).Sum());
                var ac = 0;
                for (var wrc = 0; wrc < writeRepeatCount; wrc++)
                {
                    var r = span2.MoveSizedReadBytes(out var len);

                    for (var i = 0; i < r.Length; i++)
                        Assert.Equal(answer[ac++], r[i]);
                }

                Assert.Throws<ArgumentException>(() =>
                {
                    var s = new Span<byte>(mem);
                    s.MoveSizedWrite(new Span<byte>(new byte[s.Length + 1]));
                });
            }

        }


        [Fact]
        public void TestSizedReadString()
        {
            var rnd = new Random();
            for (var c = 0; c < count; c++)
            {
                var memSize = rnd.Next(0, 1024);
                var mem = new byte[(memSize + 4) * writeRepeatCount * 4];
                var answer = new string[writeRepeatCount];
                var span1 = new Span<byte>(mem);
                var span2 = new Span<byte>(mem);

                for (var i = 0; i < writeRepeatCount; i++)
                {
                    var str = rnd.NextString("abcæøå诶	比西αβγ", memSize);
                    answer[i] = str;
                    span1.MoveSizedWrite(str);
                }

                // Ensure span is not zero
                if (memSize > 0 && answer[0][0] != 0)
                    Assert.NotEqual(0, span2.ToArray().Select(b => (int)b).Sum());
                for (var i = 0; i < writeRepeatCount; i++)
                {
                    var r = span2.MoveSizedReadString(out var len);
                    Assert.Equal(answer[i], r);
                }
            }

        }

        [Fact]
        public void TestSize()
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
                    var sr = rnd.Next(0, 4);
#pragma warning disable 8509
                    var n = sr switch
#pragma warning restore 8509
                    {
                        0 => (UInt32)rnd.Next(0, 0b00111111),
                        1 => (UInt32)rnd.Next(0b01000000, 0b00111111_11111111),
                        2 => (UInt32)rnd.Next(0b01000000_00000000, 0b00111111_11111111_11111111),
                        3 => (UInt32)rnd.Next(0b01000000_00000000_00000000, 0b00111111_11111111_11111111_11111111)
                    };

                    a[i] = n;
                    span1.MoveWriteSize(n);
                }

                // Ensure span is not zero
                Assert.NotEqual(0, span2.ToArray().Select(b => (int)b).Sum());
                for (var i = 0; i < writeRepeatCount; i++)
                {
                    var r = span2.MoveReadSize(out var len);
                    Assert.Equal(span2.MeasureWriteSize(a[i]), len);
                    Assert.Equal(a[i], r);
                }
            }
        }

        [Fact]
        public void TestSpanMove()
        {
            var rnd = new Random();
            for (var c = 0; c < count; c++)
            {
                var memSize = 10_000;
                var mem = new byte[memSize * 10];
                var answer = new byte[memSize];
                for (var i = 0; i < memSize; i++)
                    answer[i] = (byte)rnd.Next(0, 10);
                var span1 = new Span<byte>(mem);
                var span2 = new Span<byte>(mem);

                for (var i = 0; i < memSize; i++)
                {
                    span1.Move(answer[i]);
                    span1.MoveWrite(answer[i]);
                }

                // Ensure span is not zero
                if (memSize > 0 && answer[0] != 0)
                    Assert.NotEqual(0, span2.ToArray().Select(b => (int)b).Sum());
                for (var i = 0; i < memSize; i++)
                {
                    if (answer[i] > 1)
                        Assert.Equal(0, span2[1]);
                    span2.Move(answer[i]);
                    var r = span2.MoveReadByte();
                    Assert.Equal(answer[i], r);
                }

                Assert.Throws<ArgumentException>(() =>
                {
                    var s = new Span<byte>(mem);
                    s.MoveSizedWrite(new Span<byte>(new byte[s.Length + 1]));
                });

            }

        }

        #region VLQ
        [Fact]
        public void TestVLQInt16()
        {
            var rnd = new Random();
            for (var c = 0; c < count; c++)
            {
                var memSize = rnd.Next(1, 10_000);
                var mem = new byte[memSize * Utils.MeasureVLQ(UInt16.MaxValue) + 1];
                var span1 = new Span<byte>(mem);
                var span2 = new Span<byte>(mem);

                var data = new Int16[memSize];
                for (var i = 0; i < memSize; i++)
                    data[i] = rnd.NextInt16();

                for (var i = 0; i < memSize; i++)
                    span1.MoveWriteVLQ(data[i]);

                for (var i = 0; i < memSize; i++)
                {
                    Assert.Equal(data[i], span2.MoveReadVLQInt16(out var len));
                    Assert.Equal(Utils.MeasureVLQ(data[i]), len);
                }

                // Check overflow
                new Span<byte>(mem).Fill(0xFF);
                Assert.Throws<OverflowException>(() =>
                {
                    var span3 = new Span<byte>(mem);
                    span3.ReadVLQInt16(out _);
                });

            }
        }

        [Fact]
        public void TestVLQUInt16()
        {
            var rnd = new Random();
            for (var c = 0; c < count; c++)
            {
                var memSize = rnd.Next(1, 10_000);
                var mem = new byte[memSize * Utils.MeasureVLQ(UInt16.MaxValue) + 1];
                var span1 = new Span<byte>(mem);
                var span2 = new Span<byte>(mem);

                var data = new UInt16[memSize];
                for (var i = 0; i < memSize; i++)
                    data[i] = rnd.NextUInt16();

                for (var i = 0; i < memSize; i++)
                    span1.MoveWriteVLQ(data[i]);

                for (var i = 0; i < memSize; i++)
                {
                    Assert.Equal(data[i], span2.MoveReadVLQUInt16(out var len));
                    Assert.Equal(Utils.MeasureVLQ(data[i]), len);
                }

                // Check overflow
                new Span<byte>(mem).Fill(0xFF);
                Assert.Throws<OverflowException>(() =>
                {
                    var span3 = new Span<byte>(mem);
                    span3.ReadVLQUInt16(out _);
                });

            }
        }
        [Fact]
        public void TestVLQUInt24()
        {
            var rnd = new Random();
            for (var c = 0; c < count; c++)
            {
                var memSize = rnd.Next(1, 10_000);
                var mem = new byte[memSize * Utils.MeasureVLQ((UInt24)UInt24.MaxValue) + 1];
                var span1 = new Span<byte>(mem);
                var span2 = new Span<byte>(mem);

                var data = new UInt24[memSize];
                for (var i = 0; i < memSize; i++)
                    data[i] = rnd.NextUInt32().ToUInt24();

                for (var i = 0; i < memSize; i++)
                    span1.MoveWriteVLQ(data[i]);

                for (var i = 0; i < memSize; i++)
                {
                    Assert.Equal(data[i], span2.MoveReadVLQUInt24(out var len));
                    Assert.Equal(Utils.MeasureVLQ(data[i]), len);
                }

                // Check overflow
                new Span<byte>(mem).Fill(0xFF);
                Assert.Throws<OverflowException>(() =>
                {
                    var span3 = new Span<byte>(mem);
                    span3.ReadVLQUInt24(out _);
                });

            }
        }
        [Fact]
        public void TestVLQInt32()
        {
            var rnd = new Random();
            for (var c = 0; c < count; c++)
            {
                var memSize = rnd.Next(1, 10_000);
                var mem = new byte[memSize * Utils.MeasureVLQ(UInt32.MaxValue) + 1];
                var span1 = new Span<byte>(mem);
                var span2 = new Span<byte>(mem);

                var data = new Int32[memSize];
                for (var i = 0; i < memSize; i++)
                    data[i] = rnd.NextInt32();

                for (var i = 0; i < memSize; i++)
                    span1.MoveWriteVLQ(data[i]);

                for (var i = 0; i < memSize; i++)
                {
                    Assert.Equal(data[i], span2.MoveReadVLQInt32(out var len));
                    Assert.Equal(Utils.MeasureVLQ(data[i]), len);
                }

                // Check overflow
                new Span<byte>(mem).Fill(0xFF);
                Assert.Throws<OverflowException>(() =>
                {
                    var span3 = new Span<byte>(mem);
                    span3.ReadVLQInt32(out _);
                });

            }
        }

        [Fact]
        public void TestVLQUInt32()
        {
            var rnd = new Random();
            for (var c = 0; c < count; c++)
            {
                var memSize = rnd.Next(1, 10_000);
                var mem = new byte[memSize * Utils.MeasureVLQ(UInt32.MaxValue)+1];
                var span1 = new Span<byte>(mem);
                var span2 = new Span<byte>(mem);

                var data = new UInt32[memSize];
                for (var i = 0; i < memSize; i++)
                    data[i] = rnd.NextUInt32();

                for (var i = 0; i < memSize; i++)
                    span1.MoveWriteVLQ(data[i]);

                for (var i = 0; i < memSize; i++)
                {
                    Assert.Equal(data[i], span2.MoveReadVLQUInt32(out var len));
                    Assert.Equal(Utils.MeasureVLQ(data[i]), len);
                }

                // Check overflow
                new Span<byte>(mem).Fill(0xFF);
                Assert.Throws<OverflowException>(() =>
                {
                    var span3 = new Span<byte>(mem);
                    span3.ReadVLQUInt32(out _);
                });

            }
        }
        [Fact]
        public void TestVLQInt64()
        {
            var rnd = new Random();
            for (var c = 0; c < count; c++)
            {
                var memSize = rnd.Next(1, 10_000);
                var mem = new byte[memSize * Utils.MeasureVLQ(UInt64.MaxValue) + 1];
                var span1 = new Span<byte>(mem);
                var span2 = new Span<byte>(mem);

                var data = new Int64[memSize];
                for (var i = 0; i < memSize; i++)
                    data[i] = rnd.NextInt64();

                for (var i = 0; i < memSize; i++)
                    span1.MoveWriteVLQ(data[i]);

                for (var i = 0; i < memSize; i++)
                {
                    Assert.Equal(data[i], span2.MoveReadVLQInt64(out var len));
                    Assert.Equal(Utils.MeasureVLQ(data[i]), len);
                }

                // Check overflow
                new Span<byte>(mem).Fill(0xFF);
                Assert.Throws<OverflowException>(() =>
                {
                    var span3 = new Span<byte>(mem);
                    span3.ReadVLQInt64(out _);
                });

            }
        }

        [Fact]
        public void TestVLQUInt64()
        {
            var rnd = new Random();
            for (var c = 0; c < count; c++)
            {
                var memSize = rnd.Next(1, 10_000);
                var mem = new byte[memSize * Utils.MeasureVLQ(UInt64.MaxValue) + 1];
                var span1 = new Span<byte>(mem);
                var span2 = new Span<byte>(mem);

                var data = new UInt64[memSize];
                for (var i = 0; i < memSize; i++)
                    data[i] = rnd.NextUInt64();

                for (var i = 0; i < memSize; i++)
                    span1.MoveWriteVLQ(data[i]);

                for (var i = 0; i < memSize; i++)
                {
                    Assert.Equal(data[i], span2.MoveReadVLQUInt64(out var len));
                    Assert.Equal(Utils.MeasureVLQ(data[i]), len);
                }

                // Check overflow
                new Span<byte>(mem).Fill(0xFF);
                Assert.Throws<OverflowException>(() =>
                {
                    var span3 = new Span<byte>(mem);
                    span3.ReadVLQUInt64(out _);
                });

            }
        }
        #endregion
    }
}
