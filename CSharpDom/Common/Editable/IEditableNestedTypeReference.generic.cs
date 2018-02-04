namespace CSharpDom.Common.Editable
{
    public interface IEditableNestedTypeReference<TTypeReference> :
        IEditableNestedTypeReference,
        IEditableTypeReference,
        INestedTypeReference<TTypeReference>
        where TTypeReference : IEditableTypeReference
    {
        new TTypeReference Type { get; set; }

        new TTypeReference NestedType { get; set; }
    }
}