using System.Collections.Generic;

namespace CSharpDom.Common.Editable
{
    public interface IEditableStructEventCollection<TEvent, TEventProperty, TExplicitInterfaceEvent> :
        IEditableStructEventCollection,
        ICollection<TEvent>,
        IHasEditableEventProperties<TEventProperty>,
        IHasEditableExplicitInterfaceEvents<TExplicitInterfaceEvent>,
        IStructEventCollection<TEvent, TEventProperty, TExplicitInterfaceEvent>
        where TEvent : IEditableStructEvent
        where TEventProperty : IEditableStructEventProperty
        where TExplicitInterfaceEvent : IEditableExplicitInterfaceEvent
    {
    }
}