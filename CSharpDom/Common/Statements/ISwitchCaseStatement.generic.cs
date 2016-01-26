using CSharpDom.Common.Expressions;
using System.Collections.Generic;

namespace CSharpDom.Common.Statements
{
    public interface ISwitchCaseStatement<TExpression, TStatement> : ISwitchCaseStatement
        where TExpression : IExpression
        where TStatement : IStatement
    {
        TExpression Match { get; }

        IReadOnlyList<TStatement> Statements { get; }
    }
}
