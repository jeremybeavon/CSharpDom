using CSharpDom.Common.Editable.Expressions;
using CSharpDom.Common.Statements;

namespace CSharpDom.Common.Editable.Statements
{
    public interface IEditableUsingStatement<TExpression, TStatement> :
        IEditableUsingStatement,
        IUsingStatement<TExpression, TStatement>
        where TExpression : IEditableExpression
        where TStatement : IEditableStatement
    {
        new TExpression Expression { get; set; }

        new TStatement Statement { get; set; }
    }
}