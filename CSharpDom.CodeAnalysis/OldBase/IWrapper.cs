namespace CSharpDom.CodeAnalysis
{
    public interface IWrapper<T>
    {
        T ObjectToWrap { get; }
    }
}
