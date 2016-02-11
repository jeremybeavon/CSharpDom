using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class ProtectedOverridePropertyFactory : AbstractFactory<IProtectedOverrideProperty, ProtectedOverrideProperty>
    {
        public ProtectedOverridePropertyFactory(IProtectedOverrideProperty property)
            : base(property)
        {
        }

        public override void VisitProtectedOverrideProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor>(
            IProtectedOverrideProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor> property)
        {
            Value = new ProtectedOverrideProperty()
            {
                Attributes = property.Attributes.ToAttributeListUsingFactory(),
                GetAccessor = new SealedClassAccessorFactory(property.GetAccessor).Value,
                IsInternal = property.IsInternal,
                IsSealed = property.IsSealed,
                Name = property.Name,
                PropertyType = new TypeReferenceFactory(property.PropertyType).Value,
                SetAccessor = new SealedClassAccessorFactory(property.SetAccessor).Value
            };
        }
    }
}
