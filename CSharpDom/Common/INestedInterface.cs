namespace CSharpDom.Common
{
    public interface INestedInterface<TDeclaringType, TEvent, TProperty, TIndexer, TMethod> :
        IHasName,
        ICanBeGeneric,
        IBasicType<TEvent, TProperty, TIndexer, TMethod>,
        IHasDeclaringType<TDeclaringType>
    {
    }
}
