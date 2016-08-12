using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class AbstractPropertyWrapper : AbstractWrapper<IAbstractProperty>
    {
        public AbstractPropertyWrapper(IAbstractProperty property)
            : base(property)
        {
        }

        public override void VisitAbstractProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor>(
            IAbstractProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor> property)
        {
            Value = new AbstractProperty()
            {
                Attributes = property.Attributes.ToAttributeListUsingWrapper(),
                GetAccessor = new AbstractAccessorWrapper(property.GetAccessor).Value,
                Name = property.Name,
                PropertyType = new TypeReferenceWrapper(property.PropertyType).Value,
                SetAccessor = new AbstractAccessorWrapper(property.SetAccessor).Value
            };
        }
    }
}
