using CSharpDom.Common.Expressions;

namespace CSharpDom.Common.Editable.Expressions
{
    public interface IEditableBinaryOperatorExpression<TExpression> :
        IEditableBinaryOperatorExpression,
        IBinaryOperatorExpression<TExpression>
        where TExpression : IEditableExpression
    {
        new TExpression Left { get; set; }

        new BinaryOperatorExpressionType OperatorType { get; set; }

        new TExpression Right { get; set; }
    }
}