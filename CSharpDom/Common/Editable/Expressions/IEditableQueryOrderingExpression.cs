using CSharpDom.Common.Expressions;

namespace CSharpDom.Common.Editable.Expressions
{
    public interface IEditableQueryOrderingExpression : IVisitable<IEditableExpressionVisitor>, IQueryOrderingExpression
    {
    }
}