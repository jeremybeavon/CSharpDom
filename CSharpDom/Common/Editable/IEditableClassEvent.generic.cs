namespace CSharpDom.Common.Editable
{
    public interface IEditableClassEvent<TAttributeGroup, TDeclaringType, TDelegateReference> :
        IEditableClassEvent,
        IEditableEvent<TAttributeGroup, TDeclaringType, TDelegateReference>,
        IHasEditableClassMemberInheritanceModifier,
        IHasEditableFieldAttributes<TAttributeGroup>,
        IClassEvent<TAttributeGroup, TDeclaringType, TDelegateReference>
        where TAttributeGroup : IEditableAttributeGroup
        where TDeclaringType : IEditableClassType
        where TDelegateReference : IEditableDelegateReference
    {
    }
}