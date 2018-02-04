using CSharpDom.Common.Expressions;

namespace CSharpDom.Common.Editable.Expressions
{
    public interface IEditableExpression : IVisitable<IEditableExpressionVisitor>, IExpression
    {
    }
}