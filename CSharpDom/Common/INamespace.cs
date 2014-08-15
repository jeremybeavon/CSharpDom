using System.Collections.Generic;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.Common
{
    public interface INamespace
    {
        string Name { get; }

        IEnumerable<NamespaceDeclarationSyntax> Declarations { get; }
    }
}
