using System.Collections.Generic;

namespace CSharpDom.Common
{
    public interface IAbstractClassEventCollection<TEvent, TAbstractEvent, TExplicitInterfaceEvent> :
        IAbstractClassEventCollection,
        IReadOnlyCollection<TEvent>,
        IHasAbstractEvents<TAbstractEvent>,
        IHasExplicitInterfaceEvents<TExplicitInterfaceEvent>
        where TEvent : IClassEvent
        where TAbstractEvent : IAbstractEvent
        where TExplicitInterfaceEvent : IExplicitInterfaceEvent
    {
    }
}
