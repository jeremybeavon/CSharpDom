namespace CSharpDom.Common.Editable
{
    public interface IEditableStructNestedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor> :
        IEditableStructNestedClass,
        IEditableNestedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>,
        IStructNestedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>
        where TAttributeGroup : IEditableAttributeGroup
        where TDeclaringType : IEditableStructType
        where TGenericParameter : IEditableGenericParameterDeclaration
        where TClassReference : IEditableClassReference
        where TInterfaceReference : IEditableInterfaceReference
        where TEventCollection : IEditableClassEventCollection
        where TPropertyCollection : IEditableClassPropertyCollection
        where TIndexerCollection : IEditableClassIndexerCollection
        where TMethodCollection : IEditableClassMethodCollection
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