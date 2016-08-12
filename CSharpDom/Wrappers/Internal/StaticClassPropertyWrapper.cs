using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class StaticClassPropertyWrapper : AbstractWrapper<IStaticClassProperty>
    {
        public StaticClassPropertyWrapper(IStaticClassProperty property)
            : base(property)
        {
        }

        public override void VisitStaticClassProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor>(
            IStaticClassProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor> property)
        {
            Value = new StaticClassProperty()
            {
                Attributes = property.Attributes.ToAttributeListUsingWrapper(),
                GetAccessor = new StaticClassAccessorWrapper(property.GetAccessor).Value,
                Name = property.Name,
                PropertyType = new TypeReferenceWrapper(property.PropertyType).Value,
                SetAccessor = new StaticClassAccessorWrapper(property.SetAccessor).Value,
                Visibility = property.Visibility
            };
        }
    }
}
