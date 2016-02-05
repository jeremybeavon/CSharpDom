namespace CSharpDom.Common
{
    public interface IStructNestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember> :
        IStructNestedEnum,
        INestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IStructType
        where TNestedEnumMember : INestedEnumMember
    {
    }
}
