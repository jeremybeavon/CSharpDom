using CSharpDom.Common;
using CSharpDom.Serialization.Factories.Expressions;

namespace CSharpDom.Serialization.Factories
{
    public sealed class UnnamedAttributeValueFactory : AbstractFactory<IUnnamedAttributeValue, UnnamedAttributeValue>
    {
        public UnnamedAttributeValueFactory(IUnnamedAttributeValue unnamedAttributeValue)
            : base(unnamedAttributeValue)
        {
        }

        public override void VisitUnnamedAttributeValue<TExpression>(IUnnamedAttributeValue<TExpression> unnamedAttributeValue)
        {
            Value = new UnnamedAttributeValue()
            {
                Value = new ExpressionFactory(unnamedAttributeValue.Value).Value
            };
        }
    }
}
