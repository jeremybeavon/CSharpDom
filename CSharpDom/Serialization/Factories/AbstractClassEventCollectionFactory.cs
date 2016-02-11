using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public class AbstractClassEventCollectionFactory :
        AbstractFactory<IAbstractClassEventCollection, AbstractClassEventCollection>
    {
        public AbstractClassEventCollectionFactory(IAbstractClassEventCollection eventCollection)
            : base(eventCollection)
        {
        }

        public override void VisitAbstractClassEventCollection<TEvent, TEventProperty, TAbstractEvent, TExplicitInterfaceEvent>(
            IAbstractClassEventCollection<TEvent, TEventProperty, TAbstractEvent, TExplicitInterfaceEvent> eventCollection)
        {
            Value = new AbstractClassEventCollection()
            {
                Events = eventCollection.ToList(@event => new ClassEventFactory(@event).Value),
                EventProperties = eventCollection.EventProperties.ToList(@event => new ClassEventPropertyFactory(@event).Value),
                AbstractEvents = eventCollection.AbstractEvents.ToList(@event => new AbstractEventFactory(@event).Value),
                ExplicitInterfaceEvents = eventCollection.ExplicitInterfaceEvents.ToList(@event => new ExplicitInterfaceEventFactory(@event).Value)
            };
        }
    }
}
