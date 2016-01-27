using System.Collections.ObjectModel;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class DoStatement : Statement
    {
        public ExpressionStatement Condition { get; set; }

        public Collection<Statement> Block { get; set; }

        public override void Accept(StatementVisitor visitor)
        {
            if (visitor != null)
            {
                visitor.Visit(this);
            }
        }

        public override void AcceptChildren(StatementVisitor visitor)
        {
            Condition.AcceptIfNotNull(visitor);
            Block.AcceptIfNotNull(visitor);
        }
    }
}
