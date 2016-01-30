using CSharpDom.Common.Statements;
using CSharpDom.Serialization.Factories.Expressions;
using CSharpDom.Serialization.Statements;

namespace CSharpDom.Serialization.Factories.Statements
{
    public sealed class ForStatementFactory : AbstractStatementFactory<IForStatement, ForStatement>
    {
        public ForStatementFactory(IForStatement statement)
            : base(statement)
        {
        }

        public override void VisitForStatement<TExpression, TForInitializerStatement, TStatement>(
            IForStatement<TExpression, TForInitializerStatement, TStatement> forStatement)
        {
            Value = new ForStatement()
            {
                Condition = new ExpressionFactory(forStatement.Condition).Value,
                IncrementExpressions = forStatement.IncrementExpressions.ToExpressionListUsingFactory(),
                InitialValueStatement = new ForInitializerStatementFactory(forStatement.InitialValueStatement).Value,
                Statement = new StatementFactory(forStatement.Statement).Value
            };
        }
    }
}
