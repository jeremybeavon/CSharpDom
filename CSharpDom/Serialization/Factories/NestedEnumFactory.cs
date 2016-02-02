using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class NestedEnumFactory : AbstractFactory<IClassNestedEnum, ClassNestedEnum>
    {
        public NestedEnumFactory(IClassNestedEnum nestedEnum)
            : base(nestedEnum)
        {
        }

        public override void VisitClassNestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember>(IClassNestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember> nestedEnum)
        {
            Value = new ClassNestedEnum()
            {
                Attributes = nestedEnum.Attributes.ToAttributeListUsingFactory(),
                EnumMembers = nestedEnum.EnumMembers.ToList(member => new NestedEnumMemberFactory(member).Value),
                Name = nestedEnum.Name,
                Visibility = nestedEnum.Visibility
            };
        }
    }
}
