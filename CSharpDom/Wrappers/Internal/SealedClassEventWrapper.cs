using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class SealedClassEventWrapper : AbstractWrapper<ISealedClassEvent>
    {
        public SealedClassEventWrapper(ISealedClassEvent @event)
            : base(@event)
        {
        }

        public override void VisitSealedClassEvent<TAttributeGroup, TDeclaringType, TDelegateReference>(
            ISealedClassEvent<TAttributeGroup, TDeclaringType, TDelegateReference> @event)
        {
            Value = new SealedClassEvent()
            {
                Attributes = @event.Attributes.ToAttributeListUsingWrapper(),
                EventType = new DelegateReferenceWrapper(@event.EventType).Value,
                FieldAttributes = @event.FieldAttributes.ToAttributeListUsingWrapper(),
                InheritanceModifier = @event.InheritanceModifier,
                Name = @event.Name,
                Visibility = @event.Visibility
            };
        }
    }
}
