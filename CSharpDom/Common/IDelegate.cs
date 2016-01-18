namespace CSharpDom.Common
{
    public interface IDelegate<TNamespace, TProject, TSolution> :
        IHasName,
        ICanBeGeneric,
        IHasNamespace<TNamespace>,
        IHasProject<TProject>,
        IHasSolution<TSolution>
    {
    }
}
