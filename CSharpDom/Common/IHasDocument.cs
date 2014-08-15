namespace CSharpDom.Common
{
    public interface IHasDocument<TDocument>
    {
        TDocument Document { get; }
    }
}
