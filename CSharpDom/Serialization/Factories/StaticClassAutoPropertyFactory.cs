using CSharpDom.Common;
using CSharpDom.Serialization.Factories.Expressions;

namespace CSharpDom.Serialization.Factories
{
    public sealed class StaticClassAutoPropertyFactory : AbstractFactory<IStaticClassAutoProperty, StaticClassAutoProperty>
    {
        public StaticClassAutoPropertyFactory(IStaticClassAutoProperty property)
            : base(property)
        {
        }

        public override void VisitStaticClassAutoProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor, TExpression>(
            IStaticClassAutoProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor, TExpression> property)
        {
            Value = new StaticClassAutoProperty()
            {
                Attributes = property.Attributes.ToAttributeListUsingFactory(),
                GetAccessor = new StaticClassAutoPropertyAccessorFactory(property.GetAccessor).Value,
                InitialValue = new ExpressionFactory(property.InitialValue).Value,
                Name = property.Name,
                PropertyType = new TypeReferenceFactory(property.PropertyType).Value,
                SetAccessor = new StaticClassAutoPropertyAccessorFactory(property.SetAccessor).Value,
                Visibility = property.Visibility
            };
        }
    }
}
