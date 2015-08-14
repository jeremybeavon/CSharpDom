namespace CSharpDom.CodeGeneration.Tree
{
    public static class CodeGenerationCollectionExtensions
    {
        public static void AcceptIfNotNull<T>(this CodeGenerationCollection<T> collection, CodeGenerationVisitor visitor)
            where T : CodeGenerationNode
        {
            if (collection != null)
            {
                collection.Accept(visitor);
            }
        }
    }
}
