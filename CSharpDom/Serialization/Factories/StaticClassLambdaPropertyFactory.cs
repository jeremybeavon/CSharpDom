using CSharpDom.Common;
using CSharpDom.Serialization.Factories.Expressions;

namespace CSharpDom.Serialization.Factories
{
    public sealed class StaticClassLambdaPropertyFactory : AbstractFactory<IStaticClassLambdaProperty, StaticClassLambdaProperty>
    {
        public StaticClassLambdaPropertyFactory(IStaticClassLambdaProperty property)
            : base(property)
        {
        }

        public override void VisitStaticClassLambdaProperty<TAttributeGroup, TDeclaringType, TTypeReference, TExpression>(
            IStaticClassLambdaProperty<TAttributeGroup, TDeclaringType, TTypeReference, TExpression> property)
        {
            Value = new StaticClassLambdaProperty()
            {
                Attributes = property.Attributes.ToAttributeListUsingFactory(),
                LambdaExpression = new ExpressionFactory(property.LambdaExpression).Value,
                Name = property.Name,
                PropertyType = new TypeReferenceFactory(property.PropertyType).Value,
                Visibility = property.Visibility
            };
        }
    }
}
