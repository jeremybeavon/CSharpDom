using CSharpDom.Common.Expressions;

namespace CSharpDom.Common.Editable.Expressions
{
    public interface IEditableQueryGroupIntoExpression<TExpression, TIdentifierExpression> :
        IEditableQueryGroupIntoExpression,
        IEditableQueryGroupExpression<TExpression>,
        IQueryGroupIntoExpression<TExpression, TIdentifierExpression>
        where TExpression : IEditableExpression
        where TIdentifierExpression : IEditableIdentifierExpression
    {
        new TIdentifierExpression IntoExpression { get; set; }
    }
}