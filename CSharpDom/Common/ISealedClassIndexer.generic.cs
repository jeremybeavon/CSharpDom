namespace CSharpDom.Common
{
    public interface ISealedClassIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor> :
        ISealedClassIndexer,
        IIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor>,
        IHasSealedClassIndexerInheritanceModifier
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : ISealedType
        where TTypeReference : ITypeReference
        where TParameter : IIndexerParameter
        where TAccessor : IClassAccessor
    {
    }
}
