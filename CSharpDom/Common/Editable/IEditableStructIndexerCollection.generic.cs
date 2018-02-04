using System.Collections.Generic;

namespace CSharpDom.Common.Editable
{
    public interface IEditableStructIndexerCollection<TIndexer, TExplicitInterfaceIndexer> :
        IEditableStructIndexerCollection,
        ICollection<TIndexer>,
        IHasEditableExplicitInterfaceIndexers<TExplicitInterfaceIndexer>,
        IStructIndexerCollection<TIndexer, TExplicitInterfaceIndexer>
        where TIndexer : IEditableStructIndexer
        where TExplicitInterfaceIndexer : IEditableExplicitInterfaceIndexer
    {
    }
}