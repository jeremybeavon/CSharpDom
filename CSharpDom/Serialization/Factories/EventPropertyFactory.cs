using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class EventPropertyFactory : AbstractFactory<IEventProperty, EventProperty>
    {
        public EventPropertyFactory(IEventProperty eventProperty)
            : base(eventProperty)
        {
        }

        public override void VisitEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody>(
            IEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody> eventProperty)
        {
            Value = new EventProperty()
            {
                AddBody = new MethodBodyFactory(eventProperty.AddBody).Value,
                Attributes = eventProperty.Attributes.ToAttributeListUsingFactory(),
                EventType = new DelegateReferenceFactory(eventProperty.EventType).Value,
                InheritanceModifier = eventProperty.InheritanceModifier,
                Name = eventProperty.Name,
                RemoveBody = new MethodBodyFactory(eventProperty.RemoveBody).Value,
                Visibility = eventProperty.Visibility
            };
        }
    }
}
