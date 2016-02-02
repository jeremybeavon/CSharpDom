namespace CSharpDom.Common
{
    public interface IIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor> :
        IIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter>,
        IHasAccessors<TAccessor>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IType
        where TTypeReference : ITypeReference
        where TParameter : IParameter
        where TAccessor : IAccessor
    {
    }
}
