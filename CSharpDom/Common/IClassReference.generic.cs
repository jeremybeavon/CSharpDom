namespace CSharpDom.Common
{
    public interface IClassReference<TTypeReference> : 
        IClassReference,
        ITypeReference,
        IHasName,
        IHasGenericParameters<TTypeReference>
        where TTypeReference : ITypeReference
    {
    }
}
