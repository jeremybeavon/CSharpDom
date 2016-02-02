namespace CSharpDom.Common
{
    public interface INestedEnumMember<TAttributeGroup, TDeclaringType> :
        INestedEnumMember,
        IHasName,
        IHasAttributes<TAttributeGroup>,
        IHasDeclaringType<TDeclaringType>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IClassNestedEnum
    {
    }
}
