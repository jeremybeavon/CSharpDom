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

        public override void Accept(StatementVisitor visitor)
        {
            if (visitor != null)
            {
                visitor.Visit(this);
            }
        }

        public override void AcceptChildren(StatementVisitor visitor)
        {
            TryStatements.AcceptIfNotNull(visitor);
            CatchStatements.AcceptIfNotNull(visitor);
            FinallyStatement.AcceptIfNotNull(visitor);
        }
    }
}
