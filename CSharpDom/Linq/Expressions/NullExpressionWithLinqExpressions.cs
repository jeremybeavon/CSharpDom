using CSharpDom.BaseClasses.Expressions;
using System.Linq.Expressions;

namespace CSharpDom.Linq.Expressions
{
    public sealed class NullExpressionWithLinqExpressions : AbstractNullExpression, ILinqExpression<ConstantExpression>
    {
        public NullExpressionWithLinqExpressions(ConstantExpression expression)
        {
            Expression = expression;
        }

        public ConstantExpression Expression { get; private set; }

        Expression ILinqExpression.Expression
        {
            get { return Expression; }
        }
    }
}
