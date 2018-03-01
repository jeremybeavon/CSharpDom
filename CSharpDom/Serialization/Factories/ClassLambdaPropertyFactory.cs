using CSharpDom.Common;
using CSharpDom.Serialization.Factories.Expressions;

namespace CSharpDom.Serialization.Factories
{
    public sealed class ClassLambdaPropertyFactory : AbstractFactory<IClassLambdaProperty, ClassLambdaProperty>
    {
        public ClassLambdaPropertyFactory(IClassLambdaProperty property)
            : base(property)
        {
        }

        public override void VisitClassLambdaProperty<TAttributeGroup, TDeclaringType, TTypeReference, TExpression>(
            IClassLambdaProperty<TAttributeGroup, TDeclaringType, TTypeReference, TExpression> property)
        {
            Value = new ClassLambdaProperty()
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
