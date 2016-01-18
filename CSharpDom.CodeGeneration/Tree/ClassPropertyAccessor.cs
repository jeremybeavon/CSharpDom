namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class ClassPropertyAccessor : CodeGenerationNode
    {
        public ClassPropertyAccessor()
        {
            Body = new CodeGenerationCollection<Statement>();
        }

        public ClassPropertyAccessorVisibilityModifier Visibility { get; set; }

        public CodeGenerationCollection<Statement> Body { get; set; }

        public override void Accept(CodeGenerationVisitor visitor)
        {
            if (visitor != null)
            {
                visitor.Visit(this);
            }
        }

        public override void AcceptChildren(CodeGenerationVisitor visitor)
        {
            Body.AcceptIfNotNull(visitor);
        }
    }
}
