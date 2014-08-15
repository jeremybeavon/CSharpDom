using System.Linq.Expressions;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithLinqExpressions
{
    public sealed class ContinueStatement : LinqExpressionMapping<GotoExpression, ContinueStatementSyntax>
    {
        internal ContinueStatement(GotoExpression expression, ContinueStatementSyntax syntax)
            : base(expression, syntax)
        {
        }
    }
}
