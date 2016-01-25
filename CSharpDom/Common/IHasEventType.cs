namespace CSharpDom.Common
{
    public interface IHasEventType<TTypeReference>
    {
        TTypeReference EventType { get; }
    }
}
