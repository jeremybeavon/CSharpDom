using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class StructNestedEnumWrapper : AbstractWrapper<IStructNestedEnum>
    {
        public StructNestedEnumWrapper(IStructNestedEnum nestedEnum)
            : base(nestedEnum)
        {
        }

        public override void VisitStructNestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember>(IStructNestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember> nestedEnum)
        {
            Value = new StructNestedEnum()
            {
                Attributes = nestedEnum.Attributes.ToAttributeListUsingWrapper(),
                EnumMembers = nestedEnum.EnumMembers.ToList(member => new NestedEnumMemberWrapper(member).Value),
                Name = nestedEnum.Name,
                Visibility = nestedEnum.Visibility
            };
        }
    }
}
