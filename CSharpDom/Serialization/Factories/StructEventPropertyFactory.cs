using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class StructEventPropertyFactory : AbstractFactory<IStructEventProperty, StructEventProperty>
    {
        public StructEventPropertyFactory(IStructEventProperty eventProperty)
            : base(eventProperty)
        {
        }

        public override void VisitStructEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody>(
            IStructEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody> eventProperty)
        {
            Value = new StructEventProperty()
            {
                AddAttributes = eventProperty.AddAttributes.ToAttributeListUsingFactory(),
                AddBody = new MethodBodyFactory(eventProperty.AddBody).Value,
                Attributes = eventProperty.Attributes.ToAttributeListUsingFactory(),
                EventType = new DelegateReferenceFactory(eventProperty.EventType).Value,
                Name = eventProperty.Name,
                RemoveAttributes = eventProperty.RemoveAttributes.ToAttributeListUsingFactory(),
                RemoveBody = new MethodBodyFactory(eventProperty.RemoveBody).Value,
                Visibility = eventProperty.Visibility
            };
        }
    }
}
