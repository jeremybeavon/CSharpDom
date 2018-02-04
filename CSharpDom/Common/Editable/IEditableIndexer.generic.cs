namespace CSharpDom.Common.Editable
{
    public interface IEditableIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor> :
        IEditableIndexer,
        IHasEditableAttributes<TAttributeGroup>,
        IHasEditableDeclaringType<TDeclaringType>,
        IHasEditableIndexerType<TTypeReference>,
        IHasEditableParameters<TParameter>,
        IHasEditableAccessors<TAccessor>,
        IIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor>
        where TAttributeGroup : IEditableAttributeGroup
        where TDeclaringType : IEditableBasicType
        where TTypeReference : IEditableTypeReference
        where TParameter : IEditableIndexerParameter
        where TAccessor : IEditableAccessor
    {
    }
}