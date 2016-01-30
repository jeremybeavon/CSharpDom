using CSharpDom.Common.Statements;
using CSharpDom.Serialization.Factories.Expressions;
using CSharpDom.Serialization.Statements;

namespace CSharpDom.Serialization.Factories.Statements
{
    public sealed class IfStatementFactory : AbstractStatementFactory<IIfStatement, IfStatement>
    {
        public IfStatementFactory(IIfStatement statement)
            : base(statement)
        {
        }

        public override void VisitIfStatement<TExpression, TStatement>(IIfStatement<TExpression, TStatement> ifStatement)
        {
            Value = new IfStatement()
            {
                Condition = new ExpressionFactory(ifStatement.Condition).Value,
                ThenStatement = new StatementFactory(ifStatement.ThenStatement).Value,
                ElseStatement = new StatementFactory(ifStatement.ElseStatement).Value
            };
        }
    }
}
