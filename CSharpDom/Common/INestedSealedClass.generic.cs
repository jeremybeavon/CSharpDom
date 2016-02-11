namespace CSharpDom.Common
{
    public interface INestedSealedClass<
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
        INestedSealedClass,
        IHasName,
        IHasTypeVisibilityModifier,
        IHasBaseClass<TClassReference>,
        IHasImplementedInterfaces<TInterfaceReference>,
        IHasDeclaringType<TDeclaringType>,
        IHasAttributes<TAttributeGroup>,
        IHasGenericParameters<TGenericParameter>,
        ISealedType<TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TStaticConstructor>,
        IHasDestructor<TNestedDestructor>
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
