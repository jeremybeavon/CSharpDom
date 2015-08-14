namespace CSharpDom.Common
{
    public interface IHasDeclaration<TDeclaration> : IHasLocation
    {
        TDeclaration Declaration { get; }
    }
}
