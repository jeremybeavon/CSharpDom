namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class WhileStatement : Statement
    {
        public ExpressionStatement Condition { get; set; }

        public Statement Statement { get; set; }
    }
}
