using CSharpDom.Common.Editable.Expressions;
using CSharpDom.Common.Statements;

namespace CSharpDom.Common.Editable.Statements
{
    public interface IEditableDoStatement<TExpression, TStatement> :
        IEditableDoStatement,
        IDoStatement<TExpression, TStatement>
        where TExpression : IEditableExpression
        where TStatement : IEditableStatement
    {
        new TExpression Condition { get; set; }

        new TStatement Statement { get; set; }
    }
}