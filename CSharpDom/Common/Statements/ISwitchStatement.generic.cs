using CSharpDom.Common.Expressions;
using System.Collections.Generic;

namespace CSharpDom.Common.Statements
{
    public interface ISwitchStatement<TExpression, TSwitchCaseStatement, TStatement> : ISwitchStatement
        where TExpression : IExpression
        where TSwitchCaseStatement : ISwitchCaseStatement
        where TStatement : IStatement
    {
        TExpression Expression { get; }

        IReadOnlyCollection<TSwitchCaseStatement> Cases { get; }

        IReadOnlyList<TStatement> DefaultCase { get; }
    }
}
