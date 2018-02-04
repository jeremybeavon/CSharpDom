namespace CSharpDom.Common.Editable
{
    public interface IHasEditableClassFieldModifier : IHasClassFieldModifier
    {
        new ClassFieldModifier Modifier { get; set; }
    }
}