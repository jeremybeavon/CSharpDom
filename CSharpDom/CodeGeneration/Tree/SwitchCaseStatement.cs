using System.Collections.ObjectModel;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class SwitchCaseStatement : Statement
    {
        public ExpressionStatement Match { get; set; }

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
            Match.AcceptIfNotNull(visitor);
            Statements.AcceptIfNotNull(visitor);
        }
    }
}
