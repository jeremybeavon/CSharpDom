namespace CSharpDom.Common
{
    public interface INestedClass<TDeclaringType,
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
        TDestructor> :
        IHasName,
        ICanBeGeneric,
        IHasDeclaringType<TDeclaringType>,
        IType<TEvent, TProperty, TIndexer, TMethod, TField, TConstructor, TEventProperty, TOperatorOverload, TConversionOperator, TNestedClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct>,
        IHasDestructor<TDestructor>
    {
    }
}
