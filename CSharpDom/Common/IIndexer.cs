namespace CSharpDom.Common
{
    public interface IIndexer<TDeclaringType> : IHasDeclaringType<TDeclaringType>
    {
        bool HasGet { get; }

        bool HasSet { get; }
    }
}
