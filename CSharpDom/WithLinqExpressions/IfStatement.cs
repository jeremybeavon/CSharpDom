using System.Linq.Expressions;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithLinqExpressions
{
    public sealed class IfStatement : LinqExpressionMapping<ConditionalExpression, IfStatementSyntax>
    {
        internal IfStatement(ConditionalExpression expression, IfStatementSyntax syntax)
            : base(expression, syntax)
        {
        }

        public ILinqExpressionMapping Condition { get; internal set; }

        public ILinqExpressionMapping TrueImplementation { get; internal set; }

        public ILinqExpressionMapping FalseImplementation { get; internal set; }
    }
}
