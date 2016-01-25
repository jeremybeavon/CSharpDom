namespace CSharpDom.Common
{
    public interface IArrayTypeReference<TTypeReference> : IArrayTypeReference
        where TTypeReference : ITypeReference
    {
        int Dimensions { get; }

        TTypeReference ElementType { get; }
    }
}
