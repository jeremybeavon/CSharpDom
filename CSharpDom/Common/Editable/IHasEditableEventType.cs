namespace CSharpDom.Common.Editable
{
    public interface IHasEditableEventType<TTypeReference> : IHasEventType<TTypeReference>
    {
        new TTypeReference EventType { get; set; }
    }
}