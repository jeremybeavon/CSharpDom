namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class ForStatement : Statement
    {
        public ExpressionStatement InitialValueExpression { get; set; }

        public VariableDeclarationStatement InitialValueStatement { get; set; }

        public ExpressionStatement Condition { get; set; }

        public ExpressionStatement Increment { get; set; }

        public Statement Statement { get; set; }
    }
}
