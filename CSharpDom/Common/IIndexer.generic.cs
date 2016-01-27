namespace CSharpDom.Common
{
    public interface IIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor> :
        IIndexer,
        IHasAttributes<TAttributeGroup>,
        IHasMemberVisibilityModifier,
        IHasMemberInheritanceModifier,
        IHasDeclaringType<TDeclaringType>,
        IHasIndexerType<TTypeReference>,
        IHasParameters<TParameter>,
        IHasAccessors<TAccessor>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IBasicType
        where TTypeReference : ITypeReference
        where TParameter : IParameter
        where TAccessor : IAccessor
    {
    }
}
