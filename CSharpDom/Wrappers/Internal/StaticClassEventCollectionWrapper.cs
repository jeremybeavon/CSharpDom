using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    public class StaticClassEventCollectionWrapper :
        AbstractWrapper<IStaticClassEventCollection>
    {
        public StaticClassEventCollectionWrapper(IStaticClassEventCollection eventCollection)
            : base(eventCollection)
        {
        }

        public override void VisitStaticClassEventCollection<TEvent, TEventProperty>(
            IStaticClassEventCollection<TEvent, TEventProperty> eventCollection)
        {
            Value = new StaticClassEventCollection()
            {
                Events = eventCollection.ToList(@event => new StaticClassEventWrapper(@event).Value),
                EventProperties = eventCollection.EventProperties.ToList(@event => new StaticClassEventPropertyWrapper(@event).Value)
            };
        }
    }
}
