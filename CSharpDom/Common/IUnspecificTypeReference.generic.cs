namespace CSharpDom.Common
{
    public interface IUnspecificTypeReference<TGenericParameter> :
        IUnspecificTypeReference,
        ITypeReference,
        IHasName,
        IHasGenericParameters<TGenericParameter>
        where TGenericParameter : IGenericParameter
    {
    }
}
