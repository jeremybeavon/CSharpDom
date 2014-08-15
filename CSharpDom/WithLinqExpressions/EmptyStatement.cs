using System.Linq.Expressions;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithLinqExpressions
{
    public sealed class EmptyStatement : LinqExpressionMapping<DefaultExpression, EmptyStatementSyntax>
    {
        internal EmptyStatement(DefaultExpression expression, EmptyStatementSyntax syntax)
            : base(expression, syntax)
        {
        }
    }
}
