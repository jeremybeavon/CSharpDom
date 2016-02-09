using CSharpDom.Common.Expressions;
using CSharpDom.Serialization.Expressions;
using CSharpDom.Serialization.Factories.Statements;

namespace CSharpDom.Serialization.Factories.Expressions
{
    public sealed class MethodCallExpressionFactory : AbstractExpressionFactory<IMethodCallExpression, MethodCallExpression>
    {
        public MethodCallExpressionFactory(IMethodCallExpression expression)
            : base(expression)
        {
        }

        public override void VisitMethodCallExpression<TExpression>(IMethodCallExpression<TExpression> methodCallExpression)
        {
            Value = new MethodCallExpression()
            {
                Expression = new ExpressionFactory(methodCallExpression.Expression).Value,
                ParameterExpressions = methodCallExpression.ParameterExpressions.ToExpressionListUsingFactory()
            };
        }
    }
}
