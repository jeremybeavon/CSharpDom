﻿using CSharpDom.Common.Expressions;
using CSharpDom.Serialization.Expressions;
using CSharpDom.Serialization.Factories.Statements;

namespace CSharpDom.Serialization.Factories.Expressions
{
    public sealed class AnonymousMethodExpressionFactory : AbstractExpressionFactory<IAnonymousMethodExpression, AnonymousMethodExpression>
    {
        public AnonymousMethodExpressionFactory(IAnonymousMethodExpression expression)
            : base(expression)
        {
        }

        public override void VisitAnonymousMethodExpression<TParameter, TStatement>(
            IAnonymousMethodExpression<TParameter, TStatement> anonymousMethod)
        {
            Value = new AnonymousMethodExpression()
            {
                Parameters = anonymousMethod.Parameters.ToList(parameter => new AnonymousMethodParameterFactory(parameter).Value),
                Statements = anonymousMethod.Statements.ToStatementListUsingFactory()
            };
        }
    }
}
