using CSharpDom.BaseClasses.Statements;

namespace CSharpDom.CodeGeneration.Tree.Statements
{
    public sealed class ReadOnlyGotoStatement : AbstractGotoStatement
    {
        private readonly string labelName;

        public ReadOnlyGotoStatement(GotoStatement gotoStatement)
        {
            labelName = gotoStatement.Label.Label;
        }

        public override string LabelName
        {
            get { return labelName; }
        }
    }
}
