namespace CSharpDom.Common
{
    public interface IDelegateReference<TTypeReference> :
        IDelegateReference,
        ITypeReference,
        IHasName,
        IHasGenericParameters<TTypeReference>
        where TTypeReference : ITypeReference
    {
    }
}
