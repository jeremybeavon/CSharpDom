using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class NamedAttributeValueFactory : AbstractFactory<INamedAttributeValue, NamedAttributeValue>
    {
        public NamedAttributeValueFactory(INamedAttributeValue namedAttributeValue)
            : base(namedAttributeValue)
        {
        }

        public override void VisitNamedAttributeValue(INamedAttributeValue namedAttributeValue)
        {
            Value = new NamedAttributeValue()
            {
                Name = namedAttributeValue.Name,
                RawValue = namedAttributeValue.RawValue
            };
        }
    }
}
