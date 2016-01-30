using CSharpDom.Common.Statements;
using CSharpDom.Serialization.Factories.Expressions;
using CSharpDom.Serialization.Statements;

namespace CSharpDom.Serialization.Factories.Statements
{
    public sealed class DoStatementFactory : AbstractStatementFactory<IDoStatement, DoStatement>
    {
        public DoStatementFactory(IDoStatement statement)
            : base(statement)
        {
        }

        public override void VisitDoStatement<TExpression, TStatement>(IDoStatement<TExpression, TStatement> doStatement)
        {
            Value = new DoStatement()
            {
                Condition = new ExpressionFactory(doStatement.Condition).Value,
                Statement = new StatementFactory(doStatement.Statement).Value
            };
        }
    }
}
