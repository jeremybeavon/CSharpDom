namespace CSharpDom.Common.Editable
{
    public interface IEditableParameter<TAttributeGroup, TTypeReference> :
        IEditableParameter,
        IHasEditableName,
        IHasEditableAttributes<TAttributeGroup>,
        IHasEditableParameterType<TTypeReference>,
        IParameter<TAttributeGroup, TTypeReference>
        where TAttributeGroup : IEditableAttributeGroup
        where TTypeReference : IEditableTypeReference
    {
    }
}