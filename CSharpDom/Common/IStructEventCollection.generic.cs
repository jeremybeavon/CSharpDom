using System.Collections.Generic;

namespace CSharpDom.Common
{
    public interface IStructEventCollection<TEvent, TEventProperty, TExplicitInterfaceEvent> :
        IStructEventCollection,
        IReadOnlyCollection<TEvent>,
        IHasEventProperties<TEventProperty>,
        IHasExplicitInterfaceEvents<TExplicitInterfaceEvent>
        where TEvent : IStructEvent
        where TEventProperty : IStructEventProperty
        where TExplicitInterfaceEvent : IExplicitInterfaceEvent
    {
    }
}
