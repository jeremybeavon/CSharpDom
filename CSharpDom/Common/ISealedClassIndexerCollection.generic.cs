using System.Collections.Generic;

namespace CSharpDom.Common
{
    public interface ISealedClassIndexerCollection<TIndexer, TExplicitInterfaceIndexer> :
        ISealedClassIndexerCollection,
        IReadOnlyCollection<TIndexer>,
        IHasExplicitInterfaceIndexers<TExplicitInterfaceIndexer>
        where TIndexer : ISealedClassIndexer
        where TExplicitInterfaceIndexer : IExplicitInterfaceIndexer
    {
    }
}
