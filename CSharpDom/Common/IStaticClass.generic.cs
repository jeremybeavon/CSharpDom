namespace CSharpDom.Common
{
    public interface IStaticClass<TNamespace,
        TProject,
        TSolution,
        TAttributeGroup,
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
        IStaticClass,
        IHasName,
        IHasTypeVisibilityModifier,
        IHasNamespace<TNamespace>,
        IHasProject<TProject>,
        IHasSolution<TSolution>,
        IHasAttributes<TAttributeGroup>,
        IHasGenericParameters<TGenericParameter>,
        IStaticType<TEvent, TProperty, TMethod, TField, TEventProperty, TNestedClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct, TStaticConstructor>
        where TNamespace : INamespace
        where TProject : IProject
        where TSolution : ISolution
        where TAttributeGroup : IAttributeGroup
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



/*

        TStaticConstructor,
        TExplicitInterfaceEvent,
        TExplicitInterfaceProperty,
        TExplicitInterfaceIndexer,
        TExplicitInterfaceMethod


TStaticConstructor, TExplicitInterfaceEvent, TExplicitInterfaceProperty, TExplicitInterfaceIndexer, TExplicitInterfaceMethod

        where TStaticConstructor : IStaticConstructor
        where TExplicitInterfaceEvent : IExplicitInterfaceEvent
        where TExplicitInterfaceProperty : IExplicitInterfaceProperty
        where TExplicitInterfaceIndexer : IExplicitInterfaceIndexer
        where TExplicitInterfaceMethod : IExplicitInterfaceMethod
*/
