using System;
using System.Reflection;

namespace Tedd.SpanUtils.SourceGenerator
{
    public enum MethodRW
    {
        ReadOnly,
        WriteOnly,
        Both
    };
    public class MethodData
    {
        public string Name;
        public Type? Type;
        public MethodInfo ReadBody;
        public MethodInfo WriteBody;
        private string _typeString;

        public string TypeString
        {
            get => Type?.Name ?? _typeString;
            set => _typeString = value;
        }

        public Endianness Endian = Endianness.All;

        public string WriteName;

        //public bool WriteNameOnly=true;

        public string Size;
        public string? ExtraReadParams;
        public bool NoLengthParam;
        public string ExtraReadParamsDef;
        public MethodRW RW = MethodRW.Both;
        public bool IsAlias = false;

        public string GetReadBody(Endianness le)
        {
            if (BitConverter.IsLittleEndian)
            {
                if (le == Endianness.LE)
                    le = Endianness.Default;
            }
            else
                if (le == Endianness.BE)
                le = Endianness.Default;

            var body = (string)ReadBody.Invoke(null, new object[] { le });
            body = le switch
            {
                Endianness.BE => body.Replace("[LEBE]", "BE"),
                Endianness.LE => body.Replace("[LEBE]", "LE"),
                Endianness.Default => body.Replace("[LEBE]", "")
            };
            return body;
        }

        public string GetWriteBody(Endianness le)
        {
            if (BitConverter.IsLittleEndian)
            {
                if (le == Endianness.LE)
                    le = Endianness.Default;
            }
            else
                if (le == Endianness.BE)
                le = Endianness.Default;

            var body = (string)WriteBody.Invoke(null, new object[] { le });
            body = le switch
            {
                Endianness.BE => body.Replace("[LEBE]", "BE"),
                Endianness.LE => body.Replace("[LEBE]", "LE"),
                Endianness.Default => body.Replace("[LEBE]", "")
            };
            return body;
        }
    }
}