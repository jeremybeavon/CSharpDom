namespace CSharpDom.Common.Editable
{
    public interface IHasEditableDocument<TDocument> : IHasDocument<TDocument>
    {
        new TDocument Document { get; set; }
    }
}