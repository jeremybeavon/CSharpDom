using CSharpDom.Common.Statements;
using CSharpDom.Serialization.Statements;

namespace CSharpDom.Serialization.Factories.Statements
{
    public sealed class LabelStatementFactory : AbstractStatementFactory<ILabelStatement, LabelStatement>
    {
        public LabelStatementFactory(ILabelStatement statement)
            : base(statement)
        {
        }

        public override void VisitLabelStatement(ILabelStatement labelStatement)
        {
            Value = new LabelStatement()
            {
                LabelName = labelStatement.LabelName
            };
        }
    }
}
