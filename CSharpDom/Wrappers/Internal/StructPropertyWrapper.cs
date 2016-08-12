using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class StructPropertyWrapper : AbstractWrapper<IStructProperty>
    {
        public StructPropertyWrapper(IStructProperty property)
            : base(property)
        {
        }

        public override void VisitStructProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor>(
            IStructProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor> property)
        {
            Value = new StructProperty()
            {
                Attributes = property.Attributes.ToAttributeListUsingWrapper(),
                GetAccessor = new StructAccessorWrapper(property.GetAccessor).Value,
                InheritanceModifier = property.InheritanceModifier,
                Name = property.Name,
                PropertyType = new TypeReferenceWrapper(property.PropertyType).Value,
                SetAccessor = new StructAccessorWrapper(property.SetAccessor).Value,
                Visibility = property.Visibility
            };
        }
    }
}
