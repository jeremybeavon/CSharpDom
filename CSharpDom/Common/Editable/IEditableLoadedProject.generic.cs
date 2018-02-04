namespace CSharpDom.Common.Editable
{
    public interface IEditableLoadedProject<TSolution, TProject, TNamespace, TClassCollection, TDelegate, TEnum, TInterface, TStructCollection> :
        IEditableLoadedProject,
        IHasEditableSolution<TSolution>,
        IHasEditableProject<TProject>,
        IHasEditableNamespaces<TNamespace>,
        IHasEditableClassCollection<TClassCollection>,
        IHasEditableDelegates<TDelegate>,
        IHasEditableEnums<TEnum>,
        IHasEditableInterfaces<TInterface>,
        IHasEditableStructCollection<TStructCollection>,
        ILoadedProject<TSolution, TProject, TNamespace, TClassCollection, TDelegate, TEnum, TInterface, TStructCollection>
        where TSolution : IEditableSolution
        where TProject : IEditableProject
        where TNamespace : IEditableNamespace
        where TClassCollection : IEditableClassCollection
        where TDelegate : IEditableDelegate
        where TEnum : IEditableEnum
        where TInterface : IEditableInterface
        where TStructCollection : IEditableStructCollection
    {
    }
}