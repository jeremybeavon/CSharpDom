using CSharpDom.Common;
using CSharpDom.Serialization.Factories.Expressions;

namespace CSharpDom.Serialization.Factories
{
    public sealed class ClassAutoPropertyFactory : AbstractFactory<IClassAutoProperty, ClassAutoProperty>
    {
        public ClassAutoPropertyFactory(IClassAutoProperty property)
            : base(property)
        {
        }

        public override void VisitClassAutoProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor, TExpression>(
            IClassAutoProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor, TExpression> property)
        {
            Value = new ClassAutoProperty()
            {
                Attributes = property.Attributes.ToAttributeListUsingFactory(),
                GetAccessor = new ClassAccessorFactory(property.GetAccessor).Value,
                InheritanceModifier = property.InheritanceModifier,
                InitialValue = new ExpressionFactory(property.InitialValue).Value,
                Name = property.Name,
                PropertyType = new TypeReferenceFactory(property.PropertyType).Value,
                SetAccessor = new ClassAccessorFactory(property.SetAccessor).Value,
                Visibility = property.Visibility
            };
        }
    }
}
