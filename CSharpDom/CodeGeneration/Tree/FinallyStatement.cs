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

        public override void Accept(StatementVisitor visitor)
        {
            if (visitor != null)
            {
                visitor.Visit(this);
            }
        }

        public override void AcceptChildren(StatementVisitor visitor)
        {
            Statements.AcceptIfNotNull(visitor);
        }
    }
}
