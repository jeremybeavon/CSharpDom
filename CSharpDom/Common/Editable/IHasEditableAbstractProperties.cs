using System.Collections.Generic;

namespace CSharpDom.Common.Editable
{
    public interface IHasEditableAbstractProperties<TProperty> : IHasAbstractProperties<TProperty>
    {
        new ICollection<TProperty> AbstractProperties { get; set; }
    }
}