namespace CSharpDom.Common
{
    public interface ILoadedProject<TSolution, TProject, TNamespace, TClass, TDelegate, TEnum, TInterface, TStruct> :
        ILoadedProject,
        IHasSolution<TSolution>,
        IHasProject<TProject>,
        IHasNamespaces<TNamespace>,
        IHasClasses<TClass>,
        IHasDelegates<TDelegate>,
        IHasEnums<TEnum>,
        IHasInterfaces<TInterface>,
        IHasStructs<TStruct>
        where TSolution : ISolution
        where TProject : IProject
        where TNamespace : INamespace
        where TClass : IClass
        where TDelegate : IDelegate
        where TEnum : IEnum
        where TInterface : IInterface
        where TStruct : IStruct
    {
    }
}
