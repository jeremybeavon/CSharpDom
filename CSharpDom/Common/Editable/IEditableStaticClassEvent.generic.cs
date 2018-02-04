namespace CSharpDom.Common.Editable
{
    public interface IEditableStaticClassEvent<TAttributeGroup, TDeclaringType, TDelegateReference> :
        IEditableStaticClassEvent,
        IEditableEvent<TAttributeGroup, TDeclaringType, TDelegateReference>,
        IHasEditableFieldAttributes<TAttributeGroup>,
        IStaticClassEvent<TAttributeGroup, TDeclaringType, TDelegateReference>
        where TAttributeGroup : IEditableAttributeGroup
        where TDeclaringType : IEditableStaticType
        where TDelegateReference : IEditableDelegateReference
    {
    }
}