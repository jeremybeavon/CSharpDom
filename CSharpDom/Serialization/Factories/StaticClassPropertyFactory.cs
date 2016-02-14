using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class StaticClassPropertyFactory : AbstractFactory<IStaticClassProperty, StaticClassProperty>
    {
        public StaticClassPropertyFactory(IStaticClassProperty property)
            : base(property)
        {
        }

        public override void VisitStaticClassProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor>(
            IStaticClassProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor> property)
        {
            Value = new StaticClassProperty()
            {
                Attributes = property.Attributes.ToAttributeListUsingFactory(),
                GetAccessor = new StaticClassAccessorFactory(property.GetAccessor).Value,
                Name = property.Name,
                PropertyType = new TypeReferenceFactory(property.PropertyType).Value,
                SetAccessor = new StaticClassAccessorFactory(property.SetAccessor).Value,
                InheritanceModifier = property.InheritanceModifier
            };
        }
    }
}
