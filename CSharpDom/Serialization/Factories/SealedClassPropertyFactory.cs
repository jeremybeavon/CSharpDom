using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class SealedClassPropertyFactory : AbstractFactory<ISealedClassProperty, SealedClassProperty>
    {
        public SealedClassPropertyFactory(ISealedClassProperty property)
            : base(property)
        {
        }

        public override void VisitSealedClassProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor>(
            ISealedClassProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor> property)
        {
            Value = new SealedClassProperty()
            {
                Attributes = property.Attributes.ToAttributeListUsingFactory(),
                GetAccessor = new ClassAccessorFactory(property.GetAccessor).Value,
                Name = property.Name,
                PropertyType = new TypeReferenceFactory(property.PropertyType).Value,
                SetAccessor = new ClassAccessorFactory(property.SetAccessor).Value,
                Visibility = property.Visibility
            };
        }
    }
}
