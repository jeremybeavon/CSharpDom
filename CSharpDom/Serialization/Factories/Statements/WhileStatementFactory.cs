using CSharpDom.Common.Statements;
using CSharpDom.Serialization.Factories.Expressions;
using CSharpDom.Serialization.Statements;

namespace CSharpDom.Serialization.Factories.Statements
{
    public sealed class WhileStatementFactory : AbstractStatementFactory<IWhileStatement, WhileStatement>
    {
        public WhileStatementFactory(IWhileStatement statement)
            : base(statement)
        {
        }

        public override void VisitWhileStatement<TExpression, TStatement>(IWhileStatement<TExpression, TStatement> whileStatement)
        {
            Value = new WhileStatement()
            {
                Condition = new ExpressionFactory(whileStatement.Condition).Value,
                Statement = new StatementFactory(whileStatement.Statement).Value
            };
        }
    }
}
