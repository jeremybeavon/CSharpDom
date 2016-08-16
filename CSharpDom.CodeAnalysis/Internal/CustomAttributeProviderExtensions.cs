using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Linq;

namespace CSharpDom.CodeAnalysis.Internal
{
    internal static class CustomAttributeProviderExtensions
    {
        public static bool IsDefined(this ICustomAttributeProvider attributeProvider, AssemblyWithCodeAnalysis assembly, Type type)
        {
            return attributeProvider.CustomAttributes.Any(attribute => attribute.AttributeType.FullName == type.FullName);
        }
    }
}
