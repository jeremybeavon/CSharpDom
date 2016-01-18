namespace CSharpDom.Common
{
    public interface IStruct<TNamespace,
        TProject,
        TSolution,
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
        TNestedStruct> :
        IHasName,
        ICanBeGeneric,
        IHasNamespace<TNamespace>,
        IHasProject<TProject>,
        IHasSolution<TSolution>,
        IType<TEvent, TProperty, TIndexer, TMethod, TField, TConstructor, TEventProperty, TOperatorOverload, TConversionOperator, TNestedClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct>
    {
    }
}
