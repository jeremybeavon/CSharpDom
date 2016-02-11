using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public class StructEventCollectionFactory :
        AbstractFactory<IStructEventCollection, StructEventCollection>
    {
        public StructEventCollectionFactory(IStructEventCollection eventCollection)
            : base(eventCollection)
        {
        }

        public override void VisitStructEventCollection<TEvent, TEventProperty, TExplicitInterfaceEvent>(
            IStructEventCollection<TEvent, TEventProperty, TExplicitInterfaceEvent> eventCollection)
        {
            Value = new StructEventCollection()
            {
                Events = eventCollection.ToList(@event => new StructEventFactory(@event).Value),
                EventProperties = eventCollection.EventProperties.ToList(@event => new StructEventPropertyFactory(@event).Value),
                ExplicitInterfaceEvents = eventCollection.ExplicitInterfaceEvents.ToList(@event => new ExplicitInterfaceEventFactory(@event).Value)
            };
        }
    }
}
