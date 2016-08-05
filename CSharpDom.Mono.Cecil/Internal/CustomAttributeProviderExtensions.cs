using Mono.Cecil;
using System;
using System.Linq;

namespace CSharpDom.Mono.Cecil.Internal
{
    internal static class CustomAttributeProviderExtensions
    {
        public static bool IsDefined(this ICustomAttributeProvider attributeProvider, AssemblyWithMonoCecil assembly, Type type)
        {
            return attributeProvider.CustomAttributes.Any(attribute => attribute.AttributeType.FullName == type.FullName);
        }
    }
}
