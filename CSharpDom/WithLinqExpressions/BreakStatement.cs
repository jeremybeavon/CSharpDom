using System.Linq.Expressions;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithLinqExpressions
{
    public sealed class BreakStatement : LinqExpressionMapping<GotoExpression, BreakStatementSyntax>
    {
        internal BreakStatement(GotoExpression expression, BreakStatementSyntax syntax)
            : base(expression, syntax)
        {
        }
    }
}
