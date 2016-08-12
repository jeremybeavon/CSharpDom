using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class ClassNestedEnumWrapper : AbstractWrapper<IClassNestedEnum>
    {
        public ClassNestedEnumWrapper(IClassNestedEnum nestedEnum)
            : base(nestedEnum)
        {
        }

        public override void VisitClassNestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember>(IClassNestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember> nestedEnum)
        {
            Value = new ClassNestedEnum()
            {
                Attributes = nestedEnum.Attributes.ToAttributeListUsingWrapper(),
                EnumMembers = nestedEnum.EnumMembers.ToList(member => new NestedEnumMemberWrapper(member).Value),
                Name = nestedEnum.Name,
                Visibility = nestedEnum.Visibility
            };
        }
    }
}
