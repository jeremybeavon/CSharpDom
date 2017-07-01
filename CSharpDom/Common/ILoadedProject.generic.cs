namespace CSharpDom.Common
{
    public interface ILoadedProject<
        TSolution,
        TProject,
        TNamespace,
        TClassCollection,
        TDelegate, 
        TEnum,
        TInterface,
        TStructCollection> :
        ILoadedProject,
        IHasSolution<TSolution>,
        IHasProject<TProject>,
        IHasNamespaces<TNamespace>,
        IHasClassCollection<TClassCollection>,
        IHasDelegates<TDelegate>,
        IHasEnums<TEnum>,
        IHasInterfaces<TInterface>,
        IHasStructCollection<TStructCollection>
        where TSolution : ISolution
        where TProject : IProject
        where TNamespace : INamespace
        where TClassCollection : IClassCollection
        where TDelegate : IDelegate
        where TEnum : IEnum
        where TInterface : IInterface
        where TStructCollection : IStructCollection
    {
    }
}
