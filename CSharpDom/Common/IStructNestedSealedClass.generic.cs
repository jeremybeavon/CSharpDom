namespace CSharpDom.Common
{
    public interface IStructNestedSealedClass<
        TAttributeGroup,
        TDeclaringType,
        TGenericParameter,
        TClassReference,
        TInterfaceReference,
        TEvent,
        TProperty,
        TIndexer,
        TMethod,
        TField,
        TConstructor,
        TEventProperty,
        TOperatorOverload,
        TConversionOperator,
        TNestedClass,
        TNestedDelegate,
        TNestedEnum,
        TNestedInterface,
        TNestedStruct,
        TDestructor,
        TStaticConstructor,
        TExplicitInterfaceEvent,
        TExplicitInterfaceProperty,
        TExplicitInterfaceIndexer,
        TExplicitInterfaceMethod,
        TProtectedOverrideEvent,
        TProtectedOverrideProperty,
        TProtectedOverrideIndexer,
        TProtectedOverrideMethod> :
        IStructNestedSealedClass,
        INestedSealedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod, TField, TConstructor, TEventProperty, TOperatorOverload, TConversionOperator, TNestedClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct, TDestructor, TStaticConstructor, TExplicitInterfaceEvent, TExplicitInterfaceProperty, TExplicitInterfaceIndexer, TExplicitInterfaceMethod, TProtectedOverrideEvent, TProtectedOverrideProperty, TProtectedOverrideIndexer, TProtectedOverrideMethod>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IType
        where TGenericParameter : IGenericParameterDeclaration
        where TClassReference : IClassReference
        where TInterfaceReference : IInterfaceReference
        where TEvent : ISealedClassEvent
        where TProperty : ISealedClassProperty
        where TIndexer : ISealedClassIndexer
        where TMethod : ISealedClassMethod
        where TField : ISealedClassField
        where TConstructor : ISealedClassConstructor
        where TEventProperty : ISealedClassEventProperty
        where TOperatorOverload : IOperatorOverload
        where TConversionOperator : IConversionOperator
        where TNestedClass : ISealedClassNestedClass
        where TNestedDelegate : ISealedClassNestedDelegate
        where TNestedEnum : ISealedClassNestedEnum
        where TNestedInterface : ISealedClassNestedInterface
        where TNestedStruct : ISealedClassNestedStruct
        where TDestructor : IDestructor
        where TStaticConstructor : IStaticConstructor
        where TExplicitInterfaceEvent : IExplicitInterfaceEvent
        where TExplicitInterfaceIndexer : IExplicitInterfaceIndexer
        where TExplicitInterfaceMethod : IExplicitInterfaceMethod
        where TExplicitInterfaceProperty : IExplicitInterfaceProperty
        where TProtectedOverrideEvent : IProtectedOverrideEvent
        where TProtectedOverrideProperty : IProtectedOverrideIndexer
        where TProtectedOverrideIndexer : IProtectedOverrideIndexer
        where TProtectedOverrideMethod : IProtectedOverrideMethod
    {
    }
}
