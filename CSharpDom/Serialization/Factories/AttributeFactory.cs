using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class AttributeFactory : AbstractFactory<IAttribute, Attribute>
    {
        public AttributeFactory(IAttribute attribute)
            : base(attribute)
        {
        }

        public override void VisitAttribute<TClassReference, TUnnamedAttributeValue, TNamedAttributeValue>(
            IAttribute<TClassReference, TUnnamedAttributeValue, TNamedAttributeValue> attribute)
        {
            Value = new Attribute()
            {
                AttributeType = new ClassReferenceFactory(attribute.AttributeType).Value,
                NamedValues = attribute.NamedValues.ToList(value => new NamedAttributeValueFactory(value).Value),
                UnnamedValues = attribute.UnnamedValues.ToList(value => new UnnamedAttributeValueFactory(value).Value)
            };
        }
    }
}
