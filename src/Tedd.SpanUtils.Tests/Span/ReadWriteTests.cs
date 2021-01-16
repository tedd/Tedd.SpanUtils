using System;
using System.Linq;
using Xunit;

namespace Tedd.SpanUtilsTests.Span
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
                uint a;
                switch (sr)
                {
                    case 0:
                        a = (UInt32)rnd.Next(0, 0b00111111);
                        break;
                    case 1:
                        a = (UInt32)rnd.Next(0b01000000, 0b00111111_11111111);
                        break;
                    case 2:
                        a = (UInt32)rnd.Next(0b01000000_00000000, 0b00111111_11111111_11111111);
                        break;
                    //case 3:
                    default:
                        a = (UInt32)rnd.Next(0b01000000_00000000_00000000, 0b00111111_11111111_11111111_11111111);
                        break;
                }

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
        public void TestSizedBytes()
        {
            var rnd = new Random();
            for (var c = 0; c < count; c++)
            {
                var memSize = rnd.Next(1, 10_000);
                var mem = new byte[memSize + 4];
                var answer = new byte[memSize];
                var span1 = new Span<byte>(mem);
                var span2 = new Span<byte>(mem);

                rnd.NextBytes(answer);
                span1.SizedWrite(answer);

                // Ensure span is not zero
                if (memSize > 0 && answer[0] != 0)
                    Assert.NotEqual(0, span2.ToArray().Select(b => (int)b).Sum());
                var r = span2.ReadSizedBytes(out var len);
                for (var i = 0; i < answer.Length; i++)
                    Assert.Equal(answer[i], r[i]);

                Assert.Throws<ArgumentException>(() =>
                {
                    var s = new Span<byte>(mem);
                    s.SizedWrite(new byte[mem.Length + 1]);
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
                var mem = new byte[memSize + 4];
                var answer = new byte[memSize];
                var aSpan = new Span<byte>(answer);
                var span1 = new Span<byte>(mem);
                var span2 = new Span<byte>(mem);

                rnd.NextBytes(answer);
                span1.SizedWrite(aSpan);

                // Ensure span is not zero
                if (memSize > 0 && answer[0] != 0)
                    Assert.NotEqual(0, span2.ToArray().Select(b => (int)b).Sum());
                var r = span2.ReadSizedBytes(out var len);
                for (var i = 0; i < answer.Length; i++)
                    Assert.Equal(answer[i], r[i]);

                Assert.Throws<ArgumentException>(() =>
                {
                    var s = new Span<byte>(mem);
                    s.SizedWrite(new Span<byte>(new byte[mem.Length + 1]));
                });
            }
        }
        [Fact]
        public void TestSizedReadOnlySpan()
        {
            var rnd = new Random();
            for (var c = 0; c < count; c++)
            {
                var memSize = rnd.Next(1, 10_000);
                var mem = new byte[memSize + 4];
                var answer = new byte[memSize];
                var aSpan = new ReadOnlySpan<byte>(answer);
                var span1 = new Span<byte>(mem);
                var span2 = new Span<byte>(mem);

                rnd.NextBytes(answer);
                span1.SizedWrite(aSpan);

                // Ensure span is not zero
                if (memSize > 0 && answer[0] != 0)
                    Assert.NotEqual(0, span2.ToArray().Select(b => (int)b).Sum());
                var r = span2.ReadSizedBytes(out var len);
                for (var i = 0; i < answer.Length; i++)
                    Assert.Equal(answer[i], r[i]);

                Assert.Throws<ArgumentException>(() =>
                {
                    var s = new Span<byte>(mem);
                    s.SizedWrite(new ReadOnlySpan<byte>(new byte[mem.Length + 1]));
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
                var mem = new byte[(memSize + 4) * 4];
                var span1 = new Span<byte>(mem);
                var span2 = new Span<byte>(mem);

                var answer = rnd.NextString("abcæøå诶	比西αβγ", memSize);
                span1.SizedWrite(answer);


                // Ensure span is not zero
                if (memSize > 0 && answer[0] != 0)
                    Assert.NotEqual(0, span2.ToArray().Select(b => (int)b).Sum());
                var r = span2.ReadSizedString(out var len);
                Assert.Equal(answer, r);


                Assert.Throws<ArgumentException>(() =>
                {
                    var s = new Span<byte>(mem);
                    s.SizedWrite(new string('a', mem.Length + 1));
                });
            }
        }

        [Fact]
        public void TestBytes()
        {
            var rnd = new Random();
            for (var c = 0; c < count; c++)
            {
                var memSize = rnd.Next(1, 10_000);
                var mem = new byte[memSize + 4];
                var answer = new byte[memSize];
                var span1 = new Span<byte>(mem);
                var span2 = new Span<byte>(mem);

                rnd.NextBytes(answer);
                span1.Write(answer);

                // Ensure span is not zero
                if (memSize > 0 && answer[0] != 0)
                    Assert.NotEqual(0, span2.ToArray().Select(b => (int)b).Sum());
                var r = span2.ReadBytes(answer.Length);
                for (var i = 0; i < answer.Length; i++)
                    Assert.Equal(answer[i], r[i]);

                Assert.Throws<ArgumentException>(() =>
                {
                    var s = new Span<byte>(mem);
                    s.Write(new byte[mem.Length + 1]);
                });
            }

        }

        #region VLQ
        [Fact]
        public void TestVLQInt16FullRange()
        {
            var rnd = new Random();
            var mem = new byte[sizeof(Int16) + 1];
            for (int c = Int16.MinValue; c < Int16.MaxValue; c++)
            {
                var answer = (Int16)c;
                var span1 = new Span<byte>(mem);
                var span2 = new Span<byte>(mem);
                span1.Fill(0);

                var len = span1.WriteVLQ(answer);
                var back = span2.ReadVLQInt16(out var len2);

                Assert.Equal(answer, back);

                Assert.Equal(Utils.MeasureVLQ(answer), len);
                Assert.Equal(Utils.MeasureVLQ(answer), len2);
            }
        }
        [Fact]
        public void TestVLQUInt16FullRange()
        {
            var rnd = new Random();
            var mem = new byte[sizeof(UInt16) + 1];
            for (int c = UInt16.MinValue; c < UInt16.MaxValue; c++)
            {
                var answer = (UInt16)c;
                var span1 = new Span<byte>(mem);
                var span2 = new Span<byte>(mem);
                span1.Fill(0);

                var len = span1.WriteVLQ(answer);
                var back = span2.ReadVLQUInt16(out var len2);

                Assert.Equal(answer, back);

                Assert.Equal(Utils.MeasureVLQ(answer), len);
                Assert.Equal(Utils.MeasureVLQ(answer), len2);
            }
        }
        //[Fact]
        //public void TestVLQInt32FullRange()
        //{
        //    var rnd = new Random();
        //    var mem = new byte[sizeof(Int32) + 1];
        //    for (int c = Int32.MinValue; c < Int32.MaxValue; c++)
        //    {
        //        var answer = (Int32)c;
        //        var span1 = new Span<byte>(mem);
        //        var span2 = new Span<byte>(mem);
        //        span1.Fill(0);

        //        var len = span1.WriteVLQ(answer);
        //        var back = span2.ReadVLQInt32(out var len2);

        //        Assert.Equal(answer, back);

        //        Assert.Equal(Utils.MeasureVLQ(answer), len);
        //        Assert.Equal(Utils.MeasureVLQ(answer), len2);
        //    }
        //}
        //[Fact]
        //public void TestVLQUInt32FullRange()
        //{
        //    var rnd = new Random();
        //    var mem = new byte[sizeof(UInt32) + 1];
        //    for (UInt32 c = UInt32.MinValue; c < UInt32.MaxValue; c++)
        //    {
        //        var answer = (UInt32)c;
        //        var span1 = new Span<byte>(mem);
        //        var span2 = new Span<byte>(mem);
        //        span1.Fill(0);

        //        var len = span1.WriteVLQ(answer);
        //        var back = span2.ReadVLQUInt32(out var len2);

        //        Assert.Equal(answer, back);

        //        Assert.Equal(Utils.MeasureVLQ(answer), len);
        //        Assert.Equal(Utils.MeasureVLQ(answer), len2);
        //    }
        //}
        //[Fact]
        //public void TestVLQInt64FullRange()
        //{
        //    var rnd = new Random();
        //    var mem = new byte[sizeof(Int64) + 2];
        //    for (Int64 c = Int64.MinValue; c < Int64.MaxValue; c++)
        //    {
        //        var answer = (Int64)c;
        //        var span1 = new Span<byte>(mem);
        //        var span2 = new Span<byte>(mem);
        //        span1.Fill(0);

        //        var len = span1.WriteVLQ(answer);
        //        var back = span2.ReadVLQInt64(out var len2);

        //        Assert.Equal(answer, back);

        //        Assert.Equal(Utils.MeasureVLQ(answer), len);
        //        Assert.Equal(Utils.MeasureVLQ(answer), len2);
        //    }
        //}
        [Fact]
        public void TestVLQInt16()
        {
            var rnd = new Random();
            for (var c = 0; c < count; c++)
            {
                var memSize = rnd.Next(1, 10_000);
                var mem = new byte[memSize + sizeof(Int16) + 1];
                var answer = rnd.NextInt16();
                var span1 = new Span<byte>(mem);
                var span2 = new Span<byte>(mem);

                var len = span1.WriteVLQ(answer);
                var back = span2.ReadVLQInt16(out var len2);

                Assert.Equal(answer, back);

                Assert.Equal(Utils.MeasureVLQ(answer), len);
                Assert.Equal(Utils.MeasureVLQ(answer), len2);


                // Check overflow
                span1.Fill(0xFF);
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
                var mem = new byte[memSize + +sizeof(UInt16) + 1];
                var answer = rnd.NextUInt16();
                var span1 = new Span<byte>(mem);
                var span2 = new Span<byte>(mem);

                var len = span1.WriteVLQ(answer);
                var back = span2.ReadVLQUInt16(out var len2);

                Assert.Equal(Utils.MeasureVLQ(answer), len);
                Assert.Equal(Utils.MeasureVLQ(answer), len2);

                Assert.Equal(answer, back);

                // Check overflow
                span1.Fill(0xFF);
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
                var mem = new byte[memSize + 3 + 2];
                var answer = rnd.NextUInt32().ToUInt24();
                var span1 = new Span<byte>(mem);
                var span2 = new Span<byte>(mem);

                var len = span1.WriteVLQ(answer);
                var back = span2.ReadVLQUInt24(out var len2);

                Assert.Equal(Utils.MeasureVLQ(answer), len);
                Assert.Equal(Utils.MeasureVLQ(answer), len2);

                Assert.Equal(answer, back);

                // Check overflow
                span1.Fill(0xFF);
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
                var mem = new byte[memSize + sizeof(Int32) + 1];
                var answer = rnd.NextInt32();
                var span1 = new Span<byte>(mem);
                var span2 = new Span<byte>(mem);

                var len = span1.WriteVLQ(answer);
                var back = span2.ReadVLQInt32(out var len2);

                Assert.Equal(Utils.MeasureVLQ(answer), len);
                Assert.Equal(Utils.MeasureVLQ(answer), len2);

                Assert.Equal(answer, back);

                // Check overflow
                span1.Fill(0xFF);
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
                var mem = new byte[memSize + sizeof(UInt32) + 1];
                var answer = rnd.NextUInt32();
                var span1 = new Span<byte>(mem);
                var span2 = new Span<byte>(mem);

                var len = span1.WriteVLQ(answer);
                var back = span2.ReadVLQUInt32(out var len2);

                Assert.Equal(Utils.MeasureVLQ(answer), len);
                Assert.Equal(Utils.MeasureVLQ(answer), len2);

                Assert.Equal(answer, back);

                // Check overflow
                span1.Fill(0xFF);
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
                var mem = new byte[memSize + sizeof(Int64) + 2];
                var answer = rnd.NextInt64();
                var span1 = new Span<byte>(mem);
                var span2 = new Span<byte>(mem);

                var len = span1.WriteVLQ(answer);
                var back = span2.ReadVLQInt64(out var len2);

                Assert.Equal(Utils.MeasureVLQ(answer), len);
                Assert.Equal(Utils.MeasureVLQ(answer), len2);

                Assert.Equal(answer, back);

                // Check overflow
                span1.Fill(0xFF);
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
                var mem = new byte[memSize + sizeof(UInt64) + 2];
                var answer = rnd.NextUInt64();
                var span1 = new Span<byte>(mem);
                var span2 = new Span<byte>(mem);

                var len = span1.WriteVLQ(answer);
                var back = span2.ReadVLQUInt64(out var len2);

                Assert.Equal(Utils.MeasureVLQ(answer), len);
                Assert.Equal(Utils.MeasureVLQ(answer), len2);

                Assert.Equal(answer, back);

                // Check overflow
                span1.Fill(0xFF);
                Assert.Throws<OverflowException>(() =>
                {
                    var span3 = new Span<byte>(mem);
                    span3.ReadVLQUInt64(out _);
                });

            }
        }
        #endregion

        #region VInt
        [Theory]
        [InlineData(new byte[] { 0x80 }, 1, 0x80ul, 0)]
        [InlineData(new byte[] { 0x81 }, 1, 0x81ul, 1)]
        [InlineData(new byte[] { 0xfe }, 1, 0xfeul, 126)]
        [InlineData(new byte[] { 0x40, 0x7f }, 2, 0x407ful, 127)]
        [InlineData(new byte[] { 0x40, 0x80 }, 2, 0x4080ul, 128)]
        [InlineData(new byte[] { 0x10, 0xDE, 0xFF, 0xAD }, 4, 0x10deffad, 0xdeffad)]

        public void TestVInt(byte[] bytes, int expectedLength, ulong expectedEncodedValue, ulong expectedValue)
        {
            var readResult = bytes.AsSpan().ReadVInt(4);

            Assert.Equal(expectedLength, readResult.Length);
            Assert.Equal(expectedEncodedValue, readResult.EncodedValue);
            Assert.Equal(expectedValue, readResult.Value);

            var writeSpan = new byte[VInt.GetSize(expectedValue)].AsSpan();
            var writeLength = writeSpan.WriteVInt(expectedValue);

            Assert.Equal(expectedLength, writeLength);
            Assert.Equal(bytes, writeSpan.ToArray());
        }
        #endregion
    }
}