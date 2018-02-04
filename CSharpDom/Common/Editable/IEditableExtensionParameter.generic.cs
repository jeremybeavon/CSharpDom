namespace CSharpDom.Common.Editable
{
    public interface IEditableExtensionParameter<TAttributeGroup, TTypeReference> :
        IEditableExtensionParameter,
        IEditableParameter<TAttributeGroup, TTypeReference>,
        IExtensionParameter<TAttributeGroup, TTypeReference>
        where TAttributeGroup : IEditableAttributeGroup
        where TTypeReference : IEditableTypeReference
    {
    }
}