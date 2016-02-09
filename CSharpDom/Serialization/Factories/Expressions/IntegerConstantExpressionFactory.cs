using CSharpDom.Common.Expressions;
using CSharpDom.Serialization.Expressions;
using CSharpDom.Serialization.Factories.Statements;

namespace CSharpDom.Serialization.Factories.Expressions
{
    public sealed class IntegerConstantExpressionFactory : AbstractExpressionFactory<IIntegerConstantExpression, IntegerConstantExpression>
    {
        public IntegerConstantExpressionFactory(IIntegerConstantExpression expression)
            : base(expression)
        {
        }

        public override void VisitIntegerConstantExpression(IIntegerConstantExpression integerConstantExpression)
        {
            Value = new IntegerConstantExpression()
            {
                Constant = integerConstantExpression.Constant
            };
        }
    }
}
