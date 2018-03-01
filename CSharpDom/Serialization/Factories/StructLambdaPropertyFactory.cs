using CSharpDom.Common;
using CSharpDom.Serialization.Factories.Expressions;

namespace CSharpDom.Serialization.Factories
{
    public sealed class StructLambdaPropertyFactory : AbstractFactory<IStructLambdaProperty, StructLambdaProperty>
    {
        public StructLambdaPropertyFactory(IStructLambdaProperty property)
            : base(property)
        {
        }

        public override void VisitStructLambdaProperty<TAttributeGroup, TDeclaringType, TTypeReference, TExpression>(
            IStructLambdaProperty<TAttributeGroup, TDeclaringType, TTypeReference, TExpression> property)
        {
            Value = new StructLambdaProperty()
            {
                Attributes = property.Attributes.ToAttributeListUsingFactory(),
                InheritanceModifier = property.InheritanceModifier,
                LambdaExpression = new ExpressionFactory(property.LambdaExpression).Value,
                Name = property.Name,
                PropertyType = new TypeReferenceFactory(property.PropertyType).Value,
                Visibility = property.Visibility
            };
        }
    }
}
