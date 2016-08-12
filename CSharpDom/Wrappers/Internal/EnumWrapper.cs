using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class EnumWrapper : AbstractWrapper<IEnum>
    {
        public EnumWrapper(IEnum @enum)
            : base(@enum)
        {
        }

        public override void VisitEnum<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TEnumMember>(
            IEnum<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TEnumMember> @enum)
        {
            Value = new Enum()
            {
                Attributes = @enum.Attributes.ToAttributeListUsingWrapper(),
                EnumMembers = @enum.EnumMembers.ToList(member => new EnumMemberWrapper(member).Value),
                Name = @enum.Name,
                Visibility = @enum.Visibility
            };
        }
    }
}
