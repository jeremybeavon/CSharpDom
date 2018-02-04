using System.Collections.Generic;

namespace CSharpDom.Common.Editable
{
    public interface IEditableClassEventCollection<TEvent, TEventProperty, TExplicitInterfaceEvent> :
        IEditableClassEventCollection,
        ICollection<TEvent>,
        IHasEditableEventProperties<TEventProperty>,
        IHasEditableExplicitInterfaceEvents<TExplicitInterfaceEvent>,
        IClassEventCollection<TEvent, TEventProperty, TExplicitInterfaceEvent>
        where TEvent : IEditableClassEvent
        where TEventProperty : IEditableClassEventProperty
        where TExplicitInterfaceEvent : IEditableExplicitInterfaceEvent
    {
    }
}