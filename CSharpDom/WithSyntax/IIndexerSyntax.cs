using CSharpDom.Common;

namespace CSharpDom.WithSyntax
{
    public interface IIndexerSyntax : IIndexer, IHasDeclaringType<IBasicTypeSyntax>
    {
        void Accept(ISyntaxVisitor visitor);
    }
}
