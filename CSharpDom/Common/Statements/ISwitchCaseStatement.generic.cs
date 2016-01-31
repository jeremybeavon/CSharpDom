using CSharpDom.Common.Expressions;
using System.Collections.Generic;

namespace CSharpDom.Common.Statements
{
    public interface ISwitchCaseStatement<TExpression, TStatement> : ISwitchCaseStatement
        where TExpression : IExpression
        where TStatement : IStatement
    {
        IReadOnlyCollection<TExpression> Matches { get; }

        IReadOnlyList<TStatement> Statements { get; }
    }
}
