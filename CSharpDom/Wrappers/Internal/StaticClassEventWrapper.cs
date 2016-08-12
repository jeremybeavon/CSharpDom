using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class StaticClassEventWrapper : AbstractWrapper<IStaticClassEvent>
    {
        public StaticClassEventWrapper(IStaticClassEvent @event)
            : base(@event)
        {
        }

        public override void VisitStaticClassEvent<TAttributeGroup, TDeclaringType, TDelegateReference>(
            IStaticClassEvent<TAttributeGroup, TDeclaringType, TDelegateReference> @event)
        {
            Value = new StaticClassEvent()
            {
                Attributes = @event.Attributes.ToAttributeListUsingWrapper(),
                EventType = new DelegateReferenceWrapper(@event.EventType).Value,
                FieldAttributes = @event.FieldAttributes.ToAttributeListUsingWrapper(),
                Name = @event.Name,
                Visibility = @event.Visibility
            };
        }
    }
}
