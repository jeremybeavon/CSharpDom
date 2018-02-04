namespace CSharpDom.Common.Editable
{
    public interface IEditableArrayTypeReference<TTypeReference> :
        IEditableArrayTypeReference,
        IArrayTypeReference<TTypeReference>
        where TTypeReference : IEditableTypeReference
    {
        new int Dimensions { get; set; }

        new TTypeReference ElementType { get; set; }
    }
}