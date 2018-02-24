using CSharpDom.Common.Expressions;
using CSharpDom.Serialization.Expressions;
using CSharpDom.Serialization.Factories.Statements;

namespace CSharpDom.Serialization.Factories.Expressions
{
    public sealed class RefArgumentFactory : AbstractExpressionFactory<IRefArgument, RefArgument>
    {
        public RefArgumentFactory(IRefArgument expression)
            : base(expression)
        {
        }

        public override void VisitRefArgument<TExpression>(IRefArgument<TExpression> refExpression)
        {
            Value = new RefArgument()
            {
                Expression = new ExpressionFactory(refExpression.Expression).Value
            };
        }
    }
}
