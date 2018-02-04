namespace CSharpDom.Common.Editable
{
    public interface IHasEditableStructMethodInheritanceModifier : IHasStructMethodInheritanceModifier
    {
        new StructMethodInheritanceModifier InheritanceModifier { get; set; }
    }
}