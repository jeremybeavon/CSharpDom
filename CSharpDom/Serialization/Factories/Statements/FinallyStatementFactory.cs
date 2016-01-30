using CSharpDom.Common.Statements;
using CSharpDom.Serialization.Statements;

namespace CSharpDom.Serialization.Factories.Statements
{
    public sealed class FinallyStatementFactory : AbstractStatementFactory<IFinallyStatement, FinallyStatement>
    {
        public FinallyStatementFactory(IFinallyStatement statement)
            : base(statement)
        {
        }

        public override void VisitFinallyStatement<TStatement>(IFinallyStatement<TStatement> finallyStatement)
        {
            Value = new FinallyStatement()
            {
                Statements = finallyStatement.Statements.ToStatementListUsingFactory()
            };
        }
    }
}
