namespace CSharpDom.Common
{
    public interface IHasReturnType<TTypeReference>
    {
        TTypeReference ReturnType { get; }
    }
}
