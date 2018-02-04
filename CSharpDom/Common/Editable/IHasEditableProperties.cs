using System.Collections.Generic;

namespace CSharpDom.Common.Editable
{
    public interface IHasEditableProperties<TProperty> : IHasProperties<TProperty>
    {
        new ICollection<TProperty> Properties { get; set; }
    }
}