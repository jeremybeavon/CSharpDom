namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class ForStatement : Statement
    {
        public ExpressionStatement InitialValueExpression { get; set; }

        public VariableDeclarationStatement InitialValueStatement { get; set; }

        public ExpressionStatement Condition { get; set; }

        public ExpressionStatement Increment { get; set; }

        public Statement Statement { get; set; }

        public override void Accept(CodeGenerationVisitor visitor)
        {
            if (visitor != null)
            {
                visitor.Visit(this);
            }
        }

        public override void AcceptChildren(CodeGenerationVisitor visitor)
        {
            InitialValueExpression.AcceptIfNotNull(visitor);
            InitialValueStatement.AcceptIfNotNull(visitor);
            Condition.AcceptIfNotNull(visitor);
            Increment.AcceptIfNotNull(visitor);
            Statement.AcceptIfNotNull(visitor);
        }
    }
}
