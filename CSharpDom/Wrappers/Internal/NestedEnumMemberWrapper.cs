using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class NestedEnumMemberWrapper : AbstractWrapper<INestedEnumMember>
    {
        public NestedEnumMemberWrapper(INestedEnumMember nestedEnumMember)
            : base(nestedEnumMember)
        {
        }

        public override void VisitNestedEnumMember<TAttributeGroup, TDeclaringType>(
            INestedEnumMember<TAttributeGroup, TDeclaringType> nestedEnumMember)
        {
            Value = new NestedEnumMember()
            {
                Attributes = nestedEnumMember.Attributes.ToAttributeListUsingWrapper(),
                Name = nestedEnumMember.Name
            };
        }
    }
}
