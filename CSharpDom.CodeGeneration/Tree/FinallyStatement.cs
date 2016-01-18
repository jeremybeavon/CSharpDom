namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class FinallyStatement : CodeGenerationNode
    {
        public FinallyStatement()
        {
            Statements = new CodeGenerationCollection<Statement>();
        }

        public CodeGenerationCollection<Statement> Statements { get; set; }

        public override void Accept(CodeGenerationVisitor visitor)
        {
            if (visitor != null)
            {
                visitor.Visit(this);
            }
        }

        public override void AcceptChildren(CodeGenerationVisitor visitor)
        {
            Statements.AcceptIfNotNull(visitor);
        }
    }
}
