namespace CSharpDom.Common
{
    public interface ILoadedDocument<
        TSolution, 
        TProject,
        TDocument,
        TUsingDirective,
        TAttributeGroup,
        TNamespace,
        TClass,
        TDelegate,
        TEnum,
        TInterface,
        TStruct> :
        ILoadedDocument,
        IHasSolution<TSolution>,
        IHasProject<TProject>,
        IHasDocument<TDocument>,
        IHasUsingDirectives<TUsingDirective>,
        IHasAssemblyAttributes<TAttributeGroup>,
        IHasModuleAttributes<TAttributeGroup>,
        IHasNamespaces<TNamespace>,
        IHasClasses<TClass>,
        IHasDelegates<TDelegate>,
        IHasEnums<TEnum>,
        IHasInterfaces<TInterface>,
        IHasStructs<TStruct>
        where TSolution : ISolution
        where TProject : IProject
        where TDocument : IDocument
        where TUsingDirective : IUsingDirective
        where TAttributeGroup : IAttributeGroup
        where TNamespace : INamespace
        where TClass : IClass
        where TDelegate : IDelegate
        where TEnum : IEnum
        where TInterface : IInterface
        where TStruct : IStruct
    {
    }
}
