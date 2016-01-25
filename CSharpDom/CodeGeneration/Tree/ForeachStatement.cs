namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class ForeachStatement : Statement
    {
        public TypeReference Type { get; set; }

        public string VariableName { get; set; }

        public ExpressionStatement Iterator { get; set; }

        public Statement Statement { get; set; }

        public override void Accept(StatementVisitor visitor)
        {
            if (visitor != null)
            {
                visitor.Visit(this);
            }
        }

        public override void AcceptChildren(StatementVisitor visitor)
        {
            Type.AcceptIfNotNull(visitor);
            Iterator.AcceptIfNotNull(visitor);
            Statement.AcceptIfNotNull(visitor);
        }
    }
}
