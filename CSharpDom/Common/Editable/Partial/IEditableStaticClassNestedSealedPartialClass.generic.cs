using CSharpDom.Common.Partial;

namespace CSharpDom.Common.Editable.Partial
{
    public interface IEditableStaticClassNestedSealedPartialClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor> :
        IEditableStaticClassNestedSealedPartialClass,
        IEditableStaticClassNestedSealedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>,
        IStaticClassNestedSealedPartialClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>
        where TAttributeGroup : IEditableAttributeGroup
        where TDeclaringType : IEditableStaticType
        where TGenericParameter : IEditableGenericParameterDeclaration
        where TClassReference : IEditableClassReference
        where TInterfaceReference : IEditableInterfaceReference
        where TEventCollection : IEditableSealedClassEventCollection
        where TPropertyCollection : IEditableSealedClassPropertyCollection
        where TIndexerCollection : IEditableSealedClassIndexerCollection
        where TMethodCollection : IEditableSealedPartialClassMethodCollection
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