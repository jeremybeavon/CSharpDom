namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class LabelReference : Statement
    {
        public LabelReference(string label)
        {
            Label = label;
        }

        public string Label { get; set; }

        public override void Accept(StatementVisitor visitor)
        {
            if (visitor != null)
            {
                visitor.Visit(this);
            }
        }

        public override void AcceptChildren(StatementVisitor visitor)
        {
        }
    }
}
