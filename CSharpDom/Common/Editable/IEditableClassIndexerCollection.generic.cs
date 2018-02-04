using System.Collections.Generic;

namespace CSharpDom.Common.Editable
{
    public interface IEditableClassIndexerCollection<TIndexer, TExplicitInterfaceIndexer> :
        IEditableClassIndexerCollection,
        ICollection<TIndexer>,
        IHasEditableExplicitInterfaceIndexers<TExplicitInterfaceIndexer>,
        IClassIndexerCollection<TIndexer, TExplicitInterfaceIndexer>
        where TIndexer : IEditableClassIndexer
        where TExplicitInterfaceIndexer : IEditableExplicitInterfaceIndexer
    {
    }
}