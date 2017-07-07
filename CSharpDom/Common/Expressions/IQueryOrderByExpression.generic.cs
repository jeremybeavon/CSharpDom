using System.Collections.Generic;

namespace CSharpDom.Common.Expressions
{
    public interface IQueryOrderByExpression<TOrderingExpression> : IQueryOrderByExpression
        where TOrderingExpression : IQueryOrderingExpression
    {
        IReadOnlyList<TOrderingExpression> Orders { get; }
    }
}
