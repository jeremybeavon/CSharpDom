using CSharpDom.Common.Statements;
using CSharpDom.Serialization.Factories.Expressions;
using CSharpDom.Serialization.Statements;

namespace CSharpDom.Serialization.Factories.Statements
{
    public sealed class ReturnStatementFactory : AbstractStatementFactory<IReturnStatement, ReturnStatement>
    {
        public ReturnStatementFactory(IReturnStatement statement)
            : base(statement)
        {
        }

        public override void VisitReturnStatement<TExpression>(IReturnStatement<TExpression> returnStatement)
        {
            Value = new ReturnStatement()
            {
                Expression = new ExpressionFactory(returnStatement.Expression).Value
            };
        }
    }
}
