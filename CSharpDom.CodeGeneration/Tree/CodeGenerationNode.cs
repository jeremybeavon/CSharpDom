namespace CSharpDom.CodeGeneration.Tree
{
    public abstract class CodeGenerationNode : ICodeGenerationNode
    {
        public abstract void Accept(CodeGenerationVisitor visitor);

        public abstract void AcceptChildren(CodeGenerationVisitor visitor);
    }
}
