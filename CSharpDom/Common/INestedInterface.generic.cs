namespace CSharpDom.Common
{
    public interface INestedInterface<
        TAttributeGroup,
        TDeclaringType,
        TGenericParameter,
        TInterfaceReference,
        TEvent,
        TProperty,
        TIndexer,
        TMethod> :
        IHasName,
        IHasAttributes<TAttributeGroup>,
        IBasicType<TEvent, TProperty, TIndexer, TMethod>,
        IHasDeclaringType<TDeclaringType>,
        IHasGenericParameters<TGenericParameter>,
        IHasInterfaces<TInterfaceReference>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IType
        where TGenericParameter : IGenericParameterDeclaration
        where TInterfaceReference : IInterfaceReference
        where TEvent : IInterfaceEvent
        where TProperty : IInterfaceProperty
        where TIndexer : IInterfaceIndexer
        where TMethod : IInterfaceMethod
    {
    }
}
