using System.Collections.Generic;

namespace CSharpDom.Common
{
    public interface IHasIndexers<TIndexer>
    {
        IReadOnlyCollection<TIndexer> Indexers { get; }
    }
}
