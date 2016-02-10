using CSharpDom.Common;
using CSharpDom.Serialization.Factories.Expressions;

namespace CSharpDom.Serialization.Factories
{
    public sealed class NamedAttributeValueFactory : AbstractFactory<INamedAttributeValue, NamedAttributeValue>
    {
        public NamedAttributeValueFactory(INamedAttributeValue namedAttributeValue)
            : base(namedAttributeValue)
        {
        }

        public override void VisitNamedAttributeValue<TExpression>(INamedAttributeValue<TExpression> namedAttributeValue)
        {
            Value = new NamedAttributeValue()
            {
                Name = namedAttributeValue.Name,
                Value = new ExpressionFactory(namedAttributeValue.Value).Value
            };
        }
    }
}
