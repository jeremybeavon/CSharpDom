using CSharpDom.Common.Expressions;

namespace CSharpDom.Common.Editable.Expressions
{
    public interface IEditableRefExpression<TExpression> : IEditableRefExpression, IRefExpression<TExpression>
        where TExpression : IEditableExpression
    {
        new TExpression Expression { get; set; }
    }
}