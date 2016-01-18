namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class EmptyStatement : CodeGenerationNode
    {
        public override void Accept(CodeGenerationVisitor visitor)
        {
            visitor.Visit(this);
        }

        public override void AcceptChildren(CodeGenerationVisitor visitor)
        {
        }
    }
}
