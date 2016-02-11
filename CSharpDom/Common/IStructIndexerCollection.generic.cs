using System.Collections.Generic;

namespace CSharpDom.Common
{
    public interface IStructIndexerCollection<TIndexer, TExplicitInterfaceIndexer> :
        IStructIndexerCollection,
        IReadOnlyCollection<TIndexer>,
        IHasExplicitInterfaceIndexers<TExplicitInterfaceIndexer>
        where TIndexer : IStructIndexer
        where TExplicitInterfaceIndexer : IExplicitInterfaceIndexer
    {
    }
}
