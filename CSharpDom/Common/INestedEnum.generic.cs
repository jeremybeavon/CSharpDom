namespace CSharpDom.Common
{
    public interface INestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember> :
        IHasName,
        IHasAttributes<TAttributeGroup>,
        IHasDeclaringType<TDeclaringType>,
        IHasEnumMembers<TNestedEnumMember>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IType
        where TNestedEnumMember : INestedEnumMember
    {
    }
}
