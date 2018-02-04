namespace CSharpDom.Common.Editable
{
    public interface IEditableAbstractIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor> :
        IEditableAbstractIndexer,
        IEditableIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor>,
        IAbstractIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor>
        where TAttributeGroup : IEditableAttributeGroup
        where TDeclaringType : IEditableAbstractType
        where TTypeReference : IEditableTypeReference
        where TParameter : IEditableIndexerParameter
        where TAccessor : IEditableAbstractAccessor
    {
    }
}