using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class StaticClassNestedEnumWrapper : AbstractWrapper<IStaticClassNestedEnum>
    {
        public StaticClassNestedEnumWrapper(IStaticClassNestedEnum nestedEnum)
            : base(nestedEnum)
        {
        }

        public override void VisitStaticClassNestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember>(IStaticClassNestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember> nestedEnum)
        {
            Value = new StaticClassNestedEnum()
            {
                Attributes = nestedEnum.Attributes.ToAttributeListUsingWrapper(),
                EnumMembers = nestedEnum.EnumMembers.ToList(member => new NestedEnumMemberWrapper(member).Value),
                Name = nestedEnum.Name,
                Visibility = nestedEnum.Visibility
            };
        }
    }
}
