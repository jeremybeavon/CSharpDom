namespace CSharpDom.Common.Editable
{
    public interface IEditableInterfaceEvent<TAttributeGroup, TDeclaringType, TDelegateReference> :
        IEditableInterfaceEvent,
        IEditableEvent<TAttributeGroup, TDeclaringType, TDelegateReference>,
        IInterfaceEvent<TAttributeGroup, TDeclaringType, TDelegateReference>
        where TAttributeGroup : IEditableAttributeGroup
        where TDeclaringType : IEditableInterfaceType
        where TDelegateReference : IEditableDelegateReference
    {
    }
}