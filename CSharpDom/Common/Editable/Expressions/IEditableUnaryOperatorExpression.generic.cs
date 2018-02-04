using CSharpDom.Common.Expressions;

namespace CSharpDom.Common.Editable.Expressions
{
    public interface IEditableUnaryOperatorExpression<TExpression> :
        IEditableUnaryOperatorExpression,
        IUnaryOperatorExpression<TExpression>
        where TExpression : IEditableExpression
    {
        new TExpression Operand { get; set; }

        new UnaryOperatorExpressionType OperatorType { get; set; }
    }
}