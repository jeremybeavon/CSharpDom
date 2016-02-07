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
