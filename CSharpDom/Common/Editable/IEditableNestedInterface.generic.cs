namespace CSharpDom.Common.Editable
{
    public interface IEditableNestedInterface<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod> :
        IEditableNestedInterface,
        IEditableInterfaceType<TAttributeGroup, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod>,
        IHasEditableDeclaringType<TDeclaringType>,
        IVisitable<IEditableVisitor>,
        INestedInterface<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod>
        where TAttributeGroup : IEditableAttributeGroup
        where TDeclaringType : IEditableType
        where TGenericParameter : IEditableGenericParameterDeclaration
        where TInterfaceReference : IEditableInterfaceReference
        where TEvent : IEditableInterfaceEvent
        where TProperty : IEditableInterfaceProperty
        where TIndexer : IEditableInterfaceIndexer
        where TMethod : IEditableInterfaceMethod
    {
    }
}