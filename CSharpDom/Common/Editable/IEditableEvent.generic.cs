namespace CSharpDom.Common.Editable
{
    public interface IEditableEvent<TAttributeGroup, TDeclaringType, TDelegateReference> :
        IEditableEvent,
        IHasEditableName,
        IHasEditableAttributes<TAttributeGroup>,
        IHasEditableDeclaringType<TDeclaringType>,
        IHasEditableEventType<TDelegateReference>,
        IEvent<TAttributeGroup, TDeclaringType, TDelegateReference>
        where TAttributeGroup : IEditableAttributeGroup
        where TDeclaringType : IEditableBasicType
        where TDelegateReference : IEditableDelegateReference
    {
    }
}