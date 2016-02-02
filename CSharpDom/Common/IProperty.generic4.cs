namespace CSharpDom.Common
{
    public interface IProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor> :
        IProperty<TAttributeGroup, TDeclaringType, TTypeReference>,
        IHasAccessors<TAccessor>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IType
        where TTypeReference : ITypeReference
        where TAccessor : IAccessor
    {
    }
}
