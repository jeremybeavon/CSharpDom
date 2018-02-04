namespace CSharpDom.Common.Editable
{
    public interface IHasEditableIndexerInheritanceModifier : IHasIndexerInheritanceModifier
    {
        new IndexerInheritanceModifier InheritanceModifier { get; set; }
    }
}