using System.Collections.ObjectModel;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class DoStatement : Statement
    {
        public ExpressionStatement Condition { get; set; }

        public Statement Statement { get; set; }
    }
}
