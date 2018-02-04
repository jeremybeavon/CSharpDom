namespace CSharpDom.Common.Editable
{
    public interface IHasEditableIndexerCollection<TIndexerCollection> : IHasIndexerCollection<TIndexerCollection>
    {
        new TIndexerCollection Indexers { get; set; }
    }
}