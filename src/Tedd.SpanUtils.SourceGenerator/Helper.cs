using System.Text;

namespace Tedd.SpanUtils.SourceGenerator
{
    public static class Helper
    {
        public static string CreateNamespace(string name, string content, string usings) => Normalize($@"// This file is auto-generated. Do not modify.
{usings}namespace {name} {{
{content}
}}");

        public static string CreateClass(bool isStatic, string name, string content, string description) =>
            $"    public {(isStatic ? "static " : "")}partial class {name} {{{content}\n    }}\n";

        public static string CreateRefStruct(string name, string content, string description) =>
            $"    public ref partial struct {name} {{{content}\n    }}\n";

        public static void Method(StringBuilder output, bool isStatic, string returnType, string name, string parameters, string body, string description)
        {
            var prefix = isStatic ? "static " : "";
            output.AppendLine();
            if (!string.IsNullOrWhiteSpace(description)) output.AppendLine(description.TrimEnd());
            output.AppendLine("        [MethodImpl(MethodImplOptions.AggressiveInlining)]");
            if (body.Contains('\n'))
                output.Append($"        public {prefix}{returnType} {name}({parameters}) {{{body}\n        }}\n");
            else
                output.Append($"        public {prefix}{returnType} {name}({parameters}) => {body}\n");
        }

        private static string Normalize(string source)
        {
            var result = new StringBuilder();
            foreach (var line in source.Replace("\r\n", "\n").Trim('\r', '\n').Split('\n'))
                result.Append(line.TrimEnd()).Append('\n');
            return result.ToString();
        }
    }
}
