namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class LabelReference : CodeGenerationNode
    {
        public LabelReference(string label)
        {
            Label = label;
        }

        public string Label { get; set; }

        public override void Accept(CodeGenerationVisitor visitor)
        {
            if (visitor != null)
            {
                visitor.Visit(this);
            }
        }

        public override void AcceptChildren(CodeGenerationVisitor visitor)
        {
        }
    }
}
