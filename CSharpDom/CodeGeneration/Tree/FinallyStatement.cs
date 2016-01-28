using System.Collections.ObjectModel;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class FinallyStatement : Statement
    {
        public FinallyStatement()
        {
            Statements = new Collection<Statement>();
        }

        public Collection<Statement> Statements { get; set; }
    }
}
