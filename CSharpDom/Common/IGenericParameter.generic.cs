namespace CSharpDom.Common
{
    public interface IGenericParameter<TTypeReference> : IGenericParameter
        where TTypeReference : ITypeReference
    {
        TTypeReference Type { get; }
    }
}
