using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class StructEventFactory : AbstractFactory<IStructEvent, StructEvent>
    {
        public StructEventFactory(IStructEvent @event)
            : base(@event)
        {
        }

        public override void VisitStructEvent<TAttributeGroup, TDeclaringType, TDelegateReference>(
            IStructEvent<TAttributeGroup, TDeclaringType, TDelegateReference> @event)
        {
            Value = new StructEvent()
            {
                Attributes = @event.Attributes.ToAttributeListUsingFactory(),
                EventType = new DelegateReferenceFactory(@event.EventType).Value,
                InheritanceModifier = @event.InheritanceModifier,
                Name = @event.Name,
                Visibility = @event.Visibility
            };
        }
    }
}
