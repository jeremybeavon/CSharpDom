namespace CSharpDom.Common.Editable
{
    public interface IEditableNestedEnumMember<TAttributeGroup, TDeclaringType> :
        IEditableNestedEnumMember,
        IHasEditableName,
        IHasEditableAttributes<TAttributeGroup>,
        IHasEditableDeclaringType<TDeclaringType>,
        INestedEnumMember<TAttributeGroup, TDeclaringType>
        where TAttributeGroup : IEditableAttributeGroup
        where TDeclaringType : IEditableNestedEnum
    {
    }
}