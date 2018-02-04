namespace CSharpDom.Common.Editable
{
    public interface IEditableInterfaceIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor> :
        IEditableInterfaceIndexer,
        IEditableIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor>,
        IInterfaceIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor>
        where TAttributeGroup : IEditableAttributeGroup
        where TDeclaringType : IEditableInterfaceType
        where TTypeReference : IEditableTypeReference
        where TParameter : IEditableIndexerParameter
        where TAccessor : IEditableAccessor
    {
    }
}