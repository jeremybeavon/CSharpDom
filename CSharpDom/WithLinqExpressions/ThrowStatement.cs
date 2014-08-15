using System.Linq.Expressions;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithLinqExpressions
{
    public sealed class ThrowStatement : LinqExpressionMapping<UnaryExpression, ThrowStatementSyntax>
    {
        internal ThrowStatement(UnaryExpression expression, ThrowStatementSyntax syntax)
            : base(expression, syntax)
        {
        }

        public ILinqExpressionMapping ThrowExpression { get; internal set; }
    }
}
