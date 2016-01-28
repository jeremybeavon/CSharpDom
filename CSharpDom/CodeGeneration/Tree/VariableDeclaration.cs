namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class VariableDeclaration : Statement
    {
        public string Name { get; set; }

        public ExpressionStatement InitialValue { get; set; }
    }
}
