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
        where TEvent : IClassEvent
        where TProperty : IClassProperty
        where TIndexer : IClassIndexer
        where TMethod : IClassMethod
        where TField : IClassField
        where TConstructor : IClassConstructor
        where TEventProperty : IClassEventProperty
        where TOperatorOverload : IOperatorOverload
        where TConversionOperator : IConversionOperator
        where TNestedClass : IClassNestedClass
        where TNestedDelegate : IClassNestedDelegate
        where TNestedEnum : IClassNestedEnum
        where TNestedInterface : IClassNestedInterface
        where TNestedStruct : IClassNestedStruct
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
