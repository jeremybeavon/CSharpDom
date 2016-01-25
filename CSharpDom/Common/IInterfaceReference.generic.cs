namespace CSharpDom.Common
{
    public interface IInterfaceReference<TGenericParameter> :
        IInterfaceReference,
        ITypeReference,
        IHasName,
        IHasGenericParameters<TGenericParameter>
        where TGenericParameter : IGenericParameter
    {
    }
}
