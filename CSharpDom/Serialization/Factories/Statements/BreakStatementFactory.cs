using CSharpDom.Common.Statements;
using CSharpDom.Serialization.Statements;

namespace CSharpDom.Serialization.Factories.Statements
{
    public sealed class BreakStatementFactory : AbstractStatementFactory<IBreakStatement, BreakStatement>
    {
        public BreakStatementFactory(IBreakStatement statement)
            : base(statement)
        {
        }

        public override void VisitBreakStatement(IBreakStatement breakStatement)
        {
            Value = new BreakStatement();
        }
    }
}
