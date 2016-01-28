namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class LockStatement : Statement
    {
        public ExpressionStatement Expression { get; set; }

        public Statement Statement { get; set; }
    }
}
