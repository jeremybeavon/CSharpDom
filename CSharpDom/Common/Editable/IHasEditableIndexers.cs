using System.Collections.Generic;

namespace CSharpDom.Common.Editable
{
    public interface IHasEditableIndexers<TIndexer> : IHasIndexers<TIndexer>
    {
        new ICollection<TIndexer> Indexers { get; set; }
    }
}