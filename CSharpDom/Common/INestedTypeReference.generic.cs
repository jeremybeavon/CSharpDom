namespace CSharpDom.Common
{
    public interface INestedTypeReference<TTypeReference> : INestedTypeReference, ITypeReference
        where TTypeReference : ITypeReference
    {
        TTypeReference Type { get; }

        TTypeReference NestedType { get; }
    }
}
