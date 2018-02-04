using CSharpDom.Common.Expressions;

namespace CSharpDom.Common.Editable.Expressions
{
    public interface IEditableTernaryOperatorExpression<TExpression> :
        IEditableTernaryOperatorExpression,
        ITernaryOperatorExpression<TExpression>
        where TExpression : IEditableExpression
    {
        new TExpression Left { get; set; }

        new TExpression Middle { get; set; }

        new TExpression Right { get; set; }
    }
}