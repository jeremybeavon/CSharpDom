using System.Collections.Generic;

namespace CSharpDom.Common.Expressions
{
    public interface IQueryFromExpression<TExpression> : IQueryFromExpression
        where TExpression : IExpression
    {
        string Identifier { get; }

        TExpression Expression { get; }
    }
}
