namespace CSharpDom.Common.Editable
{
    public interface IEditableInterfaceType<TAttributeGroup, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod> :
        IEditableInterfaceType,
        IHasEditableName,
        IHasEditablePartial,
        IHasEditableAttributes<TAttributeGroup>,
        IHasEditableGenericParameters<TGenericParameter>,
        IHasEditableInterfaces<TInterfaceReference>,
        IHasEditableEvents<TEvent>,
        IHasEditableProperties<TProperty>,
        IHasEditableIndexers<TIndexer>,
        IHasEditableMethods<TMethod>,
        IInterfaceType<TAttributeGroup, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod>
        where TAttributeGroup : IEditableAttributeGroup
        where TGenericParameter : IEditableGenericParameterDeclaration
        where TInterfaceReference : IEditableInterfaceReference
        where TEvent : IEditableInterfaceEvent
        where TProperty : IEditableInterfaceProperty
        where TIndexer : IEditableInterfaceIndexer
        where TMethod : IEditableInterfaceMethod
    {
    }
}