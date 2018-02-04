namespace CSharpDom.Common.Editable
{
    public interface IEditableMethodParameter<TAttributeGroup, TTypeReference> :
        IEditableMethodParameter,
        IEditableParameter<TAttributeGroup, TTypeReference>,
        IHasEditableModifier<ParameterModifier>,
        IMethodParameter<TAttributeGroup, TTypeReference>
        where TAttributeGroup : IEditableAttributeGroup
        where TTypeReference : IEditableTypeReference
    {
    }
}