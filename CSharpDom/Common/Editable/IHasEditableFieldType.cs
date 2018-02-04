namespace CSharpDom.Common.Editable
{
    public interface IHasEditableFieldType<TTypeReference> : IHasFieldType<TTypeReference>
    {
        new TTypeReference FieldType { get; set; }
    }
}