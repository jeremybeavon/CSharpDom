using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    public class AbstractClassEventCollectionWrapper :
        AbstractWrapper<IAbstractClassEventCollection>
    {
        public AbstractClassEventCollectionWrapper(IAbstractClassEventCollection eventCollection)
            : base(eventCollection)
        {
        }

        public override void VisitAbstractClassEventCollection<TEvent, TEventProperty, TAbstractEvent, TExplicitInterfaceEvent>(
            IAbstractClassEventCollection<TEvent, TEventProperty, TAbstractEvent, TExplicitInterfaceEvent> eventCollection)
        {
            Value = new AbstractClassEventCollection()
            {
                Events = eventCollection.ToList(@event => new ClassEventWrapper(@event).Value),
                EventProperties = eventCollection.EventProperties.ToList(@event => new ClassEventPropertyWrapper(@event).Value),
                AbstractEvents = eventCollection.AbstractEvents.ToList(@event => new AbstractEventWrapper(@event).Value),
                ExplicitInterfaceEvents = eventCollection.ExplicitInterfaceEvents.ToList(@event => new ExplicitInterfaceEventWrapper(@event).Value)
            };
        }
    }
}
