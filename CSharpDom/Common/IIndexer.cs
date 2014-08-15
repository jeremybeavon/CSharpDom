using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.Common
{
    public interface IIndexer : IHasDeclaration<IndexerDeclarationSyntax>, IHasLocation
    {
        bool HasGet { get; }

        bool HasSet { get; }
    }
}
