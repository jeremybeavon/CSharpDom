namespace CSharpDom.Common
{
    public interface IUnspecifiedTypeReference<TGenericParameter> :
        IUnspecifiedTypeReference,
        ITypeReference,
        IHasName,
        IHasGenericParameters<TGenericParameter>
        where TGenericParameter : IGenericParameter
    {
    }
}
