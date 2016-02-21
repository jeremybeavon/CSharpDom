using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public class StaticClassEventCollectionFactory :
        AbstractFactory<IStaticClassEventCollection, StaticClassEventCollection>
    {
        public StaticClassEventCollectionFactory(IStaticClassEventCollection eventCollection)
            : base(eventCollection)
        {
        }

        public override void VisitStaticClassEventCollection<TEvent, TEventProperty>(
            IStaticClassEventCollection<TEvent, TEventProperty> eventCollection)
        {
            Value = new StaticClassEventCollection()
            {
                Events = eventCollection.ToList(@event => new StaticClassEventFactory(@event).Value),
                EventProperties = eventCollection.EventProperties.ToList(@event => new StaticClassEventPropertyFactory(@event).Value)
            };
        }
    }
}
