namespace CSharpDom.Common.Editable
{
    public interface IEditableStructReference<TTypeReference> :
        IEditableStructReference,
        IEditableTypeReference,
        IHasEditableName,
        IHasEditableGenericParameters<TTypeReference>,
        IStructReference<TTypeReference>
        where TTypeReference : IEditableTypeReference
    {
    }
}