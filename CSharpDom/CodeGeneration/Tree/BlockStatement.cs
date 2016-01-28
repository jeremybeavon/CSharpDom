using System.Collections.ObjectModel;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class BlockStatement : Statement
    {
        public BlockStatement()
        {
            Statements = new Collection<Statement>();
        }

        public Collection<Statement> Statements { get; set; }
    }
}
