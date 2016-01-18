namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class VariableDeclaration : CodeGenerationNode
    {
        public string Name { get; set; }

        public ExpressionStatement InitialValue { get; set; }

        public override void Accept(CodeGenerationVisitor visitor)
        {
            visitor.Visit(this);
        }

        public override void AcceptChildren(CodeGenerationVisitor visitor)
        {
            InitialValue.AcceptIfNotNull(visitor);
        }
    }
}
