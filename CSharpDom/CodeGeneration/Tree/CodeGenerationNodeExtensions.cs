namespace CSharpDom.CodeGeneration.Tree
{
    public static class CodeGenerationNodeExtensions
    {
        public static void AcceptIfNotNull(this CodeGenerationNode node, CodeGenerationVisitor visitor)
        {
            if (node != null)
            {
                node.Accept(visitor);
            }
        }
    }
}
