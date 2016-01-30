using CSharpDom.Common.Statements;
using CSharpDom.Serialization.Statements;

namespace CSharpDom.Serialization.Factories.Statements
{
    public sealed class ContinueStatementFactory : AbstractStatementFactory<IContinueStatement, ContinueStatement>
    {
        public ContinueStatementFactory(IContinueStatement statement)
            : base(statement)
        {
        }

        public override void VisitContinueStatement(IContinueStatement continueStatement)
        {
            Value = new ContinueStatement();
        }
    }
}
