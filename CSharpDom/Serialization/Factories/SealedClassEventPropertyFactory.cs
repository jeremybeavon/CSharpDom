using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class SealedClassEventPropertyFactory : AbstractFactory<ISealedClassEventProperty, SealedClassEventProperty>
    {
        public SealedClassEventPropertyFactory(ISealedClassEventProperty eventProperty)
            : base(eventProperty)
        {
        }

        public override void VisitSealedClassEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody>(
            ISealedClassEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody> eventProperty)
        {
            Value = new SealedClassEventProperty()
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
