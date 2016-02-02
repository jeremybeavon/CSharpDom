namespace CSharpDom.Common
{
    public interface IStructIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor> :
        IStructIndexer,
        IIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IType
        where TTypeReference : ITypeReference
        where TParameter : IParameter
        where TAccessor : IStructAccessor
    {
    }
}
