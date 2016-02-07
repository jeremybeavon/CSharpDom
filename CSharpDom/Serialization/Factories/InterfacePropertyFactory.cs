using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class InterfacePropertyFactory : AbstractFactory<IInterfaceProperty, InterfaceProperty>
    {
        public InterfacePropertyFactory(IInterfaceProperty property)
            : base(property)
        {
        }

        public override void VisitInterfaceProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor>(
            IInterfaceProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor> property)
        {
            Value = new InterfaceProperty()
            {
                Attributes = property.Attributes.ToAttributeListUsingFactory(),
                GetAccessor = new InterfaceAccessorFactory(property.GetAccessor).Value,
                InheritanceModifier = property.InheritanceModifier,
                Name = property.Name,
                PropertyType = new TypeReferenceFactory(property.PropertyType).Value,
                SetAccessor = new InterfaceAccessorFactory(property.SetAccessor).Value
            };
        }
    }
}
