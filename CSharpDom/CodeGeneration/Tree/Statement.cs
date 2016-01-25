namespace CSharpDom.CodeGeneration.Tree
{
    public abstract class Statement
    {
        public abstract void Accept(StatementVisitor visitor);

        public abstract void AcceptChildren(StatementVisitor visitor);
    }
}
