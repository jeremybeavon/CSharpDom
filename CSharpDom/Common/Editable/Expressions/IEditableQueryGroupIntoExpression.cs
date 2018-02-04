using CSharpDom.Common.Expressions;

namespace CSharpDom.Common.Editable.Expressions
{
    public interface IEditableQueryGroupIntoExpression :
        IEditableQueryGroupExpression,
        IEditableQueryClauseExpression,
        IQueryGroupIntoExpression
    {
    }
}