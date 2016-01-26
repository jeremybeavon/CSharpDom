using System.Collections.Generic;

namespace CSharpDom.Common.Expressions
{
    public interface IMethodCallExpression<TExpression>
        where TExpression : IExpression
    {
        TExpression Expression { get; }

        IReadOnlyList<TExpression> ParameterExpressions { get; }
    }
}
