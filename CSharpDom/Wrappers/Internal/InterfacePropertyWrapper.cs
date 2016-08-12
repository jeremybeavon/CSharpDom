using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class InterfacePropertyWrapper : AbstractWrapper<IInterfaceProperty>
    {
        public InterfacePropertyWrapper(IInterfaceProperty property)
            : base(property)
        {
        }

        public override void VisitInterfaceProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor>(
            IInterfaceProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor> property)
        {
            Value = new InterfaceProperty()
            {
                Attributes = property.Attributes.ToAttributeListUsingWrapper(),
                GetAccessor = new InterfaceAccessorWrapper(property.GetAccessor).Value,
                InheritanceModifier = property.InheritanceModifier,
                Name = property.Name,
                PropertyType = new TypeReferenceWrapper(property.PropertyType).Value,
                SetAccessor = new InterfaceAccessorWrapper(property.SetAccessor).Value
            };
        }
    }
}
