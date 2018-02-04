namespace CSharpDom.Common.Editable
{
    public interface IEditableUnspecifiedTypeReference<TTypeReference> :
        IEditableUnspecifiedTypeReference,
        IEditableTypeReference,
        IHasEditableName,
        IHasEditableGenericParameters<TTypeReference>,
        IUnspecifiedTypeReference<TTypeReference>
        where TTypeReference : IEditableTypeReference
    {
    }
}