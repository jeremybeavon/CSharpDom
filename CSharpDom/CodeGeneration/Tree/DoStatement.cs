using System.Collections.ObjectModel;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class DoStatement : Statement
    {
        public ExpressionStatement Condition { get; set; }

        public Collection<Statement> Block { get; set; }
    }
}
