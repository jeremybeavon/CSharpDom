using System.Collections.Generic;

namespace CSharpDom.Common.Expressions
{
    public interface IQueryFromExpression<TExpression, TQueryExpression> : IQueryFromExpression
        where TExpression : IExpression
        where TQueryExpression : IQueryExpression
    {
        string Identifier { get; }

        TExpression Expression { get; }

        IReadOnlyList<TQueryExpression> QueryExpressions { get; }
    }
}
