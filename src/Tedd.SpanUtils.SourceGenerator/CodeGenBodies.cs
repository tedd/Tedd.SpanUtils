using System;
using System.Collections.Generic;
using System.Reflection;

namespace Tedd.SpanUtils.SourceGenerator
{
    [Flags]
    public enum Endianness { None = 0, Default = 1, LE = 2, BE = 4, All = Default | LE | BE }

    public static partial class CodeGenBodies
    {
        public static readonly List<MethodData> DataStructures = new();
        public static readonly Type[] Primitives = { typeof(SByte), typeof(Byte), typeof(UInt16), typeof(Int16), typeof(UInt32), typeof(Int32), typeof(UInt64), typeof(Int64), typeof(Single), typeof(Double), typeof(Decimal), typeof(Boolean), typeof(Char) };
        public static readonly Type[] VLQTypes = { typeof(UInt16), typeof(Int16), typeof(UInt32), typeof(Int32), typeof(UInt64), typeof(Int64) };
        public static readonly Dictionary<string, Type> Aliases = new()
        {
            { "Float", typeof(Single) }, { "Short", typeof(Int16) }, { "UShort", typeof(UInt16) },
            { "Int", typeof(Int32) }, { "UInt", typeof(UInt32) }, { "Long", typeof(Int64) },
            { "ULong", typeof(UInt64) }, { "Bool", typeof(Boolean) }
        };

        private static MethodInfo Body(string name) => typeof(CodeGenBodies).GetMethod(name)
            ?? throw new InvalidOperationException($"Missing implementation: {name}");

        private static void Add(string name, string type, string size, string writeName = null,
            Endianness endian = Endianness.All, string condition = null, MethodRW rw = MethodRW.Both,
            string readBody = null, string writeBody = null)
        {
            DataStructures.Add(new MethodData
            {
                Name = name,
                TypeString = type,
                Size = size,
                WriteName = writeName,
                Endian = endian,
                Condition = condition,
                RW = rw,
                ReadBody = rw == MethodRW.WriteOnly ? null : Body(readBody ?? "Read" + name),
                WriteBody = rw == MethodRW.ReadOnly ? null : Body(writeBody ?? "Write" + name)
            });
        }

        public static void Initialize()
        {
            DataStructures.Clear();
            foreach (var type in Primitives)
                Add(type.Name, type.Name, "sizeof(" + type.Name + ")");
            foreach (var alias in Aliases)
            {
                Add(alias.Key, alias.Value.Name, "sizeof(" + alias.Value.Name + ")", rw: MethodRW.ReadOnly, readBody: "Read" + alias.Value.Name);
                DataStructures[^1].IsAlias = true;
            }
            Add("UInt24", "UInt24", "3");
            Add("Int24", "Int32", "3", "Int24");
            Add("Half", "Half", "2", condition: "NET6_0_OR_GREATER");
            Add("Int128", "Int128", "16", condition: "NET7_0_OR_GREATER");
            Add("UInt128", "UInt128", "16", condition: "NET7_0_OR_GREATER");
            Add("Guid", "Guid", "16");
            foreach (var type in VLQTypes)
                Add("VLQ" + type.Name, type.Name, "length", "VLQ", Endianness.Default);
            Add("VLQUInt24", "UInt24", "length", "VLQ", Endianness.Default);
            foreach (var item in new[] { ("Bytes", "Byte[]"), ("Span", "Span<byte>"), ("ReadOnlySpan", "ReadOnlySpan<byte>"), ("String", "String") })
            {
                Add(item.Item1, item.Item2, "length", endian: Endianness.Default, readBody: item.Item1 == "Bytes" ? "ReadBytes" : item.Item1 == "String" ? "ReadString" : "ReadSpan", writeBody: item.Item1 == "String" ? "WriteString" : "WriteSpan", writeName: item.Item1 == "String" ? "String" : null);
                DataStructures[^1].NoLengthParam = true;
                DataStructures[^1].ExtraReadParamsDef = "int length";
                DataStructures[^1].ExtraReadParams = "length";
            }
            Add("Size", "UInt32", "length", "Size", Endianness.Default);
            Add("SizedBytes", "Byte[]", "length", "Sized", Endianness.Default);
            Add("SizedString", "String", "length", "Sized", Endianness.Default);
            Add("SizedSpan", "Span<byte>", "length", "Sized", Endianness.Default, readBody: "ReadSizedSpan", writeBody: "WriteSizedSpan");
            Add("SizedReadOnlySpan", "ReadOnlySpan<byte>", "length", "Sized", Endianness.Default, readBody: "ReadSizedSpan", writeBody: "WriteSizedSpan");
        }

        public const string usings = @"
using System;
using System.Buffers.Binary;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Data;
";
        public static string EndiannessToMethodExtension(Endianness endian) => endian switch { Endianness.LE => "LE", Endianness.BE => "BE", _ => "" };
        private static string ReadResult(string expression) => $"\n            var ret = {expression};\n            [LEN]\n            [MOVE]\n            return ret;";
        private static string WriteResult(string statement) => $"\n            {statement}\n            [LEN]\n            [MOVE]";
        private static string ReadInteger(string type, Endianness endian) => ReadResult(endian == Endianness.Default
            ? $"MemoryMarshal.Read<{type}>(span)"
            : $"BinaryPrimitives.Read{type}{(endian == Endianness.LE ? "LittleEndian" : "BigEndian")}(span)");
        private static string WriteInteger(string type, Endianness endian) => WriteResult(endian == Endianness.Default
            ? "\n#if NET8_0_OR_GREATER\n            MemoryMarshal.Write(span, in value);\n#else\n            MemoryMarshal.Write(span, ref value);\n#endif"
            : $"BinaryPrimitives.Write{type}{(endian == Endianness.LE ? "LittleEndian" : "BigEndian")}(span, value);");
    }
}
