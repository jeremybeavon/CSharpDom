using CSharpDom.Common.Editable.Expressions;
using CSharpDom.Common.Statements;
using System.Collections.Generic;

namespace CSharpDom.Common.Editable.Statements
{
    public interface IEditableSwitchStatement<TExpression, TSwitchCaseStatement, TDefaultCaseStatement> :
        IEditableSwitchStatement,
        ISwitchStatement<TExpression, TSwitchCaseStatement, TDefaultCaseStatement>
        where TExpression : IEditableExpression
        where TSwitchCaseStatement : IEditableSwitchCaseStatement
        where TDefaultCaseStatement : IEditableDefaultCaseStatement
    {
        new TExpression Expression { get; set; }

        new ICollection<TSwitchCaseStatement> Cases { get; set; }

        new TDefaultCaseStatement DefaultCase { get; set; }
    }
}