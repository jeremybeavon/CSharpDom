using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class StructEventWrapper : AbstractWrapper<IStructEvent>
    {
        public StructEventWrapper(IStructEvent @event)
            : base(@event)
        {
        }

        public override void VisitStructEvent<TAttributeGroup, TDeclaringType, TDelegateReference>(
            IStructEvent<TAttributeGroup, TDeclaringType, TDelegateReference> @event)
        {
            Value = new StructEvent()
            {
                Attributes = @event.Attributes.ToAttributeListUsingWrapper(),
                EventType = new DelegateReferenceWrapper(@event.EventType).Value,
                InheritanceModifier = @event.InheritanceModifier,
                Name = @event.Name,
                Visibility = @event.Visibility
            };
        }
    }
}
