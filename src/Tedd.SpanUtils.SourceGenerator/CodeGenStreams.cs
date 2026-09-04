using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Tedd.SpanUtils.SourceGenerator
{
    /// <summary>Generates cursor wrappers from the same metadata as the span primitives.</summary>
    public static class CodeGenStreams
    {
        public static void Generate(string root)
        {
            foreach (bool memory in new[] { false, true })
            {
                foreach (bool readOnly in new[] { false, true })
                {
                    var sb = new StringBuilder();
                    foreach (var endian in new[] { Endianness.Default, Endianness.LE, Endianness.BE })
                    {
                        foreach (var ds in CodeGenBodies.DataStructures)
                        {
                            if (!ds.Endian.HasFlag(endian)) continue;
                            if (!string.IsNullOrEmpty(ds.Condition)) sb.AppendLine($"#if {ds.Condition}");
                            GenerateRead(endian, ds, sb, memory, readOnly);
                            if (!readOnly) GenerateWrite(endian, ds, sb, memory);
                            if (!string.IsNullOrEmpty(ds.Condition)) sb.AppendLine("#endif");
                        }
                    }
                    GenerateVInt(sb, readOnly);
                    string name = (readOnly ? "ReadOnly" : "") + (memory ? "MemoryStreamer" : "SpanStream");
                    string declaration = memory ? Helper.CreateClass(false, name, sb.ToString(), "") : Helper.CreateRefStruct(name, sb.ToString(), "");
                    File.WriteAllText(Path.Combine(root, name + ".generated.cs"), Helper.CreateNamespace("Tedd", declaration, CodeGenBodies.usings));
                }
            }
        }

        private static void GenerateVInt(StringBuilder sb, bool readOnly)
        {
            Helper.Method(sb, false, "VInt", "ReadVInt", "int maxLength = 8", @"
            var value = SpanUtils.ReadVInt(ReadBuffer, maxLength);
            _position += value.Length;
            return value;", "");
            Helper.Method(sb, false, "bool", "TryReadVInt", "out VInt value, int maxLength = 8", @"
            if (!SpanUtils.TryReadVInt(ReadBuffer, out value, maxLength)) return false;
            _position += value.Length;
            return true;", "");
            if (readOnly) return;
            Helper.Method(sb, false, "int", "WriteVInt", "ulong value", @"
            var length = SpanUtils.WriteVInt(WriteBuffer, value);
            AdvanceWrite(length);
            return length;", "");
            Helper.Method(sb, false, "bool", "TryWriteVInt", "ulong value, out int length", @"
            if (!SpanUtils.TryWriteVInt(WriteBuffer, value, out length)) return false;
            AdvanceWrite(length);
            return true;", "");
        }
        private static string Join(List<string> values) => string.Join(", ", values);

        private static void GenerateRead(Endianness endian, MethodData ds, StringBuilder sb, bool memory, bool readOnly)
        {
            if (ds.RW == MethodRW.WriteOnly || (readOnly && ds.TypeString == "Span<byte>")) return;
            GenerateRawTryRead(endian, ds, sb);
            string name = ds.GetReadName(endian);
            var definitions = new List<string>();
            var arguments = new List<string>();
            if (!string.IsNullOrWhiteSpace(ds.ExtraReadParamsDef)) definitions.Add(ds.ExtraReadParamsDef);
            if (!string.IsNullOrWhiteSpace(ds.ExtraReadParams)) arguments.Add(ds.ExtraReadParams);
            if (!ds.NoLengthParam)
            {
                // Stream.ReadByte must return int and -1 at EOF; its implementation is handwritten.
                if (!(memory && name == "ReadByte"))
                {
                    var noLengthArgs = new List<string>(arguments) { "out _" };
                    Helper.Method(sb, false, ds.TypeString, name, Join(definitions), $"{name}({Join(noLengthArgs)});", "");
                }
                definitions.Add("out int length");
                arguments.Add("out length");
            }
            Helper.Method(sb, false, ds.TypeString, name, Join(definitions), $@"
            var result = SpanUtils.{name}(ReadBuffer, {Join(arguments)});
            _position += {ds.Size};
            return result;", "");

            if (!ds.NoLengthParam && string.IsNullOrWhiteSpace(ds.ExtraReadParamsDef))
            {
                Helper.Method(sb, false, "bool", "Try" + name, $"out {ds.TypeString} value", $"Try{name}(out value, out _);", "");
                Helper.Method(sb, false, "bool", "Try" + name, $"out {ds.TypeString} value, out int length", $@"
            if (!SpanUtils.Try{name}(ReadBuffer, out value, out length)) return false;
            _position += length;
            return true;", "");
            }
        }

        private static void GenerateRawTryRead(Endianness endian, MethodData ds, StringBuilder sb)
        {
            if (!ds.NoLengthParam) return;
            string name = ds.GetReadName(endian);
            Helper.Method(sb, false, "bool", "Try" + name, $"{ds.ExtraReadParamsDef}, out {ds.TypeString} value", $@"
            if (!SpanUtils.Try{name}(ReadBuffer, {ds.ExtraReadParams}, out value)) return false;
            _position += {ds.Size};
            return true;", "");
        }
        private static void GenerateWrite(Endianness endian, MethodData ds, StringBuilder sb, bool memory)
        {
            if (ds.IsAlias || ds.RW == MethodRW.ReadOnly) return;
            string name = ds.GetWriteName(endian);
            string inputModifier = !memory && (ds.TypeString == "Span<byte>" || ds.TypeString == "ReadOnlySpan<byte>") ? "scoped " : "";
            string modifier = memory && name == "Write" && ds.TypeString == "ReadOnlySpan<byte>" ? "override " : "";
            sb.Append($@"
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {modifier}void {name}({inputModifier}{ds.TypeString} value) => {name}(value, out _);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void {name}({inputModifier}{ds.TypeString} value, out int length)
        {{
            SpanUtils.{name}(WriteBuffer, value, out length);
            AdvanceWrite(length);
        }}
");
            {
                Helper.Method(sb, false, "bool", "Try" + name, $"{inputModifier}{ds.TypeString} value", $"Try{name}(value, out _);", "");
                Helper.Method(sb, false, "bool", "Try" + name, $"{inputModifier}{ds.TypeString} value, out int length", $@"
            if (!SpanUtils.Try{name}(WriteBuffer, value, out length)) return false;
            AdvanceWrite(length);
            return true;", "");
            }
        }
    }
}
