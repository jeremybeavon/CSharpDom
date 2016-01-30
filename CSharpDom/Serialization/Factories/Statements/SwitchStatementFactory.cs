using CSharpDom.Common.Statements;
using CSharpDom.Serialization.Factories.Expressions;
using CSharpDom.Serialization.Statements;

namespace CSharpDom.Serialization.Factories.Statements
{
    public sealed class SwitchStatementFactory : AbstractStatementFactory<ISwitchStatement, SwitchStatement>
    {
        public SwitchStatementFactory(ISwitchStatement statement)
            : base(statement)
        {
        }

        public override void VisitSwitchStatement<TExpression, TSwitchCaseStatement, TDefaultCaseStatement>(
            ISwitchStatement<TExpression, TSwitchCaseStatement, TDefaultCaseStatement> switchStatement)
        {
            Value = new SwitchStatement()
            {
                Cases = switchStatement.Cases.ToList(@case => new SwitchCaseStatementFactory(@case).Value),
                DefaultCase = new DefaultCaseStatementFactory(switchStatement.DefaultCase).Value,
                Expression = new ExpressionFactory(switchStatement.Expression).Value
            };
        }
    }
}
