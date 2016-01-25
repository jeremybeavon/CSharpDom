namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class VariableDeclaration : Statement
    {
        public string Name { get; set; }

        public ExpressionStatement InitialValue { get; set; }

        public override void Accept(StatementVisitor visitor)
        {
            visitor.Visit(this);
        }

        public override void AcceptChildren(StatementVisitor visitor)
        {
            InitialValue.AcceptIfNotNull(visitor);
        }
    }
}
