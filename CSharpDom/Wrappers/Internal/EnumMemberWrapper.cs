using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class EnumMemberWrapper : AbstractWrapper<IEnumMember>
    {
        public EnumMemberWrapper(IEnumMember enumMember)
            : base(enumMember)
        {
        }

        public override void VisitEnumMember<TAttributeGroup, TDeclaringType>(
            IEnumMember<TAttributeGroup, TDeclaringType> enumMember)
        {
            Value = new EnumMember()
            {
                Attributes = enumMember.Attributes.ToAttributeListUsingWrapper(),
                Name = enumMember.Name
            };
        }
    }
}
