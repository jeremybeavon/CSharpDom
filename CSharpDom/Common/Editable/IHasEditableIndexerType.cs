namespace CSharpDom.Common.Editable
{
    public interface IHasEditableIndexerType<TTypeReference> : IHasIndexerType<TTypeReference>
    {
        new TTypeReference IndexerType { get; set; }
    }
}