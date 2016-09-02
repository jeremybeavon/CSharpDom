namespace CSharpDom.Common
{
    public interface IInterfaceIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor> :
        IInterfaceIndexer,
        IIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IInterfaceType
        where TTypeReference : ITypeReference
        where TParameter : IIndexerParameter
        where TAccessor : IAccessor
    {
    }
}
