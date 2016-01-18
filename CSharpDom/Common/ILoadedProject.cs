namespace CSharpDom.Common
{
    public interface ILoadedProject<TSolution, TProject, TNamespace, TClass, TDelegate, TEnum, TInterface, TStruct> :
        IHasSolution<TSolution>,
        IHasProject<TProject>,
        IHasNamespaces<TNamespace>,
        IHasClasses<TClass>,
        IHasDelegates<TDelegate>,
        IHasEnums<TEnum>,
        IHasInterfaces<TInterface>,
        IHasStructs<TStruct>
    {
    }
}
