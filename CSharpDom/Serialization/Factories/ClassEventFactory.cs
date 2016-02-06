using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class ClassEventFactory : AbstractFactory<IClassEvent, ClassEvent>
    {
        public ClassEventFactory(IClassEvent @event)
            : base(@event)
        {
        }

        public override void VisitClassEvent<TAttributeGroup, TDeclaringType, TDelegateReference>(
            IClassEvent<TAttributeGroup, TDeclaringType, TDelegateReference> @event)
        {
            Value = new ClassEvent()
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
