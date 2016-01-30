using CSharpDom.BaseClasses.Expressions;
using System.Collections.Generic;
using System.Linq.Expressions;
using System;

namespace CSharpDom.Linq.Expressions
{
    public sealed class AnonymousMethodExpressionWithLinqExpressions<TDelegate> :
        AbstractAnonymousMethodExpression<ParameterWithLinqExpressions, ILinqStatement>,
        ILinqExpression<LambdaExpression>,
        ILinqExpression<Expression<TDelegate>>
    {
        private readonly ILinqStatement body;
        private readonly IReadOnlyList<ParameterWithLinqExpressions> parameters;

        public AnonymousMethodExpressionWithLinqExpressions(Expression<TDelegate> expression)
        {
            Expression = expression;
            body = LinqStatementBuilder.BuildStatement(expression.Body);
            parameters = expression.Parameters.ToArray(parameter => new ParameterWithLinqExpressions(parameter));
        }

        public override ILinqStatement Body
        {
            get { return body; }
        }

        public Expression<TDelegate> Expression { get; private set; }

        public override IReadOnlyList<ParameterWithLinqExpressions> Parameters
        {
            get { return parameters; }
        }

        LambdaExpression ILinqExpression<LambdaExpression>.Expression
        {
            get { return Expression; }
        }

        Expression ILinqExpression.Expression
        {
            get { return Expression; }
        }
    }
}
