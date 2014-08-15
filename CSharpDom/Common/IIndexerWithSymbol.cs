using Microsoft.CodeAnalysis;

namespace CSharpDom.Common
{
    public interface IIndexerWithSymbol : IIndexer, IHasSymbol<IPropertySymbol>
    {
    }
}
