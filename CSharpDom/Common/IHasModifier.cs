namespace CSharpDom.Common
{
    public interface IHasModifier<TModifier>
    {
        TModifier Modifier { get; }
    }
}
