namespace CSharpDom.Common.Editable
{
    public interface IEditableStaticClassNestedInterface<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod> :
        IEditableStaticClassNestedInterface,
        IEditableNestedInterface<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod>,
        IStaticClassNestedInterface<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod>
        where TAttributeGroup : IEditableAttributeGroup
        where TDeclaringType : IEditableStaticType
        where TGenericParameter : IEditableGenericParameterDeclaration
        where TInterfaceReference : IEditableInterfaceReference
        where TEvent : IEditableInterfaceEvent
        where TProperty : IEditableInterfaceProperty
        where TIndexer : IEditableInterfaceIndexer
        where TMethod : IEditableInterfaceMethod
    {
    }
}