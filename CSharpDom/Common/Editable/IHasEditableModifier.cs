namespace CSharpDom.Common.Editable
{
    public interface IHasEditableModifier<TModifier> : IHasModifier<TModifier>
    {
        new TModifier Modifier { get; set; }
    }
}