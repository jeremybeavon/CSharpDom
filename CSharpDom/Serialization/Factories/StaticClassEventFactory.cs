using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class StaticClassEventFactory : AbstractFactory<IStaticClassEvent, StaticClassEvent>
    {
        public StaticClassEventFactory(IStaticClassEvent @event)
            : base(@event)
        {
        }

        public override void VisitStaticClassEvent<TAttributeGroup, TDeclaringType, TDelegateReference>(
            IStaticClassEvent<TAttributeGroup, TDeclaringType, TDelegateReference> @event)
        {
            Value = new StaticClassEvent()
            {
                Attributes = @event.Attributes.ToAttributeListUsingFactory(),
                EventType = new DelegateReferenceFactory(@event.EventType).Value,
                FieldAttributes = @event.FieldAttributes.ToAttributeListUsingFactory(),
                Name = @event.Name,
                Visibility = @event.Visibility
            };
        }
    }
}
