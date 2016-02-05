namespace CSharpDom.Common
{
    public interface IStructNestedStaticClass<TAttributeGroup,
        TDeclaringType,
        TGenericParameter,
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
        IStructNestedClass,
        INestedStaticClass<TAttributeGroup, TDeclaringType, TGenericParameter, TEvent, TProperty, TMethod, TField, TEventProperty, TNestedClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct, TStaticConstructor>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IStructType
        where TGenericParameter : IGenericParameterDeclaration
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
