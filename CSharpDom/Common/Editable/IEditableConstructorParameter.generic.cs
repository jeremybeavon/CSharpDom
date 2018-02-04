namespace CSharpDom.Common.Editable
{
    public interface IEditableConstructorParameter<TAttributeGroup, TTypeReference> :
        IEditableConstructorParameter,
        IEditableParameter<TAttributeGroup, TTypeReference>,
        IHasEditableModifier<ParameterModifier>,
        IConstructorParameter<TAttributeGroup, TTypeReference>
        where TAttributeGroup : IEditableAttributeGroup
        where TTypeReference : IEditableTypeReference
    {
    }
}