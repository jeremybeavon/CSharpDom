using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class ExplicitInterfacePropertyFactory : AbstractFactory<IExplicitInterfaceProperty, ExplicitInterfaceProperty>
    {
        public ExplicitInterfacePropertyFactory(IExplicitInterfaceProperty property)
            : base(property)
        {
        }

        public override void VisitExplicitInterfaceProperty<TAttributeGroup, TDeclaringType, TInterfaceReference, TTypeReference, TAccessor>(
            IExplicitInterfaceProperty<TAttributeGroup, TDeclaringType, TInterfaceReference, TTypeReference, TAccessor> property)
        {
            Value = new ExplicitInterfaceProperty()
            {
                Attributes = property.Attributes.ToAttributeListUsingFactory(),
                Name = property.Name,
                PropertyType = new TypeReferenceFactory(property.PropertyType).Value
            };
        }
    }
}
