using CSharpDom.BaseClasses.Expressions;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.Linq.Expressions
{
    public sealed class ParameterExpressionWithLinqExpressions : AbstractIdentifierExpression, ILinqExpression<ParameterExpression>
    {
        public ParameterExpressionWithLinqExpressions(ParameterExpression expression)
        {
            Expression = expression;
        }

        public ParameterExpression Expression { get; private set; }

        public override string Name
        {
            get { return Expression.Name; }
        }

        Expression ILinqExpression.Expression
        {
            get { return Expression; }
        }
    }
}
