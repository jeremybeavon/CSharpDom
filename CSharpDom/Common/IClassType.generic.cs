namespace CSharpDom.Common
{
    public interface IClassType<
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
        TStaticConstructor,
        TDestructor> :
        IClassType,
        IType<TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TStaticConstructor>,
        IHasDestructor<TDestructor>
        where TEventCollection : IClassEventCollection
        where TPropertyCollection : IClassPropertyCollection
        where TIndexerCollection : IClassIndexerCollection
        where TMethodCollection : IClassMethodCollection
        where TFieldCollection : IClassFieldCollection
        where TConstructor : IClassConstructor
        where TOperatorOverload : IOperatorOverload
        where TConversionOperator : IConversionOperator
        where TNestedClassCollection : IClassNestedClassCollection
        where TNestedDelegate : IClassNestedDelegate
        where TNestedEnum : IClassNestedEnum
        where TNestedInterfaceCollection : IClassNestedInterfaceCollection
        where TNestedStructCollection : IClassNestedStructCollection
        where TStaticConstructor : IStaticConstructor
        where TDestructor : IDestructor
    {
    }
}
