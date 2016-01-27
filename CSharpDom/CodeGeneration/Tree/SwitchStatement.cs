using System.Collections.ObjectModel;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class SwitchStatement : Statement
    {
        public ExpressionStatement Expression { get; set; }

        public Collection<SwitchCaseStatement> Cases { get; set; }

        public Collection<Statement> DefaultCase { get; set; }

        public override void Accept(StatementVisitor visitor)
        {
            if (visitor != null)
            {
                visitor.Visit(this);
            }
        }

        public override void AcceptChildren(StatementVisitor visitor)
        {
            Expression.AcceptIfNotNull(visitor);
            Cases.AcceptIfNotNull(visitor);
            DefaultCase.AcceptIfNotNull(visitor);
        }
    }
}
