namespace CSharpDom.Common
{
    public interface IHasAccessors<TAccessor>
    {
        TAccessor GetAccessor { get; }

        TAccessor SetAccessor { get; }
    }
}
