using System.Collections.Generic;

namespace CSharpDom.Common.Editable
{
    public interface IEditableAbstractClassEventCollection<TEvent, TEventProperty, TAbstractEvent, TExplicitInterfaceEvent> :
        IEditableAbstractClassEventCollection,
        ICollection<TEvent>,
        IHasEditableEventProperties<TEventProperty>,
        IHasEditableAbstractEvents<TAbstractEvent>,
        IHasEditableExplicitInterfaceEvents<TExplicitInterfaceEvent>,
        IAbstractClassEventCollection<TEvent, TEventProperty, TAbstractEvent, TExplicitInterfaceEvent>
        where TEvent : IEditableClassEvent
        where TEventProperty : IEditableClassEventProperty
        where TAbstractEvent : IEditableAbstractEvent
        where TExplicitInterfaceEvent : IEditableExplicitInterfaceEvent
    {
    }
}