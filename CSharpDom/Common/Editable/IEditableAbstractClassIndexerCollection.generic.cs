using System.Collections.Generic;

namespace CSharpDom.Common.Editable
{
    public interface IEditableAbstractClassIndexerCollection<TIndexer, TAbstractIndexer, TExplicitInterfaceIndexer> :
        IEditableAbstractClassIndexerCollection,
        ICollection<TIndexer>,
        IHasEditableAbstractIndexers<TAbstractIndexer>,
        IHasEditableExplicitInterfaceIndexers<TExplicitInterfaceIndexer>,
        IAbstractClassIndexerCollection<TIndexer, TAbstractIndexer, TExplicitInterfaceIndexer>
        where TIndexer : IEditableClassIndexer
        where TAbstractIndexer : IEditableAbstractIndexer
        where TExplicitInterfaceIndexer : IEditableExplicitInterfaceIndexer
    {
    }
}