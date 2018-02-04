namespace CSharpDom.Common.Editable
{
    public interface IEditableNestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember> :
        IEditableNestedEnum,
        IHasEditableName,
        IHasEditableEnumBaseType,
        IHasEditableAttributes<TAttributeGroup>,
        IHasEditableDeclaringType<TDeclaringType>,
        IHasEditableEnumMembers<TNestedEnumMember>,
        IVisitable<IEditableVisitor>,
        INestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember>
        where TAttributeGroup : IEditableAttributeGroup
        where TDeclaringType : IEditableType
        where TNestedEnumMember : IEditableNestedEnumMember
    {
    }
}