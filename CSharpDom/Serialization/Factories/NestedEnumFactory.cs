using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class NestedEnumFactory : AbstractFactory<INestedEnum, NestedEnum>
    {
        public NestedEnumFactory(INestedEnum nestedEnum)
            : base(nestedEnum)
        {
        }

        public override void VisitNestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember>(INestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember> nestedEnum)
        {
            Value = new NestedEnum()
            {
                Attributes = nestedEnum.Attributes.ToAttributeListUsingFactory(),
                EnumMembers = nestedEnum.EnumMembers.ToList(member => new NestedEnumMemberFactory(member).Value),
                Name = nestedEnum.Name,
                Visibility = nestedEnum.Visibility
            };
        }
    }
}
