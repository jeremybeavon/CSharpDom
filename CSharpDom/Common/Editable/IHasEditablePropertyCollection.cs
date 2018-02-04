namespace CSharpDom.Common.Editable
{
    public interface IHasEditablePropertyCollection<TPropertyCollection> : IHasPropertyCollection<TPropertyCollection>
    {
        new TPropertyCollection Properties { get; set; }
    }
}