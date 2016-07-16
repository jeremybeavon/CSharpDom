using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class ClassEventPropertyFactory : AbstractFactory<IClassEventProperty, ClassEventProperty>
    {
        public ClassEventPropertyFactory(IClassEventProperty eventProperty)
            : base(eventProperty)
        {
        }

        public override void VisitClassEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody>(
            IClassEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody> eventProperty)
        {
            Value = new ClassEventProperty()
            {
                AddAttributes = eventProperty.AddAttributes.ToAttributeListUsingFactory(),
                AddBody = new MethodBodyFactory(eventProperty.AddBody).Value,
                Attributes = eventProperty.Attributes.ToAttributeListUsingFactory(),
                EventType = new DelegateReferenceFactory(eventProperty.EventType).Value,
                InheritanceModifier = eventProperty.InheritanceModifier,
                Name = eventProperty.Name,
                RemoveAttributes = eventProperty.RemoveAttributes.ToAttributeListUsingFactory(),
                RemoveBody = new MethodBodyFactory(eventProperty.RemoveBody).Value,
                Visibility = eventProperty.Visibility
            };
        }
    }
}
