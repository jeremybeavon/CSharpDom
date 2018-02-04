using CSharpDom.Common.Expressions;

namespace CSharpDom.Common.Editable.Expressions
{
    public interface IEditableQuerySelectIntoExpression :
        IEditableQuerySelectExpression,
        IEditableQueryClauseExpression,
        IQuerySelectIntoExpression
    {
    }
}