using System.Collections.ObjectModel;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class CatchStatement : Statement
    {
        public CatchStatement()
        {
            Statements = new Collection<Statement>();
        }

        public TypeReference Type { get; set; }

        public string Name { get; set; }

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
            Type.AcceptIfNotNull(visitor);
            Statements.AcceptIfNotNull(visitor);
        }
    }
}
