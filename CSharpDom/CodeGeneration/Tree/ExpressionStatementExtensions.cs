namespace CSharpDom.CodeGeneration.Tree
{
    public static class ExpressionStatementExtensions
    {
        public static void AcceptIfNotNull(this IExpressionStatement node, CodeGenerationVisitor visitor)
        {
            if (node != null)
            {
                node.Accept(visitor);
            }
        }
    }
}
