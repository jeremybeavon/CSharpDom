namespace CSharpDom.Common.Editable
{
    public interface IEditableStaticType<TAttributeGroup, TGenericParameter, TEventCollection, TPropertyCollection, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor> :
        IEditableStaticType,
        IHasEditableName,
        IHasEditableAttributes<TAttributeGroup>,
        IHasEditableGenericParameters<TGenericParameter>,
        IHasEditableEventCollection<TEventCollection>,
        IHasEditablePropertyCollection<TPropertyCollection>,
        IHasEditableMethodCollection<TMethodCollection>,
        IHasEditableFieldCollection<TFieldCollection>,
        IHasEditableClassCollection<TNestedClassCollection>,
        IHasEditableDelegates<TNestedDelegate>,
        IHasEditableEnums<TNestedEnum>,
        IHasEditableInterfaces<TNestedInterface>,
        IHasEditableStructCollection<TNestedStructCollection>,
        IHasEditableStaticConstructor<TStaticConstructor>,
        IStaticType<TAttributeGroup, TGenericParameter, TEventCollection, TPropertyCollection, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>
        where TAttributeGroup : IEditableAttributeGroup
        where TGenericParameter : IEditableGenericParameterDeclaration
        where TEventCollection : IEditableStaticClassEventCollection
        where TPropertyCollection : IEditableStaticClassPropertyCollection
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