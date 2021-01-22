using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;

namespace Tedd.SpanUtils.SourceGenerator
{
    [Flags]
    public enum Endianness
    {
        None = 0,
        Default = 1,
        LE = 2,
        BE = 4,
        All = Default | LE | BE
    }

    public static partial class CodeGenBodies
    {
        public static List<MethodData> DataStructures = new();

        public static void Initialize()
        {
            // Add generator info for all primitives
            foreach (var p in Primitives)
            {
                var ds = new MethodData()
                {
                    Name = p.Name,
                    Type = p,
                    ReadBody = GetMethod($"Read{p.Name}"),
                    WriteBody = GetMethod($"Write{p.Name}"),
                    Size = $"sizeof({p.Name})"
                };
                //if (ds.Type == typeof(byte) || ds.Type == typeof(sbyte) || ds.Type == typeof(bool))
                //    ds.Endian = Endianness.Default;
                DataStructures.Add(ds);

            }

            // Add generator info for all aliases
            foreach (var a in Aliases)
            {
                var ds = new MethodData()
                {
                    IsAlias = true,
                    //RW = MethodRW.Read,
                    Name = a.Key,
                    Type = a.Value,
                    ReadBody = GetMethod($"Read{a.Value.Name}"),
                    WriteBody = GetMethod($"Write{a.Value.Name}"),
                    Size = $"sizeof({a.Value.Name})",
                };
                //if (ds.Type == typeof(byte) || ds.Type == typeof(sbyte) || ds.Type == typeof(bool))
                //    ds.Endian = Endianness.Default;
                DataStructures.Add(ds);
            }

            // Add VLQ methods
            foreach (var t in VLQTypes)
            {
                DataStructures.Add(new MethodData()
                {
                    //RW = MethodRW.Read,
                    Name = $"VLQ" + t.Name,
                    WriteName = $"VLQ",
                    //WriteNameOnly = false,
                    Type = t,
                    ReadBody = GetMethod($"ReadVLQ{t.Name}"),
                    WriteBody = GetMethod($"WriteVLQ{t.Name}"),
                    Size = $"length",
                    Endian = Endianness.Default
                });
            }

            // Others
            DataStructures.Add(new MethodData()
            {
                Name = $"UInt24",
                //WriteName = "UInt24",
                //WriteNameOnly = false,
                TypeString = "UInt24",
                ReadBody = GetMethod($"ReadUInt24"),
                WriteBody = GetMethod($"WriteUInt24"),
                Size = "3"
            });
            DataStructures.Add(new MethodData()
            {
                Name = $"VLQUInt24",
                WriteName = $"VLQ",
                TypeString = "UInt24",
                ReadBody = GetMethod($"ReadVLQUInt24"),
                WriteBody = GetMethod($"WriteVLQUInt24"),
                Size = $"length",
                Endian = Endianness.Default
            });
            DataStructures.Add(new MethodData()
            {
                Name = $"Guid",
                Type = typeof(Guid),
                ReadBody = GetMethod($"ReadGuid"),
                WriteBody = GetMethod($"WriteGuid"),
                Size = "16",
                Endian = Endianness.Default
            });
            DataStructures.Add(new MethodData()
            {
                Name = $"Bytes",
                Type = typeof(byte[]),
                ReadBody = GetMethod($"ReadBytes"),
                WriteBody = GetMethod($"WriteBytes"),
                ExtraReadParamsDef = "int length",
                ExtraReadParams = "length",
                Size = "length",
                NoLengthParam = true,
                Endian = Endianness.Default
            });
            DataStructures.Add(new MethodData()
            {
                Name = $"Span",
                TypeString = "Span<byte>",
                ReadBody = GetMethod($"ReadSpan"),
                WriteBody = GetMethod($"WriteSpan"),
                ExtraReadParamsDef = "int length",
                ExtraReadParams = "length",
                Size = "length",
                NoLengthParam = true,
                Endian = Endianness.Default
            });
            DataStructures.Add(new MethodData()
            {
                Name = $"ReadOnlySpan",
                TypeString = "ReadOnlySpan<byte>",
                ReadBody = GetMethod($"ReadSpan"),
                WriteBody = GetMethod($"WriteSpan"),
                ExtraReadParamsDef = "int length",
                ExtraReadParams = "length",
                Size = "length",
                NoLengthParam = true,
                Endian = Endianness.Default
            });
            DataStructures.Add(new MethodData()
            {
                Name = $"Size",
                WriteName = $"Size",
                //WriteNameOnly=false,
                Type = typeof(UInt32),
                ReadBody = GetMethod($"ReadSize"),
                WriteBody = GetMethod($"WriteSize"),
                Size = "length",
                Endian = Endianness.Default
            });
            DataStructures.Add(new MethodData()
            {
                Name = $"SizedBytes",
                WriteName = $"Sized",
                //WriteNameOnly = false,
                Type = typeof(byte[]),
                ReadBody = GetMethod($"ReadSizedBytes"),
                WriteBody = GetMethod($"WriteSizedBytes"),
                Size = "length",
                Endian = Endianness.Default
            });
            DataStructures.Add(new MethodData()
            {
                Name = $"SizedString",
                WriteName = $"Sized",
                //WriteNameOnly = false,
                Type = typeof(string),
                ReadBody = GetMethod($"ReadSizedString"),
                WriteBody = GetMethod($"WriteSizedString"),
                Size = "length",
                Endian = Endianness.Default
            });
            DataStructures.Add(new MethodData()
            {
                Name = $"SizedSpan",
                RW = MethodRW.WriteOnly,
                WriteName = $"Sized",
                TypeString = "Span<byte>",
                //WriteNameOnly = false,
                //Type = typeof(string),
                //ReadBody = GetMethod($"ReadSizedSpan"),
                WriteBody = GetMethod($"WriteSizedSpan"),
                Size = "length",
                Endian = Endianness.Default
            });
            DataStructures.Add(new MethodData()
            {
                Name = $"SizedReadOnlySpan",
                RW = MethodRW.WriteOnly,
                WriteName = $"Sized",
                TypeString = "ReadOnlySpan<byte>",
                //WriteNameOnly = false,
                //Type = typeof(string),
                //ReadBody = GetMethod($"ReadSizedSpan"),
                WriteBody = GetMethod($"WriteSizedSpan"),
                Size = "length",
                Endian = Endianness.Default
            });
        }

        private static MethodInfo GetMethod(string mn)
        {
            var methods = typeof(CodeGenBodies).GetMethods();
            foreach (var m in methods)
            {
                if (m.Name == mn)
                    return m;
            }

            throw new Exception($"Could not locate body implementation method \"{mn}\".");
        }

        public static Type[] Primitives = new[]
        {
            typeof(SByte), typeof(Byte),
            typeof(UInt16), typeof(Int16),
            typeof(UInt32), typeof(Int32),
            typeof(UInt64), typeof(Int64),
            typeof(float), typeof(double),
            typeof(decimal),
            typeof(bool), typeof(Char)
        };

        public static Type[] VLQTypes = new[]
        {
            typeof(UInt16), typeof(Int16),
            typeof(UInt32), typeof(Int32),
            typeof(UInt64), typeof(Int64)
        };

        public static Dictionary<string, Type> Aliases = new()
        {
            { "Float", typeof(float) },
            { "Short", typeof(short) },
            { "UShort", typeof(ushort) },
            { "Int", typeof(int) },
            { "UInt", typeof(uint) },
            { "Long", typeof(long) },
            { "ULong", typeof(ulong) },
            { "Bool", typeof(bool) }
        };

        public static string usings = @"
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
";

        public static string EndiannessToMethodExtension(Endianness e) => e switch
        {
            Endianness.BE => "BE",
            Endianness.LE => "LE",
            _ => ""
        };
    }
}