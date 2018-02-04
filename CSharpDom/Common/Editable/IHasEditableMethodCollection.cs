namespace CSharpDom.Common.Editable
{
    public interface IHasEditableMethodCollection<TMethodCollection> : IHasMethodCollection<TMethodCollection>
    {
        new TMethodCollection Methods { get; set; }
    }
}