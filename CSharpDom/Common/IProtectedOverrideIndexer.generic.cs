namespace CSharpDom.Common
{
    public interface IProtectedOverrideIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor> :
        IProtectedOverrideIndexer,
        IIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : ISealedType
        where TTypeReference : ITypeReference
        where TParameter : IParameter
        where TAccessor : IClassAccessor
    {
    }
}
