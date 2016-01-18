namespace CSharpDom.CodeGeneration.Tree
{
    public interface ICodeGenerationNode
    {
        void Accept(CodeGenerationVisitor visitor);
    }
}
