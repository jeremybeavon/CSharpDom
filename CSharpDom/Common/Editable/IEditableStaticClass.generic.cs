namespace CSharpDom.Common.Editable
{
    public interface IEditableStaticClass<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TEventCollection, TProperty, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor> :
        IEditableStaticClass,
        IHasEditableTypeVisibilityModifier,
        IHasEditableNamespace<TNamespace>,
        IHasEditableDocument<TDocument>,
        IHasEditableProject<TProject>,
        IHasEditableSolution<TSolution>,
        IEditableStaticType<TAttributeGroup, TGenericParameter, TEventCollection, TProperty, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>,
        IStaticClass<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TEventCollection, TProperty, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>
        where TNamespace : IEditableNamespace
        where TDocument : IEditableDocument
        where TProject : IEditableProject
        where TSolution : IEditableSolution
        where TAttributeGroup : IEditableAttributeGroup
        where TGenericParameter : IEditableGenericParameterDeclaration
        where TEventCollection : IEditableStaticClassEventCollection
        where TProperty : IEditableStaticClassProperty
        where TMethodCollection : IEditableStaticClassMethodCollection
        where TFieldCollection : IEditableStaticClassFieldCollection
        where TNestedClassCollection : IEditableStaticClassNestedClassCollection
        where TNestedDelegate : IEditableStaticClassNestedDelegate
        where TNestedEnum : IEditableStaticClassNestedEnum
        where TNestedInterface : IEditableStaticClassNestedInterface
        where TNestedStructCollection : IEditableStaticClassNestedStructCollection
        where TStaticConstructor : IEditableStaticConstructor
    {
    }
}