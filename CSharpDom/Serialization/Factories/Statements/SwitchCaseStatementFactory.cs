using CSharpDom.Common.Statements;
using CSharpDom.Serialization.Factories.Expressions;
using CSharpDom.Serialization.Statements;

namespace CSharpDom.Serialization.Factories.Statements
{
    public sealed class SwitchCaseStatementFactory : AbstractStatementFactory<ISwitchCaseStatement, SwitchCaseStatement>
    {
        public SwitchCaseStatementFactory(ISwitchCaseStatement statement)
            : base(statement)
        {
        }

        public override void VisitSwitchCaseStatement<TExpression, TStatement>(ISwitchCaseStatement<TExpression, TStatement> switchCaseStatement)
        {
            Value = new SwitchCaseStatement()
            {
                Match = new ExpressionFactory(switchCaseStatement.Match).Value,
                Statements = switchCaseStatement.Statements.ToStatementListUsingFactory()
            };
        }
    }
}
