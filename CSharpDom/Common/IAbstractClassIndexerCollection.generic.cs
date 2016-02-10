using System.Collections.Generic;

namespace CSharpDom.Common
{
    public interface IAbstractClassIndexerCollection<TIndexer, TAbstractIndexer, TExplicitInterfaceIndexer> :
        IAbstractClassIndexerCollection,
        IReadOnlyCollection<TIndexer>,
        IHasAbstractIndexers<TAbstractIndexer>,
        IHasExplicitInterfaceIndexers<TExplicitInterfaceIndexer>
        where TIndexer : IClassIndexer
        where TAbstractIndexer : IAbstractIndexer
        where TExplicitInterfaceIndexer : IExplicitInterfaceIndexer
    {
    }
}
