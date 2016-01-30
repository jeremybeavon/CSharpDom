using CSharpDom.BaseClasses.Expressions;
using System.Linq.Expressions;

namespace CSharpDom.Linq.Expressions
{
    public sealed class StringConstantWithLinqExpressions :
        AbstractStringConstantExpression,
        ILinqExpression<ConstantExpression>
    {
        private readonly string constant;

        public StringConstantWithLinqExpressions(ConstantExpression expression)
        {
            Expression = expression;
            constant = (string)expression.Value;
        }

        public override string Constant
        {
            get { return constant; }
        }

        public ConstantExpression Expression { get; private set; }

        public override bool HasAtSymbol
        {
            get { return false; }
        }

        Expression ILinqExpression.Expression
        {
            get { return Expression; }
        }
    }
}
