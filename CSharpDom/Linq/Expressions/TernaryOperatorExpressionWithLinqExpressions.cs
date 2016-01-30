using CSharpDom.BaseClasses.Expressions;
using System.Linq.Expressions;

namespace CSharpDom.Linq.Expressions
{
    public sealed class TernaryOperatorExpressionWithLinqExpressions :
        AbstractTernaryOperatorExpression<ILinqExpression>,
        ILinqExpression<ConditionalExpression>
    {
        private readonly ILinqExpression left;
        private readonly ILinqExpression middle;
        private readonly ILinqExpression right;

        public TernaryOperatorExpressionWithLinqExpressions(ConditionalExpression expression)
        {
            Expression = expression;
            left = LinqExpressionBuilder.BuildExpression(expression.Test);
            middle = LinqExpressionBuilder.BuildExpression(expression.IfTrue);
            right = LinqExpressionBuilder.BuildExpression(expression.IfFalse);
        }

        public ConditionalExpression Expression { get; private set; }

        public override ILinqExpression Left
        {
            get { return left; }
        }

        public override ILinqExpression Middle
        {
            get { return middle; }
        }

        public override ILinqExpression Right
        {
            get { return right; }
        }

        Expression ILinqExpression.Expression
        {
            get { return Expression; }
        }
    }
}
