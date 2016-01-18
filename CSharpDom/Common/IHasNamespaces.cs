using System.Collections.Generic;

namespace CSharpDom.Common
{
    public interface IHasNamespaces<TNamespace>
    {
        IReadOnlyCollection<TNamespace> Namespaces { get; }
    }
}
