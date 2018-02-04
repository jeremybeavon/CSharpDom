namespace CSharpDom.Common.Editable
{
    public interface IHasEditableFieldCollection<TFieldCollection> : IHasFieldCollection<TFieldCollection>
    {
        new TFieldCollection Fields { get; set; }
    }
}