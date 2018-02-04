namespace CSharpDom.Common.Editable
{
    public interface IEditableSealedClassIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor> :
        IEditableSealedClassIndexer,
        IEditableIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor>,
        IHasEditableSealedClassIndexerInheritanceModifier,
        ISealedClassIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor>
        where TAttributeGroup : IEditableAttributeGroup
        where TDeclaringType : IEditableSealedType
        where TTypeReference : IEditableTypeReference
        where TParameter : IEditableIndexerParameter
        where TAccessor : IEditableClassAccessor
    {
    }
}