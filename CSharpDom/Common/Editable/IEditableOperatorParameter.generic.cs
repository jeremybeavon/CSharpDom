namespace CSharpDom.Common.Editable
{
    public interface IEditableOperatorParameter<TAttributeGroup, TTypeReference> :
        IEditableOperatorParameter,
        IEditableParameter<TAttributeGroup, TTypeReference>,
        IOperatorParameter<TAttributeGroup, TTypeReference>
        where TAttributeGroup : IEditableAttributeGroup
        where TTypeReference : IEditableTypeReference
    {
    }
}