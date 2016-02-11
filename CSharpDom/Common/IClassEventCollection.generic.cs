using System.Collections.Generic;

namespace CSharpDom.Common
{
    public interface IClassEventCollection<TEvent, TEventProperty, TExplicitInterfaceEvent> :
        IClassEventCollection,
        IReadOnlyCollection<TEvent>,
        IHasEventProperties<TEventProperty>,
        IHasExplicitInterfaceEvents<TExplicitInterfaceEvent>
        where TEvent : IClassEvent
        where TEventProperty : IClassEventProperty
        where TExplicitInterfaceEvent : IExplicitInterfaceEvent
    {
    }
}
