using CSharpDom.Common.Expressions;

namespace CSharpDom.Common.Editable.Expressions
{
    public interface IEditableOutExpression<TExpression> : IEditableOutExpression, IOutExpression<TExpression>
        where TExpression : IEditableExpression
    {
        new TExpression Expression { get; set; }
    }
}