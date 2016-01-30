using CSharpDom.BaseClasses.Expressions;
using System.Collections.Generic;
using System.Linq.Expressions;
using System;

namespace CSharpDom.Linq.Expressions
{
    public sealed class MemberExpressionWithLinqExpressions :
        AbstractMemberExpression<ILinqExpression>,
        ILinqExpression<MemberExpression>
    {
        private readonly ILinqExpression objectExpression;

        public MemberExpressionWithLinqExpressions(MemberExpression expression)
        {
            Expression = expression;
            objectExpression = LinqExpressionBuilder.BuildExpression(expression);
        }

        public MemberExpression Expression { get; private set; }

        public override string MemberName
        {
            get { return Expression.Member.Name; }
        }

        public override ILinqExpression ObjectExpression
        {
            get { return objectExpression; }
        }

        Expression ILinqExpression.Expression
        {
            get { return Expression; }
        }
    }
}
