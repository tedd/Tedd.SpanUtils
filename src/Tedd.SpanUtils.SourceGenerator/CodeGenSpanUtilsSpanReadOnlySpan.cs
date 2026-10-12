using System;
using System.IO;
using System.Text;

namespace Tedd.SpanUtils.SourceGenerator
{
    public static class CodeGenSpanUtilsSpanReadOnlySpan
    {
        public static void GenerateSpanMethods(string className, string directory)
        {
            var methods = new StringBuilder();
            var extensions = new StringBuilder();
            foreach (var type in new[] { "Span<byte>", "ReadOnlySpan<byte>" })
            {
                Method(methods, "void", "Move", "ref " + type + " span, int length", "span = span.Slice(length);");
                Method(extensions, "void", "Move", "this ref " + type + " span, int length", "SpanUtils.Move(ref span, length);");
            }
            foreach (var endian in new[] { Endianness.Default, Endianness.LE, Endianness.BE })
                foreach (var item in CodeGenBodies.DataStructures)
                {
                    if (!item.Endian.HasFlag(endian)) continue;
                    if (item.Condition != null) { methods.AppendLine("#if " + item.Condition); extensions.AppendLine("#if " + item.Condition); }
                    foreach (var move in new[] { false, true })
                    {
                        if (item.RW != MethodRW.WriteOnly)
                            foreach (var spanType in new[] { "Span<byte>", "ReadOnlySpan<byte>" })
                                if (spanType != "ReadOnlySpan<byte>" || item.TypeString != "Span<byte>")
                                    Read(methods, extensions, item, endian, move, spanType);
                        if (item.RW != MethodRW.ReadOnly && !item.IsAlias)
                            Write(methods, extensions, item, endian, move);
                    }
                    if (item.Condition != null) { methods.AppendLine("#endif"); extensions.AppendLine("#endif"); }
                }
            File.WriteAllText(Path.Combine(directory, "SpanUtils.generated.cs"), Helper.CreateNamespace("Tedd", Helper.CreateClass(true, className, methods.ToString(), ""), CodeGenBodies.usings));
            File.WriteAllText(Path.Combine(directory, "ExtensionMethods.generated.cs"), Helper.CreateNamespace("Tedd", Helper.CreateClass(true, className + "ExtensionMethods", extensions.ToString(), ""), CodeGenBodies.usings));
        }

        private static void Method(StringBuilder output, string type, string name, string parameters, string body) => Helper.Method(output, true, type, name, parameters, body, "");
        private static string Body(string body, MethodData item, bool move, bool length) => body
            .Replace("[LEN]", length && item.Size != "length" ? "length = " + item.Size + ";" : "")
            .Replace("[MOVE]", move ? "span = span.Slice(" + item.Size + ");" : "");

        private static void ReadTryVariable(StringBuilder methods, StringBuilder extensions, MethodData item, string name, string parameters, string extensionParameters, string arguments, bool move)
        {
            string body;
            if (item.Name.StartsWith("VLQ", StringComparison.Ordinal))
            {
                var signed = item.Name.StartsWith("VLQInt", StringComparison.Ordinal);
                var bits = item.Name.EndsWith("16") ? 16 : item.Name.EndsWith("24") ? 24 : item.Name.EndsWith("32") ? 32 : 64;
                body = $"\n            if (!SpanUtils.TryRead{(signed ? "Signed" : "Unsigned")}VLQCore(span, {bits}, out var decoded, out length, out _)) {{ value = default; return false; }}\n            value = ({item.TypeString})decoded;\n            {(move ? "span = span.Slice(length);" : "")}\n            return true;";
            }
            else
            {
                body = "\n            value = default; length = 0;\n            if (span.IsEmpty || span.Length < (span[0] >> 6) + 1) return false;";
                if (item.Name != "Size")
                    body += "\n            var size = SpanUtils.ReadSize(span, out var prefix);\n            if (size > (UInt32)(span.Length - prefix)) return false;";
                body += $"\n            value = SpanUtils.{name}({arguments}, out length);\n            return true;";
            }
            var tryName = "Try" + name;
            Method(methods, "bool", tryName, parameters + $", out {item.TypeString} value, out int length", body);
            Method(methods, "bool", tryName, parameters + $", out {item.TypeString} value", $"SpanUtils.{tryName}({arguments}, out value, out _);");
            Method(extensions, "bool", tryName, extensionParameters + $", out {item.TypeString} value, out int length", $"SpanUtils.{tryName}({arguments}, out value, out length);");
            Method(extensions, "bool", tryName, extensionParameters + $", out {item.TypeString} value", $"SpanUtils.{tryName}({arguments}, out value, out _);");
        }

        private static void WriteTryVariable(StringBuilder methods, StringBuilder extensions, MethodData item, string name, string parameters, string extensionParameters, string arguments)
        {
            var body = "\n            length = 0;";
            if (item.TypeString == "String" || item.TypeString == "Byte[]")
                body += "\n            if (value == null) return false;";
            if (item.Name.StartsWith("VLQ", StringComparison.Ordinal))
            {
                if (item.TypeString == "UInt24") body += "\n            if ((UInt32)value > 0xFFFFFFU) return false;";
                body += "\n            var required = SpanUtils.MeasureVLQ(value);";
            }
            else if (item.Name == "Size")
                body += "\n            if (value > 0x3FFFFFFFU) return false;\n            var required = SpanUtils.MeasureWriteSize(value);";
            else if (item.Name.StartsWith("Sized", StringComparison.Ordinal))
            {
                body += item.TypeString == "String" ? "\n            var count = Encoding.UTF8.GetByteCount(value);" : "\n            var count = value.Length;";
                body += "\n            if (count > 0x3FFFFFFF) return false;\n            var required = count + SpanUtils.MeasureWriteSize((UInt32)count);";
            }
            else body += item.TypeString == "String" ? "\n            var required = Encoding.UTF8.GetByteCount(value);" : "\n            var required = value.Length;";
            body += $"\n            if (span.Length < required) return false;\n            SpanUtils.{name}({arguments}, out length);\n            return true;";
            var tryName = "Try" + name;
            Method(methods, "bool", tryName, parameters + ", out int length", body);
            Method(methods, "bool", tryName, parameters, $"SpanUtils.{tryName}({arguments}, out _);");
            Method(extensions, "bool", tryName, extensionParameters + ", out int length", $"SpanUtils.{tryName}({arguments}, out length);");
            Method(extensions, "bool", tryName, extensionParameters, $"SpanUtils.{tryName}({arguments}, out _);");
        }
        private static void Read(StringBuilder methods, StringBuilder extensions, MethodData item, Endianness endian, bool move, string spanType)
        {
            var name = (move ? "Move" : "") + item.GetReadName(endian);
            var reference = move ? "ref " : "";
            var extraDef = string.IsNullOrEmpty(item.ExtraReadParamsDef) ? "" : ", " + item.ExtraReadParamsDef;
            var extraCall = string.IsNullOrEmpty(item.ExtraReadParams) ? "" : ", " + item.ExtraReadParams;
            var parameters = reference + spanType + " span" + extraDef;
            var extensionParameters = "this " + reference + spanType + " span" + extraDef;
            var arguments = reference + "span" + extraCall;
            if (item.NoLengthParam)
            {
                Method(methods, item.TypeString, name, parameters, Body(item.GetReadBody(endian), item, move, false));
                Method(extensions, item.TypeString, name, extensionParameters, $"SpanUtils.{name}({arguments});");
                var tryNameRaw = "Try" + name;
                Method(methods, "bool", tryNameRaw, parameters + $", out {item.TypeString} value", $"\n            if ((uint)length > (uint)span.Length) {{ value = default; return false; }}\n            value = SpanUtils.{name}({arguments});\n            return true;");
                Method(extensions, "bool", tryNameRaw, extensionParameters + $", out {item.TypeString} value", $"SpanUtils.{tryNameRaw}({arguments}, out value);");
                return;
            }
            if (item.Size == "length")
            {
                Method(methods, item.TypeString, name, parameters, $"SpanUtils.{name}({arguments}, out _);");
                Method(methods, item.TypeString, name, parameters + ", out int length", Body(item.GetReadBody(endian), item, move, true));
            }
            else
            {
                Method(methods, item.TypeString, name, parameters, Body(item.GetReadBody(endian), item, move, false));
                Method(methods, item.TypeString, name, parameters + ", out int length", $"\n            var ret = SpanUtils.{name}({arguments});\n            length = {item.Size};\n            return ret;");
            }
            Method(extensions, item.TypeString, name, extensionParameters, $"SpanUtils.{name}({arguments});");
            Method(extensions, item.TypeString, name, extensionParameters + ", out int length", $"SpanUtils.{name}({arguments}, out length);");
            if (item.Size == "length") { ReadTryVariable(methods, extensions, item, name, parameters, extensionParameters, arguments, move); return; }
            var tryName = "Try" + name;
            var validation = item.TypeString == "Decimal" && endian != Endianness.Default
                ? $" || !SpanUtils.IsValidDecimalEncoding(span, {(endian == Endianness.BE ? "true" : "false")})" : "";
            var tryBody = $"\n            if (span.Length < {item.Size}{validation}) {{ value = default; length = 0; return false; }}\n            value = SpanUtils.{name}({arguments});\n            length = {item.Size};\n            return true;";
            Method(methods, "bool", tryName, parameters + $", out {item.TypeString} value, out int length", tryBody);
            Method(methods, "bool", tryName, parameters + $", out {item.TypeString} value", $"SpanUtils.{tryName}({arguments}, out value, out _);");
            Method(extensions, "bool", tryName, extensionParameters + $", out {item.TypeString} value, out int length", $"SpanUtils.{tryName}({arguments}, out value, out length);");
            Method(extensions, "bool", tryName, extensionParameters + $", out {item.TypeString} value", $"SpanUtils.{tryName}({arguments}, out value, out _);");
        }

        private static void Write(StringBuilder methods, StringBuilder extensions, MethodData item, Endianness endian, bool move)
        {
            var name = (move ? "Move" : "") + item.GetWriteName(endian);
            var reference = move ? "ref " : "";
            var parameters = reference + "Span<byte> span, " + item.TypeString + " value";
            var extensionParameters = "this " + parameters;
            var arguments = reference + "span, value";
            if (item.Size == "length")
            {
                Method(methods, "void", name, parameters, $"SpanUtils.{name}({arguments}, out _);");
                Method(methods, "void", name, parameters + ", out int length", Body(item.GetWriteBody(endian), item, move, true));
            }
            else
            {
                Method(methods, "void", name, parameters, Body(item.GetWriteBody(endian), item, move, false));
                Method(methods, "void", name, parameters + ", out int length", $"\n            SpanUtils.{name}({arguments});\n            length = {item.Size};");
            }
            Method(extensions, "void", name, extensionParameters, $"SpanUtils.{name}({arguments});");
            Method(extensions, "void", name, extensionParameters + ", out int length", $"SpanUtils.{name}({arguments}, out length);");
            if (item.Size == "length") { WriteTryVariable(methods, extensions, item, name, parameters, extensionParameters, arguments); return; }
            var tryName = "Try" + name;
            var invalid = item.Name == "Int24" ? " || value < -8388608 || value > 8388607"
                : item.Name == "UInt24" ? " || (UInt32)value > 0xFFFFFFU" : "";
            Method(methods, "bool", tryName, parameters + ", out int length", $"\n            if (span.Length < {item.Size}{invalid}) {{ length = 0; return false; }}\n            SpanUtils.{name}({arguments});\n            length = {item.Size};\n            return true;");
            Method(methods, "bool", tryName, parameters, $"SpanUtils.{tryName}({arguments}, out _);");
            Method(extensions, "bool", tryName, extensionParameters + ", out int length", $"SpanUtils.{tryName}({arguments}, out length);");
            Method(extensions, "bool", tryName, extensionParameters, $"SpanUtils.{tryName}({arguments}, out _);");
        }
    }
}
