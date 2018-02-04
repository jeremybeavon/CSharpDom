using System.Collections.Generic;

namespace CSharpDom.Common.Editable
{
    public interface IHasEditableDocuments<TDocument> : IHasDocuments<TDocument>
    {
        new ICollection<TDocument> Documents { get; set; }
    }
}