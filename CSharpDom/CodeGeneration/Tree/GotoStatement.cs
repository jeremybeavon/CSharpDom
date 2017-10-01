using CSharpDom.CodeGeneration.Tree.Statements;
using CSharpDom.Text;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class GotoStatement : Statement
    {
        public LabelReference Label { get; set; }

        public override string ToString()
        {
            return new ReadOnlyGotoStatement(this).ToSourceCode();
        }
    }
}
