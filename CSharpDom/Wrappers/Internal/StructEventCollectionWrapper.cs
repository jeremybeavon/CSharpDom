using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    public class StructEventCollectionWrapper :
        AbstractWrapper<IStructEventCollection>
    {
        public StructEventCollectionWrapper(IStructEventCollection eventCollection)
            : base(eventCollection)
        {
        }

        public override void VisitStructEventCollection<TEvent, TEventProperty, TExplicitInterfaceEvent>(
            IStructEventCollection<TEvent, TEventProperty, TExplicitInterfaceEvent> eventCollection)
        {
            Value = new StructEventCollection()
            {
                Events = eventCollection.ToList(@event => new StructEventWrapper(@event).Value),
                EventProperties = eventCollection.EventProperties.ToList(@event => new StructEventPropertyWrapper(@event).Value),
                ExplicitInterfaceEvents = eventCollection.ExplicitInterfaceEvents.ToList(@event => new ExplicitInterfaceEventWrapper(@event).Value)
            };
        }
    }
}
