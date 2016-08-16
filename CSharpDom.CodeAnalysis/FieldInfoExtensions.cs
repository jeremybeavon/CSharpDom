using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;

namespace CSharpDom.CodeAnalysis
{
    public static class FieldDefinitionExtensions
    {
        public static bool IsVolatile(this FieldDefinition field)
        {
            return field.FullName.Contains("modreq(System.Runtime.CompilerServices.IsVolatile)");
        }
    }
}
