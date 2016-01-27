namespace CSharpDom.Common
{
    public interface INestedInterface<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod> :
        INestedInterface,
        IHasName,
        IHasMemberVisibilityModifier,
        IHasAttributes<TAttributeGroup>,
        IBasicType<TEvent, TProperty, TIndexer, TMethod>,
        IHasDeclaringType<TDeclaringType>,
        IHasGenericParameters<TGenericParameter>,
        IHasInterfaces<TInterfaceReference>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IType
        where TGenericParameter : IGenericParameterDeclaration
        where TInterfaceReference : IInterfaceReference
        where TEvent : IEvent
        where TProperty : IProperty
        where TIndexer : IIndexer
        where TMethod : IMethod
    {
    }
}
