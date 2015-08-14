namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class IfStatement : Statement
    {
        public IExpressionStatement Condition { get; set; }

        public Statement ThenStatement { get; set; }

        public Statement ElseStatement { get; set; }

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
            ThenStatement.AcceptIfNotNull(visitor);
            ElseStatement.AcceptIfNotNull(visitor);
        }
    }
}
