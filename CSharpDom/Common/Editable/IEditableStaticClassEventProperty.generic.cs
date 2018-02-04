namespace CSharpDom.Common.Editable
{
    public interface IEditableStaticClassEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody> :
        IEditableStaticClassEventProperty,
        IEditableEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody>,
        IStaticClassEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody>
        where TAttributeGroup : IEditableAttributeGroup
        where TDeclaringType : IEditableStaticType
        where TDelegateReference : IEditableDelegateReference
        where TMethodBody : IEditableMethodBody
    {
    }
}