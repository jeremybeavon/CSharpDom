namespace CSharpDom.Common
{
    public interface IHasSymbol<TSymbol>
    {
        TSymbol Symbol { get; }
    }
}
