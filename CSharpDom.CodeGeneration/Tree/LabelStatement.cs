namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class LabelStatement : Statement
    {
        public LabelReference Label { get; set; }

        public override void Accept(CodeGenerationVisitor visitor)
        {
            if (visitor != null)
            {
                visitor.Visit(this);
            }
        }

        public override void AcceptChildren(CodeGenerationVisitor visitor)
        {
            Label.AcceptIfNotNull(visitor);
        }
    }
}
