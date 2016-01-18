namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class DoStatement : Statement
    {
        public ExpressionStatement Condition { get; set; }

        public CodeGenerationCollection<Statement> Block { get; set; }

        public override void Accept(CodeGenerationVisitor visitor)
        {
            if (visitor != null)
            {
                visitor.Visit(this);
            }
        }

        public override void AcceptChildren(CodeGenerationVisitor visitor)
        {
            Condition.AcceptIfNotNull(visitor);
            Block.AcceptIfNotNull(visitor);
        }
    }
}
