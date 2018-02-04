using System.Collections.Generic;

namespace CSharpDom.Common.Editable
{
    public interface IEditableSealedClassIndexerCollection<TIndexer, TExplicitInterfaceIndexer> :
        IEditableSealedClassIndexerCollection,
        ICollection<TIndexer>,
        IHasEditableExplicitInterfaceIndexers<TExplicitInterfaceIndexer>,
        ISealedClassIndexerCollection<TIndexer, TExplicitInterfaceIndexer>
        where TIndexer : IEditableSealedClassIndexer
        where TExplicitInterfaceIndexer : IEditableExplicitInterfaceIndexer
    {
    }
}