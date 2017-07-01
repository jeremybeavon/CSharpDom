namespace CSharpDom.Common
{
    public interface ILoadedDocument<
        TSolution, 
        TProject,
        TDocument,
        TUsingDirective,
        TAttributeGroup,
        TNamespace,
        TClassCollection,
        TDelegate,
        TEnum,
        TInterface,
        TStructCollection> :
        ILoadedDocument,
        IHasSolution<TSolution>,
        IHasProject<TProject>,
        IHasDocument<TDocument>,
        IHasUsingDirectives<TUsingDirective>,
        IHasAssemblyAttributes<TAttributeGroup>,
        IHasModuleAttributes<TAttributeGroup>,
        IHasNamespaces<TNamespace>,
        IHasClassCollection<TClassCollection>,
        IHasDelegates<TDelegate>,
        IHasEnums<TEnum>,
        IHasInterfaces<TInterface>,
        IHasStructCollection<TStructCollection>
        where TSolution : ISolution
        where TProject : IProject
        where TDocument : IDocument
        where TUsingDirective : IUsingDirective
        where TAttributeGroup : IAttributeGroup
        where TNamespace : INamespace
        where TClassCollection : IClassCollection
        where TDelegate : IDelegate
        where TEnum : IEnum
        where TInterface : IInterface
        where TStructCollection : IStructCollection
    {
    }
}
