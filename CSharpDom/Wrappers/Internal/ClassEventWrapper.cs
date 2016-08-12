using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class ClassEventWrapper : AbstractWrapper<IClassEvent>
    {
        public ClassEventWrapper(IClassEvent @event)
            : base(@event)
        {
        }

        public override void VisitClassEvent<TAttributeGroup, TDeclaringType, TDelegateReference>(
            IClassEvent<TAttributeGroup, TDeclaringType, TDelegateReference> @event)
        {
            Value = new ClassEvent()
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
