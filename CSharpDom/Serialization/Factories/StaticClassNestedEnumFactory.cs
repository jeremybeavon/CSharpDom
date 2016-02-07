using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class StaticClassNestedEnumFactory : AbstractFactory<IStaticClassNestedEnum, StaticClassNestedEnum>
    {
        public StaticClassNestedEnumFactory(IStaticClassNestedEnum nestedEnum)
            : base(nestedEnum)
        {
        }

        public override void VisitStaticClassNestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember>(IStaticClassNestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember> nestedEnum)
        {
            Value = new StaticClassNestedEnum()
            {
                Attributes = nestedEnum.Attributes.ToAttributeListUsingFactory(),
                EnumMembers = nestedEnum.EnumMembers.ToList(member => new NestedEnumMemberFactory(member).Value),
                Name = nestedEnum.Name,
                Visibility = nestedEnum.Visibility
            };
        }
    }
}
