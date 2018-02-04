namespace CSharpDom.Common.Editable
{
    public interface IEditableStructNestedStruct<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor> :
        IEditableStructNestedStruct,
        IEditableNestedStruct<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>,
        IStructNestedStruct<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>
        where TAttributeGroup : IEditableAttributeGroup
        where TDeclaringType : IEditableStructType
        where TGenericParameter : IEditableGenericParameterDeclaration
        where TInterfaceReference : IEditableInterfaceReference
        where TEventCollection : IEditableStructEventCollection
        where TPropertyCollection : IEditableStructPropertyCollection
        where TIndexerCollection : IEditableStructIndexerCollection
        where TMethodCollection : IEditableStructMethodCollection
        where TFieldCollection : IEditableStructFieldCollection
        where TConstructor : IEditableStructConstructor
        where TOperatorOverload : IEditableOperatorOverload
        where TConversionOperator : IEditableConversionOperator
        where TNestedClassCollection : IEditableStructNestedClassCollection
        where TNestedDelegate : IEditableStructNestedDelegate
        where TNestedEnum : IEditableStructNestedEnum
        where TNestedInterface : IEditableStructNestedInterface
        where TNestedStructCollection : IEditableStructNestedStructCollection
        where TStaticConstructor : IEditableStaticConstructor
    {
    }
}