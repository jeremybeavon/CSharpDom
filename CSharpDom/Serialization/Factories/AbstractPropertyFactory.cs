using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class AbstractPropertyFactory : AbstractFactory<IAbstractProperty, AbstractProperty>
    {
        public AbstractPropertyFactory(IAbstractProperty property)
            : base(property)
        {
        }

        public override void VisitAbstractProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor>(
            IAbstractProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor> property)
        {
            Value = new AbstractProperty()
            {
                Attributes = property.Attributes.ToAttributeListUsingFactory(),
                GetAccessor = new AbstractAccessorFactory(property.GetAccessor).Value,
                Name = property.Name,
                PropertyType = new TypeReferenceFactory(property.PropertyType).Value,
                SetAccessor = new AbstractAccessorFactory(property.SetAccessor).Value
            };
        }
    }
}
