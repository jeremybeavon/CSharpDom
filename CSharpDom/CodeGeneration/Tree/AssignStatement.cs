namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class AssignStatement : Statement
    {
        public ExpressionStatement Left { get; set; }

        public ExpressionStatement Right { get; set; }

        public override void Accept(StatementVisitor visitor)
        {
            if (visitor != null)
            {
                visitor.Visit(this);
            }
        }

        public override void AcceptChildren(StatementVisitor visitor)
        {
            Left.AcceptIfNotNull(visitor);
            Right.AcceptIfNotNull(visitor);
        }
    }
}
