namespace CSharpDom.Common
{
    public interface IInterfaceReference<TTypeReference> :
        IInterfaceReference,
        ITypeReference,
        IHasName,
        IHasGenericParameters<TTypeReference>
        where TTypeReference : ITypeReference
    {
    }
}
