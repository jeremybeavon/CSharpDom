using System.Collections.Generic;

namespace CSharpDom.Common
{
    public interface IStaticClassEventCollection<TEvent, TEventProperty> :
        IStaticClassEventCollection,
        IReadOnlyCollection<TEvent>,
        IHasEventProperties<TEventProperty>
        where TEvent : IStaticClassEvent
        where TEventProperty : IStaticClassEventProperty
    {
    }
}
