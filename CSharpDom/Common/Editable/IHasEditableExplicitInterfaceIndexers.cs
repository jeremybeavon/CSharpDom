using System.Collections.Generic;

namespace CSharpDom.Common.Editable
{
    public interface IHasEditableExplicitInterfaceIndexers<TExplicitInterfaceIndexer> :
        IHasExplicitInterfaceIndexers<TExplicitInterfaceIndexer>
    {
        new ICollection<TExplicitInterfaceIndexer> ExplicitInterfaceIndexers { get; set; }
    }
}