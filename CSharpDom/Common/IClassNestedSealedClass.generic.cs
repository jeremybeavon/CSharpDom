namespace CSharpDom.Common
{
    public interface IClassNestedSealedClass<
        TAttributeGroup,
        TDeclaringType,
        TGenericParameter,
        TClassReference,
        TInterfaceReference,
        TEventCollection,
        TPropertyCollection,
        TIndexerCollection,
        TMethodCollection,
        TFieldCollection,
        TConstructor,
        TOperatorOverload,
        TConversionOperator,
        TNestedClassCollection,
        TNestedDelegate,
        TNestedEnum,
        TNestedInterfaceCollection,
        TNestedStructCollection,
        TNestedDestructor,
        TStaticConstructor> :
        IClassNestedSealedClass,
        INestedSealedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TNestedDestructor, TStaticConstructor>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IType
        where TGenericParameter : IGenericParameterDeclaration
        where TClassReference : IClassReference
        where TInterfaceReference : IInterfaceReference
        where TEventCollection : ISealedClassEventCollection
        where TPropertyCollection : ISealedClassPropertyCollection
        where TIndexerCollection : ISealedClassIndexerCollection
        where TMethodCollection : ISealedClassMethodCollection
        where TFieldCollection : ISealedClassFieldCollection
        where TConstructor : ISealedClassConstructor
        where TOperatorOverload : IOperatorOverload
        where TConversionOperator : IConversionOperator
        where TNestedClassCollection : ISealedClassNestedClassCollection
        where TNestedDelegate : ISealedClassNestedDelegate
        where TNestedEnum : ISealedClassNestedEnum
        where TNestedInterfaceCollection : ISealedClassNestedInterfaceCollection
        where TNestedStructCollection : ISealedClassNestedStructCollection
        where TNestedDestructor : INestedDestructor
        where TStaticConstructor : IStaticConstructor
    {
    }
}
