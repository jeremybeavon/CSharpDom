using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class InterfaceEventFactory : AbstractFactory<IInterfaceEvent, InterfaceEvent>
    {
        public InterfaceEventFactory(IInterfaceEvent @event)
            : base(@event)
        {
        }

        public override void VisitInterfaceEvent<TAttributeGroup, TDeclaringType, TDelegateReference>(
            IInterfaceEvent<TAttributeGroup, TDeclaringType, TDelegateReference> @event)
        {
            Value = new InterfaceEvent()
            {
                Attributes = @event.Attributes.ToAttributeListUsingFactory(),
                EventType = new DelegateReferenceFactory(@event.EventType).Value,
                InheritanceModifier = @event.InheritanceModifier,
                Name = @event.Name
            };
        }
    }
}
