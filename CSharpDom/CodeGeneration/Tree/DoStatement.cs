using CSharpDom.CodeGeneration.Tree.Statements;
using CSharpDom.Text;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class DoStatement : Statement
    {
        public ExpressionStatement Condition { get; set; }

        public Statement Statement { get; set; }

        public override string ToString()
        {
            return new ReadOnlyDoStatement(this).ToSourceCode();
        }
    }
}
