namespace CSharpDom.Common.Editable
{
    public interface IEditableType<TAttributeGroup, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor> :
        IEditableType,
        IHasEditableName,
        IHasEditableAttributes<TAttributeGroup>,
        IHasEditableGenericParameters<TGenericParameter>,
        IHasEditableImplementedInterfaces<TInterfaceReference>,
        IHasEditableEventCollection<TEventCollection>,
        IHasEditablePropertyCollection<TPropertyCollection>,
        IHasEditableIndexerCollection<TIndexerCollection>,
        IHasEditableMethodCollection<TMethodCollection>,
        IHasEditableFieldCollection<TFieldCollection>,
        IHasEditableConstructors<TConstructor>,
        IHasEditableOperatorOverloads<TOperatorOverload>,
        IHasEditableConversionOperators<TConversionOperator>,
        IHasEditableClassCollection<TNestedClassCollection>,
        IHasEditableDelegates<TNestedDelegate>,
        IHasEditableEnums<TNestedEnum>,
        IHasEditableInterfaces<TNestedInterface>,
        IHasEditableStructCollection<TNestedStructCollection>,
        IHasEditableStaticConstructor<TStaticConstructor>,
        IType<TAttributeGroup, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>
        where TAttributeGroup : IEditableAttributeGroup
        where TGenericParameter : IEditableGenericParameterDeclaration
        where TInterfaceReference : IEditableInterfaceReference
        where TEventCollection : IEditableEventCollection
        where TPropertyCollection : IEditablePropertyCollection
        where TIndexerCollection : IEditableIndexerCollection
        where TMethodCollection : IEditableMethodCollection
        where TFieldCollection : IEditableFieldCollection
        where TConstructor : IEditableConstructor
        where TOperatorOverload : IEditableOperatorOverload
        where TConversionOperator : IEditableConversionOperator
        where TNestedClassCollection : IEditableNestedClassCollection
        where TNestedDelegate : IEditableNestedDelegate
        where TNestedEnum : IEditableNestedEnum
        where TNestedInterface : IEditableNestedInterface
        where TNestedStructCollection : IEditableNestedStructCollection
        where TStaticConstructor : IEditableStaticConstructor
    {
    }
}