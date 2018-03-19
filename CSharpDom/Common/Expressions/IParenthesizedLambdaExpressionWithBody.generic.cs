using CSharpDom.Common.Statements;
using System.Collections.Generic;

namespace CSharpDom.Common.Expressions
{
    public interface IParenthesizedLambdaExpressionWithBody<TParameter, TStatement> :
        IParenthesizedLambdaExpressionWithBody,
        IHasAsync
        where TParameter : IAnonymousMethodParameter
        where TStatement : IStatement
    {
        IReadOnlyList<TParameter> Parameters { get; }

        IReadOnlyList<TStatement> Statements { get; }
    }
}
