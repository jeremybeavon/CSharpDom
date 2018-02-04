using CSharpDom.Common.Partial;

namespace CSharpDom.Common.Editable.Partial
{
    public interface IEditablePartialStruct<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor> :
        IEditablePartialStruct,
        IEditableStruct<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>,
        IPartialStruct<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>
        where TNamespace : IEditableNamespace
        where TDocument : IEditableDocument
        where TProject : IEditableProject
        where TSolution : IEditableSolution
        where TAttributeGroup : IEditableAttributeGroup
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