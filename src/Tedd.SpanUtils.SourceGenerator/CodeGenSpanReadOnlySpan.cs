using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Tedd.SpanUtils.SourceGenerator
{
    public static class CodeGenSpanReadOnlySpan
    {
        private static string tab = "    ";


        public static void GenerateSpanMethods(string className, string dir)
        {
            var methods = new StringBuilder();
            var extensions = new StringBuilder();
            extensions.AppendLine("");


            var le = true;

            // Read
            GenerateReadMethods(le, methods, extensions, false);
            GenerateReadMethods(le, methods, extensions, true);
            GenerateWriteMethods(le, methods, extensions, false);
            GenerateWriteMethods(le, methods, extensions, true);
            var class1 = Helper.CreateClass(className, methods.ToString(), @"");
            var class2 = Helper.CreateClass(className + "ExtensionMethods", extensions.ToString(), @"");
            var file = Helper.CreateNamespace("Tedd", class1 + "\r\n\r\n" + class2, CodeGenBodies.usings);
            File.WriteAllText(Path.Combine(dir, "SpanUtils.generated.cs"),
                Helper.CreateNamespace("Tedd", class1, CodeGenBodies.usings));
            File.WriteAllText(Path.Combine(dir, "ExtensionMethods.generated.cs"),
                Helper.CreateNamespace("Tedd", class2, CodeGenBodies.usings));
        }

        private static void GenerateReadMethods(bool le, StringBuilder methods, StringBuilder extensions, bool move)
        {
            string CreateBody(string body, MethodData ds, string len, string move)
            {
                var b = body;
                if (!ds.NoLengthParam && !string.IsNullOrWhiteSpace(len) && len != "length")
                    len = $"length = {len};";
                else
                    len = "";
                b = b.Replace("[LEN]", len);
                b = b.Replace("[MOVE]", move);
                return b;
            }

            if (move)
            {
                Helper.Method(extensions, true, "void", "Move", "ref this Span<byte> span, int length", "span = span.Slice(length);", "");
                Helper.Method(extensions, true, "void", "Move", "ref this ReadOnlySpan<byte> span, int length", "span = span.Slice(length);", "");
                Helper.Method(methods, true, "void", "Move", "ref Span<byte> span, int length", "span = span.Slice(length);", "");
                Helper.Method(methods, true, "void", "Move", "ref ReadOnlySpan<byte> span, int length", "span = span.Slice(length);", "");
                //AddWithInline(extensions, $"{tab}{tab}public static void Move(ref this Span<byte> span, int length) {{ span = span.Slice(length); }}");
                //AddWithInline(extensions, $"{tab}{tab}public static void Move(ref this ReadOnlySpan<byte> span, int length) {{ span = span.Slice(length); }}");
                //AddWithInline(methods, $"{tab}{tab}public static void Move(ref Span<byte> span, int length) {{ span = span.Slice(length); }}");
                //AddWithInline(methods, $"{tab}{tab}public static void Move(ref ReadOnlySpan<byte> span, int length) {{ span = span.Slice(length); }}");
            }

            // Since extension methods causes defensive copying we duplicate the code instead of forming a chain.
            string methodName(string t) => (move ? "Move" : "") + $"Read{t}" + (!le ? "BE" : "");
            foreach (var ds in CodeGenBodies.DataStructures)
            {
                if (ds.RW == MethodRW.WriteOnly)
                    continue;

                var outRef = (move ? "ref " : "");
                // For "Move" we need out parameter
                var cParams = $"span";
                // Extra parameters in addition to span
                if (!string.IsNullOrWhiteSpace(ds.ExtraReadParamsDef))
                    cParams += $", {ds.ExtraReadParamsDef}";

                // Method name and skeleton body
                var mn = methodName(ds.Name);
                var body = ds.GetReadBody(le);

                var moveStr = "";
                if (move && !string.IsNullOrWhiteSpace(ds.Size))
                    moveStr = $"span = span.Slice({ds.Size});";


                var fwdExtraParams = string.IsNullOrWhiteSpace(ds.ExtraReadParams) ? "" : $", {ds.ExtraReadParams}";


                // Without "out var length": Compiler will optimize away assignment
                if (ds.NoLengthParam)
                {
                    // We use "length" as input parameter so we won't add any length logic to it

                    // Create method for ReadOnlySpan<byte>
                    Helper.Method(methods, true, ds.TypeString, mn, $"{outRef} ReadOnlySpan<byte> {cParams}", CreateBody(body, ds, "", moveStr), "");
                    Helper.Method(methods, true, ds.TypeString, mn, $"{outRef} Span<byte> {cParams}", CreateBody(body, ds, "", moveStr), "");
                    // Alias from Span to ReadOnlySpan
                    //methods.AppendLine($"            public static {ds.TypeString} {mn}({outRef}Span<byte>{cParams}) => SpanUtils.{mn}({outRef}span{fwdExtraParams});");

                    // Extension method alias for ReadOnlySpan and Span
                    Helper.Method(extensions, true, ds.TypeString, mn, $"{outRef}this Span<byte>{cParams}", $"SpanUtils.{mn}({outRef}span{fwdExtraParams});", "");
                    Helper.Method(extensions, true, ds.TypeString, mn, $"{outRef}this ReadOnlySpan<byte>{cParams}", $"SpanUtils.{mn}({outRef}span{fwdExtraParams});", "");
                    //AddWithInline(extensions, $"{tab}{tab}public static {ds.TypeString} {mn}({outRef}this Span<byte>{cParams})         => SpanUtils.{mn}({outRef}span{fwdExtraParams});");
                    //AddWithInline(extensions, $"{tab}{tab}public static {ds.TypeString} {mn}({outRef}this ReadOnlySpan<byte>{cParams}) => SpanUtils.{mn}({outRef}span{fwdExtraParams});");
                }
                else
                // With "out var length"
                {
                    // Overloads ignoring "out int length" allowing compiler to optimize it away
                    Helper.Method(methods, true, ds.TypeString, mn, $"{outRef} Span<byte>{cParams}", $"SpanUtils.{mn}({outRef}span{fwdExtraParams}, out _);", "");
                    Helper.Method(methods, true, ds.TypeString, mn, $"{outRef} ReadOnlySpan<byte>{cParams}", $"SpanUtils.{mn}({outRef}span{fwdExtraParams}, out _);", "");
                    //AddWithInline(methods, $"{tab}{tab}public static {ds.TypeString} {mn}({outRef}Span<byte>{cParams})                 => SpanUtils.{mn}({outRef}span{fwdExtraParams}, out _);");
                    //AddWithInline(methods, $"{tab}{tab}public static {ds.TypeString} {mn}({outRef}ReadOnlySpan<byte>{cParams})         => SpanUtils.{mn}({outRef}span{fwdExtraParams}, out _);");

                    // Full method
                    Helper.Method(methods, true, ds.TypeString, mn, $"{outRef}Span<byte> {cParams}, out int length", CreateBody(body, ds, ds.Size, moveStr), "");
                    Helper.Method(methods, true, ds.TypeString, mn, $"{outRef}ReadOnlySpan<byte> {cParams}, out int length", CreateBody(body, ds, ds.Size, moveStr), "");

                    // Extension method
                    // Overload for Span<byte>
                    Helper.Method(extensions, true, ds.TypeString, mn, $"{outRef}this Span<byte>{cParams}, out int length", $"SpanUtils.{mn}({outRef}span{fwdExtraParams}, out length);", "");
                    Helper.Method(extensions, true, ds.TypeString, mn, $"{outRef}this ReadOnlySpan<byte>{cParams}, out int length", $"SpanUtils.{mn}({outRef}span{fwdExtraParams}, out length);", "");
                    //AddWithInline(extensions, $"{tab}{tab}public static {ds.TypeString} {mn}({outRef}this Span<byte>{cParams}, out int length)         => SpanUtils.{mn}({outRef}span{fwdExtraParams}, out length);");
                    //AddWithInline(extensions, $"{tab}{tab}public static {ds.TypeString} {mn}({outRef}this ReadOnlySpan<byte>{cParams}, out int length) => SpanUtils.{mn}({outRef}span{fwdExtraParams}, out length);");
                    // Overloads ignoring "out int length" allowing compiler to optimize it away
                    Helper.Method(extensions, true, ds.TypeString, mn, $"{outRef}this Span<byte>{cParams}", $"SpanUtils.{mn}({outRef}span{fwdExtraParams}, out _);", "");
                    Helper.Method(extensions, true, ds.TypeString, mn, $"{outRef}this ReadOnlySpan<byte>{cParams}", $"SpanUtils.{mn}({outRef}span{fwdExtraParams}, out _);", "");
                    //AddWithInline(extensions, $"{tab}{tab}public static {ds.TypeString} {mn}({outRef}this Span<byte>{cParams})                         => SpanUtils.{mn}({outRef}span{fwdExtraParams}, out _);");
                    //AddWithInline(extensions, $"{tab}{tab}public static {ds.TypeString} {mn}({outRef}this ReadOnlySpan<byte>{cParams})                 => SpanUtils.{mn}({outRef}span{fwdExtraParams}, out _);");


                }
            }

        }
        private static void GenerateWriteMethods(bool le, StringBuilder methods, StringBuilder extensions, bool move)
        {
            string CreateBody(string body, MethodData ds, string len, string move)
            {
                var b = body;
                if (!ds.NoLengthParam && !string.IsNullOrWhiteSpace(len) && len != "length")
                    len = $"length = {len};";
                else
                    len = "";
                b = b.Replace("[LEN]", len);
                b = b.Replace("[MOVE]", move);
                return b;
            }

            // Since extension methods causes defensive copying we duplicate the code instead of forming a chain.
            string methodName(string t) => (move ? "Move" : "") + $"Write{t}" + (!le ? "BE" : "");
            foreach (var ds in CodeGenBodies.DataStructures)
            {
                // We skip aliases
                if (ds.IsAlias || ds.RW == MethodRW.ReadOnly)
                    continue;


                var outRef = (move ? "ref " : "");
                // For "Move" we need out parameter
                var cParams = $"span, {ds.TypeString} value";
                //// Extra parameters in addition to span
                //if (!string.IsNullOrWhiteSpace(ds.ExtraReadParamsDef))
                //    cParams += $", {ds.ExtraReadParamsDef}";

                // Method name and skeleton body
                var mn = methodName(ds.WriteName);
                var body = ds.GetWriteBody(le);

                var moveStr = "";
                if (move && !string.IsNullOrWhiteSpace(ds.Size))
                    moveStr = $"span = span.Slice({ds.Size});";


                //var fwdExtraParams = string.IsNullOrWhiteSpace(ds.ExtraReadParams) ? "" : $", {ds.ExtraReadParams}";


                // Without "out var length": Compiler will optimize away assignment
                //if (ds.NoLengthParam)
                //{
                //    // We use "length" as input parameter so we won't add any length logic to it

                //    // Create method for ReadOnlySpan<byte>
                //    methods.AppendLine(CodeGenClassHelper.CreateMethod(mn, "void", $"{outRef} Span<byte> {cParams}", CreateBody(body, ds, "", moveStr), ""));
                //    // Alias from Span to ReadOnlySpan
                //    //methods.AppendLine($"            public static {ds.TypeString} {mn}({outRef}Span<byte>{cParams}) => SpanUtils.{mn}({outRef}span{fwdExtraParams});");

                //    // Extension method alias for ReadOnlySpan and Span
                //    AddWithInline(extensions, $"{tab}{tab}public static void {mn}({outRef}this Span<byte>{cParams})         => SpanUtils.{mn}({outRef}span, value{fwdExtraParams});");
                //}
                //else
                // With "out var length"
                {
                    // Overloads ignoring "out int length" allowing compiler to optimize it away
                    Helper.Method(methods, true, "void", mn, $"{outRef}Span<byte>{cParams}", $"SpanUtils.{mn}({outRef}span, value, out _);", "");
                    //AddWithInline(methods, $"{tab}{tab}public static void {mn}({outRef}Span<byte>{cParams})                 => SpanUtils.{mn}({outRef}span, value, out _);");

                    // Full method
                    Helper.Method(methods, true, "void", mn, $"{outRef}Span<byte> {cParams}, out int length", CreateBody(body, ds, ds.Size, moveStr), "");

                    // Extension method
                    // Overload for Span<byte>
                    Helper.Method(extensions, true, "void", mn, $"{outRef}this Span<byte>{cParams}, out int length", $"SpanUtils.{mn}({outRef}span, value, out length);", "");
                    //AddWithInline(extensions, $"{tab}{tab}public static void {mn}({outRef}this Span<byte>{cParams}, out int length)         => SpanUtils.{mn}({outRef}span, value, out length);");
                    // Overloads ignoring "out int length" allowing compiler to optimize it away
                    Helper.Method(extensions, true, "void", mn, $"{outRef}this Span<byte>{cParams}", $"SpanUtils.{mn}({outRef}span, value, out _);", "");
                    //AddWithInline(extensions, $"{tab}{tab}public static void {mn}({outRef}this Span<byte>{cParams})                         => SpanUtils.{mn}({outRef}span, value, out _);");


                }
            }

        }

        //private static void AddWithInline(StringBuilder sb, string method)
        //{
        //    sb.AppendLine($"\r\n{tab}{tab}[MethodImpl(MethodImplOptions.AggressiveInlining)]");
        //    sb.AppendLine(method);
        //}
    }
}