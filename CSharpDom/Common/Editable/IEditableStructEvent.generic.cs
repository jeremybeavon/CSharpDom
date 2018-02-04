namespace CSharpDom.Common.Editable
{
    public interface IEditableStructEvent<TAttributeGroup, TDeclaringType, TDelegateReference> :
        IEditableStructEvent,
        IEditableEvent<TAttributeGroup, TDeclaringType, TDelegateReference>,
        IHasEditableStructMemberInheritanceModifier,
        IStructEvent<TAttributeGroup, TDeclaringType, TDelegateReference>
        where TAttributeGroup : IEditableAttributeGroup
        where TDeclaringType : IEditableStructType
        where TDelegateReference : IEditableDelegateReference
    {
    }
}