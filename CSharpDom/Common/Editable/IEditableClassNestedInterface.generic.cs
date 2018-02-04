namespace CSharpDom.Common.Editable
{
    public interface IEditableClassNestedInterface<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod> :
        IEditableClassNestedInterface,
        IEditableNestedInterface<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod>,
        IClassNestedInterface<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod>
        where TAttributeGroup : IEditableAttributeGroup
        where TDeclaringType : IEditableClassType
        where TGenericParameter : IEditableGenericParameterDeclaration
        where TInterfaceReference : IEditableInterfaceReference
        where TEvent : IEditableInterfaceEvent
        where TProperty : IEditableInterfaceProperty
        where TIndexer : IEditableInterfaceIndexer
        where TMethod : IEditableInterfaceMethod
    {
    }
}