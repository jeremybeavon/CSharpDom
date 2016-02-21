using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public class SealedClassEventCollectionFactory :
        AbstractFactory<ISealedClassEventCollection, SealedClassEventCollection>
    {
        public SealedClassEventCollectionFactory(ISealedClassEventCollection eventCollection)
            : base(eventCollection)
        {
        }

        public override void VisitSealedClassEventCollection<TEvent, TEventProperty, TExplicitInterfaceEvent>(
            ISealedClassEventCollection<TEvent, TEventProperty, TExplicitInterfaceEvent> eventCollection)
        {
            Value = new SealedClassEventCollection()
            {
                Events = eventCollection.ToList(@event => new SealedClassEventFactory(@event).Value),
                EventProperties = eventCollection.EventProperties.ToList(@event => new SealedClassEventPropertyFactory(@event).Value),
                ExplicitInterfaceEvents = eventCollection.ExplicitInterfaceEvents.ToList(@event => new ExplicitInterfaceEventFactory(@event).Value)
            };
        }
    }
}
