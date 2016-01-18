namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class SwitchCaseStatement : CodeGenerationNode
    {
        public ExpressionStatement Match { get; set; }

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
            Match.AcceptIfNotNull(visitor);
            Statements.AcceptIfNotNull(visitor);
        }
    }
}
