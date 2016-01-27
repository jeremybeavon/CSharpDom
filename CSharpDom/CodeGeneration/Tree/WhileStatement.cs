namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class WhileStatement : Statement
    {
        public ExpressionStatement Condition { get; set; }

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
            Condition.AcceptIfNotNull(visitor);
            Statement.AcceptIfNotNull(visitor);
        }
    }
}
