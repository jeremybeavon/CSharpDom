using CSharpDom.Common;
using CSharpDom.Serialization.Factories.Expressions;

namespace CSharpDom.Serialization.Factories
{
    public sealed class StructAutoPropertyFactory : AbstractFactory<IStructAutoProperty, StructAutoProperty>
    {
        public StructAutoPropertyFactory(IStructAutoProperty property)
            : base(property)
        {
        }

        public override void VisitStructAutoProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor, TExpression>(
            IStructAutoProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor, TExpression> property)
        {
            Value = new StructAutoProperty()
            {
                Attributes = property.Attributes.ToAttributeListUsingFactory(),
                GetAccessor = new StructAutoPropertyAccessorFactory(property.GetAccessor).Value,
                InheritanceModifier = property.InheritanceModifier,
                InitialValue = new ExpressionFactory(property.InitialValue).Value,
                Name = property.Name,
                PropertyType = new TypeReferenceFactory(property.PropertyType).Value,
                SetAccessor = new StructAutoPropertyAccessorFactory(property.SetAccessor).Value,
                Visibility = property.Visibility
            };
        }
    }
}
