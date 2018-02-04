namespace CSharpDom.Common.Editable
{
    public interface IEditableExplicitInterfaceIndexer<TAttributeGroup, TDeclaringType, TInterfaceReference, TTypeReference, TParameter, TAccessor> :
        IEditableExplicitInterfaceIndexer,
        IEditableIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor>,
        IHasEditableExplicitInterface<TInterfaceReference>,
        IExplicitInterfaceIndexer<TAttributeGroup, TDeclaringType, TInterfaceReference, TTypeReference, TParameter, TAccessor>
        where TAttributeGroup : IEditableAttributeGroup
        where TDeclaringType : IEditableType
        where TInterfaceReference : IEditableInterfaceReference
        where TTypeReference : IEditableTypeReference
        where TParameter : IEditableIndexerParameter
        where TAccessor : IEditableAccessor
    {
    }
}