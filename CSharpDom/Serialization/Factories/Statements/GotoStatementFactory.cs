using CSharpDom.Common.Statements;
using CSharpDom.Serialization.Statements;

namespace CSharpDom.Serialization.Factories.Statements
{
    public sealed class GotoStatementFactory : AbstractStatementFactory<IGotoStatement, GotoStatement>
    {
        public GotoStatementFactory(IGotoStatement statement)
            : base(statement)
        {
        }

        public override void VisitGotoStatement(IGotoStatement gotoStatement)
        {
            Value = new GotoStatement()
            {
                LabelName = gotoStatement.LabelName
            };
        }
    }
}
