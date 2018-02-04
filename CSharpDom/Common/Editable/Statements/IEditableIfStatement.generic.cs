using CSharpDom.Common.Editable.Expressions;
using CSharpDom.Common.Statements;

namespace CSharpDom.Common.Editable.Statements
{
    public interface IEditableIfStatement<TExpression, TStatement> :
        IEditableIfStatement,
        IIfStatement<TExpression, TStatement>
        where TExpression : IEditableExpression
        where TStatement : IEditableStatement
    {
        new TExpression Condition { get; set; }

        new TStatement ThenStatement { get; set; }

        new TStatement ElseStatement { get; set; }
    }
}