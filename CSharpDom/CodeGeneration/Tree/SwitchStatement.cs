namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class SwitchStatement : Statement
    {
        public IExpressionStatement Expression { get; set; }

        public CodeGenerationCollection<SwitchCaseStatement> Cases { get; set; }

        public CodeGenerationCollection<Statement> DefaultCase { get; set; }

        public override void Accept(CodeGenerationVisitor visitor)
        {
            if (visitor != null)
            {
                visitor.Visit(this);
            }
        }

        public override void AcceptChildren(CodeGenerationVisitor visitor)
        {
            Expression.AcceptIfNotNull(visitor);
            Cases.AcceptIfNotNull(visitor);
            DefaultCase.AcceptIfNotNull(visitor);
        }
    }
}
