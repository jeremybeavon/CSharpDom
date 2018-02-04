namespace CSharpDom.Common.Editable
{
    public interface IEditableSealedClassEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody> :
        IEditableSealedClassEventProperty,
        IEditableEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody>,
        IHasEditableSealedClassMemberInheritanceModifier,
        ISealedClassEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody>
        where TAttributeGroup : IEditableAttributeGroup
        where TDeclaringType : IEditableSealedType
        where TDelegateReference : IEditableDelegateReference
        where TMethodBody : IEditableMethodBody
    {
    }
}