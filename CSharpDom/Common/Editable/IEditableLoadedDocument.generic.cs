namespace CSharpDom.Common.Editable
{
    public interface IEditableLoadedDocument<TSolution, TProject, TDocument, TUsingDirective, TAttributeGroup, TNamespace, TClassCollection, TDelegate, TEnum, TInterface, TStructCollection> :
        IEditableLoadedDocument,
        IHasEditableSolution<TSolution>,
        IHasEditableProject<TProject>,
        IHasEditableDocument<TDocument>,
        IHasEditableUsingDirectives<TUsingDirective>,
        IHasEditableAssemblyAttributes<TAttributeGroup>,
        IHasEditableModuleAttributes<TAttributeGroup>,
        IHasEditableNamespaces<TNamespace>,
        IHasEditableClassCollection<TClassCollection>,
        IHasEditableDelegates<TDelegate>,
        IHasEditableEnums<TEnum>,
        IHasEditableInterfaces<TInterface>,
        IHasEditableStructCollection<TStructCollection>,
        ILoadedDocument<TSolution, TProject, TDocument, TUsingDirective, TAttributeGroup, TNamespace, TClassCollection, TDelegate, TEnum, TInterface, TStructCollection>
        where TSolution : IEditableSolution
        where TProject : IEditableProject
        where TDocument : IEditableDocument
        where TUsingDirective : IEditableUsingDirective
        where TAttributeGroup : IEditableAttributeGroup
        where TNamespace : IEditableNamespace
        where TClassCollection : IEditableClassCollection
        where TDelegate : IEditableDelegate
        where TEnum : IEditableEnum
        where TInterface : IEditableInterface
        where TStructCollection : IEditableStructCollection
    {
    }
}