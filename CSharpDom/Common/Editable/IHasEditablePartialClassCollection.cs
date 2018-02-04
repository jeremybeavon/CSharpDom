namespace CSharpDom.Common.Editable
{
    public interface IHasEditablePartialClassCollection<TPartialClassCollection> :
        IHasPartialClassCollection<TPartialClassCollection>
    {
        new TPartialClassCollection PartialClasses { get; set; }
    }
}