namespace CSharpDom.Common
{
    public interface IHasReflection<TReflection>
    {
        TReflection Reflection { get; }
    }
}
