using Mono.Cecil;
using System;

namespace CSharpDom.Mono.Cecil.Internal
{
    internal static class AssemblyWithMonoCecilExtensions
    {
        public static TypeReference GetTypeReference(this AssemblyWithMonoCecil assembly, Type type)
        {
            return assembly.Assembly.MainModule.Import(type);
        }
    }
}
