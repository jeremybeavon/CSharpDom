namespace CSharpDom.Common.Editable
{
    public interface IHasEditableEventCollection<TEventCollection> : IHasEventCollection<TEventCollection>
    {
        new TEventCollection Events { get; set; }
    }
}