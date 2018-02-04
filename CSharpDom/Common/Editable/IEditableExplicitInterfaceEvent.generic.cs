namespace CSharpDom.Common.Editable
{
    public interface IEditableExplicitInterfaceEvent<TAttributeGroup, TDeclaringType, TInterfaceReference, TDelegateReference, TMethodBody> :
        IEditableExplicitInterfaceEvent,
        IEditableEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody>,
        IHasEditableExplicitInterface<TInterfaceReference>,
        IExplicitInterfaceEvent<TAttributeGroup, TDeclaringType, TInterfaceReference, TDelegateReference, TMethodBody>
        where TAttributeGroup : IEditableAttributeGroup
        where TDeclaringType : IEditableType
        where TInterfaceReference : IEditableInterfaceReference
        where TDelegateReference : IEditableDelegateReference
        where TMethodBody : IEditableMethodBody
    {
    }
}