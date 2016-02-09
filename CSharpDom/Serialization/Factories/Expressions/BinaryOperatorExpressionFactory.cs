using CSharpDom.Common.Expressions;
using CSharpDom.Serialization.Expressions;
using CSharpDom.Serialization.Factories.Statements;

namespace CSharpDom.Serialization.Factories.Expressions
{
    public sealed class BinaryOperatorExpressionFactory : AbstractExpressionFactory<IBinaryOperatorExpression, BinaryOperatorExpression>
    {
        public BinaryOperatorExpressionFactory(IBinaryOperatorExpression expression)
            : base(expression)
        {
        }

        public override void VisitBinaryOperatorExpression<TExpression>(IBinaryOperatorExpression<TExpression> binaryOperatorExpression)
        {
            Value = new BinaryOperatorExpression()
            {
                Left = new ExpressionFactory(binaryOperatorExpression.Left).Value,
                OperatorType = binaryOperatorExpression.OperatorType,
                Right = new ExpressionFactory(binaryOperatorExpression.Right).Value
            };           
        }
    }
}
