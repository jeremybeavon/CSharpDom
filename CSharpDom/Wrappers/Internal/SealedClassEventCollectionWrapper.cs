using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    public class SealedClassEventCollectionWrapper :
        AbstractWrapper<ISealedClassEventCollection>
    {
        public SealedClassEventCollectionWrapper(ISealedClassEventCollection eventCollection)
            : base(eventCollection)
        {
        }

        public override void VisitSealedClassEventCollection<TEvent, TEventProperty, TExplicitInterfaceEvent>(
            ISealedClassEventCollection<TEvent, TEventProperty, TExplicitInterfaceEvent> eventCollection)
        {
            Value = new SealedClassEventCollection()
            {
                Events = eventCollection.ToList(@event => new SealedClassEventWrapper(@event).Value),
                EventProperties = eventCollection.EventProperties.ToList(@event => new SealedClassEventPropertyWrapper(@event).Value),
                ExplicitInterfaceEvents = eventCollection.ExplicitInterfaceEvents.ToList(@event => new ExplicitInterfaceEventWrapper(@event).Value)
            };
        }
    }
}
