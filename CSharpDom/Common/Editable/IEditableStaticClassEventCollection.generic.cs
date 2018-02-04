using System.Collections.Generic;

namespace CSharpDom.Common.Editable
{
    public interface IEditableStaticClassEventCollection<TEvent, TEventProperty> :
        IEditableStaticClassEventCollection,
        ICollection<TEvent>,
        IHasEditableEventProperties<TEventProperty>,
        IStaticClassEventCollection<TEvent, TEventProperty>
        where TEvent : IEditableStaticClassEvent
        where TEventProperty : IEditableStaticClassEventProperty
    {
    }
}