using System.Collections.Generic;

namespace CSharpDom.Common.Editable
{
    public interface IHasEditableNamespaces<TNamespace> : IHasNamespaces<TNamespace>
    {
        new ICollection<TNamespace> Namespaces { get; set; }
    }
}