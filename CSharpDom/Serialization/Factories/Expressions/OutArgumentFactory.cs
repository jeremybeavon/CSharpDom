using CSharpDom.Common.Expressions;
using CSharpDom.Serialization.Expressions;

namespace CSharpDom.Serialization.Factories.Expressions
{
    public sealed class OutArgumentFactory : AbstractExpressionFactory<IOutArgument, OutArgument>
    {
        public OutArgumentFactory(IOutArgument expression)
            : base(expression)
        {
        }

        public override void VisitOutArgument<TExpression>(IOutArgument<TExpression> outExpression)
        {
            Value = new OutArgument()
            {
                Expression = new ExpressionFactory(outExpression.Expression).Value
            };
        }
    }
}
