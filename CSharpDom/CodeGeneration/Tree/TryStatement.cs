using System.Collections.ObjectModel;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class TryStatement : Statement
    {
        public TryStatement()
        {
            TryStatements = new Collection<Statement>();
            CatchStatements = new Collection<CatchStatement>();
        }

        public Collection<Statement> TryStatements { get; set; }

        public Collection<CatchStatement> CatchStatements { get; set; }

        public FinallyStatement FinallyStatement { get; set; }
    }
}
