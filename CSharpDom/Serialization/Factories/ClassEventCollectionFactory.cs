using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public class ClassEventCollectionFactory :
        AbstractFactory<IClassEventCollection, ClassEventCollection>
    {
        public ClassEventCollectionFactory(IClassEventCollection eventCollection)
            : base(eventCollection)
        {
        }

        public override void VisitClassEventCollection<TEvent, TEventProperty, TExplicitInterfaceEvent>(
            IClassEventCollection<TEvent, TEventProperty, TExplicitInterfaceEvent> eventCollection)
        {
            Value = new ClassEventCollection()
            {
                Events = eventCollection.ToList(@event => new ClassEventFactory(@event).Value),
                EventProperties = eventCollection.EventProperties.ToList(@event => new ClassEventPropertyFactory(@event).Value),
                ExplicitInterfaceEvents = eventCollection.ExplicitInterfaceEvents.ToList(@event => new ExplicitInterfaceEventFactory(@event).Value)
            };
        }
    }
}
