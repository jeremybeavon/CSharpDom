namespace CSharpDom.Common
{
    public interface IType<
        TAttributeGroup,
        TGenericParameter,
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
        TNestedInterface,
        TNestedStructCollection,
        TStaticConstructor> :
        IType,
        IHasName,
        IHasAttributes<TAttributeGroup>,
        IHasGenericParameters<TGenericParameter>,
        IHasImplementedInterfaces<TInterfaceReference>,
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
        IHasInterfaces<TNestedInterface>,
        IHasStructCollection<TNestedStructCollection>,
        IHasStaticConstructor<TStaticConstructor>
        where TAttributeGroup : IAttributeGroup
        where TGenericParameter : IGenericParameterDeclaration
        where TInterfaceReference : IInterfaceReference
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
        where TNestedInterface : INestedInterface
        where TNestedStructCollection : INestedStructCollection
        where TStaticConstructor : IStaticConstructor
    {
    }
}
