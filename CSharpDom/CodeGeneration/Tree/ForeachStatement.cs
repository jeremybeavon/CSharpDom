namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class ForeachStatement : Statement
    {
        public TypeReference Type { get; set; }

        public string VariableName { get; set; }

        public ExpressionStatement Iterator { get; set; }

        public Statement Statement { get; set; }
    }
}
