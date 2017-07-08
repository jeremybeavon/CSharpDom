namespace CSharpDom.Common
{
    public interface IHasParameterType<TTypeReference>
    {
        TTypeReference ParameterType { get; }
    }
}
