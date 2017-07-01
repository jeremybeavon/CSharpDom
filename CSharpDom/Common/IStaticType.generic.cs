namespace CSharpDom.Common
{
    public interface IStaticType<
        TAttributeGroup,
        TGenericParameter,
        TEventCollection,
        TProperty,
        TMethodCollection,
        TFieldCollection,
        TNestedClassCollection,
        TNestedDelegate,
        TNestedEnum,
        TNestedInterface,
        TNestedStructCollection,
        TStaticConstructor> :
        IStaticType,
        IHasName,
        IHasAttributes<TAttributeGroup>,
        IHasGenericParameters<TGenericParameter>,
        IHasEventCollection<TEventCollection>,
        IHasProperties<TProperty>,
        IHasMethodCollection<TMethodCollection>,
        IHasFieldCollection<TFieldCollection>,
        IHasClassCollection<TNestedClassCollection>,
        IHasDelegates<TNestedDelegate>,
        IHasEnums<TNestedEnum>,
        IHasInterfaces<TNestedInterface>,
        IHasStructCollection<TNestedStructCollection>,
        IHasStaticConstructor<TStaticConstructor>
        where TAttributeGroup : IAttributeGroup
        where TGenericParameter : IGenericParameterDeclaration
        where TEventCollection : IStaticClassEventCollection
        where TProperty : IStaticClassProperty
        where TMethodCollection : IStaticClassMethodCollection
        where TFieldCollection : IStaticClassFieldCollection
        where TNestedClassCollection : IStaticClassNestedClassCollection
        where TNestedDelegate : IStaticClassNestedDelegate
        where TNestedEnum : IStaticClassNestedEnum
        where TNestedInterface : IStaticClassNestedInterface
        where TNestedStructCollection : IStaticClassNestedStructCollection
        where TStaticConstructor : IStaticConstructor
    {
    }
}
