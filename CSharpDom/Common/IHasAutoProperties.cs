using System.Collections.Generic;

namespace CSharpDom.Common
{
    public interface IHasAutoProperties<TAutoProperty>
    {
        IReadOnlyCollection<TAutoProperty> AutoProperties { get; }
    }
}
