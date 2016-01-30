using CSharpDom.Common.Statements;
using CSharpDom.Serialization.Statements;

namespace CSharpDom.Serialization.Factories.Statements
{
    public sealed class DefaultCaseStatementFactory : AbstractStatementFactory<IDefaultCaseStatement, DefaultCaseStatement>
    {
        public DefaultCaseStatementFactory(IDefaultCaseStatement statement)
            : base(statement)
        {
        }

        public override void VisitDefaultCaseStatement<TStatement>(IDefaultCaseStatement<TStatement> defaultCaseStatement)
        {
            Value = new DefaultCaseStatement()
            {
                Statements = defaultCaseStatement.Statements.ToStatementListUsingFactory()
            };
        }
    }
}
