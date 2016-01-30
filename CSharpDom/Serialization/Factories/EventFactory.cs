using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class EventFactory : AbstractFactory<IEvent, Event>
    {
        public EventFactory(IEvent @event)
            : base(@event)
        {
        }

        public override void VisitEvent<TAttributeGroup, TDeclaringType, TDelegateReference>(
            IEvent<TAttributeGroup, TDeclaringType, TDelegateReference> @event)
        {
            Value = new Event()
            {
                Attributes = @event.Attributes.ToAttributeListUsingFactory(),
                EventType = new DelegateReferenceFactory(@event.EventType).Value,
                FieldAttributes = @event.FieldAttributes.ToAttributeListUsingFactory(),
                InheritanceModifier = @event.InheritanceModifier,
                Name = @event.Name,
                Visibility = @event.Visibility
            };
        }
    }
}
