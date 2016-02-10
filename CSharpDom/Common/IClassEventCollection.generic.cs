using System.Collections.Generic;

namespace CSharpDom.Common
{
    public interface IClassEventCollection<TEvent, TExplicitInterfaceEvent> :
        IClassEventCollection,
        IReadOnlyCollection<TEvent>,
        IHasExplicitInterfaceEvents<TExplicitInterfaceEvent>
        where TEvent : IClassEvent
        where TExplicitInterfaceEvent : IExplicitInterfaceEvent
    {
    }
}
