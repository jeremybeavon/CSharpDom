namespace CSharpDom.Common
{
    public interface IDelegateReference<TGenericParameter> :
        IDelegateReference,
        ITypeReference,
        IHasName,
        IHasGenericParameters<TGenericParameter>
        where TGenericParameter : IGenericParameter
    {
    }
}
