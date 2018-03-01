using CSharpDom.Common;
using CSharpDom.Serialization.Factories.Expressions;

namespace CSharpDom.Serialization.Factories
{
    public sealed class SealedClassLambdaPropertyFactory : AbstractFactory<ISealedClassLambdaProperty, SealedClassLambdaProperty>
    {
        public SealedClassLambdaPropertyFactory(ISealedClassLambdaProperty property)
            : base(property)
        {
        }

        public override void VisitSealedClassLambdaProperty<TAttributeGroup, TDeclaringType, TTypeReference, TExpression>(
            ISealedClassLambdaProperty<TAttributeGroup, TDeclaringType, TTypeReference, TExpression> property)
        {
            Value = new SealedClassLambdaProperty()
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
