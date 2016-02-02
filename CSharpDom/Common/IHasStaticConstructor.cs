namespace CSharpDom.Common
{
    public interface IHasStaticConstructor<TStaticConstructor>
    {
        TStaticConstructor StaticConstructor { get; }
    }
}
