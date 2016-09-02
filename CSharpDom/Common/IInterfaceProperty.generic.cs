namespace CSharpDom.Common
{
    public interface IInterfaceProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor> :
        IInterfaceProperty,
        IProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IInterfaceType
        where TTypeReference : ITypeReference
        where TAccessor : IInterfaceAccessor
    {
    }
}
