namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class IfStatement : Statement
    {
        public ExpressionStatement Condition { get; set; }

        public Statement ThenStatement { get; set; }

        public Statement ElseStatement { get; set; }
    }
}
