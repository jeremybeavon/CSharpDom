using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class StaticClassEventPropertyFactory : AbstractFactory<IStaticClassEventProperty, StaticClassEventProperty>
    {
        public StaticClassEventPropertyFactory(IStaticClassEventProperty eventProperty)
            : base(eventProperty)
        {
        }

        public override void VisitStaticClassEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody>(
            IStaticClassEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody> eventProperty)
        {
            Value = new StaticClassEventProperty()
            {
                AddBody = new MethodBodyFactory(eventProperty.AddBody).Value,
                Attributes = eventProperty.Attributes.ToAttributeListUsingFactory(),
                EventType = new DelegateReferenceFactory(eventProperty.EventType).Value,
                Name = eventProperty.Name,
                RemoveBody = new MethodBodyFactory(eventProperty.RemoveBody).Value,
                Visibility = eventProperty.Visibility
            };
        }
    }
}
