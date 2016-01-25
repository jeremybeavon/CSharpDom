namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class LockStatement : Statement
    {
        public ExpressionStatement Expression { get; set; }

        public Statement Statement { get; set; }

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
            Statement.AcceptIfNotNull(visitor);
        }
    }
}
