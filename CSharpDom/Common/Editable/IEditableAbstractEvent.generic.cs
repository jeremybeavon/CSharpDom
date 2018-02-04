namespace CSharpDom.Common.Editable
{
    public interface IEditableAbstractEvent<TAttributeGroup, TDeclaringType, TDelegateReference> :
        IEditableAbstractEvent,
        IEditableEvent<TAttributeGroup, TDeclaringType, TDelegateReference>,
        IAbstractEvent<TAttributeGroup, TDeclaringType, TDelegateReference>
        where TAttributeGroup : IEditableAttributeGroup
        where TDeclaringType : IEditableAbstractType
        where TDelegateReference : IEditableDelegateReference
    {
    }
}