namespace CSharpDom.Common
{
    public interface INestedEnumMember<TAttributeGroup, TDeclaringType> :
        IEnumMember,
        IHasName,
        IHasAttributes<TAttributeGroup>,
        IHasDeclaringType<TDeclaringType>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : INestedEnum
    {
    }
}
