namespace CSharpDom.Common
{
    public interface IStaticType<
        TEvent,
        TProperty,
        TMethod,
        TField,
        TEventProperty,
        TNestedClass,
        TNestedDelegate,
        TNestedEnum,
        TNestedInterface,
        TNestedStruct,
        TStaticConstructor> :
        IType,
        IHasEvents<TEvent>,
        IHasProperties<TProperty>,
        IHasMethods<TMethod>,
        IHasFields<TField>,
        IHasEventProperties<TEventProperty>,
        IHasClasses<TNestedClass>,
        IHasDelegates<TNestedDelegate>,
        IHasEnums<TNestedEnum>,
        IHasInterfaces<TNestedInterface>,
        IHasStructs<TNestedStruct>,
        IHasStaticConstructor<TStaticConstructor>
        where TEvent : IStaticClassEvent
        where TProperty : IStaticClassProperty
        where TMethod : IStaticClassMethod
        where TField : IStaticClassField
        where TEventProperty : IStaticClassEventProperty
        where TNestedClass : IStaticClassNestedClass
        where TNestedDelegate : IStaticClassNestedDelegate
        where TNestedEnum : IStaticClassNestedEnum
        where TNestedInterface : IStaticClassNestedInterface
        where TNestedStruct : IStaticClassNestedStruct
        where TStaticConstructor : IStaticConstructor
    {
    }
}
