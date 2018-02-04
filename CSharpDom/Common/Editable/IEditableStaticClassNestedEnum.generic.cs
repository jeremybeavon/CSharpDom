namespace CSharpDom.Common.Editable
{
    public interface IEditableStaticClassNestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember> :
        IEditableStaticClassNestedEnum,
        IEditableNestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember>,
        IStaticClassNestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember>
        where TAttributeGroup : IEditableAttributeGroup
        where TDeclaringType : IEditableStaticType
        where TNestedEnumMember : IEditableNestedEnumMember
    {
    }
}