using CSharpDom.Common;
using CSharpDom.Serialization.Factories.Expressions;

namespace CSharpDom.Serialization.Factories
{
    public sealed class ConstantFactory : AbstractFactory<IConstant, Constant>
    {
        public ConstantFactory(IConstant @enum)
            : base(@enum)
        {
        }

        public override void VisitConstant<TExpression>(IConstant<TExpression> field)
        {
            Value = new Constant()
            {
                ConstantValue = new ExpressionFactory(field.ConstantValue).Value,
                Name = field.Name
            };
        }
    }
}
