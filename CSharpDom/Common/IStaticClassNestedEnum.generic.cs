namespace CSharpDom.Common
{
    public interface IStaticClassNestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember> :
        IStaticClassNestedEnum,
        INestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IStaticType
        where TNestedEnumMember : INestedEnumMember
    {
    }
}
