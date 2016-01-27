namespace CSharpDom.Common
{
    public interface IStructReference<TGenericParameter> : 
        IStructReference,
        ITypeReference,
        IHasName,
        IHasGenericParameters<TGenericParameter>
        where TGenericParameter : IGenericParameter
    {
    }
}
