namespace CSharpDom.Common.Editable
{
    public interface IEditableStructEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody> :
        IEditableStructEventProperty,
        IEditableEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody>,
        IHasEditableStructMemberInheritanceModifier,
        IStructEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody>
        where TAttributeGroup : IEditableAttributeGroup
        where TDeclaringType : IEditableStructType
        where TDelegateReference : IEditableDelegateReference
        where TMethodBody : IEditableMethodBody
    {
    }
}