using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class PropertyFactory : AbstractFactory<IProperty, Property>
    {
        public PropertyFactory(IProperty property)
            : base(property)
        {
        }

        public override void VisitProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor>(
            IProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor> property)
        {
            Value = new Property()
            {
                Attributes = property.Attributes.ToAttributeListUsingFactory(),
                GetAccessor = new AccessorFactory(property.GetAccessor).Value,
                InheritanceModifier = property.InheritanceModifier,
                Name = property.Name,
                PropertyType = new TypeReferenceFactory(property.PropertyType).Value,
                SetAccessor = new AccessorFactory(property.SetAccessor).Value,
                Visibility = property.Visibility
            };
        }
    }
}
