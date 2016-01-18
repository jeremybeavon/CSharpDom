namespace CSharpDom.Common
{
    public interface IInterface<TNamespace, TProject, TSolution, TEvent, TProperty, TIndexer, TMethod> :
        IHasName,
        ICanBeGeneric,
        IBasicType<TEvent, TProperty, TIndexer, TMethod>,
        IHasNamespace<TNamespace>,
        IHasProject<TProject>,
        IHasSolution<TSolution>
    {
    }
}
