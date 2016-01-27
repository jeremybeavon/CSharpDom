using System.Collections.Generic;

namespace CSharpDom.Common.Expressions
{
    public interface IQueryFromExpression<TIdentifierExpression, TExpression, TQueryExpression> : IQueryFromExpression
        where TIdentifierExpression : IIdentifierExpression
        where TExpression : IExpression
        where TQueryExpression : IQueryExpression
    {
        TIdentifierExpression Identifier { get; }

        TExpression Expression { get; }

        IReadOnlyList<TQueryExpression> QueryExpressions { get; }
    }
}
