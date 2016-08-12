using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    public class ClassEventCollectionWrapper :
        AbstractWrapper<IClassEventCollection>
    {
        public ClassEventCollectionWrapper(IClassEventCollection eventCollection)
            : base(eventCollection)
        {
        }

        public override void VisitClassEventCollection<TEvent, TEventProperty, TExplicitInterfaceEvent>(
            IClassEventCollection<TEvent, TEventProperty, TExplicitInterfaceEvent> eventCollection)
        {
            Value = new ClassEventCollection()
            {
                Events = eventCollection.ToList(@event => new ClassEventWrapper(@event).Value),
                EventProperties = eventCollection.EventProperties.ToList(@event => new ClassEventPropertyWrapper(@event).Value),
                ExplicitInterfaceEvents = eventCollection.ExplicitInterfaceEvents.ToList(@event => new ExplicitInterfaceEventWrapper(@event).Value)
            };
        }
    }
}
