namespace CSharpDom.Common
{
    public interface IHasSymbols<TSymbols>
    {
        TSymbols Symbols { get; }
    }
}
