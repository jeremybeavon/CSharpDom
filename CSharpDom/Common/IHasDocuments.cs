using System.Collections.Generic;

namespace CSharpDom.Common
{
    public interface IHasDocuments<TDocument>
    {
        IReadOnlyCollection<TDocument> Documents { get; }
    }
}
