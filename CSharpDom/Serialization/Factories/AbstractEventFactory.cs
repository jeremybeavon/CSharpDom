using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class AbstractEventFactory : AbstractFactory<IAbstractEvent, AbstractEvent>
    {
        public AbstractEventFactory(IAbstractEvent @event)
            : base(@event)
        {
        }

        public override void VisitAbstractEvent<TAttributeGroup, TDeclaringType, TDelegateReference>(
            IAbstractEvent<TAttributeGroup, TDeclaringType, TDelegateReference> @event)
        {
            Value = new AbstractEvent()
            {
                Attributes = @event.Attributes.ToAttributeListUsingFactory(),
                EventType = new DelegateReferenceFactory(@event.EventType).Value,
                Name = @event.Name
            };
        }
    }
}
