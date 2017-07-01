namespace CSharpDom.Common
{
    public interface IStaticClassNestedAbstractClass<
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
        TNestedInterface,
        TNestedStructCollection,
        TNestedDestructor,
        TStaticConstructor> :
        IStaticClassNestedAbstractClass,
        INestedAbstractClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TNestedDestructor, TStaticConstructor>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IStaticType
        where TGenericParameter : IGenericParameterDeclaration
        where TClassReference : IClassReference
        where TInterfaceReference : IInterfaceReference
        where TEventCollection : IAbstractClassEventCollection
        where TPropertyCollection : IAbstractClassPropertyCollection
        where TIndexerCollection : IAbstractClassIndexerCollection
        where TMethodCollection : IAbstractClassMethodCollection
        where TFieldCollection : IClassFieldCollection
        where TConstructor : IClassConstructor
        where TOperatorOverload : IOperatorOverload
        where TConversionOperator : IConversionOperator
        where TNestedClassCollection : IClassNestedClassCollection
        where TNestedDelegate : IClassNestedDelegate
        where TNestedEnum : IClassNestedEnum
        where TNestedInterface : IClassNestedInterface
        where TNestedStructCollection : IClassNestedStructCollection
        where TNestedDestructor : INestedDestructor
        where TStaticConstructor : IStaticConstructor
    {
    }
}
