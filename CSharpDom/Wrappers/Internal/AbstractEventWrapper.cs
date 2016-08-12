using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class AbstractEventWrapper : AbstractWrapper<IAbstractEvent>
    {
        public AbstractEventWrapper(IAbstractEvent @event)
            : base(@event)
        {
        }

        public override void VisitAbstractEvent<TAttributeGroup, TDeclaringType, TDelegateReference>(
            IAbstractEvent<TAttributeGroup, TDeclaringType, TDelegateReference> @event)
        {
            Value = new AbstractEvent()
            {
                Attributes = @event.Attributes.ToAttributeListUsingWrapper(),
                EventType = new DelegateReferenceWrapper(@event.EventType).Value,
                Name = @event.Name
            };
        }
    }
}
