namespace CSharpDom.Common.Editable
{
    public interface IEditableStructNestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember> :
        IEditableStructNestedEnum,
        IEditableNestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember>,
        IStructNestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember>
        where TAttributeGroup : IEditableAttributeGroup
        where TDeclaringType : IEditableStructType
        where TNestedEnumMember : IEditableNestedEnumMember
    {
    }
}