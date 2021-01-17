using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Tedd.SpanUtils.SourceGenerator
{
    public static class CodeGenSpanStream
    {

        public static void Generate(string root)
        {
            var le = true;


            {
                var sb = new StringBuilder();

                foreach (var ds in CodeGenBodies.DataStructures)
                {
                    GenReadBody(ds, sb, false);
                    GenWriteBody(ds, sb, false);
                }

                var str = Helper.CreateRefStruct("SpanStream", sb.ToString(), "");
                var ns = Helper.CreateNamespace("Tedd", str, CodeGenBodies.usings);
                var fn = Path.Combine(root, "SpanStream.generated.cs");
                if (File.Exists(fn))
                    File.Delete(fn);
                File.WriteAllText(fn, ns);
            }
            {
                var sb = new StringBuilder();

                foreach (var ds in CodeGenBodies.DataStructures)
                {
                    GenReadBody(ds, sb, true);
                    GenWriteBody(ds, sb, true);
                }
                var str = Helper.CreateClass(false, "MemoryStreamer", sb.ToString(), "");
                var ns = Helper.CreateNamespace("Tedd", str, CodeGenBodies.usings);
                var fn = Path.Combine(root, "MemoryStreamer.generated.cs");
                if (File.Exists(fn))
                    File.Delete(fn);
                File.WriteAllText(fn, ns);
            }
        }

        private static string Sj(List<string> l) => String.Join(", ", l);

        private static void GenReadBody(MethodData ds, StringBuilder sb, bool isMemoryStreamer)
        {
            if (ds.RW == MethodRW.WriteOnly)
                return;

            var memory = isMemoryStreamer ? "Memory." : "";
            List<string> pDef = new();
            List<string> p = new();


            if (!string.IsNullOrWhiteSpace(ds.ExtraReadParamsDef))
                pDef.Add(ds.ExtraReadParamsDef);
            if (!string.IsNullOrWhiteSpace(ds.ExtraReadParams))
                p.Add(ds.ExtraReadParams);
            var retType = ds.TypeString;
            
            if (isMemoryStreamer && ds.TypeString == typeof(byte).Name && ds.Name == typeof(byte).Name)
            {
                retType = "override int";
            }
            if (!ds.NoLengthParam)
            {
                var pC = new List<string>(p);
                pC.Add("out _");
                Helper.Method(sb, false, retType, $"Read{ds.Name}", Sj(pDef), $"Read{ds.Name}({Sj(pC)});", "");
                pDef.Add("out int length");
                p.Add("out length");
            }


            Helper.Method(sb, false, ds.TypeString, $"Read{ds.Name}", Sj(pDef), @$"
            var ret = SpanUtils.Read{ds.Name}({memory}Span.Slice(_position), {Sj(p)});
            Position += {ds.Size};
            return ret;", "");

        }
        private static void GenWriteBody(MethodData ds, StringBuilder sb, bool isMemoryStreamer)
        {
            if (ds.IsAlias || ds.RW == MethodRW.ReadOnly)
                return;

            var name = $"Write{ds.WriteName}";
            var memory = isMemoryStreamer ? "Memory." : "";

            List<string> pDef = new();
            List<string> p = new();

            pDef.Add($"{ds.TypeString} value");
            p.Add("value");


            if (!ds.NoLengthParam)
            {
            }
            sb.Append($@"
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void {name}({Sj(pDef)}) => {name}({Sj(p)}, out _);
");
            pDef.Add("out int length");
            p.Add("out length");

            sb.Append($@"
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void {name}({Sj(pDef)}) {{
            SpanUtils.{name}({memory}Span.Slice(_position), {Sj(p)});
            Position += {ds.Size};
        }}");
        }
    }
}