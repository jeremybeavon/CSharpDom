using System.Collections.Generic;

namespace CSharpDom.Common
{
    public interface IClassIndexerCollection<TIndexer, TExplicitInterfaceIndexer> :
        IClassIndexerCollection,
        IReadOnlyCollection<TIndexer>,
        IHasExplicitInterfaceIndexers<TExplicitInterfaceIndexer>
        where TIndexer : IClassIndexer
        where TExplicitInterfaceIndexer : IExplicitInterfaceIndexer
    {
    }
}
