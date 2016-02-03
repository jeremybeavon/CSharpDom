namespace CSharpDom.Common
{
    public interface INullableTypeReference<TStructReference> : INullableTypeReference
        where TStructReference : IStructReference
    {
        TStructReference Type { get; }
    }
}
