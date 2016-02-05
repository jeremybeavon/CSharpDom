using System.Collections.Generic;

namespace CSharpDom.Common
{
    public interface IHasAbstractIndexers<TIndexer>
    {
        IReadOnlyCollection<TIndexer> AbstractIndexers { get; }
    }
}
