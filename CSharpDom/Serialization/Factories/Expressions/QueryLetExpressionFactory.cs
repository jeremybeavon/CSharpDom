﻿using CSharpDom.Common.Expressions;
using CSharpDom.Serialization.Expressions;
using CSharpDom.Serialization.Factories.Statements;

namespace CSharpDom.Serialization.Factories.Expressions
{
    public sealed class QueryLetExpressionFactory : AbstractExpressionFactory<IQueryLetExpression, QueryLetExpression>
    {
        public QueryLetExpressionFactory(IQueryLetExpression expression)
            : base(expression)
        {
        }

        public override void VisitQueryLetExpression<TExpression>(IQueryLetExpression<TExpression> queryLetExpression)
        {
            Value = new QueryLetExpression()
            {
                Expression = new ExpressionFactory(queryLetExpression.Expression).Value,
                Identifier = queryLetExpression.Identifier
            };
        }
    }
}
