using CSharpDom.Common.Expressions;

namespace CSharpDom.Common.Editable.Expressions
{
    public interface IEditableQueryEndExpression : IVisitable<IEditableExpressionVisitor>, IQueryEndExpression
    {
    }
}