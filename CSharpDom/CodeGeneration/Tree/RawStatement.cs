namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class RawStatement : Statement
    {
        public RawStatement()
        {
        }

        public RawStatement(string statement)
        {
            Statement = statement;
        }

        public string Statement { get; set; }
    }
}
