namespace CSharpDom.Common
{
    public interface IHasIndexerType<TTypeReference>
    {
        TTypeReference IndexerType { get; }
    }
}
