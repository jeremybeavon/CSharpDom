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
        TInterfaceCollection,
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
        IHasInterfaceCollection<TInterfaceCollection>,
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
        where TInterfaceCollection : IInterfaceCollection
        where TStructCollection : IStructCollection
    {
    }
}
