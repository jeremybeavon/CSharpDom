namespace CSharpDom.Common
{
    public interface IHasCompositeType<TCompositeType>
    {
        TCompositeType CompositeType { get; }
    }
}
