namespace CSharpDom.Common
{
    public interface IStructNestedClass<TAttributeGroup,
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
        TNestedDestructor,
        TStaticConstructor,
        TExplicitInterfaceEvent,
        TExplicitInterfaceProperty,
        TExplicitInterfaceIndexer,
        TExplicitInterfaceMethod> :
        IStructNestedClass,
        INestedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod, TField, TConstructor, TEventProperty, TOperatorOverload, TConversionOperator, TNestedClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct, TNestedDestructor, TStaticConstructor, TExplicitInterfaceEvent, TExplicitInterfaceProperty, TExplicitInterfaceIndexer, TExplicitInterfaceMethod>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IType
        where TGenericParameter : IGenericParameterDeclaration
        where TClassReference : IClassReference
        where TInterfaceReference : IInterfaceReference
        where TEvent : IClassEvent
        where TProperty : IClassProperty
        where TIndexer : IClassIndexer
        where TMethod : IClassMethod
        where TField : IClassField
        where TConstructor : IClassConstructor
        where TEventProperty : IClassEventProperty
        where TOperatorOverload : IOperatorOverload
        where TConversionOperator : IConversionOperator
        where TNestedClass : IClassNestedClass
        where TNestedDelegate : IClassNestedDelegate
        where TNestedEnum : IClassNestedEnum
        where TNestedInterface : IClassNestedInterface
        where TNestedStruct : IClassNestedStruct
        where TNestedDestructor : INestedDestructor
        where TStaticConstructor : IStaticConstructor
        where TExplicitInterfaceEvent : IExplicitInterfaceEvent
        where TExplicitInterfaceProperty : IExplicitInterfaceProperty
        where TExplicitInterfaceIndexer : IExplicitInterfaceIndexer
        where TExplicitInterfaceMethod : IExplicitInterfaceMethod
    {
    }
}
