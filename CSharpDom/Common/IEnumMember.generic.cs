namespace CSharpDom.Common
{
    public interface IEnumMember<TAttributeGroup, TDeclaringType> :
        IEnumMember,
        IHasName,
        IHasAttributes<TAttributeGroup>,
        IHasDeclaringType<TDeclaringType>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IEnum
    {
    }
}
