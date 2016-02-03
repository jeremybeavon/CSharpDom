namespace CSharpDom.Common
{
    public interface IType<
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
        TExplicitInterfaceMethod> :
        IType,
        IBasicType<TEvent, TProperty, TIndexer, TMethod>,
        IHasFields<TField>,
        IHasConstructors<TConstructor>,
        IHasEventProperties<TEventProperty>,
        IHasOperatorOverloads<TOperatorOverload>,
        IHasConversionOperators<TConversionOperator>,
        IHasClasses<TNestedClass>,
        IHasDelegates<TNestedDelegate>,
        IHasEnums<TNestedEnum>,
        IHasInterfaces<TNestedInterface>,
        IHasStructs<TNestedStruct>,
        IHasStaticConstructor<TStaticConstructor>,
        IHasExplicitInterfaceEvents<TExplicitInterfaceEvent>,
        IHasExplicitInterfaceIndexers<TExplicitInterfaceIndexer>,
        IHasExplicitInterfaceMethods<TExplicitInterfaceMethod>,
        IHasExplicitInterfaceProperties<TExplicitInterfaceProperty>
        where TEvent : IEvent
        where TProperty : IProperty
        where TIndexer : IIndexer
        where TMethod : IMethod
        where TField : IField
        where TConstructor : IConstructor
        where TEventProperty : IEventProperty
        where TOperatorOverload : IOperatorOverload
        where TConversionOperator : IConversionOperator
        where TNestedClass : INestedClass
        where TNestedDelegate : INestedDelegate
        where TNestedEnum : INestedEnum
        where TNestedInterface : INestedInterface
        where TNestedStruct : INestedStruct
        where TStaticConstructor : IStaticConstructor
        where TExplicitInterfaceEvent : IExplicitInterfaceEvent
        where TExplicitInterfaceIndexer : IExplicitInterfaceIndexer
        where TExplicitInterfaceMethod : IExplicitInterfaceMethod
        where TExplicitInterfaceProperty : IExplicitInterfaceProperty
    {
    }
}
