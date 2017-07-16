namespace CSharpDom.Common
{
    public interface IUnspecifiedTypeReference<TTypeReference> :
        IUnspecifiedTypeReference,
        ITypeReference,
        IHasName,
        IHasGenericParameters<TTypeReference>
        where TTypeReference : ITypeReference
    {
    }
}
