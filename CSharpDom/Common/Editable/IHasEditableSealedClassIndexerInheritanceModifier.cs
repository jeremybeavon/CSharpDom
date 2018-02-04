namespace CSharpDom.Common.Editable
{
    public interface IHasEditableSealedClassIndexerInheritanceModifier : IHasSealedClassIndexerInheritanceModifier
    {
        new SealedClassIndexerInheritanceModifier InheritanceModifier { get; set; }
    }
}