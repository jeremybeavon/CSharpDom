using CSharpDom.Common.Statements;
using CSharpDom.Serialization.Factories.Expressions;
using CSharpDom.Serialization.Statements;

namespace CSharpDom.Serialization.Factories.Statements
{
    public sealed class UsingStatementFactory : AbstractStatementFactory<IUsingStatement, UsingStatement>
    {
        public UsingStatementFactory(IUsingStatement statement)
            : base(statement)
        {
        }

        public override void VisitUsingStatement<TExpression, TStatement>(IUsingStatement<TExpression, TStatement> usingStatement)
        {
            Value = new UsingStatement()
            {
                Expression = new ExpressionFactory(usingStatement.Expression).Value,
                Statement = new StatementFactory(usingStatement.Statement).Value
            };
        }
    }
}
