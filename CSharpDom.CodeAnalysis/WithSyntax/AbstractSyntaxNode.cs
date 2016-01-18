namespace CSharpDom.CodeAnalysis.WithSyntax
{
    public abstract class AbstractSyntaxNode
    {
        public abstract void Accept(SyntaxVisitor visitor);

        public abstract void Visit(SyntaxVisitor visitor);

        public abstract override string ToString();
    }
}
