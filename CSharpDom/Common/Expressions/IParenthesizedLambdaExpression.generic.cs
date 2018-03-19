using CSharpDom.Common.Statements;
using System.Collections.Generic;

namespace CSharpDom.Common.Expressions
{
    public interface IParenthesizedLambdaExpression<TParameter, TExpression> : IParenthesizedLambdaExpression, IHasAsync
        where TParameter : IAnonymousMethodParameter
        where TExpression : IExpression
    {
        IReadOnlyList<TParameter> Parameters { get; }

        TExpression Expression { get; }
    }
}
