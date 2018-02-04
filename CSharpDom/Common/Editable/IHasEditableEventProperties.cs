using System.Collections.Generic;

namespace CSharpDom.Common.Editable
{
    public interface IHasEditableEventProperties<TEventProperty> : IHasEventProperties<TEventProperty>
    {
        new ICollection<TEventProperty> EventProperties { get; set; }
    }
}