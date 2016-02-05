namespace CSharpDom.Common
{
    public interface ISealedClass<TNamespace,
        TDocument,
        TProject,
        TSolution,
        TAttributeGroup,
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
        ISealedClass,
        IHasName,
        IHasTypeVisibilityModifier,
        IHasBaseClass<TClassReference>,
        IHasImplementedInterfaces<TInterfaceReference>,
        IHasNamespace<TNamespace>,
        IHasDocument<TDocument>,
        IHasProject<TProject>,
        IHasSolution<TSolution>,
        IHasAttributes<TAttributeGroup>,
        IHasGenericParameters<TGenericParameter>,
        ISealedType<TEvent, TProperty, TIndexer, TMethod, TField, TConstructor, TEventProperty, TOperatorOverload, TConversionOperator, TNestedClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct, TStaticConstructor, TExplicitInterfaceEvent, TExplicitInterfaceProperty, TExplicitInterfaceIndexer, TExplicitInterfaceMethod, TProtectedOverrideEvent, TProtectedOverrideProperty, TProtectedOverrideIndexer, TProtectedOverrideMethod>
        where TNamespace : INamespace
        where TDocument : IDocument
        where TProject : IProject
        where TSolution : ISolution
        where TAttributeGroup : IAttributeGroup
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
