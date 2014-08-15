using System.Linq.Expressions;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithLinqExpressions
{
    public sealed class ParameterReferenceExpression : LinqExpressionMapping<ParameterExpression, IdentifierNameSyntax>
    {
        internal ParameterReferenceExpression(ParameterExpression expression, IdentifierNameSyntax syntax)
            : base(expression, syntax)
        {
        }
    }
}
