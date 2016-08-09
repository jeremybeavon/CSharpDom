using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class SealedClassEventFactory : AbstractFactory<ISealedClassEvent, SealedClassEvent>
    {
        public SealedClassEventFactory(ISealedClassEvent @event)
            : base(@event)
        {
        }

        public override void VisitSealedClassEvent<TAttributeGroup, TDeclaringType, TDelegateReference>(
            ISealedClassEvent<TAttributeGroup, TDeclaringType, TDelegateReference> @event)
        {
            Value = new SealedClassEvent()
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
