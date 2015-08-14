namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class EnumField : CodeGenerationNode
    {
        public EnumField(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public string RawInitialValue { get; set; }

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
