using System;
using System.Data;
using System.Linq;
using Xunit;
using Tedd;

namespace Tedd.SpanUtilsTests.Span
{
    public class MemoryStreamerTests
    {
        private int count = 100;
        private int writeRepeatCount = 10;

        #region Standard Stream Read Write
        [Fact]
        public void TestStreamReadWrite()
        {
            var rnd = new Random();
            for (var c = 0; c < count; c++)
            {
                var memSize = rnd.Next(1, 10_000);
                var mem = new byte[(memSize + 4) * writeRepeatCount];
                var answer = new byte[memSize * writeRepeatCount];
                rnd.NextBytes(answer);

                for (var bc = 1; bc < writeRepeatCount; bc++)
                {
                    for (var offset = 0; offset < bc; offset++)
                    {
                        var span1 = new MemoryStreamer(mem);
                        var span2 = new MemoryStreamer(mem);

                        span1.Write(answer, offset, bc - offset);
                        var buffer = new byte[bc + offset];
                        span2.Read(buffer, offset, bc - offset);

                        Assert.Equal(new Span<byte>(answer).Slice(offset, bc - offset).ToArray(), new Memory<byte>(buffer).Slice(offset, bc - offset).ToArray());
                    }
                }

                Assert.Throws<ArgumentNullException>(() =>
                {
                    var s = new MemoryStreamer(mem);
                    s.Read(null, 0, 1);
                });
            }
        }
        #endregion


        [Fact]
        public void TestLength()
        {
            var mem = new byte[100];
            var ss = new MemoryStreamer(mem);
            Assert.Equal(100, ss.Length);
            Assert.Equal(100, ss.MaxLength);
            ss.SetLength(0);
            Assert.Equal(0, ss.Length);
            ss.Write((UInt32)0);
            Assert.Equal(4, ss.Length);
            ss.Clear();
            Assert.Equal(0, ss.Length);
        }
        [Fact]
        public void TestOtherStreamStuff()
        {
            var mem = new byte[2];
            var ms = new MemoryStreamer(mem);
            Assert.Throws<ArgumentOutOfRangeException>(() => ms.SetLength(mem.Length + 1));
            ms.Flush();
        }

        [Fact]
        public void TestSizedReadWriteSpan()
        {
            var rnd = new Random();
            for (var c = 0; c < count; c++)
            {
                var memSize = rnd.Next(1, 10_000);
                var mem = new byte[(memSize + 4) * writeRepeatCount];
                var answer = new byte[memSize * writeRepeatCount];
                rnd.NextBytes(answer);

                var span1 = new MemoryStreamer(mem);
                var span2 = new MemoryStreamer(mem);
                span1.WriteSized(new Span<byte>(answer));
                span1.Write(1234);

                var bytes = span2.ReadSizedBytes(out var length);
                Assert.Equal(answer, bytes);
                Assert.Equal(1234, span2.ReadInt32());
            }
        }

        [Fact]
        public void TestSizedReadWriteReadOnlyMemory()
        {
            var rnd = new Random();
            for (var c = 0; c < count; c++)
            {
                var memSize = rnd.Next(1, 10_000);
                var mem = new byte[(memSize + 4) * writeRepeatCount + 10];
                var answer = new byte[memSize * writeRepeatCount];
                rnd.NextBytes(answer);

                var span1 = new MemoryStreamer(mem);
                var span2 = new ReadOnlyMemoryStreamer(new ReadOnlyMemory<byte>(mem));
                span1.WriteSized(new Span<byte>(answer));
                span1.Write(1234);

                var bytes = span2.ReadSizedBytes(out var length);
                Assert.Equal(answer, bytes);
                Assert.Equal(1234, span2.ReadInt32());
            }
        }

        [Fact]
        public void TestSizedReadWriteBytes()
        {
            var rnd = new Random();
            for (var c = 0; c < count; c++)
            {
                var memSize = rnd.Next(1, 10_000);
                var mem = new byte[(memSize + 4) * writeRepeatCount];
                var answer = new byte[memSize * writeRepeatCount];
                rnd.NextBytes(answer);

                var span1 = new MemoryStreamer(mem);
                var span2 = new MemoryStreamer(mem);
                span1.WriteSized(answer);
                span1.Write(1234);

                var bytes = span2.ReadSizedBytes(out var length);
                Assert.Equal(answer, bytes);
                Assert.Equal(1234, span2.ReadInt32());
            }
        }


        [Fact]
        public void TestCanReadCanWrite()
        {
            var mem = new byte[2];
            var s = new Memory<byte>(mem);
            var ros = new ReadOnlyMemory<byte>(mem);

            var ss = new MemoryStreamer(s);
            Assert.True(ss.CanRead);
            Assert.True(ss.CanWrite);
            Assert.True(ss.CanSeek);
            var ross = new ReadOnlyMemoryStreamer(ros);
            Assert.True(ross.CanRead);
            Assert.False(ross.CanWrite);
            Assert.True(ross.CanSeek);
        }

        //[Fact]
        //public void TestReadOnlyCheck()
        //{
        //    var mem = new byte[100];
        //    Assert.Throws<ReadOnlyException>(() =>
        //    {
        //        new MemoryStreamer(new ReadOnlyMemory<byte>(mem)).WriteSize(1);
        //    });
        //    Assert.Throws<ReadOnlyException>(() =>
        //    {
        //        new MemoryStreamer(new ReadOnlyMemory<byte>(mem)).Write((byte)1);
        //    });
        //    Assert.Throws<ReadOnlyException>(() =>
        //    {
        //        new MemoryStreamer(new ReadOnlyMemory<byte>(mem)).Write((sbyte)1);
        //    });
        //    Assert.Throws<ReadOnlyException>(() =>
        //    {
        //        new MemoryStreamer(new ReadOnlyMemory<byte>(mem)).Write((Int16)1);
        //    });
        //    Assert.Throws<ReadOnlyException>(() =>
        //    {
        //        new MemoryStreamer(new ReadOnlyMemory<byte>(mem)).Write((UInt16)1);
        //    });
        //    Assert.Throws<ReadOnlyException>(() =>
        //    {
        //        new MemoryStreamer(new ReadOnlyMemory<byte>(mem)).Write((UInt24)1);
        //    });
        //    Assert.Throws<ReadOnlyException>(() =>
        //    {
        //        new MemoryStreamer(new ReadOnlyMemory<byte>(mem)).Write((Int32)1);
        //    });
        //    Assert.Throws<ReadOnlyException>(() =>
        //    {
        //        new MemoryStreamer(new ReadOnlyMemory<byte>(mem)).Write((UInt32)1);
        //    });
        //    Assert.Throws<ReadOnlyException>(() =>
        //    {
        //        new MemoryStreamer(new ReadOnlyMemory<byte>(mem)).Write((Int64)1);
        //    });
        //    Assert.Throws<ReadOnlyException>(() =>
        //    {
        //        new MemoryStreamer(new ReadOnlyMemory<byte>(mem)).Write((UInt64)1);
        //    });
        //    Assert.Throws<ReadOnlyException>(() =>
        //    {
        //        new MemoryStreamer(new ReadOnlyMemory<byte>(mem)).WriteVLQ((byte)1);
        //    });
        //    Assert.Throws<ReadOnlyException>(() =>
        //    {
        //        new MemoryStreamer(new ReadOnlyMemory<byte>(mem)).WriteVLQ((sbyte)1);
        //    });
        //    Assert.Throws<ReadOnlyException>(() =>
        //    {
        //        new MemoryStreamer(new ReadOnlyMemory<byte>(mem)).WriteVLQ((Int16)1);
        //    });
        //    Assert.Throws<ReadOnlyException>(() =>
        //    {
        //        new MemoryStreamer(new ReadOnlyMemory<byte>(mem)).WriteVLQ((UInt16)1);
        //    });
        //    Assert.Throws<ReadOnlyException>(() =>
        //    {
        //        new MemoryStreamer(new ReadOnlyMemory<byte>(mem)).WriteVLQ((UInt24)1);
        //    });
        //    Assert.Throws<ReadOnlyException>(() =>
        //    {
        //        new MemoryStreamer(new ReadOnlyMemory<byte>(mem)).WriteVLQ((Int32)1);
        //    });
        //    Assert.Throws<ReadOnlyException>(() =>
        //    {
        //        new MemoryStreamer(new ReadOnlyMemory<byte>(mem)).WriteVLQ((UInt32)1);
        //    });
        //    Assert.Throws<ReadOnlyException>(() =>
        //    {
        //        new MemoryStreamer(new ReadOnlyMemory<byte>(mem)).WriteVLQ((Int64)1);
        //    });
        //    Assert.Throws<ReadOnlyException>(() =>
        //    {
        //        new MemoryStreamer(new ReadOnlyMemory<byte>(mem)).WriteVLQ((UInt64)1);
        //    });
        //    Assert.Throws<ReadOnlyException>(() =>
        //    {
        //        new MemoryStreamer(new ReadOnlyMemory<byte>(mem)).WriteSized("1");
        //    });
        //    Assert.Throws<ReadOnlyException>(() =>
        //    {
        //        new MemoryStreamer(new ReadOnlyMemory<byte>(mem)).WriteSized(new byte[1] { 1 });
        //    });
        //    Assert.Throws<ReadOnlyException>(() =>
        //    {
        //        new MemoryStreamer(new ReadOnlyMemory<byte>(mem)).WriteSized(new Span<byte>(new byte[1] { 1 }));
        //    });
        //    Assert.Throws<ReadOnlyException>(() =>
        //    {
        //        new MemoryStreamer(new ReadOnlyMemory<byte>(mem)).WriteSized(new ReadOnlySpan<byte>(new byte[1] { 1 }));
        //    });
        //    Assert.Throws<ReadOnlyException>(() =>
        //    {
        //        new MemoryStreamer(new ReadOnlyMemory<byte>(mem)).Write(new byte[1] { 1 }, 0, 1);
        //    });
        //    Assert.Throws<ArgumentNullException>(() =>
        //    {
        //        new MemoryStreamer(mem).Write((byte[])null, 0, 1);
        //    });
        //    Assert.Throws<ReadOnlyException>(() =>
        //    {
        //        new MemoryStreamer(new ReadOnlyMemory<byte>(mem)).Write(new Span<byte>(new byte[1] { 1 }));
        //    });
        //    Assert.Throws<ReadOnlyException>(() =>
        //    {
        //        new MemoryStreamer(new ReadOnlyMemory<byte>(mem)).Write(Guid.NewGuid());
        //    });
        //}

        [Fact]
        public void TestPosOverflow()
        {
            var mem = new byte[2];

            {
                var s = new Memory<byte>(mem);
                var ss = new MemoryStreamer(s);
                ss.Position = mem.Length;
                Assert.Equal(mem.Length, ss.Position);
                ss.Position = 0;
                Assert.Equal(0, ss.Position);
            }
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                var s = new Memory<byte>(mem);
                var ss = new MemoryStreamer(s);
                ss.Position = mem.Length + 1;
            });
        }


        [Fact]
        public void TestSByte()
        {
            var rnd = new System.Random();
            for (var c = 0; c < count; c++)
            {
                var mem = new byte[sizeof(SByte) * writeRepeatCount];
                var span1 = new MemoryStreamer(mem);
                var span2 = new MemoryStreamer(mem);
                var a = new sbyte[writeRepeatCount];

                for (var i = 0; i < writeRepeatCount; i++)
                {
                    var n = rnd.NextSByte();
                    a[i] = n;
                    span1.Write(n);
                }

                for (var i = 0; i < writeRepeatCount; i++)
                {
                    var r = span2.ReadSByte();
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
                var span1 = new MemoryStreamer(mem);
                var span2 = new MemoryStreamer(mem);
                var a = new Byte[writeRepeatCount];

                for (var i = 0; i < writeRepeatCount; i++)
                {
                    var n = rnd.NextByte();
                    a[i] = n;
                    span1.Write(n);
                }

                for (var i = 0; i < writeRepeatCount; i++)
                {
                    var r = span2.ReadByte();
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
                var span1 = new MemoryStreamer(mem);
                var span2 = new MemoryStreamer(mem);
                var a = new Int16[writeRepeatCount];

                for (var i = 0; i < writeRepeatCount; i++)
                {
                    var n = rnd.NextInt16();
                    a[i] = n;
                    span1.Write(n);
                }

                for (var i = 0; i < writeRepeatCount; i++)
                {
                    var r = span2.ReadInt16();
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
                var span1 = new MemoryStreamer(mem);
                var span2 = new MemoryStreamer(mem);
                var a = new UInt16[writeRepeatCount];

                for (var i = 0; i < writeRepeatCount; i++)
                {
                    var n = rnd.NextUInt16();
                    a[i] = n;
                    span1.Write(n);
                }

                for (var i = 0; i < writeRepeatCount; i++)
                {
                    var r = span2.ReadUInt16();
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
                var span1 = new MemoryStreamer(mem);
                var span2 = new MemoryStreamer(mem);
                var a = new UInt24[writeRepeatCount];

                for (var i = 0; i < writeRepeatCount; i++)
                {
                    var n = rnd.NextUInt32().ToUInt24();
                    a[i] = n;
                    span1.Write(n);
                }

                for (var i = 0; i < writeRepeatCount; i++)
                {
                    var r = span2.ReadUInt24();
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
                var span1 = new MemoryStreamer(mem);
                var span2 = new MemoryStreamer(mem);
                var a = new Int32[writeRepeatCount];

                for (var i = 0; i < writeRepeatCount; i++)
                {
                    var n = rnd.NextInt32();
                    a[i] = n;
                    span1.Write(n);
                }

                for (var i = 0; i < writeRepeatCount; i++)
                {
                    var r = span2.ReadInt32();
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
                var span1 = new MemoryStreamer(mem);
                var span2 = new MemoryStreamer(mem);
                var a = new UInt32[writeRepeatCount];


                for (var i = 0; i < writeRepeatCount; i++)
                {
                    var n = rnd.NextUInt32();
                    a[i] = n;
                    span1.Write(n);
                }

                for (var i = 0; i < writeRepeatCount; i++)
                {
                    var r = span2.ReadUInt32();
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
                var span1 = new MemoryStreamer(mem);
                var span2 = new MemoryStreamer(mem);
                var a = new Int64[writeRepeatCount];

                for (var i = 0; i < writeRepeatCount; i++)
                {
                    var n = rnd.NextInt64();
                    a[i] = n;
                    span1.Write(n);
                }

                for (var i = 0; i < writeRepeatCount; i++)
                {
                    var r = span2.ReadInt64();
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
                var span1 = new MemoryStreamer(mem);
                var span2 = new MemoryStreamer(mem);
                var a = new UInt64[writeRepeatCount];

                for (var i = 0; i < writeRepeatCount; i++)
                {
                    var n = rnd.NextUInt64();
                    a[i] = n;
                    span1.Write(n);
                }

                for (var i = 0; i < writeRepeatCount; i++)
                {
                    var r = span2.ReadUInt64();
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
                var span1 = new MemoryStreamer(mem);
                var span2 = new MemoryStreamer(mem);
                var a = new Guid[writeRepeatCount];

                for (var i = 0; i < writeRepeatCount; i++)
                {
                    var n = Guid.NewGuid();
                    a[i] = n;
                    span1.Write(n);
                }

                for (var i = 0; i < writeRepeatCount; i++)
                {
                    var r = span2.ReadGuid();
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
                var span1 = new MemoryStreamer(mem);
                var span2 = new MemoryStreamer(mem);

                for (var i = 0; i < writeRepeatCount; i++)
                {
                    var a = new Span<byte>(answer).Slice(memSize * i, memSize).ToArray();
                    span1.Write(a);
                }

                // Ensure span is not zero
                var ac = 0;
                for (var wrc = 0; wrc < writeRepeatCount; wrc++)
                {
                    var r = span2.ReadBytes(memSize);

                    for (var i = 0; i < r.Length; i++)
                        Assert.Equal(answer[ac++], r[i]);
                }

                Assert.Throws<ArgumentException>(() =>
                {
                    var s = new MemoryStreamer(mem);
                    s.Write(new byte[mem.Length + 1]);
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
                var span1 = new MemoryStreamer(mem);
                var span2 = new MemoryStreamer(mem);

                for (var i = 0; i < writeRepeatCount; i++)
                {
                    var a = new Span<byte>(answer).Slice(memSize * i, memSize);
                    span1.Write(a);
                }

                var ac = 0;
                for (var wrc = 0; wrc < writeRepeatCount; wrc++)
                {
                    var r = span2.ReadBytes(memSize);

                    for (var i = 0; i < r.Length; i++)
                        Assert.Equal(answer[ac++], r[i]);
                }

                Assert.Throws<ArgumentException>(() =>
                {
                    var s = new MemoryStreamer(mem);
                    s.Write(new Span<byte>(new byte[mem.Length + 1]));
                });
            }
        }

        [Fact]
        public void TestReadOnlyMemory()
        {
            var rnd = new Random();
            for (var c = 0; c < count; c++)
            {
                var memSize = rnd.Next(1, 10_000);
                var mem = new byte[(memSize + 4) * writeRepeatCount];
                var answer = new byte[memSize * writeRepeatCount];
                rnd.NextBytes(answer);
                var span1 = new MemoryStreamer(mem);
                var span2 = new MemoryStreamer(mem);

                for (var i = 0; i < writeRepeatCount; i++)
                {
                    var a = new Span<byte>(answer).Slice(memSize * i, memSize);
                    span1.Write(a);
                }

                // Ensure span is not zero
                var ac = 0;
                for (var wrc = 0; wrc < writeRepeatCount; wrc++)
                {
                    var r = span2.ReadBytes(memSize);

                    for (var i = 0; i < r.Length; i++)
                        Assert.Equal(answer[ac++], r[i]);
                }

                Assert.Throws<ArgumentException>(() =>
                {
                    var s = new MemoryStreamer(mem);
                    s.Write(new Span<byte>(new byte[mem.Length + 1]));
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
                var span1 = new MemoryStreamer(mem);
                var span2 = new MemoryStreamer(mem);

                for (var i = 0; i < writeRepeatCount; i++)
                {
                    var a = new Span<byte>(answer).Slice(memSize * i, memSize).ToArray();
                    span1.WriteSized(a);
                }

                var ac = 0;
                for (var wrc = 0; wrc < writeRepeatCount; wrc++)
                {
                    var r = span2.ReadSizedBytes(out var len);

                    for (var i = 0; i < r.Length; i++)
                        Assert.Equal(answer[ac++], r[i]);
                }

                Assert.Throws<ArgumentException>(() =>
                {
                    var s = new MemoryStreamer(mem);
                    s.WriteSized(new Span<byte>(new byte[mem.Length + 1]));
                });
            }

        }
        [Fact]
        public void TestSizedSpan()
        {
            var rnd = new Random();
            for (var c = 0; c < count; c++)
            {
                var memSize = rnd.Next(1, 10_000);
                var mem = new byte[(memSize + 4) * writeRepeatCount];
                var answer = new byte[memSize * writeRepeatCount];
                rnd.NextBytes(answer);
                var span1 = new MemoryStreamer(mem);
                var span2 = new MemoryStreamer(mem);

                for (var i = 0; i < writeRepeatCount; i++)
                {
                    var a = new ReadOnlySpan<byte>(answer).Slice(memSize * i, memSize);
                    span1.WriteSized(a);
                }

                var ac = 0;
                for (var wrc = 0; wrc < writeRepeatCount; wrc++)
                {
                    var r = span2.ReadSizedBytes(out var len);

                    for (var i = 0; i < r.Length; i++)
                        Assert.Equal(answer[ac++], r[i]);
                }

                Assert.Throws<ArgumentException>(() =>
                {
                    var s = new MemoryStreamer(mem);
                    s.WriteSized(new Span<byte>(new byte[mem.Length + 1]));
                });
            }

        }


        [Fact]
        public void TestSizedString()
        {
            var rnd = new Random();
            for (var c = 0; c < count; c++)
            {
                var memSize = rnd.Next(0, 1024);
                var mem = new byte[(memSize + 4) * writeRepeatCount * 4];
                var answer = new string[writeRepeatCount];
                var span1 = new MemoryStreamer(mem);
                var span2 = new MemoryStreamer(mem);

                for (var i = 0; i < writeRepeatCount; i++)
                {
                    var str = rnd.NextString("abcæøå诶	比西αβγ", memSize);
                    answer[i] = str;
                    span1.WriteSized(str);
                }

                for (var i = 0; i < writeRepeatCount; i++)
                {
                    var r = span2.ReadSizedString(out var len);
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
                var span1 = new MemoryStreamer(mem);
                var span2 = new MemoryStreamer(mem);
                var a = new UInt32[writeRepeatCount];

                for (var i = 0; i < writeRepeatCount; i++)
                {
                    var sr = rnd.Next(0, 4);
                    uint n;
                    switch (sr)
                    {
                        case 0:
                            n = (UInt32)rnd.Next(0, 0b00111111);
                            break;
                        case 1:
                            n = (UInt32)rnd.Next(0b01000000, 0b00111111_11111111);
                            break;
                        case 2:
                            n = (UInt32)rnd.Next(0b01000000_00000000, 0b00111111_11111111_11111111);
                            break;
                        //case 3:
                        default:
                            n = (UInt32)rnd.Next(0b01000000_00000000_00000000, 0b00111111_11111111_11111111_11111111);
                            break;
                    }

                    a[i] = n;
                    span1.WriteSize(n);
                }

                for (var i = 0; i < writeRepeatCount; i++)
                {
                    var r = span2.ReadSize(out var len);
                    Assert.Equal(span2.MeasureWriteSize(a[i]), len);
                    Assert.Equal(a[i], r);
                }
            }
        }

        [Fact]
        public void TestPosition()
        {
            var rnd = new Random();
            for (var c = 0; c < count; c++)
            {
                var memSize = 10_000;
                var mem = new byte[memSize * 10];
                var answer = new byte[memSize];
                for (var i = 0; i < memSize; i++)
                    answer[i] = (byte)rnd.Next(0, 10);
                var span1 = new MemoryStreamer(mem);
                var span2 = new MemoryStreamer(mem);

                for (var i = 0; i < memSize; i++)
                {
                    span1.Position += answer[i];
                    span1.Write(answer[i]);
                }

                // Ensure span is not zero
                for (var i = 0; i < memSize; i++)
                {

                    span2.Position += answer[i];
                    var r = span2.ReadByte();
                    Assert.Equal(answer[i], r);
                }



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
                var mem = new byte[memSize * SpanUtils.MeasureVLQ(UInt16.MaxValue) + 1];
                var span1 = new MemoryStreamer(mem);
                var span2 = new MemoryStreamer(mem);

                var data = new Int16[memSize];
                for (var i = 0; i < memSize; i++)
                    data[i] = rnd.NextInt16();

                for (var i = 0; i < memSize; i++)
                    span1.WriteVLQ(data[i]);

                for (var i = 0; i < memSize; i++)
                {
                    Assert.Equal(data[i], span2.ReadVLQInt16(out var len));
                    Assert.Equal(SpanUtils.MeasureVLQ(data[i]), len);
                }

                // Check overflow
                new Span<byte>(mem).Fill(0xFF);
                Assert.Throws<OverflowException>(() =>
                {
                    var span3 = new MemoryStreamer(mem);
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
                var mem = new byte[memSize * SpanUtils.MeasureVLQ(UInt16.MaxValue) + 1];
                var span1 = new MemoryStreamer(mem);
                var span2 = new MemoryStreamer(mem);

                var data = new UInt16[memSize];
                for (var i = 0; i < memSize; i++)
                    data[i] = rnd.NextUInt16();

                for (var i = 0; i < memSize; i++)
                    span1.WriteVLQ(data[i]);

                for (var i = 0; i < memSize; i++)
                {
                    Assert.Equal(data[i], span2.ReadVLQUInt16(out var len));
                    Assert.Equal(SpanUtils.MeasureVLQ(data[i]), len);
                }

                // Check overflow
                new Span<byte>(mem).Fill(0xFF);
                Assert.Throws<OverflowException>(() =>
                {
                    var span3 = new MemoryStreamer(mem);
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
                var mem = new byte[memSize * SpanUtils.MeasureVLQ((UInt24)UInt24.MaxValue) + 1];
                var span1 = new MemoryStreamer(mem);
                var span2 = new MemoryStreamer(mem);

                var data = new UInt24[memSize];
                for (var i = 0; i < memSize; i++)
                    data[i] = rnd.NextUInt32().ToUInt24();

                for (var i = 0; i < memSize; i++)
                    span1.WriteVLQ(data[i]);

                for (var i = 0; i < memSize; i++)
                {
                    Assert.Equal(data[i], span2.ReadVLQUInt24(out var len));
                    Assert.Equal(SpanUtils.MeasureVLQ(data[i]), len);
                }

                // Check overflow
                new Span<byte>(mem).Fill(0xFF);
                Assert.Throws<OverflowException>(() =>
                {
                    var span3 = new MemoryStreamer(mem);
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
                var mem = new byte[memSize * SpanUtils.MeasureVLQ(UInt32.MaxValue) + 1];
                var span1 = new MemoryStreamer(mem);
                var span2 = new MemoryStreamer(mem);

                var data = new Int32[memSize];
                for (var i = 0; i < memSize; i++)
                    data[i] = rnd.NextInt32();

                for (var i = 0; i < memSize; i++)
                    span1.WriteVLQ(data[i]);

                for (var i = 0; i < memSize; i++)
                {
                    Assert.Equal(data[i], span2.ReadVLQInt32(out var len));
                    Assert.Equal(SpanUtils.MeasureVLQ(data[i]), len);
                }

                // Check overflow
                new Span<byte>(mem).Fill(0xFF);
                Assert.Throws<OverflowException>(() =>
                {
                    var span3 = new MemoryStreamer(mem);
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
                var mem = new byte[memSize * SpanUtils.MeasureVLQ(UInt32.MaxValue) + 1];
                var span1 = new MemoryStreamer(mem);
                var span2 = new MemoryStreamer(mem);

                var data = new UInt32[memSize];
                for (var i = 0; i < memSize; i++)
                    data[i] = rnd.NextUInt32();

                for (var i = 0; i < memSize; i++)
                    span1.WriteVLQ(data[i]);

                for (var i = 0; i < memSize; i++)
                {
                    Assert.Equal(data[i], span2.ReadVLQUInt32(out var len));
                    Assert.Equal(SpanUtils.MeasureVLQ(data[i]), len);
                }

                // Check overflow
                new Span<byte>(mem).Fill(0xFF);
                Assert.Throws<OverflowException>(() =>
                {
                    var span3 = new MemoryStreamer(mem);
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
                var mem = new byte[memSize * SpanUtils.MeasureVLQ(UInt64.MaxValue) + 1];
                var span1 = new MemoryStreamer(mem);
                var span2 = new MemoryStreamer(mem);

                var data = new Int64[memSize];
                for (var i = 0; i < memSize; i++)
                    data[i] = rnd.NextInt64();

                for (var i = 0; i < memSize; i++)
                    span1.WriteVLQ(data[i]);

                for (var i = 0; i < memSize; i++)
                {
                    Assert.Equal(data[i], span2.ReadVLQInt64(out var len));
                    Assert.Equal(SpanUtils.MeasureVLQ(data[i]), len);
                }

                // Check overflow
                new Span<byte>(mem).Fill(0xFF);
                Assert.Throws<OverflowException>(() =>
                {
                    var span3 = new MemoryStreamer(mem);
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
                var mem = new byte[memSize * SpanUtils.MeasureVLQ(UInt64.MaxValue) + 1];
                var span1 = new MemoryStreamer(mem);
                var span2 = new MemoryStreamer(mem);

                var data = new UInt64[memSize];
                for (var i = 0; i < memSize; i++)
                    data[i] = rnd.NextUInt64();

                for (var i = 0; i < memSize; i++)
                    span1.WriteVLQ(data[i]);

                for (var i = 0; i < memSize; i++)
                {
                    Assert.Equal(data[i], span2.ReadVLQUInt64(out var len));
                    Assert.Equal(SpanUtils.MeasureVLQ(data[i]), len);
                }

                // Check overflow
                new Span<byte>(mem).Fill(0xFF);
                Assert.Throws<OverflowException>(() =>
                {
                    var span3 = new MemoryStreamer(mem);
                    span3.ReadVLQUInt64(out _);
                });

            }
        }
        #endregion

    }
}
