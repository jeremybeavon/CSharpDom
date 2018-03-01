using CSharpDom.Common;
using CSharpDom.Serialization.Factories.Expressions;

namespace CSharpDom.Serialization.Factories
{
    public sealed class SealedClassAutoPropertyFactory : AbstractFactory<ISealedClassAutoProperty, SealedClassAutoProperty>
    {
        public SealedClassAutoPropertyFactory(ISealedClassAutoProperty property)
            : base(property)
        {
        }

        public override void VisitSealedClassAutoProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor, TExpression>(
            ISealedClassAutoProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor, TExpression> property)
        {
            Value = new SealedClassAutoProperty()
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
