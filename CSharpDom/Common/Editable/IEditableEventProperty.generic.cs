namespace CSharpDom.Common.Editable
{
    public interface IEditableEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody> :
        IEditableEventProperty,
        IHasEditableName,
        IHasEditableAttributes<TAttributeGroup>,
        IHasEditableDeclaringType<TDeclaringType>,
        IHasEditableEventType<TDelegateReference>,
        IHasEditableEventPropertyBody<TMethodBody>,
        IHasEditableEventPropertyBodyAttributes<TAttributeGroup>,
        IEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody>
        where TAttributeGroup : IEditableAttributeGroup
        where TDeclaringType : IEditableType
        where TDelegateReference : IEditableDelegateReference
        where TMethodBody : IEditableMethodBody
    {
    }
}