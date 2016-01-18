namespace CSharpDom.Common
{
    public interface ILoadedDocument<TSolution, TProject, TDocument, TNamespace, TClass, TDelegate, TEnum, TInterface, TStruct> :
        IHasSolution<TSolution>,
        IHasProject<TProject>,
        IHasDocument<TDocument>,
        IHasNamespaces<TNamespace>,
        IHasClasses<TClass>,
        IHasDelegates<TDelegate>,
        IHasEnums<TEnum>,
        IHasInterfaces<TInterface>,
        IHasStructs<TStruct>
    {
    }
}
