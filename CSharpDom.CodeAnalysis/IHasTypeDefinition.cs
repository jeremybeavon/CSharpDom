using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;

namespace CSharpDom.CodeAnalysis
{
    public interface IHasTypeDefinition
    {
        TypeDefinition TypeDefinition { get; }
    }
}
