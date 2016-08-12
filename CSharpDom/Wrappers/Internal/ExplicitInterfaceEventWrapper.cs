using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class ExplicitInterfaceEventWrapper : AbstractWrapper<IExplicitInterfaceEvent>
    {
        public ExplicitInterfaceEventWrapper(IExplicitInterfaceEvent eventProperty)
            : base(eventProperty)
        {
        }

        public override void VisitExplicitInterfaceEvent<TAttributeGroup, TDeclaringType, TInterfaceReference, TDelegateReference, TMethodBody>(
            IExplicitInterfaceEvent<TAttributeGroup, TDeclaringType, TInterfaceReference, TDelegateReference, TMethodBody> @event)
        {
            Value = new ExplicitInterfaceEvent()
            {
                AddAttributes = @event.AddAttributes.ToAttributeListUsingWrapper(),
                AddBody = new MethodBodyWrapper(@event.AddBody).Value,
                Attributes = @event.Attributes.ToAttributeListUsingWrapper(),
                EventType = new DelegateReferenceWrapper(@event.EventType).Value,
                ExplicitInterface = new InterfaceReferenceWrapper(@event.ExplicitInterface).Value,
                Name = @event.Name,
                RemoveAttributes = @event.AddAttributes.ToAttributeListUsingWrapper(),
                RemoveBody = new MethodBodyWrapper(@event.RemoveBody).Value
            };
        }
    }
}
