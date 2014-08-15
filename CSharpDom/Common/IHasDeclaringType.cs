namespace CSharpDom.Common
{
    public interface IHasDeclaringType<TDeclaringType>
    {
        TDeclaringType DeclaringType { get; }
    }
}
