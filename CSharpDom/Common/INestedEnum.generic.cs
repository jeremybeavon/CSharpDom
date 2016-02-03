namespace CSharpDom.Common
{
    public interface INestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember> :
        INestedEnum,
        IHasName,
        IHasEnumBaseType,
        IHasAttributes<TAttributeGroup>,
        IHasDeclaringType<TDeclaringType>,
        IHasEnumMembers<TNestedEnumMember>,
        IVisitable<IGenericVisitor>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IType
        where TNestedEnumMember : INestedEnumMember
    {
    }
}
