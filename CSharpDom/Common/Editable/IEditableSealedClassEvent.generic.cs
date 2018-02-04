namespace CSharpDom.Common.Editable
{
    public interface IEditableSealedClassEvent<TAttributeGroup, TDeclaringType, TDelegateReference> :
        IEditableSealedClassEvent,
        IEditableEvent<TAttributeGroup, TDeclaringType, TDelegateReference>,
        IHasEditableFieldAttributes<TAttributeGroup>,
        IHasEditableSealedClassMemberInheritanceModifier,
        ISealedClassEvent<TAttributeGroup, TDeclaringType, TDelegateReference>
        where TAttributeGroup : IEditableAttributeGroup
        where TDeclaringType : IEditableSealedType
        where TDelegateReference : IEditableDelegateReference
    {
    }
}