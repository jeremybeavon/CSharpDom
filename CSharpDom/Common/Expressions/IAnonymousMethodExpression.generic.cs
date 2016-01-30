using CSharpDom.Common.Statements;
using System.Collections.Generic;

namespace CSharpDom.Common.Expressions
{
    public interface IAnonymousMethodExpression<TParameter, TStatement> : IAnonymousMethodExpression
        where TParameter : IParameter
        where TStatement : IStatement
    {
        IReadOnlyList<TParameter> Parameters { get; }

        TStatement Body { get; }
    }
}
