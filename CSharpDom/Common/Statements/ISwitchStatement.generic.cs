using CSharpDom.Common.Expressions;
using System.Collections.Generic;

namespace CSharpDom.Common.Statements
{
    public interface ISwitchStatement<TExpression, TSwitchCaseStatement, TDefaultCaseStatement> : ISwitchStatement
        where TExpression : IExpression
        where TSwitchCaseStatement : ISwitchCaseStatement
        where TDefaultCaseStatement : IDefaultCaseStatement
    {
        TExpression Expression { get; }

        IReadOnlyCollection<TSwitchCaseStatement> Cases { get; }

        TDefaultCaseStatement DefaultCase { get; }
    }
}
