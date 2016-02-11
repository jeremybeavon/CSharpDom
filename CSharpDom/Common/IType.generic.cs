namespace CSharpDom.Common
{
    public interface IType<
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
        TStaticConstructor> :
        IType,
        IHasEventCollection<TEventCollection>,
        IHasPropertyCollection<TPropertyCollection>,
        IHasIndexerCollection<TIndexerCollection>,
        IHasMethodCollection<TMethodCollection>,
        IHasFieldCollection<TFieldCollection>,
        IHasConstructors<TConstructor>,
        IHasOperatorOverloads<TOperatorOverload>,
        IHasConversionOperators<TConversionOperator>,
        IHasClassCollection<TNestedClassCollection>,
        IHasDelegates<TNestedDelegate>,
        IHasEnums<TNestedEnum>,
        IHasInterfaceCollection<TNestedInterfaceCollection>,
        IHasStructCollection<TNestedStructCollection>,
        IHasStaticConstructor<TStaticConstructor>
        where TEventCollection : IEventCollection
        where TPropertyCollection : IPropertyCollection
        where TIndexerCollection : IIndexerCollection
        where TMethodCollection : IMethodCollection
        where TFieldCollection : IFieldCollection
        where TConstructor : IConstructor
        where TOperatorOverload : IOperatorOverload
        where TConversionOperator : IConversionOperator
        where TNestedClassCollection : INestedClassCollection
        where TNestedDelegate : INestedDelegate
        where TNestedEnum : INestedEnum
        where TNestedInterfaceCollection : INestedInterfaceCollection
        where TNestedStructCollection : INestedStructCollection
        where TStaticConstructor : IStaticConstructor
    {
    }
}
