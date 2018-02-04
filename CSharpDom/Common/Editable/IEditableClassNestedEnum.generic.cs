namespace CSharpDom.Common.Editable
{
    public interface IEditableClassNestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember> :
        IEditableClassNestedEnum,
        IEditableNestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember>,
        IClassNestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember>
        where TAttributeGroup : IEditableAttributeGroup
        where TDeclaringType : IEditableClassType
        where TNestedEnumMember : IEditableNestedEnumMember
    {
    }
}