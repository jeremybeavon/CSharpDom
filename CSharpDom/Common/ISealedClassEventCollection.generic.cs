using System.Collections.Generic;

namespace CSharpDom.Common
{
    public interface ISealedClassEventCollection<TEvent, TEventProperty, TExplicitInterfaceEvent> :
        ISealedClassEventCollection,
        IReadOnlyCollection<TEvent>,
        IHasEventProperties<TEventProperty>,
        IHasExplicitInterfaceEvents<TExplicitInterfaceEvent>
        where TEvent : ISealedClassEvent
        where TEventProperty : IClassEventProperty
        where TExplicitInterfaceEvent : IExplicitInterfaceEvent
    {
    }
}
