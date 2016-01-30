using CSharpDom.Common.Statements;
using CSharpDom.Serialization.Factories.Expressions;
using CSharpDom.Serialization.Statements;

namespace CSharpDom.Serialization.Factories.Statements
{
    public sealed class TryStatementFactory : AbstractStatementFactory<ITryStatement, TryStatement>
    {
        public TryStatementFactory(ITryStatement statement)
            : base(statement)
        {
        }

        public override void VisitTryStatement<TStatement, TCatchStatement, TFinallyStatement>(
            ITryStatement<TStatement, TCatchStatement, TFinallyStatement> tryStatement)
        {
            Value = new TryStatement()
            {
                CatchStatements = tryStatement.CatchStatements.ToList(statement => new CatchStatementFactory(statement).Value),
                FinallyStatement = new FinallyStatementFactory(tryStatement.FinallyStatement).Value,
                TryStatements = tryStatement.TryStatements.ToStatementListUsingFactory()
            };
        }
    }
}
