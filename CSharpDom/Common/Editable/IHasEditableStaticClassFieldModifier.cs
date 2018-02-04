namespace CSharpDom.Common.Editable
{
    public interface IHasEditableStaticClassFieldModifier : IHasStaticClassFieldModifier
    {
        new StaticClassFieldModifier Modifier { get; set; }
    }
}