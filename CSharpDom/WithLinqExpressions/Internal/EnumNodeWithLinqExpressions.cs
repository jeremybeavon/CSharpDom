using CSharpDom.WithSyntax.Internal;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithLinqExpressions.Internal
{
    internal class EnumNodeWithLinqExpressions : EnumNodeWithSyntax
    {
        public EnumNodeWithLinqExpressions(EnumDeclarationSyntax declaration, ITypeContainer container)
            : base(declaration, container)
        {
        }
    }
}
