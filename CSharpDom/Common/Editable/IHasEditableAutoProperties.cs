using System.Collections.Generic;

namespace CSharpDom.Common.Editable
{
    public interface IHasEditableAutoProperties<TAutoProperty> : IHasAutoProperties<TAutoProperty>
    {
        new ICollection<TAutoProperty> AutoProperties { get; set; }
    }
}
