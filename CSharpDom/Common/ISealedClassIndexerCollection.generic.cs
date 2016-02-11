using System.Collections.Generic;

namespace CSharpDom.Common
{
    public interface ISealedClassIndexerCollection<TIndexer, TProtectedOverrideIndexer, TExplicitInterfaceIndexer> :
        ISealedClassIndexerCollection,
        IReadOnlyCollection<TIndexer>,
        IHasProtectedOverrideIndexers<TProtectedOverrideIndexer>,
        IHasExplicitInterfaceIndexers<TExplicitInterfaceIndexer>
        where TIndexer : ISealedClassIndexer
        where TProtectedOverrideIndexer : IProtectedOverrideIndexer
        where TExplicitInterfaceIndexer : IExplicitInterfaceIndexer
    {
    }
}
