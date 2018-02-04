using CSharpDom.Common.Partial;

namespace CSharpDom.Common.Editable.Partial
{
    public interface IEditableStaticClassNestedPartialStruct<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor> :
        IEditableStaticClassNestedPartialStruct,
        IEditableStaticClassNestedStruct<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>,
        IStaticClassNestedPartialStruct<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>
        where TAttributeGroup : IEditableAttributeGroup
        where TDeclaringType : IEditableStaticType
        where TGenericParameter : IEditableGenericParameterDeclaration
        where TInterfaceReference : IEditableInterfaceReference
        where TEventCollection : IEditableStructEventCollection
        where TPropertyCollection : IEditableStructPropertyCollection
        where TIndexerCollection : IEditableStructIndexerCollection
        where TMethodCollection : IEditablePartialStructMethodCollection
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