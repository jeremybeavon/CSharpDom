using System.Collections.Generic;

namespace CSharpDom.Common
{
    public interface IHasExplicitInterfaceIndexers<TExplicitInterfaceIndexer>
    {
        IReadOnlyCollection<TExplicitInterfaceIndexer> ExplicitInterfaceIndexers { get; }
    }
}
