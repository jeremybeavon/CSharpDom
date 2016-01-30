using CSharpDom.Common.Statements;
using CSharpDom.Serialization.Factories.Expressions;
using CSharpDom.Serialization.Statements;

namespace CSharpDom.Serialization.Factories.Statements
{
    public sealed class ExpressionStatementFactory : AbstractStatementFactory<IExpressionStatement, ExpressionStatement>
    {
        public ExpressionStatementFactory(IExpressionStatement statement)
            : base(statement)
        {
        }

        public override void VisitExpressionStatement<TExpression>(IExpressionStatement<TExpression> expressionStatement)
        {
            Value = new ExpressionStatement()
            {
                Expression = new ExpressionFactory(expressionStatement.Expression).Value
            };
        }
    }
}
