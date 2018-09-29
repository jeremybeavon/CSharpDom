using CSharpDom.Common.Expressions;
using CSharpDom.Serialization.Expressions;

namespace CSharpDom.Serialization.Factories.Expressions
{
    public sealed class MethodCallExpressionFactory : AbstractExpressionFactory<IMethodCallExpression, MethodCallExpression>
    {
        public MethodCallExpressionFactory(IMethodCallExpression expression)
            : base(expression)
        {
        }

        public override void VisitMethodCallExpression<TExpression, TArgument>(
            IMethodCallExpression<TExpression, TArgument> methodCallExpression)
        {
            Value = new MethodCallExpression()
            {
                Expression = new GenericExpressionFactory(methodCallExpression.Expression).Value,
                Parameters = methodCallExpression.Parameters.ToList(argument => new ArgumentFactory(argument).Value)
            };
        }
    }
}
