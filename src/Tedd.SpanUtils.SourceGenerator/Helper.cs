using System.Text;

namespace Tedd.SpanUtils.SourceGenerator
{
    public static class Helper
    {
        public static string CreateNamespace(string name, string content, string @using) => $@"// This file is auto-generated. Do not modify.
{@using}namespace {name} {{
{content}
}}
";

        public static string CreateClass(bool isStatic, string name, string content, string description)
        {
            var @static = isStatic ? "static " : "";
            if (!description.EndsWith("\r\n"))
                description += "\r\n";
            return $@"    public {@static}partial class {name} {{{content}
    }}
";
        }
        public static string CreateRefStruct(string name, string content, string description)
        {
            if (!description.EndsWith("\r\n"))
                description += "\r\n";
            return $@"    public ref partial struct {name} {{{content}
    }}
";
        }
        public static void Method(StringBuilder sb, bool isStatic, string returnType, string name, string @params, string body, string description)
        {
            var @static = isStatic ? "static " : "";
            if (!description.EndsWith("\r\n"))
                description += "\r\n";
            if (body.Contains("\r\n"))
            sb.Append($@"
{description}        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {@static}{returnType} {name}({@params}) {{{body}
        }}
");
            else
                sb.Append($@"
{description}        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public {@static}{returnType} {name}({@params}) => {body}
");
        }
    }
}