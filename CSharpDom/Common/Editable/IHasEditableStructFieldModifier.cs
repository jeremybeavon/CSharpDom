namespace CSharpDom.Common.Editable
{
    public interface IHasEditableStructFieldModifier : IHasStructFieldModifier
    {
        new StructFieldModifier Modifier { get; set; }
    }
}