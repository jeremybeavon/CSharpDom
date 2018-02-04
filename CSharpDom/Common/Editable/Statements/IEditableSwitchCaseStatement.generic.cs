using CSharpDom.Common.Editable.Expressions;
using CSharpDom.Common.Statements;
using System.Collections.Generic;

namespace CSharpDom.Common.Editable.Statements
{
    public interface IEditableSwitchCaseStatement<TExpression, TStatement> :
        IEditableSwitchCaseStatement,
        ISwitchCaseStatement<TExpression, TStatement>
        where TExpression : IEditableExpression
        where TStatement : IEditableStatement
    {
        new ICollection<TExpression> Matches { get; set; }

        new IList<TStatement> Statements { get; set; }
    }
}