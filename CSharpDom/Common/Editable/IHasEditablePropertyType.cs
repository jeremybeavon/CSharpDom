namespace CSharpDom.Common.Editable
{
    public interface IHasEditablePropertyType<TTypeReference> : IHasPropertyType<TTypeReference>
    {
        new TTypeReference PropertyType { get; set; }
    }
}