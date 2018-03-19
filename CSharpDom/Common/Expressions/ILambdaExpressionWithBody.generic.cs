using CSharpDom.Common.Statements;
using System.Collections.Generic;

namespace CSharpDom.Common.Expressions
{
    public interface ILambdaExpressionWithBody<TStatement> : ILambdaExpressionWithBody, IHasAsync
        where TStatement : IStatement
    {
        string ParameterName { get; }

        IReadOnlyList<TStatement> Statements { get; }
    }
}
