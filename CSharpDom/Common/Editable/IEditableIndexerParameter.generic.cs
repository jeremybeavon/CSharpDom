namespace CSharpDom.Common.Editable
{
    public interface IEditableIndexerParameter<TAttributeGroup, TTypeReference> :
        IEditableIndexerParameter,
        IEditableParameter<TAttributeGroup, TTypeReference>,
        IHasEditableModifier<IndexerParameterModifier>,
        IIndexerParameter<TAttributeGroup, TTypeReference>
        where TAttributeGroup : IEditableAttributeGroup
        where TTypeReference : IEditableTypeReference
    {
    }
}