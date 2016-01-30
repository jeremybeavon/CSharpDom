using CSharpDom.Common.Statements;
using CSharpDom.Serialization.Factories.Expressions;
using CSharpDom.Serialization.Statements;

namespace CSharpDom.Serialization.Factories.Statements
{
    public sealed class LockStatementFactory : AbstractStatementFactory<ILockStatement, LockStatement>
    {
        public LockStatementFactory(ILockStatement statement)
            : base(statement)
        {
        }

        public override void VisitLockStatement<TExpression, TStatement>(ILockStatement<TExpression, TStatement> lockStatement)
        {
            Value = new LockStatement()
            {
                Expression = new ExpressionFactory(lockStatement.Expression).Value,
                Statement = new StatementFactory(lockStatement.Statement).Value
            };
        }
    }
}
