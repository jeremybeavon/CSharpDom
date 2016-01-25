namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class LabelStatement : Statement
    {
        public LabelReference Label { get; set; }

        public override void Accept(StatementVisitor visitor)
        {
            if (visitor != null)
            {
                visitor.Visit(this);
            }
        }

        public override void AcceptChildren(StatementVisitor visitor)
        {
            Label.AcceptIfNotNull(visitor);
        }
    }
}
