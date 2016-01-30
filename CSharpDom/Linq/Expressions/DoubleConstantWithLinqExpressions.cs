using CSharpDom.BaseClasses.Expressions;
using System.Linq.Expressions;

namespace CSharpDom.Linq.Expressions
{
    public sealed class DoubleConstantWithLinqExpressions :
        AbstractDoubleConstantExpression,
        ILinqExpression<ConstantExpression>
    {
        private readonly double constant;

        public DoubleConstantWithLinqExpressions(ConstantExpression expression)
        {
            Expression = expression;
            constant = (double)expression.Value;
        }

        public override double Constant
        {
            get { return constant; }
        }

        public ConstantExpression Expression { get; private set; }

        Expression ILinqExpression.Expression
        {
            get { return Expression; }
        }
    }
}
