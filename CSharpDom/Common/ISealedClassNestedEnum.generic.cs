namespace CSharpDom.Common
{
    public interface ISealedClassNestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember> :
        ISealedClassNestedEnum,
        INestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : ISealedType
        where TNestedEnumMember : INestedEnumMember
    {
    }
}
