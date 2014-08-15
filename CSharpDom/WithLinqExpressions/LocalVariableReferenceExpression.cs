using System.Linq.Expressions;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithLinqExpressions
{
    public sealed class LocalVariableReferenceExpression : LinqExpressionMapping<ParameterExpression, IdentifierNameSyntax>
    {
        internal LocalVariableReferenceExpression(ParameterExpression expression, IdentifierNameSyntax syntax)
            : base(expression, syntax)
        {
        }
    }
}
