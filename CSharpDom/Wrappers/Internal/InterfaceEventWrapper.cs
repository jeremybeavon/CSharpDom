using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class InterfaceEventWrapper : AbstractWrapper<IInterfaceEvent>
    {
        public InterfaceEventWrapper(IInterfaceEvent @event)
            : base(@event)
        {
        }

        public override void VisitInterfaceEvent<TAttributeGroup, TDeclaringType, TDelegateReference>(
            IInterfaceEvent<TAttributeGroup, TDeclaringType, TDelegateReference> @event)
        {
            Value = new InterfaceEvent()
            {
                Attributes = @event.Attributes.ToAttributeListUsingWrapper(),
                EventType = new DelegateReferenceWrapper(@event.EventType).Value,
                InheritanceModifier = @event.InheritanceModifier,
                Name = @event.Name
            };
        }
    }
}
