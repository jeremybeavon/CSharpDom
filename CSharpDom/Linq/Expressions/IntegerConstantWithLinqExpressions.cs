using CSharpDom.BaseClasses.Expressions;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.Linq.Expressions
{
    public sealed class IntegerConstantWithLinqExpressions :
        AbstractIntegerConstantExpression,
        ILinqExpression<ConstantExpression>
    {
        private readonly int constant;

        public IntegerConstantWithLinqExpressions(ConstantExpression expression)
        {
            Expression = expression;
            constant = (int)expression.Value;
        }

        public override int Constant
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
