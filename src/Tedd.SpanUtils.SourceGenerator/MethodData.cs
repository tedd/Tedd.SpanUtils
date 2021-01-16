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

        public string WriteName;

        //public bool WriteNameOnly=true;

        public string Size;
        public string? ExtraReadParams;
        public bool NoLengthParam;
        public string ExtraReadParamsDef;
        public MethodRW RW = MethodRW.Both;
        public bool IsAlias=false;

        public string GetReadBody(bool le) => (string)ReadBody.Invoke(null, new object[] { le });
        public string GetWriteBody(bool le) => (string)WriteBody.Invoke(null, new object[] { le });

    }
}