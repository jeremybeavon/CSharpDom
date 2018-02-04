namespace CSharpDom.Common.Editable
{
    public interface IEditableDelegateParameter<TAttributeGroup, TTypeReference> :
        IEditableDelegateParameter,
        IEditableParameter<TAttributeGroup, TTypeReference>,
        IHasEditableModifier<ParameterModifier>,
        IDelegateParameter<TAttributeGroup, TTypeReference>
        where TAttributeGroup : IEditableAttributeGroup
        where TTypeReference : IEditableTypeReference
    {
    }
}