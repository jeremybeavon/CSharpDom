using CSharpDom.Common.Expressions;

namespace CSharpDom.Common.Editable.Expressions
{
    public interface IEditableQuerySelectIntoExpression<TExpression, TIdentifierExpression> :
        IEditableQuerySelectIntoExpression,
        IEditableQuerySelectExpression<TExpression>,
        IQuerySelectIntoExpression<TExpression, TIdentifierExpression>
        where TExpression : IEditableExpression
        where TIdentifierExpression : IEditableIdentifierExpression
    {
        new TIdentifierExpression IntoExpression { get; set; }
    }
}