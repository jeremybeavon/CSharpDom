using System.Collections.Generic;

namespace CSharpDom.Common
{
    public interface ISealedClassEventCollection<TEvent, TEventProperty, TProtectedOverrideEvent, TExplicitInterfaceEvent> :
        ISealedClassEventCollection,
        IReadOnlyCollection<TEvent>,
        IHasEventProperties<TEventProperty>,
        IHasProtectedOverrideEvents<TProtectedOverrideEvent>,
        IHasExplicitInterfaceEvents<TExplicitInterfaceEvent>
        where TEvent : ISealedClassEvent
        where TEventProperty : IClassEventProperty
        where TProtectedOverrideEvent : IProtectedOverrideEvent
        where TExplicitInterfaceEvent : IExplicitInterfaceEvent
    {
    }
}
