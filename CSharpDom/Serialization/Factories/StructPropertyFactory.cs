using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class StructPropertyFactory : AbstractFactory<IStructProperty, StructProperty>
    {
        public StructPropertyFactory(IStructProperty property)
            : base(property)
        {
        }

        public override void VisitStructProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor>(
            IStructProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor> property)
        {
            Value = new StructProperty()
            {
                Attributes = property.Attributes.ToAttributeListUsingFactory(),
                GetAccessor = new StructAccessorFactory(property.GetAccessor).Value,
                InheritanceModifier = property.InheritanceModifier,
                Name = property.Name,
                PropertyType = new TypeReferenceFactory(property.PropertyType).Value,
                SetAccessor = new StructAccessorFactory(property.SetAccessor).Value,
                Visibility = property.Visibility
            };
        }
    }
}
