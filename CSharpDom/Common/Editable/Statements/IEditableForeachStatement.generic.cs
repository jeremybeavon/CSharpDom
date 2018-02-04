using CSharpDom.Common.Editable.Expressions;
using CSharpDom.Common.Statements;

namespace CSharpDom.Common.Editable.Statements
{
    public interface IEditableForeachStatement<TTypeReference, TExpression, TStatement> :
        IEditableForeachStatement,
        IForeachStatement<TTypeReference, TExpression, TStatement>
        where TTypeReference : IEditableTypeReference
        where TExpression : IEditableExpression
        where TStatement : IEditableStatement
    {
        new TTypeReference Type { get; set; }

        new string VariableName { get; set; }

        new TExpression Iterator { get; set; }

        new TStatement Statement { get; set; }
    }
}