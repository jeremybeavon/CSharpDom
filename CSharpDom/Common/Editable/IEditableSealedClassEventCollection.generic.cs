using System.Collections.Generic;

namespace CSharpDom.Common.Editable
{
    public interface IEditableSealedClassEventCollection<TEvent, TEventProperty, TExplicitInterfaceEvent> :
        IEditableSealedClassEventCollection,
        ICollection<TEvent>,
        IHasEditableEventProperties<TEventProperty>,
        IHasEditableExplicitInterfaceEvents<TExplicitInterfaceEvent>,
        ISealedClassEventCollection<TEvent, TEventProperty, TExplicitInterfaceEvent>
        where TEvent : IEditableSealedClassEvent
        where TEventProperty : IEditableSealedClassEventProperty
        where TExplicitInterfaceEvent : IEditableExplicitInterfaceEvent
    {
    }
}