using CSharpDom.Common.Expressions;

namespace CSharpDom.Common.Editable.Expressions
{
    public interface IEditableQueryClauseExpression : IVisitable<IEditableExpressionVisitor>, IQueryClauseExpression
    {
    }
}