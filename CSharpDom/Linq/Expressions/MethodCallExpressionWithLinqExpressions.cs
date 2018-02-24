using CSharpDom.BaseClasses.Expressions;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace CSharpDom.Linq.Expressions
{
    public sealed class MethodCallExpressionWithLinqExpressions :
        AbstractMethodCallExpression<ILinqExpression, ILinqExpression>,
        ILinqExpression<MethodCallExpression>
    {
        private readonly ILinqExpression expression;
        private readonly IReadOnlyList<ILinqExpression> parameterExpressions;

        public MethodCallExpressionWithLinqExpressions(MethodCallExpression expression)
        {
            LinqExpression = expression;
            this.expression = LinqExpressionBuilder.BuildExpression(expression.Object);
            parameterExpressions = LinqExpressionBuilder.BuildExpressions(expression.Arguments);
        }

        public MethodCallExpression LinqExpression { get; private set; }

        public override ILinqExpression Expression
        {
            get { return expression; }
        }

        public string Name { get => throw new NotSupportedException(); }

        public override IReadOnlyList<ILinqExpression> Parameters
        {
            get { return parameterExpressions; }
        }

        Expression ILinqExpression.Expression
        {
            get { return LinqExpression; }
        }

        MethodCallExpression ILinqExpression<MethodCallExpression>.Expression
        {
            get { return LinqExpression; }
        }
    }
}
