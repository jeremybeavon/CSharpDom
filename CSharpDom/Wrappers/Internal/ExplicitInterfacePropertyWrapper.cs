using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class ExplicitInterfacePropertyWrapper : AbstractWrapper<IExplicitInterfaceProperty>
    {
        public ExplicitInterfacePropertyWrapper(IExplicitInterfaceProperty property)
            : base(property)
        {
        }

        public override void VisitExplicitInterfaceProperty<TAttributeGroup, TDeclaringType, TInterfaceReference, TTypeReference, TAccessor>(
            IExplicitInterfaceProperty<TAttributeGroup, TDeclaringType, TInterfaceReference, TTypeReference, TAccessor> property)
        {
            Value = new ExplicitInterfaceProperty()
            {
                Attributes = property.Attributes.ToAttributeListUsingWrapper(),
                ExplicitInterface = new InterfaceReferenceWrapper(property.ExplicitInterface).Value,
                Name = property.Name,
                PropertyType = new TypeReferenceWrapper(property.PropertyType).Value
            };
        }
    }
}
