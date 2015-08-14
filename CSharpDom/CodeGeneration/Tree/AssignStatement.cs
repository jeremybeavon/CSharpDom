namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class AssignStatement : Statement, IExpressionStatement
    {
        public IExpressionStatement Left { get; set; }

        public IExpressionStatement Right { get; set; }

        public override void Accept(CodeGenerationVisitor visitor)
        {
            if (visitor != null)
            {
                visitor.Visit(this);
            }
        }

        public override void AcceptChildren(CodeGenerationVisitor visitor)
        {
            Left.AcceptIfNotNull(visitor);
            Right.AcceptIfNotNull(visitor);
        }
    }
}
