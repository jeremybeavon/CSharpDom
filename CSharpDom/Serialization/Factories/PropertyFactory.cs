using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class PropertyFactory : AbstractFactory<IClassProperty, ClassProperty>
    {
        public PropertyFactory(IClassProperty property)
            : base(property)
        {
        }

        public override void VisitClassProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor>(
            IClassProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor> property)
        {
            Value = new ClassProperty()
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
