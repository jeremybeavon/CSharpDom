using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class SealedClassNestedEnumFactory : AbstractFactory<ISealedClassNestedEnum, SealedClassNestedEnum>
    {
        public SealedClassNestedEnumFactory(ISealedClassNestedEnum nestedEnum)
            : base(nestedEnum)
        {
        }

        public override void VisitSealedClassNestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember>(ISealedClassNestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember> nestedEnum)
        {
            Value = new SealedClassNestedEnum()
            {
                Attributes = nestedEnum.Attributes.ToAttributeListUsingFactory(),
                EnumMembers = nestedEnum.EnumMembers.ToList(member => new NestedEnumMemberFactory(member).Value),
                Name = nestedEnum.Name,
                Visibility = nestedEnum.Visibility
            };
        }
    }
}
