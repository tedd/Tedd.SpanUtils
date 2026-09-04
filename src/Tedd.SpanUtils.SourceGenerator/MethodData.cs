using System;
using System.Reflection;

namespace Tedd.SpanUtils.SourceGenerator
{
    public enum MethodRW { ReadOnly, WriteOnly, Both }

    public class MethodData
    {
        public string Name;
        public string Condition;
        public Type Type;
        public MethodInfo ReadBody;
        public MethodInfo WriteBody;
        private string _typeString;
        public string TypeString { get => Type?.Name ?? _typeString; set => _typeString = value; }
        public Endianness Endian = Endianness.All;
        public string WriteName;
        public string Size;
        public string ExtraReadParams;
        public bool NoLengthParam;
        public string ExtraReadParamsDef;
        public MethodRW RW = MethodRW.Both;
        public bool IsAlias;

        public string GetReadBody(Endianness endian) => Resolve(ReadBody, endian);
        public string GetWriteBody(Endianness endian) => Resolve(WriteBody, endian);
        private static string Resolve(MethodInfo method, Endianness endian) =>
            ((string)method.Invoke(null, new object[] { endian }))
                .Replace("[LEBE]", CodeGenBodies.EndiannessToMethodExtension(endian));
        public string GetReadName(Endianness endian) => "Read" + Name + CodeGenBodies.EndiannessToMethodExtension(endian);
        public string GetWriteName(Endianness endian) => "Write" + WriteName + CodeGenBodies.EndiannessToMethodExtension(endian);
    }
}
