namespace CSharpDom.Common
{
    public interface IStructReference<TTypeReference> : 
        IStructReference,
        ITypeReference,
        IHasName,
        IHasGenericParameters<TTypeReference>
        where TTypeReference : ITypeReference
    {
    }
}
