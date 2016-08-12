using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class ClassPropertyWrapper : AbstractWrapper<IClassProperty>
    {
        public ClassPropertyWrapper(IClassProperty property)
            : base(property)
        {
        }

        public override void VisitClassProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor>(
            IClassProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor> property)
        {
            Value = new ClassProperty()
            {
                Attributes = property.Attributes.ToAttributeListUsingWrapper(),
                GetAccessor = new ClassAccessorWrapper(property.GetAccessor).Value,
                InheritanceModifier = property.InheritanceModifier,
                Name = property.Name,
                PropertyType = new TypeReferenceWrapper(property.PropertyType).Value,
                SetAccessor = new ClassAccessorWrapper(property.SetAccessor).Value,
                Visibility = property.Visibility
            };
        }
    }
}
