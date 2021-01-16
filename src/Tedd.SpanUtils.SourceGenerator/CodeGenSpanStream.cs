using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Tedd.SpanUtils.SourceGenerator
{
    public static class CodeGenSpanStream
    {
        private static string tab = "    ";

        public static void Generate(string root)
        {
            var le = true;
            var sb = new StringBuilder();

            foreach (var ds in CodeGenBodies.DataStructures)
            {
                GenReadBody(ds, sb);
                GenWriteBody(ds, sb);
            }

            var str = Helper.CreateRefStruct("SpanStream", sb.ToString(), "");
            var ns = Helper.CreateNamespace("Tedd", str, CodeGenBodies.usings);
            var fn = Path.Combine(root, "SpanStream.generated.cs");
            if (File.Exists(fn))
                File.Delete(fn);
            File.WriteAllText(fn, ns);
        }

        private static string Sj(List<string> l) => String.Join(", ", l);

        private static void GenReadBody(MethodData ds, StringBuilder sb)
        {
            if (ds.RW == MethodRW.WriteOnly)
                return;

            List<string> pDef = new();
            List<string> p = new();


            if (!string.IsNullOrWhiteSpace(ds.ExtraReadParamsDef))
                pDef.Add(ds.ExtraReadParamsDef);
            if (!string.IsNullOrWhiteSpace(ds.ExtraReadParams))
                p.Add(ds.ExtraReadParams);

            if (!ds.NoLengthParam)
            {
                var pC = new List<string>(p);
                pC.Add("out _");
                Helper.Method(sb, false, ds.TypeString, $"Read{ds.Name}", Sj(pDef), $"Read{ds.Name}({Sj(pC)});", "");
                //                sb.Append($@"
                //        [MethodImpl(MethodImplOptions.AggressiveInlining)]
                //        public {ds.TypeString} Read{ds.Name}({Sj(pDef)}) => Read{ds.Name}({Sj(pC)});
                //");
                pDef.Add("out int length");
                p.Add("out length");
            }


            //else
            //{
            //    if (!string.IsNullOrWhiteSpace(pP))
            //        pPNL += ", ";
            //    pPNL += "out int length";
            //}

            Helper.Method(sb, false, ds.TypeString, $"Read{ds.Name}", Sj(pDef), @$"
            var ret = SpanUtils.Read{ds.Name}(Span.Slice(_position), {Sj(p)});
            Position += {ds.Size};
            return ret;", "");

            //    sb.Append($@"
            //[MethodImpl(MethodImplOptions.AggressiveInlining)]
            //public {ds.TypeString} Read{ds.Name}({Sj(pDef)}) {{
            //    var ret = SpanUtils.Read{ds.Name}(Span.Slice(_position), {Sj(p)});
            //    Position += {ds.Size};
            //    return ret;
            //}}");
        }
        private static void GenWriteBody(MethodData ds, StringBuilder sb)
        {
            if (ds.IsAlias || ds.RW == MethodRW.ReadOnly)
                return;

            var name = $"Write{ds.WriteName}";

            List<string> pDef = new();
            List<string> p = new();

            pDef.Add($"{ds.TypeString} value");
            p.Add("value");


            //if (!string.IsNullOrWhiteSpace(ds.ExtraReadParamsDef))
            //    pDef.Add(ds.ExtraReadParamsDef);
            //if (!string.IsNullOrWhiteSpace(ds.ExtraReadParams))
            //    p.Add(ds.ExtraReadParams);

            if (!ds.NoLengthParam)
            {
            }
            sb.Append($@"
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void {name}({Sj(pDef)}) => {name}({Sj(p)}, out _);
");
            pDef.Add("out int length");
            p.Add("out length");
            //else
            //{
            //    if (!string.IsNullOrWhiteSpace(pP))
            //        pPNL += ", ";
            //    pPNL += "out int length";
            //}


            sb.Append($@"
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void {name}({Sj(pDef)}) {{
            SpanUtils.{name}(Span.Slice(_position), {Sj(p)});
            Position += {ds.Size};
        }}");
        }
    }
}