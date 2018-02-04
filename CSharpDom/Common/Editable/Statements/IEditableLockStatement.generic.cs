using CSharpDom.Common.Editable.Expressions;
using CSharpDom.Common.Statements;

namespace CSharpDom.Common.Editable.Statements
{
    public interface IEditableLockStatement<TExpression, TStatement> :
        IEditableLockStatement,
        ILockStatement<TExpression, TStatement>
        where TExpression : IEditableExpression
        where TStatement : IEditableStatement
    {
        new TExpression Expression { get; set; }

        new TStatement Statement { get; set; }
    }
}