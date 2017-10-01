using CSharpDom.CodeGeneration.Tree.Statements;
using CSharpDom.Text;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class ForeachStatement : Statement
    {
        public TypeReference Type { get; set; }

        public string VariableName { get; set; }

        public ExpressionStatement Iterator { get; set; }

        public Statement Statement { get; set; }

        public override string ToString()
        {
            return new ReadOnlyForeachStatement(this).ToSourceCode();
        }
    }
}
