using CSharpDom.Common.Expressions;

namespace CSharpDom.Common.Editable.Expressions
{
    public interface IEditableGenericExpression : IVisitable<IEditableExpressionVisitor>, IGenericExpression
    {
    }
}
