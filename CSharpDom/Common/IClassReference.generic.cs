namespace CSharpDom.Common
{
    public interface IClassReference<TGenericParameter> : 
        IClassReference,
        ITypeReference,
        IHasName,
        IHasGenericParameters<TGenericParameter>
        where TGenericParameter : IGenericParameter
    {
    }
}
