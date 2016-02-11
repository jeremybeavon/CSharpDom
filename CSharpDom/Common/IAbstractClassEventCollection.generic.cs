using System.Collections.Generic;

namespace CSharpDom.Common
{
    public interface IAbstractClassEventCollection<TEvent, TEventProperty, TAbstractEvent, TExplicitInterfaceEvent> :
        IAbstractClassEventCollection,
        IReadOnlyCollection<TEvent>,
        IHasEventProperties<TEventProperty>,
        IHasAbstractEvents<TAbstractEvent>,
        IHasExplicitInterfaceEvents<TExplicitInterfaceEvent>
        where TEvent : IClassEvent
        where TEventProperty : IClassEventProperty
        where TAbstractEvent : IAbstractEvent
        where TExplicitInterfaceEvent : IExplicitInterfaceEvent
    {
    }
}
