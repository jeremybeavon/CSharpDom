namespace CSharpDom.Common
{
    public interface IExplicitInterfaceProperty<TAttributeGroup, TDeclaringType, TInterfaceReference, TTypeReference, TAccessor> :
        IExplicitInterfaceProperty,
        IProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor>,
        IHasExplicitInterface<TInterfaceReference>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IType
        where TInterfaceReference : IInterfaceReference
        where TTypeReference : ITypeReference
        where TAccessor : IAccessor
    {
    }
}
