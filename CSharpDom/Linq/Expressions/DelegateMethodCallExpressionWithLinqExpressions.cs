using CSharpDom.BaseClasses.Expressions;
using CSharpDom.Reflection;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace CSharpDom.Linq.Expressions
{
    public sealed class DelegateMethodCallExpressionWithLinqExpressions :
        AbstractMethodCallExpression<ILinqExpression, ILinqExpression>,
        ILinqExpression<InvocationExpression>
    {
        private readonly ILinqExpression expression;
        private readonly IReadOnlyList<ILinqExpression> parameterExpressions;

        public DelegateMethodCallExpressionWithLinqExpressions(InvocationExpression expression)
        {
            LinqExpression = expression;
            this.expression = LinqExpressionBuilder.BuildExpression(expression.Expression);
            parameterExpressions = LinqExpressionBuilder.BuildExpressions(expression.Arguments);
        }

        public InvocationExpression LinqExpression { get; private set; }

        public string Name { get => throw new NotSupportedException(); }

        public override ILinqExpression Expression
        {
            get { return expression; }
        }

        public override IReadOnlyList<ILinqExpression> Parameters
        {
            get { return parameterExpressions; }
        }
        
        Expression ILinqExpression.Expression
        {
            get { return LinqExpression; }
        }

        InvocationExpression ILinqExpression<InvocationExpression>.Expression
        {
            get { return LinqExpression; }
        }
    }
}
