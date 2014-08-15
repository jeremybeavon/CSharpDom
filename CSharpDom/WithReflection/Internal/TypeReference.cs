using System;
using System.Reflection;

namespace CSharpDom.WithReflection.Internal
{
    internal sealed class TypeReference
    {
        public TypeReference(string typeName, Assembly assembly)
        {
            TypeName = typeName;
            Assembly = assembly;
        }

        public string TypeName { get; private set; }

        public Assembly Assembly { get; private set; }

        public Type Type
        {
            get { return Assembly.GetType(TypeName); }
        }
    }
}
