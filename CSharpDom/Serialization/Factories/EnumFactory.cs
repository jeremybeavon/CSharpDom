using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class EnumFactory : AbstractFactory<IEnum, Enum>
    {
        public EnumFactory(IEnum @enum)
            : base(@enum)
        {
        }

        public override void VisitEnum<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TEnumMember>(
            IEnum<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TEnumMember> @enum)
        {
            Value = new Enum()
            {
                Attributes = @enum.Attributes.ToAttributeListUsingFactory(),
                EnumMembers = @enum.EnumMembers.ToList(member => new EnumMemberFactory(member).Value),
                Name = @enum.Name,
                Visibility = @enum.Visibility
            };
        }
    }
}
