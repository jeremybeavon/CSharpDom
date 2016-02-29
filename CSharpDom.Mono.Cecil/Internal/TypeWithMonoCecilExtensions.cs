using Mono.Cecil;
using System;

namespace CSharpDom.Mono.Cecil.Internal
{
    internal static class TypeWithMonoCecilExtensions
    {
        public static TypeReference GetTypeReference(this ITypeWithMonoCecil typeWithMonoCecil, Type type)
        {
            return typeWithMonoCecil.Assembly.GetTypeReference(type);
        }
    }
}
