namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class AssignStatement : Statement
    {
        public ExpressionStatement Left { get; set; }

        public ExpressionStatement Right { get; set; }
    }
}
