namespace CSharpDom.Common
{
    public interface ILoadedProject<
        TSolution,
        TProject,
        TNamespace,
        TClassCollection,
        TDelegate, 
        TEnum,
        TInterfaceCollection,
        TStructCollection> :
        ILoadedProject,
        IHasSolution<TSolution>,
        IHasProject<TProject>,
        IHasNamespaces<TNamespace>,
        IHasClassCollection<TClassCollection>,
        IHasDelegates<TDelegate>,
        IHasEnums<TEnum>,
        IHasInterfaceCollection<TInterfaceCollection>,
        IHasStructCollection<TStructCollection>
        where TSolution : ISolution
        where TProject : IProject
        where TNamespace : INamespace
        where TClassCollection : IClassCollection
        where TDelegate : IDelegate
        where TEnum : IEnum
        where TInterfaceCollection : IInterfaceCollection
        where TStructCollection : IStructCollection
    {
    }
}
