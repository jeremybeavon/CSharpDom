namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class UsingDeclaration : CodeGenerationNode
    {
        public UsingDeclaration(string @namespace)
        {
            Namespace = @namespace;
        }

        public string Namespace { get; set; }

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
