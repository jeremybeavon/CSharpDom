using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class EnumMemberFactory : AbstractFactory<IEnumMember, EnumMember>
    {
        public EnumMemberFactory(IEnumMember enumMember)
            : base(enumMember)
        {
        }

        public override void VisitEnumMember<TAttributeGroup, TDeclaringType>(
            IEnumMember<TAttributeGroup, TDeclaringType> enumMember)
        {
            Value = new EnumMember()
            {
                Attributes = enumMember.Attributes.ToAttributeListUsingFactory(),
                Name = enumMember.Name
            };
        }
    }
}
