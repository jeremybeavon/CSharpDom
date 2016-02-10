namespace CSharpDom.Common
{
    public interface IHasEventCollection<TEventCollection>
    {
        TEventCollection Events { get; }
    }
}
