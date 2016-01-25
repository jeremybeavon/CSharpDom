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

        public override void Accept(StatementVisitor visitor)
        {
            if (visitor != null)
            {
                visitor.Visit(this);
            }
        }

        public override void AcceptChildren(StatementVisitor visitor)
        {
        }
    }
}
