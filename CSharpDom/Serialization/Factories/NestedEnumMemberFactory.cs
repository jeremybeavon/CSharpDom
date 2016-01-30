using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class NestedEnumMemberFactory : AbstractFactory<INestedEnumMember, NestedEnumMember>
    {
        public NestedEnumMemberFactory(INestedEnumMember nestedEnumMember)
            : base(nestedEnumMember)
        {
        }

        public override void VisitNestedEnumMember<TAttributeGroup, TDeclaringType>(
            INestedEnumMember<TAttributeGroup, TDeclaringType> nestedEnumMember)
        {
            Value = new NestedEnumMember()
            {
                Attributes = nestedEnumMember.Attributes.ToAttributeListUsingFactory(),
                Name = nestedEnumMember.Name
            };
        }
    }
}
