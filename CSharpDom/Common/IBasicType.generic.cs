namespace CSharpDom.Common
{
    public interface IBasicType<TEvent, TProperty, TIndexer, TMethod> :
        IBasicType,
        IHasEvents<TEvent>,
        IHasProperties<TProperty>,
        IHasIndexers<TIndexer>,
        IHasMethods<TMethod>
    {
    }
}
