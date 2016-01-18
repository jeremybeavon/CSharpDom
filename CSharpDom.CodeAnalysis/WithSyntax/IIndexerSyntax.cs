using CSharpDom.Common;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.WithSyntax
{
    public interface IIndexerSyntax :
        IIndexer<IBasicTypeSyntax>,
        IHasDeclaration<IndexerDeclarationSyntax>,
        IHasLocation
    {
        void Accept(ISyntaxVisitor visitor);
    }
}
