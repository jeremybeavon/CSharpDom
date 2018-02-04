using System.Collections.Generic;

namespace CSharpDom.Common.Editable
{
    public interface IHasEditableAbstractIndexers<TIndexer> : IHasAbstractIndexers<TIndexer>
    {
        new ICollection<TIndexer> AbstractIndexers { get; set; }
    }
}