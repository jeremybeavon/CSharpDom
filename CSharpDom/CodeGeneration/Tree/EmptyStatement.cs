namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class EmptyStatement : Statement
    {
        public override void Accept(StatementVisitor visitor)
        {
            visitor.Visit(this);
        }

        public override void AcceptChildren(StatementVisitor visitor)
        {
        }
    }
}
