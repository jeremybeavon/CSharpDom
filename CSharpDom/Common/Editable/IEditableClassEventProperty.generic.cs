namespace CSharpDom.Common.Editable
{
    public interface IEditableClassEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody> :
        IEditableClassEventProperty,
        IEditableEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody>,
        IHasEditableClassMemberInheritanceModifier,
        IClassEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody>
        where TAttributeGroup : IEditableAttributeGroup
        where TDeclaringType : IEditableClassType
        where TDelegateReference : IEditableDelegateReference
        where TMethodBody : IEditableMethodBody
    {
    }
}