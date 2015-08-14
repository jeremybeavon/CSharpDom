namespace CSharpDom
{
    public interface IWrapper<T>
    {
        T ObjectToWrap { get; }
    }
}
