namespace CSharpDom.Common
{
    public interface ISealedType<
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
        TStaticConstructor,
        TExplicitInterfaceEvent,
        TExplicitInterfaceProperty,
        TExplicitInterfaceIndexer,
        TExplicitInterfaceMethod,
        TProtectedOverrideEvent,
        TProtectedOverrideProperty,
        TProtectedOverrideIndexer,
        TProtectedOverrideMethod> :
        ISealedType,
        IType<TEvent, TProperty, TIndexer, TMethod, TField, TConstructor, TEventProperty, TOperatorOverload, TConversionOperator, TNestedClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct, TStaticConstructor, TExplicitInterfaceEvent, TExplicitInterfaceProperty, TExplicitInterfaceIndexer, TExplicitInterfaceMethod>,
        IHasProtectedOverrideEvents<TProtectedOverrideEvent>,
        IHasProtectedOverrideProperties<TProtectedOverrideProperty>,
        IHasProtectedOverrideIndexers<TProtectedOverrideIndexer>,
        IHasProtectedOverrideMethods<TProtectedOverrideMethod>
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
