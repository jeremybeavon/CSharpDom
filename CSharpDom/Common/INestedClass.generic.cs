namespace CSharpDom.Common
{
    public interface INestedClass<TAttributeGroup,
        TDeclaringType,
        TGenericParameter,
        TClassReference,
        TInterfaceReference,
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
        TNestedDestructor> :
        INestedClass,
        IHasName,
        IHasMemberVisibilityModifier,
        IHasTypeInheritanceModifier,
        IHasAttributes<TAttributeGroup>,
        IHasDeclaringType<TDeclaringType>,
        IHasGenericParameters<TGenericParameter>,
        IHasBaseClass<TClassReference>,
        IHasImplementedInterfaces<TInterfaceReference>,
        IType<TEvent, TProperty, TIndexer, TMethod, TField, TConstructor, TEventProperty, TOperatorOverload, TConversionOperator, TNestedClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct>,
        IHasDestructor<TNestedDestructor>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IType
        where TGenericParameter : IGenericParameterDeclaration
        where TClassReference : IClassReference
        where TInterfaceReference : IInterfaceReference
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
        where TNestedDestructor : INestedDestructor
    {
    }
}
