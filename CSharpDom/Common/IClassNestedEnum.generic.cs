namespace CSharpDom.Common
{
    public interface IClassNestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember> :
        IClassNestedEnum,
        INestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IType
        where TNestedEnumMember : INestedEnumMember
    {
    }
}
