namespace CSharpDom.Common.Editable
{
    public interface IEditableInterfaceReference<TTypeReference> :
        IEditableInterfaceReference,
        IEditableTypeReference,
        IHasEditableName,
        IHasEditableGenericParameters<TTypeReference>,
        IInterfaceReference<TTypeReference>
        where TTypeReference : IEditableTypeReference
    {
    }
}