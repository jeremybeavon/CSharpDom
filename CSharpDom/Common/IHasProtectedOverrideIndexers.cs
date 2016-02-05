using System.Collections.Generic;

namespace CSharpDom.Common
{
    public interface IHasProtectedOverrideIndexers<TIndexer>
    {
        IReadOnlyCollection<TIndexer> ProtectedOverrideIndexers { get; }
    }
}
