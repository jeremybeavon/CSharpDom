namespace CSharpDom.Common
{
    public interface IStruct<TNamespace,
        TProject,
        TSolution,
        TAttributeGroup,
        TGenericParameter,
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
        TNestedStruct> :
        IStruct,
        IHasName,
        IHasTypeVisibilityModifier,
        IHasPartialSupport,
        IHasNamespace<TNamespace>,
        IHasProject<TProject>,
        IHasSolution<TSolution>,
        IHasAttributes<TAttributeGroup>,
        IHasGenericParameters<TGenericParameter>,
        IHasImplementedInterfaces<TInterfaceReference>,
        IType<TEvent, TProperty, TIndexer, TMethod, TField, TConstructor, TEventProperty, TOperatorOverload, TConversionOperator, TNestedClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct>
        where TNamespace : INamespace
        where TProject : IProject
        where TSolution : ISolution
        where TAttributeGroup : IAttributeGroup
        where TGenericParameter : IGenericParameterDeclaration
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
    {
    }
}
