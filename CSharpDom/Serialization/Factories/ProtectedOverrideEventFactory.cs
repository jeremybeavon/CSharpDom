using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class ProtectedOverrideEventFactory : AbstractFactory<IProtectedOverrideEvent, ProtectedOverrideEvent>
    {
        public ProtectedOverrideEventFactory(IProtectedOverrideEvent eventProperty)
            : base(eventProperty)
        {
        }

        public override void VisitProtectedOverrideEvent<TAttributeGroup, TDeclaringType, TDelegateReference>(
            IProtectedOverrideEvent<TAttributeGroup, TDeclaringType, TDelegateReference> @event)
        {
            Value = new ProtectedOverrideEvent()
            {
                Attributes = @event.Attributes.ToAttributeListUsingFactory(),
                EventType = new DelegateReferenceFactory(@event.EventType).Value,
                IsInternal = @event.IsInternal,
                IsSealed = @event.IsSealed,
                Name = @event.Name
            };
        }
    }
}
