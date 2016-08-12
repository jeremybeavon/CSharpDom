using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class SealedClassPropertyWrapper : AbstractWrapper<ISealedClassProperty>
    {
        public SealedClassPropertyWrapper(ISealedClassProperty property)
            : base(property)
        {
        }

        public override void VisitSealedClassProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor>(
            ISealedClassProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor> property)
        {
            Value = new SealedClassProperty()
            {
                Attributes = property.Attributes.ToAttributeListUsingWrapper(),
                InheritanceModifier = property.InheritanceModifier,
                GetAccessor = new ClassAccessorWrapper(property.GetAccessor).Value,
                Name = property.Name,
                PropertyType = new TypeReferenceWrapper(property.PropertyType).Value,
                SetAccessor = new ClassAccessorWrapper(property.SetAccessor).Value,
                Visibility = property.Visibility
            };
        }
    }
}
