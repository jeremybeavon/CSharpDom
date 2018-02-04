using CSharpDom.Common.Expressions;

namespace CSharpDom.Common.Editable.Expressions
{
    public interface IEditableCastExpression<TTypeReference, TExpression> :
        IEditableCastExpression,
        ICastExpression<TTypeReference, TExpression>
        where TTypeReference : IEditableTypeReference
        where TExpression : IEditableExpression
    {
        new TTypeReference Type { get; set; }

        new TExpression Expression { get; set; }
    }
}