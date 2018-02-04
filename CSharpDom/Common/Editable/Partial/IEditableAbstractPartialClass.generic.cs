using CSharpDom.Common.Partial;

namespace CSharpDom.Common.Editable.Partial
{
    public interface IEditableAbstractPartialClass<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor> :
        IEditablePartialClass,
        IEditableAbstractClass<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>,
        IAbstractPartialClass<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>
        where TNamespace : IEditableNamespace
        where TDocument : IEditableDocument
        where TProject : IEditableProject
        where TSolution : IEditableSolution
        where TAttributeGroup : IEditableAttributeGroup
        where TGenericParameter : IEditableGenericParameterDeclaration
        where TClassReference : IEditableClassReference
        where TInterfaceReference : IEditableInterfaceReference
        where TEventCollection : IEditableAbstractClassEventCollection
        where TPropertyCollection : IEditableAbstractClassPropertyCollection
        where TIndexerCollection : IEditableAbstractClassIndexerCollection
        where TMethodCollection : IEditableAbstractPartialClassMethodCollection
        where TFieldCollection : IEditableClassFieldCollection
        where TConstructor : IEditableClassConstructor
        where TOperatorOverload : IEditableOperatorOverload
        where TConversionOperator : IEditableConversionOperator
        where TNestedClassCollection : IEditableClassNestedClassCollection
        where TNestedDelegate : IEditableClassNestedDelegate
        where TNestedEnum : IEditableClassNestedEnum
        where TNestedInterface : IEditableClassNestedInterface
        where TNestedStructCollection : IEditableClassNestedStructCollection
        where TStaticConstructor : IEditableStaticConstructor
        where TDestructor : IEditableDestructor
    {
    }
}