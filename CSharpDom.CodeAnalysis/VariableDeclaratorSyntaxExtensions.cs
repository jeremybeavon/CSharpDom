using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    internal static class VariableDeclaratorSyntaxExtensions
    {
        public static VariableDeclaratorSyntax WithInitialValue(
            this VariableDeclaratorSyntax parentSyntax,
            ExpressionSyntax childSyntax)
        {
            if (childSyntax == null)
            {
                return parentSyntax.WithInitializer(null);
            }

            EqualsValueClauseSyntax valueSyntax = parentSyntax.Initializer;
            return valueSyntax == null ?
                parentSyntax.WithInitializer(SyntaxFactory.EqualsValueClause(childSyntax)) :
                parentSyntax.WithInitializer(parentSyntax.Initializer.WithValue(childSyntax));
        }
    }
}
