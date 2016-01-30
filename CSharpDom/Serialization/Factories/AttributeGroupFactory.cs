using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class AttributeGroupFactory : AbstractFactory<IAttributeGroup, AttributeGroup>
    {
        public AttributeGroupFactory(IAttributeGroup attributeGroup)
            : base(attributeGroup)
        {
        }

        public override void VisitAttributeGroup<TAttribute>(IAttributeGroup<TAttribute> attributes)
        {
            Value = new AttributeGroup()
            {
                Attributes = attributes.Attributes.ToList(attribute => new AttributeFactory(attribute).Value)
            };
        }
    }
}
