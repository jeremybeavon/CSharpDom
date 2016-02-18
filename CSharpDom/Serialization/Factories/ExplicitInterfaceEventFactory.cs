using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class ExplicitInterfaceEventFactory : AbstractFactory<IExplicitInterfaceEvent, ExplicitInterfaceEvent>
    {
        public ExplicitInterfaceEventFactory(IExplicitInterfaceEvent eventProperty)
            : base(eventProperty)
        {
        }

        public override void VisitExplicitInterfaceEvent<TAttributeGroup, TDeclaringType, TInterfaceReference, TDelegateReference, TMethodBody>(
            IExplicitInterfaceEvent<TAttributeGroup, TDeclaringType, TInterfaceReference, TDelegateReference, TMethodBody> @event)
        {
            Value = new ExplicitInterfaceEvent()
            {
                AddBody = new MethodBodyFactory(@event.AddBody).Value,
                Attributes = @event.Attributes.ToAttributeListUsingFactory(),
                EventType = new DelegateReferenceFactory(@event.EventType).Value,
                ExplicitInterface = new InterfaceReferenceFactory(@event.ExplicitInterface).Value,
                Name = @event.Name,
                RemoveBody = new MethodBodyFactory(@event.RemoveBody).Value
            };
        }
    }
}
