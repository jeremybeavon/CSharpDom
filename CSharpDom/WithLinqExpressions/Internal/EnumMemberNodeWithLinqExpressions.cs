using CSharpDom.WithSyntax.Internal;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithLinqExpressions.Internal
{
    internal class EnumMemberNodeWithLinqExpressions : EnumMemberNodeWithSyntax
    {
        public EnumMemberNodeWithLinqExpressions(EnumMemberDeclarationSyntax declaration, EnumNode container)
            : base(declaration, container)
        {
        }
    }
}
