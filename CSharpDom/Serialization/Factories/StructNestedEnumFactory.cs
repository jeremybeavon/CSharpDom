using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class StructNestedEnumFactory : AbstractFactory<IStructNestedEnum, StructNestedEnum>
    {
        public StructNestedEnumFactory(IStructNestedEnum nestedEnum)
            : base(nestedEnum)
        {
        }

        public override void VisitStructNestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember>(IStructNestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember> nestedEnum)
        {
            Value = new StructNestedEnum()
            {
                Attributes = nestedEnum.Attributes.ToAttributeListUsingFactory(),
                EnumMembers = nestedEnum.EnumMembers.ToList(member => new NestedEnumMemberFactory(member).Value),
                Name = nestedEnum.Name,
                Visibility = nestedEnum.Visibility
            };
        }
    }
}
