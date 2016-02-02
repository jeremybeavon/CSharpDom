namespace CSharpDom.Common
{
    public interface IInterface<TNamespace,
        TProject,
        TSolution,
        TAttributeGroup,
        TGenericParameter,
        TInterfaceReference,
        TEvent,
        TProperty,
        TIndexer,
        TMethod> :
        IInterface,
        IHasName,
        IHasTypeVisibilityModifier,
        IHasPartialSupport,
        IHasAttributes<TAttributeGroup>,
        IHasGenericParameters<TGenericParameter>,
        IHasInterfaces<TInterfaceReference>,
        IBasicType<TEvent, TProperty, TIndexer, TMethod>,
        IHasNamespace<TNamespace>,
        IHasProject<TProject>,
        IHasSolution<TSolution>
        where TNamespace : INamespace
        where TProject : IProject
        where TSolution : ISolution
        where TAttributeGroup : IAttributeGroup
        where TGenericParameter : IGenericParameterDeclaration
        where TInterfaceReference : IInterfaceReference
        where TEvent : IInterfaceEvent
        where TProperty : IInterfaceProperty
        where TIndexer : IInterfaceIndexer
        where TMethod : IInterfaceMethod
    {
    }
}
