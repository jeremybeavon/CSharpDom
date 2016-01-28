namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class UsingStatement : Statement
    {
        public ExpressionStatement Expression { get; set; }

        public Statement Statement { get; set; }
    }
}
