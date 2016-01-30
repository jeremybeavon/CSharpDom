using CSharpDom.BaseClasses.Expressions;
using System.Collections.Generic;
using System.Linq.Expressions;
using System;

namespace CSharpDom.Linq.Expressions
{
    public sealed class DynamicMethodCallExpressionWithLinqExpressions :
        AbstractMethodCallExpression<ILinqExpression>,
        ILinqExpression<DynamicExpression>
    {
        //private readonly ILinqExpression expression;
        private readonly IReadOnlyList<ILinqExpression> parameterExpressions;

        public DynamicMethodCallExpressionWithLinqExpressions(DynamicExpression expression)
        {
            LinqExpression = expression;
            //this.expression = LinqExpressionBuilder.BuildExpression(expression.);
            parameterExpressions = LinqExpressionBuilder.BuildExpressions(expression.Arguments);
            throw new NotImplementedException();
        }

        public DynamicExpression LinqExpression { get; private set; }

        public override ILinqExpression Expression
        {
            get { return null; }
        }

        public override IReadOnlyList<ILinqExpression> ParameterExpressions
        {
            get { return parameterExpressions; }
        }

        Expression ILinqExpression.Expression
        {
            get { return LinqExpression; }
        }

        DynamicExpression ILinqExpression<DynamicExpression>.Expression
        {
            get { return LinqExpression; }
        }
    }
}
